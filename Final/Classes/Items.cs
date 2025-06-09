using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Classes
{
    class Items
    {
        public string Type { get; set; }
        public int ID { get; set; }
        public string Identifire { get; set; }
        public string IsActive { get; set; }
        public Rooms Room { get; set; }
        public Student Owner { get; set; }
    }
}
