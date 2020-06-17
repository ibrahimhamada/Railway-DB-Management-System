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
    public partial class ViewAndCancelEmp : Form
    {
        private Controller controllerObj;
        int empno;
        public ViewAndCancelEmp(int id)
        {
            InitializeComponent();
            controllerObj = new Controller();

            empno = id;

            MyTickDGV.DataSource = controllerObj.ViewAllTickets();
            MyTickDGV.Refresh();
            MyTickDGV.ReadOnly = true;
            MyTickDGV.AllowUserToAddRows = false;
            MyTickDGV.AllowUserToDeleteRows = false;

         
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void ViewAndCancelEmp_Load(object sender, EventArgs e)
        {

        }


    

      
  
        private void viewall_Click(object sender, EventArgs e)
        {
            MyTickDGV.DataSource = controllerObj.ViewAllTickets();
            MyTickDGV.Refresh();
            MyTickDGV.ReadOnly = true;
            MyTickDGV.AllowUserToAddRows = false;
            MyTickDGV.AllowUserToDeleteRows = false;
        }

        private void view_Click(object sender, EventArgs e)
        {
            if (Date.Text != "yyyy-mm-dd") {

                MyTickDGV.DataSource = controllerObj.ViewAllTicketsDate(Date.Text);
                MyTickDGV.Refresh();
                MyTickDGV.ReadOnly = true;
                MyTickDGV.AllowUserToAddRows = false;
                MyTickDGV.AllowUserToDeleteRows = false;
            }

            else
            {
                MessageBox.Show("Please Select a Valid Date!");

            }
        }

        private void cancel_Click_1(object sender, EventArgs e)
        {
            int ticketno = (int)ticketID.Value;

            int passengerno = controllerObj.passengernofromticket(ticketno);

            int p1 = controllerObj.DeleteTicket(ticketno);

            int p2 = controllerObj.DeletePassenger(passengerno);
            if (p1 != 0 && p2 != 0)
            {
                MessageBox.Show("Ticket has been canceled successfully!");
                MyTickDGV.DataSource = controllerObj.ViewAllTickets();
                MyTickDGV.Refresh();
                MyTickDGV.ReadOnly = true;
                MyTickDGV.AllowUserToAddRows = false;
                MyTickDGV.AllowUserToDeleteRows = false;
            }
            else
                MessageBox.Show("Errorr while Ticket Cancelation!");

        }

        private void back_Click(object sender, EventArgs e)
        {
            Employees2 ad = new Employees2(empno);
            ad.Show();
            this.Close();
        }

        private void done_Click(object sender, EventArgs e)
        {
            Employees2 ad = new Employees2(empno);
            ad.Show();
            this.Close();
        }
    }
}