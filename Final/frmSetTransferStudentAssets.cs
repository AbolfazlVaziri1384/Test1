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
    public partial class frmSetTransferStudentAssets : Form
    {
        public frmSetTransferStudentAssets()
        {
            InitializeComponent();
        }
        public long UserID;
        public long StudentAssetId;
        DormitoryDbContext db;
        private void frmSetTransferStudentAssets_Load(object sender, EventArgs e)
        {
            db = new DormitoryDbContext();
            RefreshStudentsList(db.Users.ToList());
            db.Dispose();
        }
        private void RefreshStudentsList(List<Models.User> Userslist)
        {
            dgvStudents.Rows.Clear();
            foreach (var item in Userslist)
            {
                if ((Role.FindRole(UserID) != (int)RoleTool.Role.Admin) || (Role.FindRole(UserID) != (int)RoleTool.Role.Manager) || (Role.FindRole(UserID) == (int)RoleTool.Role.DormitoryOwner))
                    if ((item.Id != UserID) && (item.IsDeleted == false) && (item.IsActive == true))
                    {
                        dgvStudents.Rows.Add(item.Id.ToString(),
                                          item.FirstName,
                                          item.LastName,
                                         (item.Gender == 0) ? "خانم" : "آقا",
                                          item.StuPerCode
                                          );
                    }

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                db = new DormitoryDbContext();
                RefreshStudentsList((List<Models.User>)db.Users.Where(i => i.FirstName.Contains(txtSearch.Text.Trim()) ||
                                                   i.LastName.Contains(txtSearch.Text.Trim()) ||
                                                   i.StuPerCode.ToString().Contains(txtSearch.Text.Trim())));
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBoxTool.msger(ex.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvStudents.Rows.Count == 0)
                {
                    return;
                }
                long Id;
                Id = long.Parse(dgvStudents.CurrentRow.Cells[0].Value.ToString());
                DialogResult result;
                result = MessageBoxTool.msgq("آیا از انتقال مطمئن هستید ؟");
                if (result == DialogResult.Yes)
                {
                    StudentAsset.SetTransfer(StudentAssetId, UserID, Id);
                    MessageBoxTool.msgr("انتقال با موفقیت ثبت شد");
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
