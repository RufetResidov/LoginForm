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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullname = txtFullname.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            bool isCorrect = false;
            if (email.Contains("@"))
            {
                if (Utilities.UserList.Count == 0)
                {
                    User us = new User(fullname, email, password);
                    Utilities.UserList.Add(us);
                }
                else
                {
                    foreach (var u in Utilities.UserList)
                    {
                        if (u.Email != email)
                        {
                            User us = new User(fullname, email, password);
                            MessageBox.Show("Qeydiyyat ugurla basa catdi !");
                            Utilities.UserList.Add(us);
                            isCorrect = true;
                            txtEmail.Text = "";
                            txtFullname.Text = "";
                            txtPassword.Text = "";
                            break;
                        }
                    }
                    if (!isCorrect)
                    {
                        MessageBox.Show("Email already exist!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Email adini duzgun daxil edin");
            }
        }
    }
}
