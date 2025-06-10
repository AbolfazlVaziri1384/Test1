using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final.Models;

namespace Final
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public long UserId;
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void mnuSetUser_Click(object sender, EventArgs e)
        {
            frmSetUser frm = new frmSetUser();
            frm.UserId = UserId;
            frm.ShowDialog();
        }
    }
}
