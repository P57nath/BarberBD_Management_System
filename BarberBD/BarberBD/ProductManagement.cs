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
    public partial class ProductManagement : UserControl
    {
        private DataAccess Da { get; set; }
        public ProductManagement()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.PopulateGidView();
            this.PopulateComboBox();
            this.AutoIdGenerate();
        }
        public void PopulateGidView(string sql = "SELECT productInfo.ProductID,productInfo.ProductName,catagoryInfo.CatagoryName,catagoryInfo.CatagoryID,productInfo.ProductPrice,productInfo.ProductQuantity,ProductExpireDate FROM productInfo INNER JOIN catagoryInfo ON productInfo.CatagoryID=catagoryInfo.CatagoryID;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvProduct.AutoGenerateColumns = true;
            this.dgvProduct.DataSource = ds.Tables[0];
        }

        public void PopulateComboBox()
        {
            try
            {
                this.catagoryInfoTableAdapter.Fill(this.barBerBD_SQL_DataBase.catagoryInfo);
                this.cmbCatagory.DisplayMember = "CatagoryID";
                this.cmbCatagory.ValueMember = "CatagoryName";
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void AutoIdGenerate()
        {
            var sql = "select ProductID from productInfo order by ProductID desc;";
            var dt = this.Da.ExecuteQueryTable(sql);
            var oldId = dt.Rows[0][0].ToString();
            int newId = Convert.ToInt32(oldId);
            this.txtProductID.Text = (++newId).ToString();
        }
        private void ClearAll()
        {
            this.txtProductID.Clear();
            this.txtProductName.Text = "";
            this.txtQuantity.Clear();
            this.txtPrice.Clear();
            this.dtpExpireDate.Text = "";
            this.cmbCatagory.SelectedIndex = -1;

            this.txtAutoSearch.Clear();

            this.dgvProduct.ClearSelection();
        }

        private bool IsValidToSave()
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtProductID.Text) || String.IsNullOrEmpty(this.txtProductName.Text)
                || String.IsNullOrEmpty(this.txtPrice.Text) || String.IsNullOrEmpty(this.cmbCatagory.ValueMember)
                || String.IsNullOrEmpty(this.txtQuantity.Text) || String.IsNullOrEmpty(this.dtpExpireDate.Text))
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
            this.PopulateGidView();
            this.AutoIdGenerate();
        }

        private void dgvProduct_DoubleClick(object sender, EventArgs e)
        {
            this.txtProductID.Text = this.dgvProduct.CurrentRow.Cells[0].Value.ToString();
            this.txtProductName.Text = this.dgvProduct.CurrentRow.Cells[1].Value.ToString();
            this.txtQuantity.Text = this.dgvProduct.CurrentRow.Cells[5].Value.ToString();
            this.txtPrice.Text = this.dgvProduct.CurrentRow.Cells[4].Value.ToString();
            this.dtpExpireDate.Text = this.dgvProduct.CurrentRow.Cells[6].Value.ToString();
            this.cmbCatagory.Text = this.dgvProduct.CurrentRow.Cells[3].Value.ToString();
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "SELECT productInfo.ProductID,productInfo.ProductName,catagoryInfo.CatagoryName,catagoryInfo.CatagoryID,productInfo.ProductPrice,productInfo.ProductQuantity,ProductExpireDate FROM productInfo INNER JOIN catagoryInfo ON productInfo.CatagoryID=catagoryInfo.CatagoryID where ProductName like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGidView(sql);
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
                var sql = "select * from productInfo where ProductID = '" + this.txtProductID.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    query = @"INSERT INTO productInfo(ProductName, ProductQuantity, ProductPrice, ProductExpireDate, CatagoryID) 
                                VALUES('" + this.txtProductName.Text + @"', 
                                '" + this.txtQuantity.Text + @"', 
                                '" + this.txtPrice.Text + @"', 
                                '" + this.dtpExpireDate.Text + @"', 
                                '" + this.cmbCatagory.Text + "');";
                    var count = this.Da.ExecuteDMLQuery(query);

                    if (count == 1)
                        MessageBox.Show("Product data has been added properly");
                    else
                        MessageBox.Show("Product data saving failed");
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
                var sql = "select * from productInfo where ProductID = '" + this.txtProductID.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    query = @"UPDATE productInfo
                            SET ProductName = '" + this.txtProductName.Text + @"',
                            ProductQuantity = '" + this.txtQuantity.Text + @"',
                            ProductPrice = '" + this.txtPrice.Text + @"',
                            ProductExpireDate = '" + this.dtpExpireDate.Text + @"',
                            CatagoryID = '" + this.cmbCatagory.Text + @"'
                            WHERE ProductID = '" + this.txtProductID.Text + "'; ";

                    var count = this.Da.ExecuteDMLQuery(query);

                    if (count == 1)
                        MessageBox.Show("Product data has been updated properly");
                    else
                        MessageBox.Show("Product data upgradation failed");
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
                if (this.dgvProduct.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to remove the data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure to remove the data?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;

                var id = this.dgvProduct.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvProduct.CurrentRow.Cells["ProductName"].Value.ToString();
                var query = "delete from productInfo where ProductID = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)
                    MessageBox.Show(name.ToUpper() + " has been removed from the list.");
                else
                    MessageBox.Show("Product data remove failed");

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
