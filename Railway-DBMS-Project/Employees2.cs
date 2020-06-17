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
    public partial class Employees2 : Form
    {
        private Controller controllerObj;
        int empno, privl;
        string password;
        public Employees2(string pass, int employeeno, int priv)
        {

            InitializeComponent();
            controllerObj = new Controller();
            empno = employeeno;
            privl = priv;
            password = pass;
            if (controllerObj.IsDriver(empno))
            {
                tracksandstations.Enabled = false;
                button3.Enabled = false;
            }

        }
        public Employees2(int employeeno)
        {

            InitializeComponent();
            controllerObj = new Controller();
            empno = employeeno;

            if (controllerObj.IsDriver(empno))
            {
                tracksandstations.Enabled = false;
                button3.Enabled = false;
            }

        }

        private void Employees2_Load(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            Login Log = new Login();
            Log.Show();
            this.Close();
        }

        private void viewmytickets_Click(object sender, EventArgs e)
        {
            Tracks_and_Stations Log = new Tracks_and_Stations(empno);
            Log.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ticket_Reservation_Employee Log = new Ticket_Reservation_Employee(empno);
            Log.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View_Trains ad = new View_Trains(empno);
            ad.Show();
            this.Close();
        }

        private void tracksandstations_Click(object sender, EventArgs e)
        {
            ViewAndCancelEmp ad = new ViewAndCancelEmp(empno);
            ad.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SendRequest v = new SendRequest(empno);
            v.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            EmpEditPassword Log = new EmpEditPassword(password,empno,privl);
            Log.Show();
            this.Close();
        }

        private void viewstatistics_Click(object sender, EventArgs e)
        {
            Statistics ad = new Statistics(empno) ;
            ad.Show();
            this.Close();
        }
    }
}
