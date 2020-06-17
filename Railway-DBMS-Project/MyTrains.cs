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
    public partial class MyTrains : Form
    {
        private Controller controllerObj;
        int empno;
        public MyTrains(int empid)
        {
            InitializeComponent();
            empno = empid;
            controllerObj = new Controller();

            SelTrainDGV.DataSource = controllerObj.SelectMyTrain(empno);
            SelTrainDGV.Refresh();
            SelTrainDGV.ReadOnly = true;
            SelTrainDGV.AllowUserToAddRows = false;
            SelTrainDGV.AllowUserToDeleteRows = false;

        }

        private void MyTrains_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            View_Trains ad = new View_Trains(empno);
            ad.Show();
            this.Close();
        }
    }
}
