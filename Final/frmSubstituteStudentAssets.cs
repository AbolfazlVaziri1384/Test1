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
    public partial class frmSubstituteStudentAssets : Form
    {
        public frmSubstituteStudentAssets()
        {
            InitializeComponent();
        }
        DormitoryDbContext db;
        private void frmSubstituteStudentAssets_Load(object sender, EventArgs e)
        {
            db = new DormitoryDbContext();
            RefreshSSAList(db.SubstituteStudentAssets.ToList());
            db.Dispose();
        }
        private void RefreshSSAList(List<Models.SubstituteStudentAsset> SSAlist)
        {
            dgvSubstitute.Rows.Clear();

            foreach (var item in SSAlist)
            {
                dgvSubstitute.Rows.Add(item.Id.ToString(),
                                        User.GetFullName(item.Student),
                                        ((EnumTool.PartNumber)item.PartNumber).ToString(),
                                        RoomAsset.FindRoomAssetById(item.NewRoomAssetId).AssetNumber,
                                        item.LastRoomAsset.AssetNumber);
            }

            if (dgvSubstitute.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in dgvSubstitute.Rows)
                {
                    if (row.Cells[4].Value == null)
                    {
                        row.DefaultCellStyle.BackColor = Color.Aqua;
                    }
                }
            }



        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dtSSA = new DataTable();
            dtSSA.Columns.Add("Name");
            dtSSA.Columns.Add("PartNumber");
            dtSSA.Columns.Add("NewRoomAsset");
            dtSSA.Columns.Add("LastRoomAsset");

            foreach (DataGridViewRow row in dgvSubstitute.Rows)
            {
                dtSSA.Rows.Add(
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    row.Cells[3].Value.ToString(),
                    row.Cells[4].Value.ToString()
                    );
            }
            //stiSSAPrint.Load(Application.StartupPath + "/SSAReport.mrt");
            //stiSSAPrint.RegData("DTSSA", dtSSA);
            //stiSSAPrint.Show();
        }
    }
}
