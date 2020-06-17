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
    public partial class UpdateTrainInfo : Form
    {
        private Controller controllerObj;
        private int Tno;
        public UpdateTrainInfo(int Tnum)
        {
            InitializeComponent();
            controllerObj = new Controller();
            Tno = Tnum;
            comboBox3.DisplayMember = "employee_name";
            comboBox3.ValueMember = "employee_id";
            comboBox3.DataSource = controllerObj.DriverIDs();
            comboBox2.DisplayMember = "duration_id";
            comboBox2.ValueMember = "duration_id";
            comboBox2.DataSource = controllerObj.TripsInfo();
            comboBox1.DisplayMember = "track_name";
            comboBox1.ValueMember = "track_num";
            comboBox1.DataSource = controllerObj.TracksInfo();
        }

        private void UpdateTrainInfo_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int val = controllerObj.UpdateTrains(Tno, (int)numericUpDown2.Value, 
                comboBox4.SelectedIndex + 1980, (int)comboBox2.SelectedValue, 
                (int)comboBox3.SelectedValue,(int)comboBox1.SelectedValue);
            if (val > 0) MessageBox.Show("Updated succefully");
            else MessageBox.Show("Update failed");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Trains t = new Trains();
            t.Show();
            this.Hide();
        }
    }
}
