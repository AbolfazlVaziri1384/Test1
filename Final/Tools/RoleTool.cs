using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Tools
{
    internal class RoleTool
    {
        public enum Role : byte
        {
            Admin = 0,
            Manager = 1,
            DormitoryOwner = 2,
            BlockOwner = 3
        }
    }
}
