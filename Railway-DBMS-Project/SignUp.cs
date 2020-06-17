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
    public partial class SignUp : Form
    {
        private Controller controllerObj;
        string Gender;
        HashCode hc = new HashCode();
        public SignUp()
        {
            controllerObj = new Controller();

            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        

        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void phnoenum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid Phone Number value in integers  ");
            }


        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "M";
        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "F";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = (string)name.Text; // get the name string
            string Email = (string)email.Text; // get the name string
            string Password = hc.PassHash((string)password.Text); // Encrypting 
            int PhoneNum = int.Parse((string)phonenum.Text);
            int Age = int.Parse((string)age.Text);
            int CurrentUserID = controllerObj.GetMaxUserID();
            CurrentUserID++;

           int val = controllerObj.SignUpUser(CurrentUserID,Name,Email,Password,Age,Gender,PhoneNum); // Add function to Controller 
           if (val > 0) MessageBox.Show("You have signed up successfully");
        }

        private void age_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
