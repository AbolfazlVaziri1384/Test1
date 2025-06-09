using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Classes
{
    class Rooms
    {
        public int RoomNumber { get; set; }
        public int Floor { get; set; }
        public int Capacity
        {
            get { return Capacity; }
            set
            {
                if (value <= 6)
                {
                    Capacity = value;
                }
                else
                {
                    throw new Exception();
                }

            }

        }
        public List<Items> Item { get; set; }
        public List<Student> students { get; set; }
        public Blocks block { get; set; }

        public Rooms()
        {
            Item = new List<Items>();
            students = new List<Student>();


        }
    }
}
