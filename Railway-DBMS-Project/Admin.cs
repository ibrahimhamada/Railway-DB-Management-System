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
    public partial class Admin : Form
    {
        private Controller controllerObj;
        private int Emp_id;
        public Admin(int id)
        {
            InitializeComponent();
            controllerObj = new Controller();
            Emp_id = id;
        }

        public Admin()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Statistics stat = new Statistics(Emp_id);
            stat.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Login Log = new Login();
            Log.Show();
            this.Close();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            Trains train = new Trains();
            train.Show();
            this.Close();

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Tracks t = new Tracks();
            t.Show();
            this.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Stations st = new Stations();
            st.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ViewRequests VR = new ViewRequests(Emp_id);
            VR.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Employees2 VR = new Employees2(Emp_id);
            VR.Show();
            this.Close();
        }

        private void Button7_Click_1(object sender, EventArgs e)
        {
            StatisticsReport st = new StatisticsReport();
            st.Show();
            this.Close();
        }
    }
}
