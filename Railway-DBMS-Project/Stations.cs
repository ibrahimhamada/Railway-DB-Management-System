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
    public partial class Stations : Form
    {
        private Controller controllerObj;
        public Stations()
        {
            InitializeComponent();
            controllerObj = new Controller();
            dataGridView1.DataSource = controllerObj.StationInfo();
            comboBox1.DisplayMember = "station_name";
            comboBox1.ValueMember = "station_num";
            comboBox1.DataSource = controllerObj.StationInfo();
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
                        textBox1.Clear();

        }

        private void Stations_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.Show();
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int val = controllerObj.DeleteStation((int)comboBox1.SelectedValue);
            if (val > 0) MessageBox.Show("Deleted succefully");
            else MessageBox.Show("failed!");
            dataGridView1.DataSource = controllerObj.StationInfo();
            comboBox1.DisplayMember = "station_name";
            comboBox1.ValueMember = "station_num";
            comboBox1.DataSource = controllerObj.StationInfo();
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            textBox1.Visible = true;
            button5.Visible = true;
            
            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            InsertNewStation ins = new InsertNewStation();
            ins.Show();
            this.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            int val = controllerObj.UpdateStation((int)comboBox1.SelectedValue
                , textBox1.Text);
            if (val > 0) MessageBox.Show("Successfully Updated!");
            else MessageBox.Show("Failed!");
            label2.Visible = false;
            textBox1.Visible = false;
            button5.Visible = false;
            dataGridView1.DataSource = controllerObj.StationInfo();
            comboBox1.DisplayMember = "station_name";
            comboBox1.ValueMember = "station_num";
            comboBox1.DataSource = controllerObj.StationInfo();
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            textBox1.Clear();
        }
    }
}
