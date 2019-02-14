using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Autonomous : Form
    {
        public Autonomous()
        {
            InitializeComponent();
        }

        private void BtnNextScreenAutonomous_Click(object sender, EventArgs e)
        {
            DriverControlled form3 = new DriverControlled();
            this.Close();
            form3.Show();
        }
    }
}
