using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberBD
{
    public partial class Billing : UserControl
    {
        private DataAccess Da { get; set; }
        private DataGridViewRow dr ;
        private int Stock {  get; set; }
        private string ProductID {  get; set; }
        private string BillID {  get; set; }
        private static int n = 0;
        private float GrdTotal = 0f;
        public Billing()
        {
            InitializeComponent();
            
            this.Da = new DataAccess();

            this.PopulateProductGidView();

            this.PopulateServiceGidView();

            this.CustomerAutoIdGenerate();

            this.BillAutoIdGenerate();
        }

        //
        //Product Details
        //

        public void PopulateProductGidView(string sql = "select * from productInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvProduct.AutoGenerateColumns = true;
            this.dgvProduct.DataSource = ds.Tables[0];
        }
        private void ClearAllProductDetails()
        {
            this.txtProductName.Text = "";
            this.txtProductQuantity.Clear();
            this.txtProductPrice.Clear();
            this.dgvProduct.ClearSelection();
            Stock = 0;
            ProductID = string.Empty;
        }
        private bool IsValidToAddProduct()
        {
            try
            {
                int value = Convert.ToInt32(this.txtProductQuantity.Text);
                if (String.IsNullOrEmpty(this.txtProductName.Text) || String.IsNullOrEmpty(this.txtProductPrice.Text) 
                    || value <= 0)
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

        private void btnProductReset_Click(object sender, EventArgs e)
        {
            this.ClearAllProductDetails();
            this.PopulateProductGidView();
        }

        private void dgvProduct_DoubleClick(object sender, EventArgs e)
        {
            this.txtProductName.Text = this.dgvProduct.CurrentRow.Cells[1].Value.ToString();
            this.ProductID = this.dgvProduct.CurrentRow.Cells[0].Value.ToString();
            this.txtProductPrice.Text = this.dgvProduct.CurrentRow.Cells[3].Value.ToString();
            this.Stock = Convert.ToInt32(this.dgvProduct.CurrentRow.Cells[2].Value.ToString());
        }

        private void UpdateStock()
        {
            try
            {
                int newQty = this.Stock - Convert.ToInt32(txtProductQuantity.Text);
                string PID = this.ProductID;
                string query = @"UPDATE productInfo
                        SET ProductQuantity = '" + newQty + @"'
                        WHERE ProductID = '" + PID + "'; ";

                this.Da.ExecuteDMLQuery(query);

                this.ClearAllProductDetails();
                this.PopulateProductGidView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity = Convert.ToInt32(txtProductQuantity.Text);
                int Price = Convert.ToInt32(txtProductPrice.Text);
                int discount = 0;
                float vat = 1.5f;
                float discountedPrice = Price - (Price * discount / 100);
                float totalBeforeVAT = quantity * discountedPrice;
                float totalWithVAT = totalBeforeVAT * (1 + vat / 100);


                if (txtProductQuantity.Text == "" || quantity > Stock)
                {
                    MessageBox.Show("Not Enough Quantity");
                }
                else if (!IsValidToAddProduct())
                {
                    MessageBox.Show("Please fill all the information Correctly");
                }
                else
                {
                    dr = new DataGridViewRow();
                    dr.CreateCells(dgvFinalBill);
                    dr.Cells[0].Value = n + 1;
                    dr.Cells[1].Value = this.txtProductName.Text;
                    dr.Cells[2].Value = quantity;
                    dr.Cells[3].Value = Price;
                    dr.Cells[4].Value = discount + "%";
                    dr.Cells[5].Value = vat + "%";
                    dr.Cells[6].Value = "Taka " + totalWithVAT;
                    
                    dgvFinalBill.Rows.Add(dr);
                    n++;

                    GrdTotal = GrdTotal + totalWithVAT;
                    lblAmount.Text = "Taka " + GrdTotal;
                    UpdateStock();
                    ClearAllProductDetails();
                    PopulateProductGidView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
            }
            
        }

        //
        //Service Details
        //

        public void PopulateServiceGidView(string sql = "select * from serviceInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvService.AutoGenerateColumns = true;
            this.dgvService.DataSource = ds.Tables[0];
        }

        private void ClearAllServiceDetails()
        {
            this.txtServiceName.Text = "";
            this.txtServicePrice.Clear();
            this.txtServiceDiscount.Clear();
            this.dgvService.ClearSelection();
        }

        private bool IsValidToAddService()
        {
            try
            {
                int value = Convert.ToInt32(this.txtServiceDiscount.Text);
                if (String.IsNullOrEmpty(this.txtServiceName.Text) || String.IsNullOrEmpty(this.txtServicePrice.Text)
                    || value <= 0)
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

        private void btnServiceReset_Click(object sender, EventArgs e)
        {
            this.ClearAllServiceDetails();
            this.PopulateServiceGidView();
        }

        private void dgvService_DoubleClick(object sender, EventArgs e)
        {
            this.txtServiceName.Text = this.dgvService.CurrentRow.Cells[1].Value.ToString();
            this.txtServicePrice.Text = this.dgvService.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnServiceAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity = 1;
                int Price = Convert.ToInt32(this.txtServicePrice.Text);
                int discount = Convert.ToInt32(this.txtServiceDiscount.Text);
                float vat = 0.0f;
                float discountedPrice = Price - (Price * discount / 100);
                float totalBeforeVAT = quantity * discountedPrice;
                float totalWithVAT = totalBeforeVAT;

                if (!IsValidToAddService())
                {
                    MessageBox.Show("Please fill all the information Correctly");
                }
                else
                {
                    dr = new DataGridViewRow();
                    dr.CreateCells(dgvFinalBill);
                    dr.Cells[0].Value = n + 1;
                    dr.Cells[1].Value = this.txtServiceName.Text;
                    dr.Cells[2].Value = quantity;
                    dr.Cells[3].Value = Price;
                    dr.Cells[4].Value = discount + "%";
                    dr.Cells[5].Value = vat + "%";
                    dr.Cells[6].Value = "Taka " + totalWithVAT;

                    dgvFinalBill.Rows.Add(dr);
                    n++;

                    GrdTotal = GrdTotal + totalWithVAT;
                    lblAmount.Text = "Taka " + GrdTotal;
                    ClearAllServiceDetails();
                    PopulateServiceGidView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        //
        //BillID AutoGenerate
        //

        private void BillAutoIdGenerate()
        {
            var sql = "select iD from Table_1 order by iD desc;";
            var dt = this.Da.ExecuteQueryTable(sql);
            var oldId = dt.Rows[0][0].ToString();
            int newId = Convert.ToInt32(oldId);
            this.txtBillID.Text = (++newId).ToString();
            this.BillID = this.txtBillID.Text;
        }

        //
        //Customer Details
        //

        private void CustomerAutoIdGenerate()
        {
            var sql = "select CustomerID from customerinfo order by CustomerID desc;";
            var dt = this.Da.ExecuteQueryTable(sql);
            var oldId = dt.Rows[0][0].ToString();
            int newId = Convert.ToInt32(oldId);
            this.txtCustomerID.Text = (++newId).ToString();
        }

        private bool IsValidToAddCustomer()
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtCustomerID.Text) || String.IsNullOrEmpty(this.txtCustomerName.Text)
                    || String.IsNullOrEmpty(this.txtCustomerNumber.Text) || String.IsNullOrEmpty(this.txtCustomerEmail.Text)
                    || String.IsNullOrEmpty(this.txtBillID.Text))
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

        private void ClearAllCustomerDetails()
        {
            this.txtCustomerName.Text = "";
            this.txtCustomerNumber.Clear();
            this.txtCustomerEmail.Clear();
            this.CustomerAutoIdGenerate();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //
            //Add Customer To Database
            //

            try
            {
                if (!this.IsValidToAddCustomer())
                {
                    MessageBox.Show("Please fill all the information Correctly");
                    return;
                }

                string query = null;
                var sql = "select * from customerinfo where CustomerID = '" + this.txtCustomerID.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    query = @"INSERT INTO customerinfo(CustomerID, CustomerName, CustomerPNo, CustomerEmail) 
                                VALUES('" + this.txtCustomerID.Text + @"', 
                                '" + this.txtCustomerName.Text + @"',
                                '" + this.txtCustomerNumber.Text + @"',
                                '" + this.txtCustomerEmail.Text + "');";
                    var count = this.Da.ExecuteDMLQuery(query);

                    //if (count == 1)
                    //    MessageBox.Show("Customer data has been added properly");
                    //else
                    //    MessageBox.Show("Customer data adding failed");
                }
                
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has been found:\n" + exc.Message);
            }

            //
            //Add BillInfo To Database
            //

            try
            {
                if (!this.IsValidToAddCustomer())
                {
                    MessageBox.Show("Please fill all the information Correctly");
                    return;
                }

                string query = null;
                var date = DateTime.Now;
                string datetime = date.ToString();
                var sql = "select * from Table_1 where iD = '" + this.txtBillID.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    query = @"INSERT INTO Table_1(grandTotal, dateTm) 
                                VALUES('" + GrdTotal + @"', 
                                '" + datetime + "');";
                    var count = this.Da.ExecuteDMLQuery(query);

                    //if (count == 1)
                    //    MessageBox.Show("Billing data has been added properly");
                    //else
                    //    MessageBox.Show("Billing data adding failed");
                }
                this.ClearAllCustomerDetails();
                //dgvFinalBill.Rows.Remove(dr);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has been found:\n" + exc.Message);
            }

            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 360, 600);
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        int productId, productQntity, productPrice, positon = 60;
        string dis, vat, total;
        string productName;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("BarberBD Management", new Font("Monotype Corsiva", 12,FontStyle.Italic),Brushes.Red,new Point(80));
            e.Graphics.DrawString("SNo. Product Qty Price Dis Vat Total", new Font("Monotype Corsiva", 10,FontStyle.Italic),Brushes.Red,new Point(26,40));
            foreach(DataGridViewRow row in dgvFinalBill.Rows )
            {
                productId = Convert.ToInt32(row.Cells["Column1"].Value);
                productName = "" + row.Cells["Column2"].Value;
                productQntity = Convert.ToInt32(row.Cells["Column3"].Value);
                productPrice = Convert.ToInt32(row.Cells["Column4"].Value);
                dis = Convert.ToString(row.Cells["Column5"].Value);
                vat = Convert.ToString(row.Cells["Column6"].Value);
                total = Convert.ToString(row.Cells["Column7"].Value);

                e.Graphics.DrawString(""+productId, new Font("Monotype Corsiva", 8, FontStyle.Italic), Brushes.Blue, new Point(26, positon));
                e.Graphics.DrawString(""+productName, new Font("Monotype Corsiva", 8, FontStyle.Italic), Brushes.Blue, new Point(45, positon));
                e.Graphics.DrawString(""+productQntity, new Font("Monotype Corsiva", 8, FontStyle.Italic), Brushes.Blue, new Point(120, positon));
                e.Graphics.DrawString(""+productPrice, new Font("Monotype Corsiva", 8, FontStyle.Italic), Brushes.Blue, new Point(170, positon));
                e.Graphics.DrawString(""+dis, new Font("Monotype Corsiva", 8, FontStyle.Italic), Brushes.Blue, new Point(235, positon));
                e.Graphics.DrawString(""+vat, new Font("Monotype Corsiva", 8, FontStyle.Italic), Brushes.Blue, new Point(310, positon));
                e.Graphics.DrawString(""+total, new Font("Monotype Corsiva", 8, FontStyle.Italic), Brushes.Blue, new Point(360, positon));
                positon = positon+20;
            }
            e.Graphics.DrawString("Grand Total :Taka" + GrdTotal, new Font("Monotype Corsiva", 12, FontStyle.Italic), Brushes.Crimson, new Point(50, positon+50));
            e.Graphics.DrawString("**************BarberBD Management**************" + GrdTotal, new Font("Monotype Corsiva", 12, FontStyle.Italic), Brushes.Crimson, new Point(10, positon+85));
            dgvFinalBill.Rows.Clear();
            dgvFinalBill.Refresh();
            positon = 100;
            GrdTotal = 0;
            n = 0;
        }
    }
}
