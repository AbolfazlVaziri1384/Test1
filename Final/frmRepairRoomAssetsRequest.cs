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

namespace Final
{
    public partial class frmRepairRoomAssetsRequest : Form
    {
        public frmRepairRoomAssetsRequest()
        {
            InitializeComponent();
        }
        public long UserID;
        DormitoryDbContext db;
        private void frmRepairRoomAssetsRequest_Load(object sender, EventArgs e)
        {
            db = new DormitoryDbContext();
            RefreshRequestsList(db.Repairs.ToList());
            db.Dispose();
        }
        private void RefreshRequestsList(List<Models.Repair> Repairlist)
        {
            dgvRequests.Rows.Clear();
            foreach (var item in Repairlist)
            {

                dgvRequests.Rows.Add(item.Id.ToString(),
                                     item.Guid,
                                      ((EnumTool.PartNumber)item.RoomAsset.PartNumber).ToString(),
                                      (item.RoomAsset.AssetNumber).ToString(),
                                      (item.Status == (int)EnumTool.Status.Intact) ? "سالم" : (item.Status == (int)EnumTool.Status.Defective) ? "معیوب" : "درحال تعمیر",
                                      item.Discription,
                                       HDateTimeTool.ToHDateTime(item.RequestDate),
                                       (item.IsRepair == true) ? "تعمیر انجام شده" : "در حال پیگیری",
                                       User.GetFullName(item.User)
                                       );


            }
            if (dgvRequests.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in dgvRequests.Rows)
                {
                    // اگر وسیله در حال استفاده باشد
                    if (row.Cells[6].Value.ToString() != "تعمیر انجام شده")
                    {
                        row.DefaultCellStyle.BackColor = Color.Aqua;
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                db = new DormitoryDbContext();
                RefreshRequestsList((List<Models.Repair>)db.Repairs.Where(i => i.Guid.ToString().Contains(txtSearch.Text.Trim())).ToList());
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBoxTool.msger(ex.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRequests.Rows.Count == 0)
            {
                return;
            }
            long id;
            id = long.Parse(dgvRequests.CurrentRow.Cells[0].Value.ToString());
            if (id != 0)
            {
                DialogResult result;
                result = MessageBoxTool.msgq("آیا از حذف مطمئن هستید ؟");
                if (result == DialogResult.Yes)
                {
                    Repair.Delete(id);
                    MessageBoxTool.msg();
                    db = new DormitoryDbContext();
                    RefreshRequestsList(db.Repairs.ToList());
                    db.Dispose();
                }
            }
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            if (dgvRequests.Rows.Count == 0)
            {
                return;
            }
            long id;
            id = long.Parse(dgvRequests.CurrentRow.Cells[0].Value.ToString());
            Repair.ChangeIsRepair(id);
            MessageBoxTool.msg();
            db = new DormitoryDbContext();
            RefreshRequestsList(db.Repairs.ToList());
            db.Dispose();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dtRepair = new DataTable();
            dtRepair.Columns.Add("Guid");
            dtRepair.Columns.Add("PartNumber");
            dtRepair.Columns.Add("AssetNumber");
            dtRepair.Columns.Add("Status");
            dtRepair.Columns.Add("Discription");
            dtRepair.Columns.Add("RequestDate");
            dtRepair.Columns.Add("IsRepair");
            dtRepair.Columns.Add("User");
            


            foreach (DataGridViewRow row in dgvRequests.Rows)
            {
                dtRepair.Rows.Add(
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    row.Cells[3].Value.ToString(),
                    row.Cells[4].Value.ToString(),
                    row.Cells[5].Value.ToString(),
                    row.Cells[6].Value.ToString(),
                    row.Cells[7].Value.ToString(),
                    row.Cells[8].Value.ToString()
                    );
            }
            //stiRepairPrint.Load(Application.StartupPath + "/RepairReport.mrt");
            //stiRepairPrint.RegData("DTRepair", dtRepair);
            //stiRepairPrint.Show();
        }
    }
}
