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
    public partial class Tracks : Form
    {
        private Controller controllerObj;
        public Tracks()
        {
            InitializeComponent();
            controllerObj = new Controller();
            dataGridView1.DataSource = controllerObj.ViewTracksInfo();
            dataGridView1.Refresh();
            dataGridView1.ReadOnly = true;
        }

        private void Tracks_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controllerObj.ViewStationInfo((int)numericUpDown1.Value);
            dataGridView1.Refresh();
            dataGridView1.ReadOnly = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
    

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.Show();
            this.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
           int val = controllerObj.DeleteTrack((int)numericUpDown1.Value);
            controllerObj.DeleteFromBelongs((int)numericUpDown1.Value);
            if (val > 0) MessageBox.Show("Deleted succefully");
            else MessageBox.Show("Delete failed");
            dataGridView1.DataSource = controllerObj.ViewTracksInfo();
            dataGridView1.Refresh();
            dataGridView1.ReadOnly = true;

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            InsertNewTrack insert = new InsertNewTrack();
            insert.Show();
            this.Hide();
        }
    }
}
