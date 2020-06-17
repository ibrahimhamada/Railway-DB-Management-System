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
    public partial class SendRequest : Form
    {
        private Controller controllerObj;
        int empno;
        public SendRequest(int employeenum)
        {
            InitializeComponent();
            empno = employeenum;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SendRequest_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Employee v = new Employee(empno);
            v.Show();
            this.Close();

        }

        private void sendreq_Click(object sender, EventArgs e)
        {
            string request = (string)writereq.Text; // get the request that employee wrote
            int requestnum = controllerObj.GetRequestID() + 1;
            int superssnnum = controllerObj.GetRSuperSSN(empno);
            string req_status = "ON";
            controllerObj.InsertRequest(requestnum,request, empno,  superssnnum, req_status);
            MessageBox.Show("Your request has been recorded and sent.");

            Employee v = new Employee(empno);
            v.Show();
            this.Close();

        }
    }
}
