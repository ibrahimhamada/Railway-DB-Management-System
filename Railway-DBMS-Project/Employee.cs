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
    public partial class Employee : Form
    {
        private Controller controllerObj;
        int emplno;// Edit
        public Employee(int id)
        {
            InitializeComponent();
            controllerObj = new Controller();
            emplno = id;


            TrackCB.DataSource = controllerObj.ViewTracks();
            TrackCB.DisplayMember = "track_name";
            string trackname = (string)TrackCB.SelectedValue;
            int TrackVal = controllerObj.KnowStationNum(trackname);

            FromStCB.DataSource = controllerObj.StationToTrack(TrackVal);
            FromStCB.DisplayMember = "station_name";


            ToStCB.DataSource = controllerObj.StationToTrack(TrackVal);
            ToStCB.DisplayMember = "station_name";
        }

        private void Emplloyee_Load(object sender, EventArgs e)
        {

        }

        private void TrackCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FromStCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ToStCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Date_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendRequest v = new SendRequest(emplno);
            v.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string FromStVal = (string)FromStCB.SelectedValue;
            int FromStatVal = controllerObj.KnowStationNum(FromStVal);

            string ToStVal = (string)ToStCB.SelectedValue;
            int ToStatVal = controllerObj.KnowStationNum(ToStVal);

            string DateInput = Date.Text;

            string trackname = (string)TrackCB.SelectedValue;
            int TrackVal = controllerObj.KnowStationNum(trackname);

            //SelectTime v = new SelectTime(FromStatVal, ToStatVal); // Need to Edit  - (A.Lila : When you edit this please update Back button from Employee SelectTime Form)
            // v.Show();
            this.Hide();
        }
    }
}
