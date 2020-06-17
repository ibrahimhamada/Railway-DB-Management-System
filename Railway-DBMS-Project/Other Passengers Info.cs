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
    public partial class Other_Passengers_Info : Form
    {
        private Controller controllerObj;
        int userno, counter, TrackVal;
        int ticket_no, t_price, trip_number, user_no, pass_no, from_station, to_station, track_no;

        private void agebox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void sexbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FromStCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelTimeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ToStCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Date_TextChanged(object sender, EventArgs e)
        {

        }

        private void nametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        string ticket_type, resrve_date, p_sex;

        private void SelTimeCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public Other_Passengers_Info(int id, int n)
        {
            InitializeComponent();
            controllerObj = new Controller();
            userno = id;
            counter = n;

            counter--;
            if (counter == 0)
            {
                finish.Enabled = true;
                next.Enabled = false;
            }
            else
            {
                finish.Enabled = false;
            }
            TrackCB.DisplayMember = "track_name";
            TrackCB.ValueMember = "track_num";
            TrackCB.DataSource = controllerObj.ViewTracks();

            TrackVal = (int)TrackCB.SelectedValue;

            FromStCB.DisplayMember = "station_name";
            FromStCB.ValueMember = "station_num";
            FromStCB.DataSource = controllerObj.StationToTrack(TrackVal);

            ToStCB.DisplayMember = "station_name";
            ToStCB.ValueMember = "station_num";
            ToStCB.DataSource = controllerObj.StationToTrack(TrackVal);

            SelTimeDGV.DataSource = controllerObj.SelectTimeDGV(TrackVal);
            SelTimeDGV.Refresh();
            SelTimeDGV.ReadOnly = true;
            SelTimeDGV.AllowUserToAddRows = false;
            SelTimeDGV.AllowUserToDeleteRows = false;

            SelTimeCB.DisplayMember = "departue_time";
            SelTimeCB.ValueMember = "duration_id";
            SelTimeCB.DataSource = controllerObj.SelectTimeDGV(TrackVal);

        }

        private void TrackCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FromStCB.DisplayMember = "station_name";
            FromStCB.ValueMember = "station_num";
            FromStCB.DataSource = controllerObj.StationToTrack((int)TrackCB.SelectedValue);

            ToStCB.DisplayMember = "station_name";
            ToStCB.ValueMember = "station_num";
            ToStCB.DataSource = controllerObj.StationToTrack((int)TrackCB.SelectedValue);

            SelTimeDGV.DataSource = controllerObj.SelectTimeDGV((int)TrackCB.SelectedValue);
            SelTimeDGV.Refresh();
            SelTimeDGV.ReadOnly = true;
            SelTimeDGV.AllowUserToAddRows = false;
            SelTimeDGV.AllowUserToDeleteRows = false;

            SelTimeCB.DisplayMember = "departue_time";
            SelTimeCB.ValueMember = "duration_id";
            SelTimeCB.DataSource = controllerObj.SelectTimeDGV((int)TrackCB.SelectedValue);

        }

        private void finish_Click(object sender, EventArgs e)
        {
            int price = 0;
            if ((textBox1.Text != "VIP" && textBox1.Text != "Normal") || Date.Text == "yyyy-mm-dd" ||
                (int)FromStCB.SelectedValue == 0 || (int)ToStCB.SelectedValue == 0)
            {
                MessageBox.Show("Invalid Data! Fill all fields with Correct Data!");
            }
            else
            {
                if (textBox1.Text == "VIP" && TrackVal == 1) price = 100;
                if (textBox1.Text == "Normal" && TrackVal == 1) price = 50;
                if (textBox1.Text == "VIP" && TrackVal == 2) price = 120;
                if (textBox1.Text == "Normal" && TrackVal == 2) price = 60;
                if (textBox1.Text == "VIP" && TrackVal == 3) price = 140;
                if (textBox1.Text == "Normal" && TrackVal == 3) price = 70;
                if (textBox1.Text == "VIP" && TrackVal == 4) price = 180;
                if (textBox1.Text == "Normal" && TrackVal == 4) price = 90;

                ticket_no = controllerObj.MaxTicketID() + 1;
                pass_no = controllerObj.MaxPasstID() + 1;

                t_price = price;
                if (sexbox.SelectedIndex == 0)
                {
                    p_sex = "M";
                }
                else
                {
                    p_sex = "F";
                }

                ticket_type = textBox1.Text;
                resrve_date = Date.Text;
                from_station = (int)FromStCB.SelectedValue;
                to_station = (int)ToStCB.SelectedValue;
                track_no = (int)TrackCB.SelectedValue;
                user_no = userno;
                int p2 = controllerObj.InsertPassenger(pass_no, nametextbox.Text, (int)agebox.Value, p_sex, user_no);

                int p1 = controllerObj.InsertTicketfromUser(ticket_no, t_price, ticket_type, resrve_date, (int)SelTimeCB.SelectedValue,
                user_no, pass_no, from_station, to_station, track_no);

                if (p1 == 0 || p2 == 0)
                {
                    MessageBox.Show("Error! Invalid Data!");

                }
                else
                {
                    MessageBox.Show("Reservation done Successfully!");

                }

                User1 ad = new User1(userno);
                ad.Show();
                this.Close();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Tickets_For_Other_Passengers ad = new Tickets_For_Other_Passengers(userno);
            ad.Show();
            this.Close();
        }

        private void next_Click(object sender, EventArgs e)
        {
            int price = 0;
            if ((textBox1.Text != "VIP" && textBox1.Text != "Normal") || Date.Text == "yyyy-mm-dd" ||
                (int)FromStCB.SelectedValue == 0 || (int)ToStCB.SelectedValue == 0)
            {
                MessageBox.Show("Invalid Data! Fill all fields with Correct Data!");
            }
            else
            {
                if (textBox1.Text == "VIP" && TrackVal == 1) price = 100;
                if (textBox1.Text == "Normal" && TrackVal == 1) price = 50;    
                if (textBox1.Text == "VIP" && TrackVal == 2) price = 120;
                if (textBox1.Text == "Normal" && TrackVal == 2) price = 60;
                if (textBox1.Text == "VIP" && TrackVal == 3) price = 140;
                if (textBox1.Text == "Normal" && TrackVal == 3) price = 70;
                if (textBox1.Text == "VIP" && TrackVal == 4) price = 180;
                if (textBox1.Text == "Normal" && TrackVal == 4) price = 90;

                ticket_no = controllerObj.MaxTicketID() + 1;
                pass_no = controllerObj.MaxPasstID() + 1;

                t_price = price;
                if (sexbox.SelectedIndex == 0)
                {
                    p_sex = "M";
                }
                else
                {
                    p_sex = "F";
                }

                ticket_type = textBox1.Text;
                resrve_date = Date.Text;
                from_station = (int)FromStCB.SelectedValue;
                to_station = (int)ToStCB.SelectedValue;
                track_no = (int)TrackCB.SelectedValue;
                user_no = userno;
                int p2 = controllerObj.InsertPassenger(pass_no, nametextbox.Text, (int)agebox.Value, p_sex, user_no);

                int p1 = controllerObj.InsertTicketfromUser(ticket_no, t_price, ticket_type, resrve_date, (int)SelTimeCB.SelectedValue,
                user_no, pass_no, from_station, to_station, track_no);

                if (p1 == 0 || p2 == 0)
                {
                    MessageBox.Show("Error! Invalid Data!");

                }
                else
                {
                    MessageBox.Show("Reservation done Successfully!");

                }                
                Other_Passengers_Info v = new Other_Passengers_Info(userno, counter);
                v.Show();
                this.Hide();           
            }
        }

        private void Other_Passengers_Info_Load(object sender, EventArgs e)
        {

        }

    }
}
