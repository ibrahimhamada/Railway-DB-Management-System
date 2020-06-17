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
    public partial class Statistics : Form
    {
        private Controller controllerObj;
        private int emp_id;
        public Statistics(int id)
        {
            emp_id = id;
            InitializeComponent();
            controllerObj = new Controller();
            YearComboBox.DisplayMember = "stat_year";
            YearComboBox.ValueMember = "stat_year";
            YearComboBox.DataSource = controllerObj.DisStatYears();

            YearComboBox.Update();

            if(!(controllerObj.checkSuperid(emp_id)))
            {
                EditButton7.Enabled = false;
                DeleteButton.Enabled = false;
                insert.Enabled = false;
            }

            DataTable dt = controllerObj.DisStatFMonths((int)YearComboBox.SelectedValue);
            FromComboBox.DisplayMember = "from_month";
            FromComboBox.ValueMember = "from_month";
            FromComboBox.DataSource = dt;
            FromComboBox.Update();
            
            ToComboBox.DisplayMember = "till_month";
            ToComboBox.ValueMember = "till_month";
            ToComboBox.DataSource = controllerObj.DisStatTMonths((int)YearComboBox.SelectedValue);

            ToComboBox.Update();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if ((int)FromComboBox.SelectedValue >= (int)ToComboBox.SelectedValue)
            {
                MessageBox.Show("Please choose a valid date");
            }
            else
            {
                UpdateStatisticsInfo S = new UpdateStatisticsInfo((int)YearComboBox.SelectedValue, (int)FromComboBox.SelectedValue, (int)ToComboBox.SelectedValue, emp_id);
                S.Show();
                this.Hide();
            }
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            if((int)FromComboBox.SelectedValue >= (int)ToComboBox.SelectedValue)
            {
                MessageBox.Show("Please choose a valid date");
            }
            else
            {
                most_start_station.Text = controllerObj.Viewmost_start_station((int)YearComboBox.SelectedValue,
                    (int)FromComboBox.SelectedValue, (int)ToComboBox.SelectedValue).ToString();

                most_end_station.Text = controllerObj.Viewmost_end_station((int)YearComboBox.SelectedValue,
                    (int)FromComboBox.SelectedValue, (int)ToComboBox.SelectedValue).ToString();

                most_month.Text = controllerObj.Viewmost_month((int)YearComboBox.SelectedValue,
                    (int)FromComboBox.SelectedValue, (int)ToComboBox.SelectedValue).ToString();

                most_sex.Text = controllerObj.Viewmost_sex((int)YearComboBox.SelectedValue,
                    (int)FromComboBox.SelectedValue, (int)ToComboBox.SelectedValue).ToString();
                
                most_departure.Text = controllerObj.Viewmost_trip((int)YearComboBox.SelectedValue,
                  (int)FromComboBox.SelectedValue, (int)ToComboBox.SelectedValue).ToString();
                
            }




        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if ((int)FromComboBox.SelectedValue >= (int)ToComboBox.SelectedValue)
            {
                MessageBox.Show("Please choose a valid date");
            }
            else
            {
                controllerObj.DeleteStat((int)YearComboBox.SelectedValue,
                   (int)FromComboBox.SelectedValue, (int)ToComboBox.SelectedValue);
                
                MessageBox.Show("Selected Statistic has been deleted successfully!");

                YearComboBox.DataSource = controllerObj.DisStatYears();
                YearComboBox.DisplayMember = "stat_year";
                YearComboBox.ValueMember = "stat_year";
                YearComboBox.Update();


                FromComboBox.Update();
                ToComboBox.Update();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Employees2 ad = new Employees2(emp_id);
            ad.Show();
            this.Hide();
        }

        private void YearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DataTable dt = controllerObj.DisStatFMonths((int)YearComboBox.SelectedValue);
            FromComboBox.DisplayMember = "from_month";
            FromComboBox.ValueMember = "from_month";
            FromComboBox.DataSource = dt;

            FromComboBox.Update();
            ToComboBox.DisplayMember = "till_month";
            ToComboBox.ValueMember = "till_month";
            ToComboBox.DataSource = controllerObj.DisStatTMonths((int)YearComboBox.SelectedValue);

            ToComboBox.Update();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {

        }

        private void most_start_station1_Click(object sender, EventArgs e)
        {

        }

        private void most_end_station_TextChanged(object sender, EventArgs e)
        {

        }

        private void FromComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void most_trip_TextChanged(object sender, EventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {
            InsertStatistics istat = new InsertStatistics(emp_id);
            istat.Show();
            this.Hide();
        }
    }
}
