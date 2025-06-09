using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final.Tools
{
    public class MessageBoxTool
    {
        public static void msg()
        {
            MessageBox.Show("عملیات با موفقیت انجام شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void msgr(string s)
        {
            MessageBox.Show(s.ToString(), "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void msger(string e)
        {
            MessageBox.Show(e.ToString(), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static DialogResult msgq(string q)
        {
            DialogResult result = MessageBox.Show(q.ToString(), "نیاز به تایید شما", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result;
        }
        public static void msgw(string w)
        {
            MessageBox.Show(w.ToString(), "WELCOME", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
