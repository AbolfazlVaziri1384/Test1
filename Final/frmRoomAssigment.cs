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
    public partial class frmRoomAssigment : Form
    {
        public frmRoomAssigment()
        {
            InitializeComponent();
        }
        public long UserID;
        public long RoomId;
        DormitoryDbContext db;
        private void frmRoomAssigment_Load(object sender, EventArgs e)
        {
            frmRoomAssigment frmRoomAssigment = new frmRoomAssigment();

            Models.Room? room = Models.Room.FindRoomById(RoomId);
            Models.Block? block = Models.Block.FindBlockById(room.BlockId);
            Models.Dormitory? dormitory = Models.Dormitory.FindDormitoryById(block.DermitoryId);
            frmRoomAssigment.Text = string.Format("{1} افراد اتاق شماره {0} در طبقه", room.Number, room.FloorNumber);
            lblBlock.Text = block.Name;
            lblDormitory.Text = dormitory.Name;

            Models.User? BlockOwner = Models.Role.FindBlockOwner(room.BlockId);
            Models.User? DormitoryOwner = Models.Role.FindBlockOwner(Models.Block.FindBlockById(room.BlockId).DermitoryId);

            if (BlockOwner != null)
            {
                string name = ((BlockOwner.Gender == 1) ? "آقا" : "خانم") + " " + BlockOwner.FirstName + " " + BlockOwner.LastName;
                lblBlockOwner.Text = name;
            }
            else lblBlockOwner.Text = "-";

            if (DormitoryOwner != null)
            {
                string name = ((DormitoryOwner.Gender == 1) ? "آقا" : "خانم") + " " + DormitoryOwner.FirstName + " " + DormitoryOwner.LastName;
                lblDormitoryOwner.Text = name;
            }
            else lblDormitoryOwner.Text = "-";

            db = new DormitoryDbContext();
            RefreshRoomAssigmentList(db.RoomAssigments.ToList());
            db.Dispose();
        }
        private void RefreshRoomAssigmentList(List<Models.RoomAssigment> RoomAssigmentlist)
        {
            dgvStudents.Rows.Clear();

            foreach (var item in RoomAssigmentlist)
            {
                // افراد داخل اتاق رامیاره

                if ((item.RoomId == RoomId) && (item.IsDeleted == false))
                {
                    Models.User user = User.FindUserById(item.Id);
                    string name = ((user.Gender == 1) ? "آقا" : "خانم") + " " + user.FirstName + " " + user.LastName;

                    dgvStudents.Rows.Add(item.Id.ToString(),
                                            name,
                                            user.StuPerCode,
                                            user.NationalCode,
                                            HDateTimeTool.ToHDateTime(item.CreatOn));
                }

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dtRoomAssigment = new DataTable();
            dtRoomAssigment.Columns.Add("Name");
            dtRoomAssigment.Columns.Add("StuPerStudent");
            dtRoomAssigment.Columns.Add("NationalCode");
            dtRoomAssigment.Columns.Add("CreatOn");

            dtRoomAssigment.Columns.Add("Dormitory");
            dtRoomAssigment.Columns.Add("Block");
            dtRoomAssigment.Columns.Add("DormitoryOwner");
            dtRoomAssigment.Columns.Add("BlockOwner");

            dtRoomAssigment.Columns.Add("Number");
            dtRoomAssigment.Columns.Add("FloorNumber");

            Models.Room? room = Models.Room.FindRoomById(RoomId);

            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                dtRoomAssigment.Rows.Add(
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    row.Cells[3].Value.ToString(),
                    row.Cells[4].Value.ToString(),
                    lblDormitory.Text,
                    lblBlock.Text,
                    lblDormitoryOwner.Text,
                    lblBlockOwner.Text,
                    room.Number,
                    room.FloorNumber
                    );
            }
            //stiRoomAssigmentPrint.Load(Application.StartupPath + "/RoomAssigmentReport.mrt");
            //stiRoomAssigmentPrint.RegData("DTRoomAssigment", dtRoomAssigment);
            //stiRoomAssigmentPrint.Show();
        }
    }
}
