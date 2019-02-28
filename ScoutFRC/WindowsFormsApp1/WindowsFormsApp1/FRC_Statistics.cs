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
    public partial class FRC_Statistics : Form
    {
        public FRC_Statistics()
        {
            InitializeComponent();
        }

        private void BtnNextMatch_Click(object sender, EventArgs e)
        {
            frmRecordLog form1 = new frmRecordLog();
            this.Close();
            form1.Visible=true;
        }
    }
}
