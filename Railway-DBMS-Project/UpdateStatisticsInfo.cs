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
    public partial class UpdateStatisticsInfo : Form
    {
        private Controller controllerObj;
        private int year, FMonth, TMonth, emp_id;

        public UpdateStatisticsInfo(int yr, int FMon, int TMon, int id)
        {
            InitializeComponent();
            controllerObj = new Controller();
            year = yr;
            FMonth = FMon;
            TMonth = TMon;
            emp_id = id;

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

        private void Button2_Click(object sender, EventArgs e)
        {
            Statistics stat = new Statistics(emp_id);
            stat.Show();
            this.Hide();
        }

        private void SSComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateStatisticsInfo_Load(object sender, EventArgs e)
        {

        }

        private void showinfo_Click(object sender, EventArgs e)
        {
            if (FMonth >= TMonth)
            {
                MessageBox.Show("Please choose a valid date");
            }
            else
            {
                most_start_station.Text = controllerObj.Viewmost_start_station(year,
                    FMonth, TMonth).ToString();

                most_end_station.Text = controllerObj.Viewmost_end_station(year,
                    FMonth, TMonth).ToString();

                most_month.Text = controllerObj.Viewmost_month(year,
                    FMonth, TMonth).ToString();

                most_sex.Text = controllerObj.Viewmost_sex(year,
                    FMonth, TMonth).ToString();

                most_departure.Text = controllerObj.Viewmost_trip(year,
                  FMonth, TMonth).ToString();

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        private void Button1_Click(object sender, EventArgs e)
        {
            string g;
            if (Gender.SelectedIndex == 0)
                g = "M";
            else
                g = "F";
            int a = controllerObj.UpdateStat1(year, FMonth, TMonth, (int)startstat.SelectedValue, (int)endstat.SelectedValue,
                      g, (int)numericUpDown1.Value, (int)triptime.SelectedValue, emp_id);
            if (a == 0)
            {
                MessageBox.Show("Error Invalid Data!");
            }
            else
                MessageBox.Show("Statistic has been Updated Successfully!");
            startstat.Refresh();
            endstat.Refresh();
            triptime.Refresh();
            Gender.Refresh();
        
        }

    }
}
