using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BarberBD
{
    public partial class AdminDashBoard : Form
    {
        private Login F1 { get; set; }
        private DataAccess Da { get; set; }
        private string ID { get; set; }
        private string Name { get; set; }
        public AdminDashBoard()
        {
            InitializeComponent();
        }
        public AdminDashBoard(string id, string name, Login f) : this() 
        {
            this.lblProfile.Text = name + " Profile ";
            this.ID = id;
            this.Name = name;
            this.F1 = f;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form frm = new Login();
            frm.Show();
            this.Hide();
        }
        
        public void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel4.Controls.Clear();
            panel4.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ServiceManagement serviceManagement = new ServiceManagement();
            AddUserControl(serviceManagement);
        }

        private void btnCatMan_Click(object sender, EventArgs e)
        {
            NewAddCatagory newAddCatagory = new NewAddCatagory();
            AddUserControl(newAddCatagory);
        }

        private void btnUserMan_Click(object sender, EventArgs e)
        {
            UserManagement userManagement = new UserManagement();
            AddUserControl(userManagement);
        }

        private void btnProductMan_Click(object sender, EventArgs e)
        {
            ProductManagement productManagement = new ProductManagement();
            AddUserControl(productManagement);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Billing billing = new Billing();
            AddUserControl (billing);   
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Profile(this.ID, this).Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            AddUserControl(dashBoard);
        }
    }
}
