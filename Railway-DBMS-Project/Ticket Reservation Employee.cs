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
    public partial class Ticket_Reservation_Employee : Form
    {
        private Controller controllerObj;
        int empno;
        public Ticket_Reservation_Employee(int id)
        {
            InitializeComponent();
            controllerObj = new Controller();
            empno = id;
        }

        private void Ticket_Reservation_Employee_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employees2 ad = new Employees2(empno);
            ad.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Passengers_Info_Employee ad = new Passengers_Info_Employee(empno, (int)quantity.Value);
            ad.Show();
            this.Close();
        }
    }
}
