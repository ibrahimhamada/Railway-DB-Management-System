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
    public partial class Tickets_For_Other_Passengers : Form
    {
        private Controller controllerObj;
        int userno;

        public Tickets_For_Other_Passengers(int id)
        {
            InitializeComponent();
            controllerObj = new Controller();
            userno = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User1 ad = new User1(userno);
            ad.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Other_Passengers_Info ad = new Other_Passengers_Info(userno, (int)quantity.Value);
            ad.Show();
            this.Close();
        }

        private void Tickets_For_Other_Passengers_Load(object sender, EventArgs e)
        {

        }
    }
}
