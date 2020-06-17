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
using System.Configuration;

namespace RailWay
{
    public partial class User : Form
    {
        private Controller controllerObj;
        int userno;
        int TrackVal;
        public User(int id)
        {
            InitializeComponent();
            controllerObj = new Controller();
            userno = id;


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

        }

        public User()
        {
            InitializeComponent();
            controllerObj = new Controller();

            TrackCB.DisplayMember = "track_name";
            TrackCB.ValueMember = "track_num";
            TrackCB.DataSource = controllerObj.ViewTracks();

        }
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int price = 0;
            if((textBox1.Text != "VIP" && textBox1.Text != "Normal") ||  Date.Text == "yyyy-mm-dd" || 
                (int) FromStCB.SelectedValue == 0 || (int)ToStCB.SelectedValue == 0)
            {
                MessageBox.Show("Invalid Data! Fill all fields with Correct Data!");
            }
            else
            {
                if (textBox1.Text == "VIP" && TrackVal ==1)
                {
                    price = 100;
                }

                if (textBox1.Text == "Normal" && TrackVal == 1)
                {
                    price = 50;
                }

                if (textBox1.Text == "VIP" && TrackVal == 2)
                {
                    price = 120;
                }

                if (textBox1.Text == "Normal" && TrackVal == 2)
                {
                    price = 60;
                }

                if (textBox1.Text == "VIP" && TrackVal == 3)
                {
                    price = 140;
                }

                if (textBox1.Text == "Normal" && TrackVal == 3)
                {
                    price = 70;
                }

                if (textBox1.Text == "VIP" && TrackVal == 4)
                {
                    price = 180;
                }

                if (textBox1.Text == "Normal" && TrackVal == 4)
                {
                    price = 90;
                }


                int ticketID = controllerObj.MaxTicketID() +1;
                int passID = controllerObj.MaxPasstID() +1;


                SelectTime v = new SelectTime(ticketID, price, textBox1.Text, Date.Text, userno, passID, 
                    (int)FromStCB.SelectedValue, (int)ToStCB.SelectedValue, (int)TrackCB.SelectedValue);
                v.Show();
                this.Hide();

            }


            
        }

        private void User_Load(object sender, EventArgs e)
        {



        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TrackCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FromStCB.DisplayMember = "station_name";
            FromStCB.ValueMember = "station_num";
            FromStCB.DataSource = controllerObj.StationToTrack(TrackVal);
            TrackVal = (int)TrackCB.SelectedValue;


            ToStCB.DisplayMember = "station_name";
            ToStCB.ValueMember = "station_num";
            ToStCB.DataSource = controllerObj.StationToTrack(TrackVal);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            User1 ad = new User1(userno);
            ad.Show();
            this.Close();
        }
    }
}
