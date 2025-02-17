using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peminjaman_Playstation.view
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Efek fade out sebelum berpindah ke form login
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer1.Stop(); 
                this.Hide();
                //LoginForm loginForm = new LoginForm(); // Ganti dengan form login kamu
                //loginForm.Show();
                Homepage homepage = new Homepage(); // Ganti dengan form login kamu
                homepage.Show();
            }
        }
    }
}
