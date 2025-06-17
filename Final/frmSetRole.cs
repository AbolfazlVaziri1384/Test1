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
    public partial class frmSetRole : Form
    {
        public frmSetRole()
        {
            InitializeComponent();
        }
        public long Dormitory_BlockId = -1;
        public bool IsDormitory = false;
        public long UserID;
        DormitoryDbContext db;
        private void frmSetRole_Load(object sender, EventArgs e)
        {
            db = new DormitoryDbContext();
            RefreshUsersList(db.Users.ToList());
            db.Dispose();
        }
        private void RefreshUsersList(List<Models.User> Userslist)
        {
            dgvUsers.Rows.Clear();
            foreach (var item in Userslist)
            {
                // افرادی که تا به الان به انها نقش داده شده را نمایش ندهد
                if (!(Role.AnyRole(item.Id)) && (item.Id != UserID) && (item.IsDeleted == false))
                {
                    dgvUsers.Rows.Add(item.Id.ToString(),
                                      item.FirstName,
                                      item.LastName,
                                     (item.Gender == 0) ? "خانم" : "آقا",
                                      item.StuPerCode,
                                      item.NationalCode,
                                      item.Phone,
                                     (item.IsActive == true) ? "فعال" : "غیر فعال");
                }

            }

            if (dgvUsers.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in dgvUsers.Rows)
                {
                    // برای زمانی که اگر کسی غیر فعال است قر مز بشه
                    if (row.Cells[7].Value.ToString() == "غیر فعال")
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
                RefreshUsersList((List<Models.User>)db.Users.Where(i => i.FirstName.Contains(txtSearch.Text.Trim()) ||
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

        private void btnSet_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsers.Rows.Count == 0)
                {
                    return;
                }
                long Id;
                Id = long.Parse(dgvUsers.CurrentRow.Cells[0].Value.ToString());
                DialogResult result;
                result = MessageBoxTool.msgq("آیا از فرد مطمئن هستید؟");
                if (result == DialogResult.Yes)
                {
                    Role.SetRole(Id, IsDormitory, Dormitory_BlockId, UserID);
                    MessageBoxTool.msgr("ثبت نقش با موفقیت انجام شد");
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
