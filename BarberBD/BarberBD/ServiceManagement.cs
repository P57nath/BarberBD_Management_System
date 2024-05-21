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
    public partial class ServiceManagement : UserControl
    {
        private DataAccess Da { get; set; }
        
        public ServiceManagement()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.PopulateGidView();
            this.PopulateComboBox();
            this.AutoIdGenerate();
        }

        public void PopulateGidView(string sql = "SELECT serviceInfo.ServiceID,serviceInfo.ServiceName,catagoryInfo.CatagoryName,catagoryInfo.CatagoryID,serviceInfo.ServicePrice FROM serviceInfo INNER JOIN catagoryInfo ON serviceInfo.CatagoryID=catagoryInfo.CatagoryID;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvService.AutoGenerateColumns = true;
            this.dgvService.DataSource = ds.Tables[0];
        }

        public void PopulateComboBox()
        {
            try
            {
                this.catagoryInfoTableAdapter.Fill(this.barBerBD_SQL_DataBase.catagoryInfo);
                this.cmbCatagoryID.DisplayMember = "CatagoryID";
                this.cmbCatagoryID.ValueMember = "CatagoryName";
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void AutoIdGenerate()
        {
            var sql = "select ServiceID from serviceInfo order by ServiceID desc;";
            var dt = this.Da.ExecuteQueryTable(sql);
            var oldId = dt.Rows[0][0].ToString();
            int newId = Convert.ToInt32(oldId);
            this.txtServiceID.Text = (++newId).ToString();
        }

        private void lblCatagoryName_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
            this.PopulateGidView();
            this.AutoIdGenerate();
        }

        private void ClearAll()
        {
            this.txtServiceID.Clear();
            this.txtServiceName.Text = "";
            this.txtPrice.Clear();
            this.cmbCatagoryID.SelectedIndex = -1;

            this.txtAutoSearch.Clear();

            this.dgvService.ClearSelection();
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "SELECT serviceInfo.ServiceID,serviceInfo.ServiceName,catagoryInfo.CatagoryName,catagoryInfo.CatagoryID,serviceInfo.ServicePrice FROM serviceInfo INNER JOIN catagoryInfo ON serviceInfo.CatagoryID=catagoryInfo.CatagoryID where ServiceName like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGidView(sql);
        }

        private bool IsValidToSave()
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtServiceID.Text) || String.IsNullOrEmpty(this.txtServiceName.Text)
                || String.IsNullOrEmpty(this.txtPrice.Text) || String.IsNullOrEmpty(this.cmbCatagoryID.ValueMember))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return false;
            }

        }

        private void dgvService_DoubleClick(object sender, EventArgs e)
        {
            this.txtServiceID.Text = this.dgvService.CurrentRow.Cells[0].Value.ToString();
            this.txtServiceName.Text = this.dgvService.CurrentRow.Cells[1].Value.ToString();
            this.txtPrice.Text = this.dgvService.CurrentRow.Cells[4].Value.ToString();
            this.cmbCatagoryID.Text = this.dgvService.CurrentRow.Cells[3].Value.ToString();
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
                var sql = "select * from serviceInfo where ServiceID = '" + this.txtServiceID.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);
                //int catID = Convert.ToInt32(this.cmbCatagoryID.ValueMember);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    query = @"INSERT INTO serviceInfo(ServiceName, ServicePrice, CatagoryID) 
                                VALUES('" + this.txtServiceName.Text + @"', 
                                '" + this.txtPrice.Text + @"', 
                                '" + this.cmbCatagoryID.Text + "');";
                    var count = this.Da.ExecuteDMLQuery(query);

                    if (count == 1)
                        MessageBox.Show("Service data has been added properly");
                    else
                        MessageBox.Show("Service data saving failed");
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
                var sql = "select * from serviceInfo where ServiceID = '" + this.txtServiceID.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    query = @"UPDATE serviceInfo
                            SET ServiceName = '" + this.txtServiceName.Text + @"',
                            ServicePrice = '" + this.txtPrice.Text + @"',
                            CatagoryID = '" + this.cmbCatagoryID.Text + @"'
                            WHERE ServiceID = '" + this.txtServiceID.Text + "'; ";

                    var count = this.Da.ExecuteDMLQuery(query);

                    if (count == 1)
                        MessageBox.Show("Service data has been updated properly");
                    else
                        MessageBox.Show("Service data upgradation failed");
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
                if (this.dgvService.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to remove the data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure to remove the data?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;

                var id = this.dgvService.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvService.CurrentRow.Cells["ServiceName"].Value.ToString();
                var query = "delete from serviceInfo where ServiceID = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)
                    MessageBox.Show(name.ToUpper() + " has been removed from the list.");
                else
                    MessageBox.Show("Service data remove failed");

                this.PopulateGidView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has been found:\n" + exc.Message);
            }
        }
    }
}
