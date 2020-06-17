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
    public partial class StatisticsReport : Form
    {
        private Controller controllerObj;
        public StatisticsReport()
        {
            InitializeComponent();
            controllerObj = new Controller();
            textBox3.Text = controllerObj.GetCapacity().ToString();
            textBox3.ReadOnly = true;
            textBox8.Text = controllerObj.GetNumberOfTicket().ToString();
            textBox8.ReadOnly = true;
            int max;
            


        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void StatisticsReport_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.Show();
            this.Close();
        }
    }
}
