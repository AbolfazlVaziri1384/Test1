using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final.Models;

namespace Final.Tools
{
    internal class CheckTool
    {
        public static bool UserField(string FirstName, string LastName, string UserName, string Password, string ConfirmPassword, string Address, long NationalCode, long Stu_Per_Code, long Phone, string Birthday)
        {
            bool Istrue = false;
            if ((string.IsNullOrWhiteSpace(FirstName)) ||
                (string.IsNullOrWhiteSpace(LastName)) ||
                (string.IsNullOrWhiteSpace(UserName)) ||
                (string.IsNullOrWhiteSpace(Password)) ||
                (string.IsNullOrWhiteSpace(ConfirmPassword)) ||
                (string.IsNullOrWhiteSpace(Address)) ||
                (string.IsNullOrWhiteSpace(NationalCode.ToString())) ||
                (NationalCode == 0) ||
                (string.IsNullOrWhiteSpace(Stu_Per_Code.ToString())) ||
                (Stu_Per_Code == 0) ||
                (string.IsNullOrWhiteSpace(Phone.ToString())) ||
                (Phone == 0) ||
                (Birthday != "    /  /  "))
            {
                MessageBoxTool.msger("تمام فیلد ها باید کامل شوند");
                return false;
            }
            if ((Password.Trim() != ConfirmPassword.Trim()) || (string.IsNullOrWhiteSpace(Password)) || (string.IsNullOrWhiteSpace(ConfirmPassword)))
            {
                MessageBoxTool.msger("رمز جدید با تکرار آن مغایرت دارد");
                return false;
            }
            // چک کردن نام کاربری که تکراری نباشد
            bool IsUserNameExist = User.AnyUser(UserName);
            if (IsUserNameExist)
            {
                MessageBoxTool.msger("این نام کاربری قبلا ثبت شده است");
                return false;
            }
            return true;
        }
    }
}
