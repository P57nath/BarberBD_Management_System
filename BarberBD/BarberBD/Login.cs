using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace BarberBD
{
    public partial class Login : Form
    {
        private DataAccess Da { get; set; }

        public Login()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            txtUserID.Clear();
            txtPasswordName.Clear();
            txtUserID.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtUserID.Text) || String.IsNullOrEmpty(this.txtPasswordName.Text))
                return false;
            else
                return true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the information");
                    return;
                }

                string sql = "Select * from userInfo where UserID = '" + this.txtUserID.Text + "' and UserPass = '" + this.txtPasswordName.Text + "';";

                var ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    var name = ds.Tables[0].Rows[0][1].ToString();
                    var id = ds.Tables[0].Rows[0][0].ToString();
                    var role = ds.Tables[0].Rows[0][7].ToString();

                    if (role == "Manager")
                    {
                        this.Hide();
                        new AdminDashBoard(id,name, this).Show();                     
                    }
                    else if(role == "Staff")
                    {
                        this.Hide();
                        new StaffDashBoard(id,name, this).Show();
                    }
                }
                else
                {
                    MessageBox.Show("The UserName or Password you entered is incorrect, Try Again");
                    txtUserID.Clear();
                    txtPasswordName.Clear();
                    txtUserID.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.txtPasswordName.PasswordChar = '\0';

            Timer timer = new Timer();
            timer.Interval = 3000; 
            timer.Tick += (s, args) =>
            {
                this.txtPasswordName.PasswordChar = '*';
                timer.Stop(); 
                timer.Dispose(); 
            };
            timer.Start();
        }
    }
}
