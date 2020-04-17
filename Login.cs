using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class Login : Form
    {
        Main pf;
        public Login()
        {
            InitializeComponent();

        }


        public Login(Main parent)
        {
            InitializeComponent();
            pf = parent;
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtEmail.TextLength == 0 )
            {
                MessageBox.Show("Please enter a proper email address");

            } 
            else
            {
                MessageBox.Show("Check your email for information to reset your password. Please wait at least one minute and mkae sure to check the spam folder before trying again.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtUsername.TextLength == 0 || txtPassword.TextLength == 0)
            {
                MessageBox.Show("Please fill in an email address and password.");

            } else if ((txtUsername.TextLength < 6 || txtPassword.TextLength < 6)) {

                MessageBox.Show("Wrong username or password. Try again. If you forgot your password click the Forgot Password? tab.");

            }
            else
            {
                MessageBox.Show("Logged in. Welcome " + txtUsername.Text);
            }
        }
    }
}
