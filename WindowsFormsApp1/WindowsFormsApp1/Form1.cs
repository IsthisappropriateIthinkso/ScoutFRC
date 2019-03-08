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
    public partial class frmRecordLog : Form
    {
        public frmRecordLog()
        {
            InitializeComponent();
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            Preload form2 = new Preload();
            form2.Show();
            this.Visible = false;
        }
    }
}
