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
using Final.Tools;

namespace Final
{
    public partial class frmRepairRoomAsset : Form
    {
        public frmRepairRoomAsset()
        {
            InitializeComponent();
        }
        public long UserID;
        public long RoomAssetID;
        private void frmRepairRoomAsset_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result;
                result = MessageBoxTool.msgq("آیا از این درخواست مطمئن هستید ؟");
                if (result == DialogResult.Yes)
                {
                    string serial = Repair.SetRepair(RoomAssetID, (cmbStatus.Text == "سالم") ? 0 : 1, txtDiscription.Text, UserID);
                    MessageBoxTool.msgr($"{serial} ثبت با موفقیت انجام شد و شماره پیگیری شما");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBoxTool.msger(ex.Message);
            }
        }
    }
}
