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
using Microsoft.VisualBasic.ApplicationServices;

namespace Final
{
    public partial class frmSetRoomAssets : Form
    {
        public frmSetRoomAssets()
        {
            InitializeComponent();
        }
        public long UserID;
        public long RoomAssetID = -1;
        private void btnSetRoomAssets_Load(object sender, EventArgs e)
        {
            if (RoomAssetID != -1)
            {
                btnSave.Text = "ویرایش";
                frmSetRoomAssets frm = new frmSetRoomAssets();
                frm.Text = "صفحه ویرایش";
                RoomAsset ra = RoomAsset.FindRoomAssetById(RoomAssetID);
                lblAssetNumber.Text = ra.AssetNumber.ToString();
                switch (ra.PartNumber)
                {
                    case 1:
                        cmbPartNumber.SelectedIndex = 0;
                        break;
                    case 2:
                        cmbPartNumber.SelectedIndex = 1;
                        break;
                    case 3:
                        cmbPartNumber.SelectedIndex = 2;
                        break;
                    case 4:
                        cmbPartNumber.SelectedIndex = 3;
                        break;
                    case 5:
                        cmbPartNumber.SelectedIndex = 4;
                        break;
                }
                switch (ra.Status)
                {
                    case 0:
                        cmbStatus.SelectedIndex = 0;
                        break;
                    case 1:
                        cmbStatus.SelectedIndex = 1;
                        break;
                    case 2:
                        cmbStatus.SelectedIndex = 2;
                        break;
                }
            }
            else
            {
                lblAssetNumber.Text = TimeSerial();
            }
        }
        public string TimeSerial()
        {
            DateTime now = DateTime.Now;
            return $"{now:yyyyMMddHHmm}";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool Istrue = (cmbPartNumber.Text != null && cmbStatus.Text != null);
            if (RoomAssetID == -1)
            {
                if (Istrue == true)
                {
                    RoomAsset.SetRoomAsset(cmbPartNumber.SelectedIndex + 1, long.Parse(lblAssetNumber.Text) , cmbStatus.SelectedIndex , UserID);
                    MessageBoxTool.msgr("وسیله با موفقیت ثبت شد");
                    Close();
                }
            }
            else
            {
                if (Istrue == true)
                {
                    DialogResult result;
                    result = MessageBoxTool.msgq("آیا از ویرایش مطمئن هستید؟");
                    if (result == DialogResult.Yes)
                    {
                        RoomAsset.EditRoomAsset(RoomAssetID , cmbPartNumber.SelectedIndex + 1, long.Parse(lblAssetNumber.Text), cmbStatus.SelectedIndex, UserID);
                        MessageBoxTool.msgr("وسیله با موفقیت ویرایش شد");
                        Close();
                    }
                }
            }
        }
    }
}
