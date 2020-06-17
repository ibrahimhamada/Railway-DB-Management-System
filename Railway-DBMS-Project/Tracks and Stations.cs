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
    public partial class Tracks_and_Stations : Form
    { 
        private Controller controllerObj;
        int userno;
        int TrackVal;
        public Tracks_and_Stations(int id)
        {
            controllerObj = new Controller();
            InitializeComponent();
            userno = id;
            comboBox1.DisplayMember = "track_name";
            comboBox1.ValueMember = "track_num";
            comboBox1.DataSource = controllerObj.ViewTracks();

            TrackVal = (int)comboBox1.SelectedValue;

            dataGridView1.DataSource = controllerObj.StationToTrack(TrackVal);
            dataGridView1.Refresh();
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            

        }



        private void Tracks_and_Stations_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TrackVal = (int)comboBox1.SelectedValue;
            dataGridView1.DataSource = controllerObj.StationToTrack(TrackVal);
            dataGridView1.Refresh();
            dataGridView1.ReadOnly = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (userno < 111111)
            {
                User1 ad = new User1(userno);
                ad.Show();
                this.Close();
            }
            else
            {
                Employees2 ad = new Employees2(userno);
                ad.Show();
                this.Close();
            }
        }
    }
}
