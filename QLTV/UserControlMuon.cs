using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class UserControlMuon : UserControl
    {
        public UserControlMuon()
        {
            InitializeComponent();
        }

        //private void btnThem_Click(object sender, EventArgs e)
        //{

        //}

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            FormPhieuMuon f = new FormPhieuMuon();
            f.ShowDialog();
        }
    }
}
