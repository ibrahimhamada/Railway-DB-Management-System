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
    public partial class View_Trains : Form
    {
        private Controller controllerObj;
        int empno,  TrackVal;

        private void back_Click(object sender, EventArgs e)
        {
            Employees2 ad = new Employees2(empno);
            ad.Show();
            this.Close();
        }

        public View_Trains(int empid)
        {
            InitializeComponent();
            empno = empid;
            controllerObj = new Controller();


            bool a = controllerObj.IsDriver(empno);

            if (a == true)
            {
                viewmytrains.Enabled = true;
            }
            else
            {
                viewmytrains.Enabled = false;
            }

            TrackCB.DisplayMember = "track_name";
            TrackCB.ValueMember = "track_num";
            TrackCB.DataSource = controllerObj.ViewTracks();

            TrackVal = (int)TrackCB.SelectedValue;


            SelTrainDGV.DataSource = controllerObj.SelectTrainDGV(TrackVal);
            SelTrainDGV.Refresh();
            SelTrainDGV.ReadOnly = true;
            SelTrainDGV.AllowUserToAddRows = false;
            SelTrainDGV.AllowUserToDeleteRows = false;

        }

        private void TrackCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelTrainDGV.DataSource = controllerObj.SelectTrainDGV((int)TrackCB.SelectedValue);
            SelTrainDGV.Refresh();
            SelTrainDGV.ReadOnly = true;
            SelTrainDGV.AllowUserToAddRows = false;
            SelTrainDGV.AllowUserToDeleteRows = false;
        }

        private void viewmytrains_Click(object sender, EventArgs e)
        {
            MyTrains ad = new MyTrains(empno);
            ad.Show();
            this.Close();
        }

        private void View_Trains_Load(object sender, EventArgs e)
        {

        }
    }
}
