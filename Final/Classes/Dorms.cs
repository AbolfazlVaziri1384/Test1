using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Classes
{
    class Dorms
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Capacity { get; set; }
        public string Manager { get; set; }
        public List<Blocks> BlockList { get; set; }
        public Dorms()
        {
            BlockList = new List<Blocks>();

        }
    }
}
