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
    public partial class StartLoading : Form
    {
        public StartLoading()
        {
            InitializeComponent();
        }

        private void Tmr_Pb_Tick(object sender, EventArgs e)
        {
            prgbrStart.Value = prgbrStart.Value + 2;
            lblPercent.Text = prgbrStart.Value.ToString() + "%";


            if (prgbrStart.Value >= 99)
            {
                Tmr_Pb.Enabled = false;
                Form frm = new Login();
                frm.Show();
                this.Hide();
            }
        }
    }
}
