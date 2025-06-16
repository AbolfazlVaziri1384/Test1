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
    public partial class frmRoom : Form
    {
        public frmRoom()
        {
            InitializeComponent();
        }
        public long BlockId;
        public long UserID;

        DormitoryDbContext db;
        private void frmRoom_Load(object sender, EventArgs e)
        {
            Models.User? Owner = Models.Role.FindBlockOwner(BlockId);
            Models.Block? block = Models.Block.FindBlockById(BlockId);
            Models.Dormitory? dormitory = Models.Dormitory.FindDormitoryById(block.DermitoryId);
            frmRoom frmRoom = new frmRoom();
            if (Owner != null)
            {
                string name = ((Owner.Gender == 1) ? "آقا" : "خانم") + " " + Owner.FirstName + " " + Owner.LastName;
                frmRoom.Text = string.Format("{اتاق های بلوک {0} از خوابگاه {1} با مدیریت {2", block.Name, dormitory.Name, name);
            }
            else
                frmRoom.Text = string.Format("!اتاق های بلوک {0} از خوابگاه {1} بدون مدیر", block.Name, dormitory.Name);
            db = new DormitoryDbContext();
            RefreshRoomList(db.Rooms.ToList());
            db.Dispose();
        }
        private void RefreshRoomList(List<Models.Room> Roomlist)
        {
            dgvRooms.Rows.Clear();

            foreach (var item in Roomlist)
            {
                // اتاق های ان بلوک را میاره

                if ((item.BlockId == BlockId) && (item.IsDeleted == false))
                {
                    dgvRooms.Rows.Add(item.Id.ToString(),
                                            item.Number,
                                            item.FloorNumber,
                                            item.Capacity,
                                            Room.StudentCount(item.Id),
                                            HDateTimeTool.ToHDateTime(item.CreatOn));
                }

            }

            if (dgvRooms.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in dgvRooms.Rows)
                {
                    // برای زمانی که اتاقی پره
                    if (row.Cells[3].Value == row.Cells[4].Value)
                    {
                        row.DefaultCellStyle.BackColor = Color.Aqua;
                    }
                }
            }



        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dtRoom = new DataTable();
            dtRoom.Columns.Add("Number");
            dtRoom.Columns.Add("FloorNumber");
            dtRoom.Columns.Add("Capacity");
            dtRoom.Columns.Add("StudentCount");
            dtRoom.Columns.Add("CreatOn");
            dtRoom.Columns.Add("BlockName");
            dtRoom.Columns.Add("DormitoryName");

            Models.Block? block = Models.Block.FindBlockById(BlockId);
            Models.Dormitory? dormitory = Models.Dormitory.FindDormitoryById(block.DermitoryId);

            foreach (DataGridViewRow row in dgvRooms.Rows)
            {
                dtRoom.Rows.Add(
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    row.Cells[3].Value.ToString(),
                    row.Cells[4].Value.ToString(),
                    row.Cells[5].Value.ToString(),
                    block.Name.ToString(),
                    dormitory.Name.ToString()
                    );
            }
            //stiRoomPrint.Load(Application.StartupPath + "/RoomReport.mrt");
            //stiRoomPrint.RegData("DTRoom", dtRoom);
            //stiRoomPrint.Show();
        }
    }
}
