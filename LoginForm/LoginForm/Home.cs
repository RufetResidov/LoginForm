using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register rg = new Register();
            rg.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
        }
    }
}
