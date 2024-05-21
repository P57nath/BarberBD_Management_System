using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberBD
{
    public partial class NewAddCatagory : UserControl
    {
        private Login F1 { get; set; }
        private DataAccess Da { get; set; }
        public NewAddCatagory()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.PopulateGidView();
            this.AutoIdGenerate();
        }

        private void AutoIdGenerate()
        {
            var sql = "select CatagoryID from catagoryInfo order by CatagoryID desc;";
            var dt = this.Da.ExecuteQueryTable(sql);
            var oldId = dt.Rows[0][0].ToString();
            int newId = Convert.ToInt32(oldId);
            this.txtCatagoryID.Text = (++newId).ToString();
        }

        public void PopulateGidView(string sql = "select * from catagoryInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvCatagory.AutoGenerateColumns = true;
            this.dgvCatagory.DataSource = ds.Tables[0];
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
            this.AutoIdGenerate();
        }

        private void ClearAll()
        {
            this.txtCatagoryID.Clear();
            this.txtCatagoryName.Text = "";
            this.dgvCatagory.ClearSelection();
            this.AutoIdGenerate();
        }

        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtCatagoryID.Text)
                || String.IsNullOrEmpty(this.txtCatagoryName.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void dgvCatagory_DoubleClick(object sender, EventArgs e)
        {
            this.txtCatagoryID.Text = this.dgvCatagory.CurrentRow.Cells[0].Value.ToString();
            this.txtCatagoryName.Text = this.dgvCatagory.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the information");
                    return;
                }

                string query = null;
                var sql = "select * from catagoryInfo where CatagoryID = '" + this.txtCatagoryID.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    query = @"UPDATE catagoryInfo
                            SET CatagoryName = '" + this.txtCatagoryName.Text + @"'
                            WHERE CatagoryID = '" + this.txtCatagoryID.Text + "'; ";

                    var count = this.Da.ExecuteDMLQuery(query);

                    if (count == 1)
                        MessageBox.Show("Catagory data has been updated properly");
                    else
                        MessageBox.Show("Catagory data upgradation failed");
                }
                this.PopulateGidView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has been found:\n" + exc.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvCatagory.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to remove the data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure to remove the data?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;

                var id = this.dgvCatagory.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvCatagory.CurrentRow.Cells["CatagoryName"].Value.ToString();
                var query = "delete from catagoryInfo where CatagoryID = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)
                    MessageBox.Show(name.ToUpper() + " has been removed from the list.");
                else
                    MessageBox.Show("Catagory data remove failed");

                this.PopulateGidView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has been found:\n" + exc.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the information");
                    return;
                }

                string query = null;
                var sql = "select * from catagoryInfo where CatagoryID = '" + this.txtCatagoryID.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    query = "INSERT INTO catagoryInfo(CatagoryName) VALUES('" + this.txtCatagoryName.Text + "');";
                    var count = this.Da.ExecuteDMLQuery(query);

                    if (count == 1)
                        MessageBox.Show("Catagory data has been added properly");
                    else
                        MessageBox.Show("Catagory data saving failed");
                }
                this.PopulateGidView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has been found:\n" + exc.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var sql = "select * from catagoryInfo where CatagoryName like '" + this.txtCatagoryName.Text + "%';";
            this.PopulateGidView(sql);
        }
    }
}
