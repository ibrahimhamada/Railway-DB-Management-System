using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace RailWay
{
    public partial class ViewRequests : Form
    {
        private Controller controllerObj;
        int adminid;
        public ViewRequests(int empid)
        {
            InitializeComponent();
            adminid = empid;

        }

        private void ViewRequests_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            ViewReqDGV.DataSource = controllerObj.ViewRequests(adminid);
            ViewReqDGV.Refresh();
            ViewReqDGV.ReadOnly = true;
            ViewReqDGV.AllowUserToAddRows = false;
            ViewReqDGV.AllowUserToDeleteRows = false;
            MessageBox.Show("Current Requests Viewed!"); // chcek[if there are no elements in data grid view ]
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.Show();
            this.Hide();
        }
    }
}
