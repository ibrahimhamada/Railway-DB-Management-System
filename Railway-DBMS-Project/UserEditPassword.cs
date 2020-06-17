using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailWay
{
    public partial class UserEditPassword : Form
    {

        private Controller controllerObj;
        int usernum;
        public UserEditPassword(int userid)
        {
            InitializeComponent();
            controllerObj = new Controller();
            usernum = userid;
        }

        private void UserEditPassword_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User us = new User();
            us.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // Remember To add encryption after checking that this form is OKAY 
        {
            // get user pass by adding new controller function 
            string userpass = controllerObj.GetUserPassword(usernum); // ERROR here 
            if (currpass.Text == userpass) // He wrote right password
            {
                if (newpass.Text == confirmpass.Text) // compare between new password and its confirmation
                {
                    controllerObj.EditUserPassword(newpass.Text, usernum);
                    MessageBox.Show("Password Changed Successfully!");
                }
                else
                {
                    MessageBox.Show("Plese make sure that two passwords are the same");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please enter valid Current Password");
                return;
            }
        }
    }
}
