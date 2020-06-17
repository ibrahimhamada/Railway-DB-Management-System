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
    public partial class InsertToBelongs : Form
    {
        private Controller controllerObj;
        private int order, TrackNum, count;
        
        public InsertToBelongs(int Track, int counter)
        {
            InitializeComponent();
            controllerObj = new Controller();
            order = counter;
            count = counter;
            label1.Text = "Station Order (" + order.ToString() + ")";
            TrackNum = Track;
            comboBox1.ValueMember = "station_num";
            comboBox1.DisplayMember = "station_name";
            comboBox1.DataSource = controllerObj.StationInfo();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int val = controllerObj.InsertToBelongs(TrackNum, order, (int)comboBox1.SelectedValue);
            if (val > 0)
            {
                if (count == 1)
                {
                    Tracks t = new Tracks();
                    t.Show();
                    this.Close();
                }
                else
                {
                    count = count - 1;
                    InsertToBelongs ins = new InsertToBelongs(TrackNum, count);
                    ins.Show();
                    this.Close();
                }
                
            }
            else
            {
                MessageBox.Show("Cannot add the station");
                InsertToBelongs ins = new InsertToBelongs(TrackNum, count);
                ins.Show();
                this.Close();
            }
        }

        private void InsertToBelongs_Load(object sender, EventArgs e)
        {

        }
    }
}
