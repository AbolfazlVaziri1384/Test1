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
    public partial class frmTransferRoomAssetHistory : Form
    {
        public frmTransferRoomAssetHistory()
        {
            InitializeComponent();
        }
        public long UserID;
        public long RoomAssetID;
        private void frmTransferRoomAssetHistory_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // ثبت isused فراموش نشود
            //در هنگام ادیت کردن باید حواست پر کردن sustiyude باشه
        }
    }
}
