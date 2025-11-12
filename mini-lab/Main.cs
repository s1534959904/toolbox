using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsCloudTest;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Reptile_QR f2 = new Reptile_QR();

           
            f2.FormClosed += (s, args) => { this.Show(); };
            f2.Show();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AI_ds f4 = new AI_ds();

          
            f4.FormClosed += (s, args) => { this.Show(); };
            f4.Show();
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Cloud f4 = new Cloud();

           
            f4.FormClosed += (s, args) => { this.Show(); };
            f4.Show();
        }
    }
}
