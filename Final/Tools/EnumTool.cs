using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Tools
{
    internal class EnumTool
    {
        public enum Role : byte
        {
            Admin = 0,
            Manager = 1,
            DormitoryOwner = 2,
            BlockOwner = 3
        }
        public enum Status : byte
        {
            Intact = 0,
            Defective = 1,
            InRepair = 2
        }
        public enum PartNumber : byte
        {
            Refrigerator = 0,
            Desk = 1,
            Chair = 2,
            Bed = 3,
            Dresser = 4
        }
    }
}
