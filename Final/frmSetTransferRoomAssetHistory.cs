using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final.Classes;
using Final.Models;
using Final.Tools;
using Microsoft.VisualBasic.ApplicationServices;

namespace Final
{
    public partial class frmSetTransferRoomAssetHistory : Form
    {
        public frmSetTransferRoomAssetHistory()
        {
            InitializeComponent();
        }
        public long UserID;
        public long RoomAssetID;
        public long EditTransferRoomAssetID = -1;
        DormitoryDbContext db;

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOwner.Rows.Count == 0)
                {
                    return;
                }
                long id;
                id = long.Parse(dgvOwner.CurrentRow.Cells[0].Value.ToString());

                if (EditTransferRoomAssetID == -1)
                {
                    if (RoomAsset.FindRoomAssetById(RoomAssetID).PartNumber == 1)
                        TransferRoomAssetHistory.Set(RoomAssetID, true, id, UserID);
                    else
                        TransferRoomAssetHistory.Set(RoomAssetID, false, id, UserID);
                    MessageBoxTool.msgr("تخصیص با موفقیت انجام شد");
                    Close();
                }
                else
                {

                    DialogResult result;
                    result = MessageBoxTool.msgq("آیا از ویرایش مطمئن هستید؟");
                    if (result == DialogResult.Yes)
                    {
                        if (RoomAsset.FindRoomAssetById(RoomAssetID).PartNumber == 1)
                            TransferRoomAssetHistory.Edit(EditTransferRoomAssetID, true, id, UserID);
                        else
                            TransferRoomAssetHistory.Edit(EditTransferRoomAssetID, false, id, UserID);
                        MessageBoxTool.msgr("تخصیص با موفقیت ویرایش شد");
                        Close();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBoxTool.msger(ex.Message);
            }
        }

        private void frmSetTransferRoomAssetHistory_Load(object sender, EventArgs e)
        {
            if (EditTransferRoomAssetID != -1)
            {
                btnSave.Text = "ویرایش";
                frmSetTransferRoomAssetHistory frm = new frmSetTransferRoomAssetHistory();
                frm.Text = "صفحه ویرایش";
            }
            db = new DormitoryDbContext();
            if (RoomAsset.FindRoomAssetById(RoomAssetID).PartNumber == 1)
                RefreshRoomList(db.Rooms.ToList());
            else
                RefreshStudentList(db.Users.ToList());
            db.Dispose();
        }
        private void RefreshRoomList(List<Models.Room> Roomlist)
        {
            dgvOwner.Rows.Clear();
            foreach (var item in Roomlist)
            {
                // اتاق هایی که به آنها اختصاص دادیم دیگر نمایش داده نشوند

                if ((!TransferRoomAssetHistory.IsRoomInUse(item.Id)) && (item.IsDeleted == false))
                {
                    dgvOwner.Rows.Add(item.Id.ToString(),
                                            item.Number,
                                            item.FloorNumber,
                                            item.Block.Name,
                                            item.Block.Dermitory.Name);
                }

            }
        }
        private void RefreshStudentList(List<Models.User> Userlist)
        {
            dgvOwner.Rows.Clear();

            foreach (var item in Userlist)
            {
                // دیگر اگر قبلا این وسیله را به ان فرد اختصاص دادیم نشانش ندیم

                if ((!TransferRoomAssetHistory.IsStudentHasThisAsset(item.Id, RoomAsset.FindRoomAssetById(RoomAssetID).PartNumber)) && (item.IsDeleted == false))
                {
                    dgvOwner.Rows.Add(item.Id.ToString(),
                                          item.FirstName,
                                          item.LastName,
                                         (item.Gender == 0) ? "خانم" : "آقا",
                                          item.StuPerCode,
                                          item.NationalCode,
                                         (item.IsActive == true) ? "فعال" : "غیر فعال");
                }

            }

            if (dgvOwner.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in dgvOwner.Rows)
                {
                    // برای زمانی که اگر کسی غیر فعال است قر مز بشه
                    if (row.Cells[6].Value.ToString() == "غیر فعال")
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }



        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                db = new DormitoryDbContext();
                if (RoomAsset.FindRoomAssetById(RoomAssetID).PartNumber == 1)
                    RefreshRoomList((List<Models.Room>)db.Rooms.Where(i => i.Number.ToString().Contains(txtSearch.Text.Trim()) ||
                                                                           i.FloorNumber.ToString().Contains(txtSearch.Text.Trim())).ToList());
                else
                    RefreshStudentList((List<Models.User>)db.Users.Where(i => i.FirstName.Contains(txtSearch.Text.Trim()) ||
                                                               i.LastName.Contains(txtSearch.Text.Trim()) ||
                                                               i.StuPerCode.ToString().Contains(txtSearch.Text.Trim()) ||
                                                               i.NationalCode.ToString().Contains(txtSearch.Text.Trim())).ToList());
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBoxTool.msger(ex.ToString());
            }
        }
    }
}
