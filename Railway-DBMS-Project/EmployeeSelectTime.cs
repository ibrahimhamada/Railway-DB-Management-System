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
    public partial class EmployeeSelectTime : Form
    {
        private Controller controllerObj;
        private int FromCB, ToCB; // Need to add more members 
        public EmployeeSelectTime(int ticketnum, int price, string tickettype, string date, int tripnum, int usernum, int passnum, int FromSCB, int ToSCB, int tracknum, int employeenum)
        {
            InitializeComponent();
            controllerObj = new Controller();
            FromCB = FromSCB;
            ToCB = ToSCB;
            //SelTimeDGV.DataSource = controllerObj.SelectTimeDGV(); // Edit 

            SelTimeCB.DataSource = controllerObj.SelectTimeCB(); //Edit 
            SelTimeCB.DisplayMember = "departure_time";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(NumVal.Value); // get the value as int from numericupdown 
                                                   // Link this button with Employee-SetQuantity using the number you get from numericupdown
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Employee v = new Employee();    // Update here (Enter employee id)
            //v.Show();
        }
    }
}
