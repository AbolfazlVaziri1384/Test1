using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Tools

{
    public static class HDateTimeTool
    {
        public static string Now()
        {
            DateTime now = DateTime.Now;
            return now.ToHDateTime();
        }

        public static DateTime ToDateTime(this string persianDate)
        {
            int year = Convert.ToInt32(persianDate.Substring(0, 4));
            int month = Convert.ToInt32(persianDate.Substring(5, 2));
            int day = Convert.ToInt32(persianDate.Substring(8, 2));
            DateTime georgianDateTime = new DateTime(year, month, day, new System.Globalization.PersianCalendar());
            return georgianDateTime;
        }

        public static string ToHDateTime(this DateTime georgianDate)
        {
            if (georgianDate == DateTime.MinValue) return "01/01/1300";

            System.Globalization.PersianCalendar persianCalendar = new System.Globalization.PersianCalendar();

            string year = persianCalendar.GetYear(georgianDate).ToString();
            string month = persianCalendar.GetMonth(georgianDate).ToString().PadLeft(2, '0');
            string day = persianCalendar.GetDayOfMonth(georgianDate).ToString().PadLeft(2, '0');
            string persianDateString = string.Format("{0}/{1}/{2}", year, month, day);

            return persianDateString;
        }
        // nullable همان بالایی
        public static string ToHDateTime(this DateTime? georgianDate)
        {
            if (georgianDate == null) return null;
            if (georgianDate == DateTime.MinValue) return "01/01/1300";

            System.Globalization.PersianCalendar persianCalendar = new System.Globalization.PersianCalendar();

            string year = persianCalendar.GetYear(georgianDate.Value).ToString();
            string month = persianCalendar.GetMonth(georgianDate.Value).ToString().PadLeft(2, '0');
            string day = persianCalendar.GetDayOfMonth(georgianDate.Value).ToString().PadLeft(2, '0');
            string persianDateString = string.Format("{0}/{1}/{2}", year, month, day);

            return persianDateString;
        }

        public static string ToShortTimeSpan(this TimeSpan timeSpan)
        {
            if (timeSpan == null) return null;
            return string.Format("{0:hh\\:mm}", timeSpan); // "{0:hh\\:mm\\:ss}"
        }
        // nullable همان بالایی
        public static string ToShortTimeSpan(this TimeSpan? timeSpan)
        {
            if (timeSpan == null) return null;
            return string.Format("{0:hh\\:mm}", timeSpan); // "{0:hh\\:mm\\:ss}"
        }

        public static TimeSpan? ToShortTimeSpan(this string strTimeSpan)
        {
            if (strTimeSpan.IsValidStrTimeSpan())
            {
                return TimeSpan.Parse(strTimeSpan);
            }
            else
            {
                return null;
            }
        }

        public static string AddDaysToHDateTime(this string persianDate, int days)
        {
            DateTime dt = persianDate.ToDateTime();
            dt = dt.AddDays(days);
            return dt.ToHDateTime();
        }

        public static bool IsValidHDateString(this string hdate)
        {
            if (hdate == null) return false;
            if (hdate.Length != 10) return false;

            var numberCount = hdate.Count(x => Char.IsDigit(x));
            if (numberCount != 8) return false;

            if (hdate.Substring(4, 1) != "/") return false;
            if (hdate.Substring(7, 1) != "/") return false;

            if (int.Parse(hdate.Substring(0, 4)) < 1000) return false;
            if (int.Parse(hdate.Substring(5, 2)) > 12) return false;
            if (int.Parse(hdate.Substring(8, 2)) > 31) return false;

            try
            {
                hdate.ToDateTime();    // در نهایت چک میکنیم که قابل تبدیل باشد        
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public static bool IsValidDateString(this string date)
        {
            Boolean value = true;
            if (date == String.Empty || date == null)
            {
                value = false;
            }
            else
            {
                DateTime n;
                return DateTime.TryParse(date, out n);
            }
            return value;
        }

        public static bool IsValidStrTimeSpan(this string strTimeSpan)
        {

            // Example  07:22

            if (strTimeSpan == null) return false;
            if (strTimeSpan.Length != 5) return false;

            var numberCount = strTimeSpan.Count(x => Char.IsDigit(x));
            if (numberCount != 4) return false;

            if (strTimeSpan.Substring(2, 1) != ":") return false;

            if (int.Parse(strTimeSpan.Substring(0, 2)) < 0) return false;
            if (int.Parse(strTimeSpan.Substring(3, 2)) < 0) return false;
            if (int.Parse(strTimeSpan.Substring(0, 2)) > 23) return false;
            if (int.Parse(strTimeSpan.Substring(3, 2)) > 59) return false;

            try
            {
                TimeSpan time = TimeSpan.Parse(strTimeSpan);    // در نهایت چک میکنیم که قابل تبدیل باشد        
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
