using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Classes
{
    class Blocks
    {
        public string Name { get; set; }
        public int FloorCount { get; set; }
        public int RoomCount { get; set; }
        public string BlockManager { get; set; }
        public List<Rooms> RoomList { get; set; }
        public Dorms Dorm { get; set; }
        public Blocks()
        {
            RoomList = new List<Rooms>();

        }
    }
}
