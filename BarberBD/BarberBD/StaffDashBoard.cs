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
    public partial class StaffDashBoard : Form
    {
        private Login F1 { get; set; }
        private DataAccess Da { get; set; }
        private string ID {  get; set; }
        private string Name {  get; set; }
        public StaffDashBoard()
        {
            InitializeComponent();
        }
        public StaffDashBoard(string id, string name, Login f) : this()
        {
            this.ID = id;
            this.Name = name;
            this.lblProfile.Text = name + " Profile ";
            this.F1 = f;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
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

        private void btnCatMan_Click(object sender, EventArgs e)
        {
            NewAddCatagory newAddCatagory = new NewAddCatagory();
            AddUserControl(newAddCatagory);
        }

        private void btnProductMan_Click(object sender, EventArgs e)
        {
            ProductManagement productManagement = new ProductManagement();
            AddUserControl(productManagement);
        }

        private void btnServiceMan_Click(object sender, EventArgs e)
        {
            ServiceManagement serviceManagement = new ServiceManagement();
            AddUserControl(serviceManagement);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Billing billing = new Billing();
            AddUserControl(billing);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Profile(this.ID, this ).Show();
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
