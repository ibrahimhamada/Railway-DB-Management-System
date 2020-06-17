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
    public partial class InsertStatistics : Form
    {
        private Controller controllerObj;
        private int emp_id;
        public InsertStatistics(int id)
        {
            emp_id = id;
            InitializeComponent();
            controllerObj = new Controller();

            startstat.DisplayMember = "station_name";
            startstat.ValueMember = "station_num";
            startstat.DataSource = controllerObj.StationNames();
            startstat.Update();
            endstat.DisplayMember = "station_name";
            endstat.ValueMember = "station_num";
            endstat.DataSource = controllerObj.StationNames();
            endstat.Update();

            triptime.DisplayMember = "departue_time";
            triptime.ValueMember = "duration_id";
            triptime.DataSource = controllerObj.Trips();
            endstat.Update();

        }

        private void InsertStatistics_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Statistics stat = new Statistics(emp_id);
            stat.Show();
            this.Hide();

        }

        private void insert_Click(object sender, EventArgs e)
        {
            string g;
            if (Gender.SelectedIndex == 0)
                g = "M";
            else
                g = "F";
            int a =
                controllerObj.InsertStat((int)year.Value, (int)frommonth.Value, (int)tomonth.Value,
                (int)startstat.SelectedValue, (int)endstat.SelectedValue,
           g, (int)popmonth.Value, (int)triptime.SelectedValue, emp_id);


            if (a == 0)
            {
                MessageBox.Show("Error Invalid Data!");
            }
            else
                MessageBox.Show("Statistic has been Added Successfully!");
            startstat.Refresh();
            endstat.Refresh();
            triptime.Refresh();
            Gender.Refresh();

        }

    }
    
}
