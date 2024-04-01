using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            

            if (txtEmail.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please fill completely");
                txtEmail.Text = "";
                txtPassword.Text = "";

            }
            else if(txtEmail.Text == "moe@gmail.com" && txtPassword.Text == "123456")
            {
                MessageBox.Show("Login Successful");
                txtEmail.Text = "";
                txtPassword.Text = "";
            }
            else if(txtEmail.Text != "moe@gmail.com")
            {
                MessageBox.Show("Your Email is wrong.Please try again");
                txtEmail.Text = "";
            }
            else if(txtPassword.Text != "123456")
            {
                MessageBox.Show("Your Password is wrong.Please try again");
                txtPassword.Text = "";
            }
            else { MessageBox.Show("Login Fail.Please check your email and password");
                txtEmail.Text = "";
                txtPassword.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtPassword.Text = "";

        }
    }
}
