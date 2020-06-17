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
    public partial class MyTickets : Form
    {
        private Controller controllerObj;
        int userno;
        public MyTickets(int usernum)
        {
            InitializeComponent();
            controllerObj = new Controller();

            userno = usernum;

            MyTickDGV.DataSource = controllerObj.ViewTicketsinformation(userno);
            MyTickDGV.Refresh();
            MyTickDGV.ReadOnly = true;
            MyTickDGV.AllowUserToAddRows = false;
            MyTickDGV.AllowUserToDeleteRows = false;

            CancelTickCB.DataSource = controllerObj.ViewTicketsCB(userno);
            CancelTickCB.DisplayMember = "ticket_no";
            CancelTickCB.ValueMember = "ticket_no";


        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
    
        }

        private void MyTickets_Load(object sender, EventArgs e)
        {
            
        }
       

        private void button1_Click(object sender, EventArgs e) // Cancelling 
        {
            User1 ad = new User1(userno);
            ad.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User1 ad = new User1(userno);
            ad.Show();
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            int ticketno = (int)CancelTickCB.SelectedValue;

            int passengerno = controllerObj.passengerno(userno);

            int p1 = controllerObj.DeleteTicket(ticketno);

            int p2 = controllerObj.DeletePassenger(passengerno);
           if (p1 !=0 && p2 != 0)
            {
                MessageBox.Show("Ticket has been canceled successfully!");
                MyTickDGV.DataSource = controllerObj.ViewTicketsinformation(userno);
                MyTickDGV.Refresh();
                MyTickDGV.ReadOnly = true;
                MyTickDGV.AllowUserToAddRows = false;
                MyTickDGV.AllowUserToDeleteRows = false;

                CancelTickCB.DataSource = controllerObj.ViewTicketsCB(userno);
                CancelTickCB.DisplayMember = "ticket_no";
                CancelTickCB.ValueMember = "ticket_no";
            }
           else
                MessageBox.Show("Error while Ticket Cancelation!");


        }
    }
}
