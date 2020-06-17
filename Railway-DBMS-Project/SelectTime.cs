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
    public partial class SelectTime : Form
    {

        private Controller controllerObj;
        private int FromCB, ToCB;

        private int ticket_no, t_price, trip_number, user_no, pass_no, from_station, to_station, track_no;

        private void SelectTime_Load(object sender, EventArgs e)
        {

        }

        private string ticket_type, resrve_date;


        public SelectTime(int ticketnum, int tprice, string tickettype, string date, int usernum, int passnum, int FromSCB,
            int ToSCB, int tracknum)
        {
            InitializeComponent();
            controllerObj = new Controller();
            FromCB = FromSCB;
            ToCB = ToSCB;

            ticket_no = ticketnum; t_price = tprice; ticket_type = tickettype; resrve_date = date; user_no = usernum;
            pass_no = passnum; from_station = FromSCB; to_station = ToSCB; track_no = tracknum;


            SelTimeDGV.DataSource = controllerObj.SelectTimeDGV(track_no);
            SelTimeDGV.Refresh();
            SelTimeDGV.ReadOnly = true;
            SelTimeDGV.AllowUserToAddRows = false;
            SelTimeDGV.AllowUserToDeleteRows = false;

            SelTimeCB.DataSource = controllerObj.SelectTimeDGV(track_no);
            SelTimeCB.DisplayMember = "departue_time";
            SelTimeCB.ValueMember = "duration_id";

        }


        private void SelTimeCB_SelectedIndexChanged(object sender, EventArgs e)
        {


        }


        private void Label1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {


            int p2 = controllerObj.InsertNewPassenger(pass_no, user_no);


            int p1 = controllerObj.InsertTicketfromUser(ticket_no, t_price, ticket_type, resrve_date, (int)SelTimeCB.SelectedValue,
            user_no, pass_no, from_station, to_station, track_no);

            if (p1 == -1 || p2 == -1)
            {
                MessageBox.Show("Error! Invalid Data!");

            }
            else
            {
                MessageBox.Show("Reservation done Successfully!");
                User1 ad = new User1(user_no);
                ad.Show();
                this.Close();

            }




        }


        private void button1_Click(object sender, EventArgs e)
        {
      
            User Log = new User(user_no);
            Log.Show();
            this.Close();
        }
    }
}