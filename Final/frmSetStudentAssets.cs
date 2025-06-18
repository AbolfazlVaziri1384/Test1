using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class frmSetStudentAssets : Form
    {
        public frmSetStudentAssets()
        {
            InitializeComponent();
        }
        public long UserID;
        public long RoomAssetID = -1;
        private void frmSetStudentAssets_Load(object sender, EventArgs e)
        {

        }
    }
}
