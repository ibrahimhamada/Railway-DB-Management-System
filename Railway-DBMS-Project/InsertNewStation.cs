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
    public partial class InsertNewStation : Form
    {
        private Controller controllerObj;
        public InsertNewStation()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int val = controllerObj.InsertNewStation((int)numericUpDown1.Value,
                textBox1.Text);
            if (val > 0) MessageBox.Show("Succeeded");
            else MessageBox.Show("Failed!");

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Stations st = new Stations();
            st.Show();
            this.Close();
        }

        private void InsertNewStation_Load(object sender, EventArgs e)
        {

        }
    }
}
