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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            bool isCorrect = false;
            foreach (var user in Utilities.UserList)
            {
                if (user.Email == email && user.Password == password)
                {
                    Dashboard ds = new Dashboard();
                    isCorrect = true;
                    ds.ShowDialog();
                }
            }
            if(!isCorrect )
            {
                MessageBox.Show("Email ve ya parol sehvdir");
            }
        }
    }
}
