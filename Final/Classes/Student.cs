using Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final.Classes
{
    class Student:Person
    {
        public string StudentCode { get; set; }
        public Rooms Room { get; set; }
        public Blocks Block { get; set; }
        public Dorms Dorm { get; set; }
        public List<Items> PersonalItem { get; set; }

        public Student()
        {

            PersonalItem = new List<Items>();

        }
    }
}
