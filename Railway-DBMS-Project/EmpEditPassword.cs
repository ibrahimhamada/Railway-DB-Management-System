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
    public partial class EmpEditPassword : Form
    {
        private Controller controllerObj;
        int empnum;
        int priv;
        string password;
        public EmpEditPassword(string pass, int employeenum, int privilige)
        {
            InitializeComponent();
            controllerObj = new Controller();
            empnum = employeenum;
            priv = privilige;
            password = pass;
        }

        private void EmpEditPassword_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (currpass.Text == password) // He wrote right password
            {
                if (newpass.Text == confirmpass.Text) // compare between new password and its confirmation
                {
                    controllerObj.EditEmpPassword(newpass.Text, password);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Employees2 emp = new Employees2(password,empnum,priv);
            emp.Show();
            this.Hide();
        }
    }
}
