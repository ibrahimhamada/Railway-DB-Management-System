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
    public partial class InsertNewTrack : Form
    {
        private Controller controllerObj;
        public InsertNewTrack()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int val = controllerObj.InsertNewTrack((int)numericUpDown1.Value,
                textBox1.Text);
            if (val > 0)
            {
                    InsertToBelongs insert = new InsertToBelongs((int)numericUpDown1.Value,(int)numericUpDown2.Value);
                    insert.Show();
                this.Close();
            }
            else MessageBox.Show("failed!");
           
        }
    }
}
