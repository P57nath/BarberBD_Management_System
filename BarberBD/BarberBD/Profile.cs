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

namespace BarberBD
{
    public partial class Profile : Form
    {
        private AdminDashBoard F1 { get; set; }
        private StaffDashBoard F2 { get; set; }
        private DataAccess Da { get; set; }
        private string ID;

        public Profile()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.ShowAll();
        }

        public Profile(string id, AdminDashBoard f1) : this()
        {
            this.ID = id;
            this.txtUserID.Text = this.ID;
            this.F1 = f1;
        }

        public Profile(string id, StaffDashBoard f2) : this()
        {
            this.ID = id;
            this.txtUserID.Text = this.ID;
            this.F2 = f2;
        }

        private void ShowAll()
        {
            string sql = "select * from userInfo where UserID = '" + this.ID + "';";
            var dt = this.Da.ExecuteQueryTable(sql);

            //this.txtUserID.Text = dt.Rows[0][0].ToString();
            //this.txtUserName.Text = dt.Rows[0][1].ToString();
            //this.txtPass.Text = dt.Rows[0][2].ToString();
            //this.txtPhoneNum.Text = dt.Rows[0][3].ToString();
            //this.txtAddress.Text = dt.Rows[0][4].ToString();
            //this.txtStartDate.Text = dt.Rows[0][5].ToString();
            //this.txtSalary.Text = dt.Rows[0][6].ToString();
            //this.txtRole.Text = dt.Rows[0][7].ToString();
            //this.txtEmail.Text = dt.Rows[0][8].ToString();

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

        private bool IsValidToSave()
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtUserID.Text) || String.IsNullOrEmpty(this.txtUserName.Text)
                || String.IsNullOrEmpty(this.txtPass.Text) || String.IsNullOrEmpty(this.txtPhoneNum.Text)
                || String.IsNullOrEmpty(this.txtAddress.Text) || String.IsNullOrEmpty(this.txtEmail.Text)
                || String.IsNullOrEmpty(this.txtRole.Text) || String.IsNullOrEmpty(this.txtSalary.Text))
                {
                    return false;
                }
                else
                {
                    if (IsValidBangladeshiPhoneNumber(this.txtPhoneNum.Text))
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

        private void button3_Click(object sender, EventArgs e)
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
                    query = @"UPDATE [User]
                            SET UserName = '" + this.txtUserName.Text + @"',
                            UserPass = '" + this.txtPass.Text + @"',
                            UserPhoNo = '" + this.txtPhoneNum.Text + @"',
                            UserAdd = '" + this.txtAddress.Text + @"',
                            UserJoinDate = '" + this.txtStartDate.Text + @"',
                            UserSalary = '" + this.txtSalary.Text + @"',
                            UserRole = '" + this.txtRole.Text + @"',
                            UserEmail = '" + this.txtEmail.Text + @"'
                            WHERE UserID = '" + this.txtUserID.Text + "'; ";

                    var count = this.Da.ExecuteDMLQuery(query);

                    if (count == 1)
                        MessageBox.Show("User data has been updated properly");
                    else
                        MessageBox.Show("User data upgradation failed");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has been found:\n" + exc.Message);
            }
        }

        private void Profile_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
