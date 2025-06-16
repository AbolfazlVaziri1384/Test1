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
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace Final
{
    public partial class frmBlock : Form
    {
        public frmBlock()
        {
            InitializeComponent();
        }
        public long DormitoryId;
        public long UserID;
        DormitoryDbContext db;
        private void frmBlock_Load(object sender, EventArgs e)
        {
            Models.User? Owner = Models.Role.FindDormitoryOwner(DormitoryId);
            Models.Dormitory? dormitory = Models.Dormitory.FindDormitoryById(DormitoryId);
            frmBlock frmBlock = new frmBlock();
            if (Owner != null)
            {
                string name = ((Owner.Gender == 1) ? "آقا" : "خانم") + " " + Owner.FirstName + " " + Owner.LastName;
                frmBlock.Text = string.Format("{1} بلوک های خوابگاه {0} با مدیریت", dormitory.Name, name);
            }
            else
                frmBlock.Text = string.Format("!بلوک های خوابگاه {0} بدون مدیر", dormitory.Name);

            db = new DormitoryDbContext();
            RefreshBlockList(db.Blocks.ToList());
            db.Dispose();
        }
        private void RefreshBlockList(List<Models.Block> Blocklist)
        {
            dgvBlocks.Rows.Clear();
            // اگر ادمین یا مدیر یا مسئول خوابگاه اصلی باشد
            if ((Role.FindRole(UserID) == 0) || (Role.FindRole(UserID) == 1) || (Role.FindRole(UserID) == 2))
                foreach (var item in Blocklist)
                {
                    // نمایش همه
                    if ((item.IsDeleted == false) && (item.DermitoryId == DormitoryId))
                    {
                        dgvBlocks.Rows.Add(item.Id.ToString(),
                                                item.Name,
                                                item.FloorNumber,
                                                item.RoomNumber,
                                                item.Capacity,
                                                HDateTimeTool.ToHDateTime(item.CreatOn),
                                                Block.FindBlockOwnerName(item.Id));
                    }

                }
            else
                foreach (var item in Blocklist)
                {
                    // بلوک های مربوط به این خوابگاه را می آورد

                    if ((item.CreatBy == UserID) && (item.IsDeleted == false) && (item.DermitoryId == DormitoryId))
                    {
                        dgvBlocks.Rows.Add(item.Id.ToString(),
                                                item.Name,
                                                item.FloorNumber,
                                                item.RoomNumber,
                                                item.Capacity,
                                                HDateTimeTool.ToHDateTime(item.CreatOn),
                                                Block.FindBlockOwnerName(item.Id));
                    }

                }

            if (dgvBlocks.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in dgvBlocks.Rows)
                {
                    // برای زمانی که بلوکی بی مسئوله
                    if (row.Cells[6].Value.ToString() == "")
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }



        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dtBlock = new DataTable();
            dtBlock.Columns.Add("Name");
            dtBlock.Columns.Add("FloorNumber");
            dtBlock.Columns.Add("RoomNumber");
            dtBlock.Columns.Add("Capacity");
            dtBlock.Columns.Add("CreatOn");
            dtBlock.Columns.Add("Owner");
            dtBlock.Columns.Add("DormitoryName");

            Models.Dormitory? dormitory = Models.Dormitory.FindDormitoryById(DormitoryId);

            foreach (DataGridViewRow row in dgvBlocks.Rows)
            {
                dtBlock.Rows.Add(
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    row.Cells[3].Value.ToString(),
                    row.Cells[4].Value.ToString(),
                    row.Cells[5].Value.ToString(),
                    row.Cells[6].Value.ToString(),
                    dormitory.Name.ToString()
                    );
            }
            //stiBlockPrint.Load(Application.StartupPath + "/BlockReport.mrt");
            //stiBlockPrint.RegData("DTBlock", dtBlock);
            //stiBlockPrint.Show();
        }
    }
}
