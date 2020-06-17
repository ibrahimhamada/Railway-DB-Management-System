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
    public enum Privileges
    {
        Admin = 1,
        Others = 2,
        Supervisor = 3
    }
    public partial class Login : Form
    {
        private Controller controllerObj;
        public Login()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int prvg = controllerObj.CheckPassword(TxtBx_username.Text, TxtBx_pass.Text);
            if (prvg > 0)
            {
                if (prvg == 1)
                {
                    if (controllerObj.checkEmpid((int)id.Value))
                    {
                        Employees2 adm = new Employees2(TxtBx_pass.Text,(int)id.Value, prvg);
                        adm.Show(this);
                        TxtBx_username.Clear();
                        TxtBx_pass.Clear();
                        id.Refresh();
                        
                    }
                    else
                    {
                        MessageBox.Show("Incorrect ID");
                    }
                }
                else if(prvg == 2)
                {
                    if (controllerObj.checkUserid((int)id.Value))
                    {

                        User1 usr = new User1((int)id.Value);
                        usr.Show(this);
                        TxtBx_username.Clear();
                        TxtBx_pass.Clear();
                        id.Refresh();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect ID");
                    }
                }

                else if (prvg == 3)
                {
                    if (controllerObj.checkSuperid((int)id.Value))
                    {

                        Admin usr = new Admin((int)id.Value);
                        usr.Show(this);
                        TxtBx_username.Clear();
                        TxtBx_pass.Clear();
                        id.Refresh();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect ID");
                    }
                }
            }
            else
                MessageBox.Show("Incorrect Password or Email or ID");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SignUp SU = new SignUp();
            SU.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void TxtBx_pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
