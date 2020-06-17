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
    public partial class Trains : Form
    {
        private Controller controllerObj;
        private int emp_id;
        public Trains()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.ViewTrains();
            dataGridView1.DataSource = dt;
            comboBox1.DisplayMember = "train_no";
            comboBox1.ValueMember = "train_no";
            comboBox1.DataSource = controllerObj.TrainsNumber();
        }

      

        private void Button1_Click(object sender, EventArgs e)
        {
            AddNewTrain train = new AddNewTrain();
            train.Show();
            this.Hide();


        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            UpdateTrainInfo UpdateTrain = new UpdateTrainInfo((int)comboBox1.SelectedValue);
            UpdateTrain.Show();
            this.Hide();
        }

        private void Trains_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int val = controllerObj.DeleteTrain((int)comboBox1.SelectedValue);
            if (val > 0) MessageBox.Show("train deleted Succefully");
            else MessageBox.Show("delete failed");
            dataGridView1.DataSource = controllerObj.ViewTrains();
            dataGridView1.Refresh();
            comboBox1.DisplayMember = "train_no";
            comboBox1.ValueMember = "train_no";
            comboBox1.DataSource = controllerObj.TrainsNumber();
            comboBox1.Refresh();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Admin adm = new Admin();
            adm.Show();
            this.Hide();
        }
    }
}
