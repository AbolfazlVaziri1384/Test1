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
    public partial class frmStudentAssets : Form
    {
        public frmStudentAssets()
        {
            InitializeComponent();
        }
        DormitoryDbContext db;
        public long UserID;
        private void frmStudentAssets_Load(object sender, EventArgs e)
        {
            db = new DormitoryDbContext();
            RefreshStudentAssetsList(db.StudentAssets.ToList());
            RefreshRoomAssetsList(db.TransferRoomAssetHistorys.ToList());
            db.Dispose();
        }
        private void RefreshStudentAssetsList(List<Models.StudentAsset> SAlist)
        {
            dgvStudentAssets.Rows.Clear();
            string name;
            foreach (var item in SAlist)
            {
                if (item.StudentId == UserID)
                {
                    if (item.LastStudentId != null)
                    {
                        name = Models.User.GetFullName(Models.User.FindUserById(item.LastStudentId));
                    }
                    else
                        name = "";
                    dgvStudentAssets.Rows.Add(item.Id.ToString(),
                                            item.Name,
                                            item.Guid,
                                            name,
                                            (item.TransferDate == null) ? "" : HDateTimeTool.ToHDateTime(item.TransferDate),
                                            (item.Discription == null) ? "" : item.Discription);
                }

            }


            if (dgvStudentAssets.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in dgvStudentAssets.Rows)
                {
                    // اگر وسیله انتقالی باشه
                    if (row.Cells[3].Value.ToString() != "")
                    {
                        row.DefaultCellStyle.BackColor = Color.Aqua;
                    }
                }
            }
        }
        private void RefreshRoomAssetsList(List<Models.TransferRoomAssetHistory> TRAlist)
        {
            dgvRoomAssets.Rows.Clear();
            foreach (var item in TRAlist)
            {
                if (((item.StudentId == UserID) || (TransferRoomAssetHistory.IsInOneRoom(item.RoomAssetId, UserID))) && (item.RoomAsset.IsDeleted == false))
                {
                    dgvRoomAssets.Rows.Add(item.Id.ToString(),
                                            ((EnumTool.PartNumber)item.RoomAsset.PartNumber).ToString(),
                                            item.RoomAsset.AssetNumber,
                                            (item.RoomAsset.Status == (int)EnumTool.Status.Intact) ? "سالم" : (item.RoomAsset.Status == (int)EnumTool.Status.Defective) ? "معیوب" : "درحال تعمیر",
                                            HDateTimeTool.ToHDateTime(item.CreatOn),
                                            Models.User.GetFullName(Models.User.FindUserById(item.CreatBy)));
                }

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dtStudentAsset = new DataTable();
            dtStudentAsset.Columns.Add("Name");
            dtStudentAsset.Columns.Add("Guid");
            dtStudentAsset.Columns.Add("LastOwner");
            dtStudentAsset.Columns.Add("TransferDate");
            dtStudentAsset.Columns.Add("Discription");

            dtStudentAsset.Columns.Add("StFullName");
            dtStudentAsset.Columns.Add("StudentCode");


            foreach (DataGridViewRow row in dgvStudentAssets.Rows)
            {
                dtStudentAsset.Rows.Add(
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    row.Cells[3].Value.ToString(),
                    row.Cells[4].Value.ToString(),
                    row.Cells[5].Value.ToString(),
                    Models.User.GetFullName(Models.User.FindUserById(UserID)),
                    Models.User.FindUserById(UserID).StuPerCode.ToString()
                    );
            }

            DataTable dtRoomAsset = new DataTable();
            dtStudentAsset.Columns.Add("PartNumber");
            dtStudentAsset.Columns.Add("AssetNumber");
            dtStudentAsset.Columns.Add("Status");
            dtStudentAsset.Columns.Add("CreatOn");
            dtStudentAsset.Columns.Add("CreatBy");


            foreach (DataGridViewRow row in dgvRoomAssets.Rows)
            {
                dtStudentAsset.Rows.Add(
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    row.Cells[3].Value.ToString(),
                    row.Cells[4].Value.ToString(),
                    row.Cells[5].Value.ToString()
                    );
            }

            //stiAssetPrint.Load(Application.StartupPath + "/AssetReport.mrt");
            //stiAssetPrint.RegData("DTRoomAsset", dtRoomAsset);
            //stiAssetPrint.RegData("DTStudentAsset", dtStudentAsset);
            //stiAssetPrint.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudentAssets.Rows.Count == 0)
            {
                return;
            }
            long id;
            id = long.Parse(dgvStudentAssets.CurrentRow.Cells[0].Value.ToString());
            DialogResult result;
            result = MessageBoxTool.msgq("آیا از حذف این وسیله مطمئن هستید ؟");
            if (result == DialogResult.Yes)
            {
                StudentAsset.DeleteAsset(id);
                MessageBoxTool.msgr("حذف با موفقیت انجام شد");
            }
        }

        private void btnSetStudentAsset_Click(object sender, EventArgs e)
        {
            frmSetStudentAssets frm = new frmSetStudentAssets();
            frm.UserID = UserID;
            frm.ShowDialog();
            db = new DormitoryDbContext();
            RefreshStudentAssetsList(db.StudentAssets.ToList());
            RefreshRoomAssetsList(db.TransferRoomAssetHistorys.ToList());
            db.Dispose();
        }

        private void btnSetTransfer_Click(object sender, EventArgs e)
        {
            if (dgvStudentAssets.Rows.Count == 0)
            {
                return;
            }
            long id;
            id = long.Parse(dgvStudentAssets.CurrentRow.Cells[0].Value.ToString());

            frmSetTransferStudentAssets frm = new frmSetTransferStudentAssets();
            frm.UserID = UserID;
            frm.StudentAssetId = id;
            frm.ShowDialog();
            db = new DormitoryDbContext();
            RefreshStudentAssetsList(db.StudentAssets.ToList());
            RefreshRoomAssetsList(db.TransferRoomAssetHistorys.ToList());
            db.Dispose();
        }

        private void btnRepairRoomAsset_Click(object sender, EventArgs e)
        {
            if (dgvRoomAssets.Rows.Count == 0)
            {
                return;
            }
            long id;
            id = long.Parse(dgvRoomAssets.CurrentRow.Cells[0].Value.ToString());

            frmRepairRoomAsset frm = new frmRepairRoomAsset();
            frm.UserID = UserID;
            frm.RoomAssetID = id;
            frm.ShowDialog();
            db = new DormitoryDbContext();
            RefreshStudentAssetsList(db.StudentAssets.ToList());
            RefreshRoomAssetsList(db.TransferRoomAssetHistorys.ToList());
            db.Dispose();
        }
    }
}
