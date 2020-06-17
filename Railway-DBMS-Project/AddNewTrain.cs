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
    public partial class AddNewTrain : Form
    {
        private Controller controllerObj;
        public AddNewTrain()
        {
            InitializeComponent();
            controllerObj = new Controller();
            comboBox3.DisplayMember = "employee_name";
            comboBox3.ValueMember = "employee_id";
            comboBox3.DataSource = controllerObj.DriverIDs();          
            comboBox2.DisplayMember = "duration_id";
            comboBox2.ValueMember = "duration_id";
            comboBox2.DataSource = controllerObj.TripsInfo();
            comboBox4.DisplayMember = "track_name";
            comboBox4.ValueMember = "track_num";
            comboBox4.DataSource = controllerObj.TracksInfo();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void AddNewTrain_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
          
            int val = controllerObj.InsertNewTrain((int)numericUpDown1.Value, (int)numericUpDown2.Value
                , comboBox1.SelectedIndex + 1980, (int)comboBox2.SelectedValue, (int)comboBox3.SelectedValue, (int)comboBox4.SelectedValue);
            if (val > 0) MessageBox.Show("Insert new train Succeeded");
            else MessageBox.Show("Insertion failed");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Trains t = new Trains();
            t.Show();
            this.Hide();
        }
    }
}
