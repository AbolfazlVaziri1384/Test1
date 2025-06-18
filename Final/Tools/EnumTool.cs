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
            Refrigerator = 1,
            Desk = 2,
            Chair = 3,
            Bed = 4,
            Dresser = 5
        }
    }
}
