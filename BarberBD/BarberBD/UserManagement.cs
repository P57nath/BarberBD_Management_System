using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BarberBD
{
    public partial class UserManagement : UserControl
    {
        private Login F1 { get; set; }
        private DataAccess Da { get; set; }
        public UserManagement()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.PopulateGidView();
            this.AutoIdGenerate();
        }
        private void AutoIdGenerate()
        {
            var sql = "select UserID from userInfo order by UserID desc;";
            var dt = this.Da.ExecuteQueryTable(sql);
            var oldId = dt.Rows[0][0].ToString();
            string[] temp = oldId.Split('-');
            int num = Convert.ToInt32(temp[1]);
            string newId = "U-" + (++num).ToString("d3");
            this.txtUserID.Text = newId;
        }

        public void PopulateGidView(string sql = "select * from userInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvUser.AutoGenerateColumns = true;
            this.dgvUser.DataSource = ds.Tables[0];
        }

        private void ClearAll()
        {
            this.txtUserID.Clear();
            this.txtUserName.Text = "";
            this.txtPassword.Clear();
            this.txtNumber.Clear();
            this.txtAddress.Clear();
            this.dtpStartDate.Text = "";
            this.txtSalary.Text = string.Empty;
            this.cmbRole.SelectedIndex = -1;
            this.txtEmail.Text = string.Empty;

            this.txtAutoSearch.Clear();

            this.dgvUser.ClearSelection();
            this.AutoIdGenerate();
        }

        private bool IsValidToSave()
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtUserID.Text) || String.IsNullOrEmpty(this.txtUserName.Text)
                || String.IsNullOrEmpty(this.txtPassword.Text) || String.IsNullOrEmpty(this.txtNumber.Text)
                || String.IsNullOrEmpty(this.txtAddress.Text) || String.IsNullOrEmpty(this.txtEmail.Text)
                || String.IsNullOrEmpty(this.cmbRole.Text) || String.IsNullOrEmpty(this.txtSalary.Text))
                {
                    return false;
                }
                else
                {
                    if (IsValidBangladeshiPhoneNumber(this.txtNumber.Text))
                    {
                        if (IsValidEmail(this.txtEmail.Text))
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Invalid email address.\n" + "Example : example@example.com");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Bangladeshi phone number.\n" + "Example : 01782641610");
                        return false;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return false;
            }

        }
        private bool IsValidBangladeshiPhoneNumber(string phoneNumber)
        {
            Regex regex = new Regex(@"^(?:\+?88)?01[0-9]\d{8}$");

            return regex.IsMatch(phoneNumber);
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
            this.AutoIdGenerate();
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from userInfo where UserName like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGidView(sql);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvUser.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to remove the data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure to remove the data?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;

                var id = this.dgvUser.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvUser.CurrentRow.Cells["UserName"].Value.ToString();
                var query = "delete from userInfo where UserID = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)
                    MessageBox.Show(name.ToUpper() + " has been removed from the list.");
                else
                    MessageBox.Show("User data remove failed");

                this.PopulateGidView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has been found:\n" + exc.Message);
            }
        }

        private void dgvUser_DoubleClick(object sender, EventArgs e)
        {
            this.txtUserID.Text = this.dgvUser.CurrentRow.Cells[0].Value.ToString();
            this.txtUserName.Text = this.dgvUser.CurrentRow.Cells[1].Value.ToString();
            this.txtPassword.Text = this.dgvUser.CurrentRow.Cells[2].Value.ToString();
            this.txtNumber.Text = this.dgvUser.CurrentRow.Cells[3].Value.ToString();
            this.txtAddress.Text = this.dgvUser.CurrentRow.Cells[4].Value.ToString();
            this.dtpStartDate.Text = this.dgvUser.CurrentRow.Cells[5].Value.ToString();
            this.txtSalary.Text = this.dgvUser.CurrentRow.Cells[6].Value.ToString();
            this.cmbRole.Text = this.dgvUser.CurrentRow.Cells[7].Value.ToString();
            this.txtEmail.Text = this.dgvUser.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the information Correctly");
                    return;
                }

                string query = null;
                var sql = "select * from userInfo where UserID = '" + this.txtUserID.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    query = @"INSERT INTO userInfo(UserID, UserName, UserPass, UserPNo, UserAdd, UserStartDate, UserSalary, UserRole, UserEmail) 
                                VALUES('" + this.txtUserID.Text + @"', 
                                '" + this.txtUserName.Text + @"', 
                                '" + this.txtPassword.Text + @"', 
                                '" + this.txtNumber.Text + @"', 
                                '" + this.txtAddress.Text + @"', 
                                '" + this.dtpStartDate.Text + @"', 
                                " + this.txtSalary.Text + @", 
                                '" + this.cmbRole.Text + @"', 
                                '" + this.txtEmail.Text + "');";
                    var count = this.Da.ExecuteDMLQuery(query);

                    if (count == 1)
                        MessageBox.Show("User data has been added properly");
                    else
                        MessageBox.Show("User data saving failed");
                }
                this.PopulateGidView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has been found:\n" + exc.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the information Correctly");
                    return;
                }

                string query = null;
                var sql = "select * from userInfo where UserID = '" + this.txtUserID.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    query = @"UPDATE userInfo
                            SET UserName = '" + this.txtUserName.Text + @"',
                            UserPass = '" + this.txtPassword.Text + @"',
                            UserPNo = '" + this.txtNumber.Text + @"',
                            UserAdd = '" + this.txtAddress.Text + @"',
                            UserStartDate = '" + this.dtpStartDate.Text + @"',
                            UserSalary = '" + this.txtSalary.Text + @"',
                            UserRole = '" + this.cmbRole.Text + @"',
                            UserEmail = '" + this.txtEmail.Text + @"'
                            WHERE UserID = '" + this.txtUserID.Text + "'; ";

                    var count = this.Da.ExecuteDMLQuery(query);

                    if (count == 1)
                        MessageBox.Show("User data has been updated properly");
                    else
                        MessageBox.Show("User data upgradation failed");
                }
                this.PopulateGidView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has been found:\n" + exc.Message);
            }
        }

        private void pbxEye_Click(object sender, EventArgs e)
        {
            this.txtPassword.PasswordChar = '\0';

            Timer timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += (s, args) =>
            {
                this.txtPassword.PasswordChar = '*';
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }

        
    }
}
