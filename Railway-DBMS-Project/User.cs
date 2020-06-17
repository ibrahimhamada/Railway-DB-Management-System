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
    public partial class User1 : Form
    {
        private Controller controllerObj;
        int userno;
        int TrackVal;
        public User1(int id)
        {
            InitializeComponent();
            controllerObj = new Controller();
            userno = id;

        }



        private void logout_Click(object sender, EventArgs e)
        {
            Login Log = new Login();
            Log.Show();
            this.Close();
        }

        private void User1_Load(object sender, EventArgs e)
        {

        }

        private void viewmytickets_Click(object sender, EventArgs e)
        {
            Tracks_and_Stations Log = new Tracks_and_Stations(userno);
            Log.Show();
            this.Close();
        }

        private void bookmyself_Click(object sender, EventArgs e)
        {
            User Log = new User(userno);
            Log.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tickets_For_Other_Passengers Log = new Tickets_For_Other_Passengers(userno);
            Log.Show();
            this.Close();
        }

        private void tracksandstations_Click(object sender, EventArgs e)
        {
            MyTickets Log = new MyTickets(userno);
            Log.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserEditPassword Log = new UserEditPassword(userno);
            Log.Show();
            this.Close();
        }
    }
}
