using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final.Models;
using Final.Tools;

namespace Final
{
    public partial class frmSetUser : Form
    {
        public frmSetUser()
        {
            InitializeComponent();
        }
        public int UserEditId = -1;
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool Istrue;
                bool Isture = CheckTool.UserField(txtFirstName.Text , txtLastName.Text,txtUserName.Text , txtPassword.Text , txtConfirmPassword.Text , txtAddress.Text , Convert.ToInt64(numNationalCode.Value) , Convert.ToInt64(numStu_Per_Code.Value) , Convert.ToInt64(numPhone.Value) , mskbirthday.Text.ToString());
                // برای تغییر نام دکمه هنگامی که ما برای ویرایش وارد می شویم 
                //if (UserIdEdit == -1)
                //{
                //    if (Istrue == true)
                //    {
                //        user.FirstName = FirstName.text;
                //        user.FirstName = FirstName.text;
                //        user.FirstName = FirstName.text;
                //        user.FirstName = FirstName.text;
                //        user.FirstName = FirstName.text;
                //        user.FirstName = FirstName.text;
                //        user.FirstName = FirstName.text;
                //        user.FirstName = FirstName.text;
                //        ////creat ها حتما پر شوند !!!
                //        db.Users.Add(user);
                //        db.SaveChanges();
                //        MessageBoxTool.msgr("کاربر جدید با موفقیت ثبت شد");
                //        Close();
                //    }
                //    else
                //    {
                //        if (Istrue == true)
                //        {
                //            DialogResult result;
                //            result = MessageBoxTool.msgq("آیا از ویرایش مطمئن هستید؟");
                //            if (result == DialogResult.Yes)
                //            {

                //                user = db.Users.find(i => i.Id == UserIdEidt).firstordefult();

                //                user.FirstName = FirstName.text;
                //                user.FirstName = FirstName.text;
                //                user.FirstName = FirstName.text;
                //                user.FirstName = FirstName.text;
                //                user.FirstName = FirstName.text;
                //                user.FirstName = FirstName.text;
                //                user.FirstName = FirstName.text;
                //                user.FirstName = FirstName.text;
                //                //modify ها حتما پر شوند !!!

                //                db.SaveChanges();
                //                MessageBoxTool.msgr("کابر با موفقیت ویرایش شد");
                //                Close();
                //            }
                //        }
                //    }


                //}
            }
            catch (Exception ex)
            {
                MessageBoxTool.msger(ex.Message);
            }


        }





        private void frmSetUser_Load(object sender, EventArgs e)
        {
            if (UserEditId != -1)
            {
                btnSave.Text = "ویرایش";
                frmSetUser frm = new frmSetUser();
                frm.Text = "صفحه ویرایش";
                User? EditUser = User.FindUserById(UserEditId);
                // پر کردن فیلد ها
                txtFirstName.Text = EditUser.FirstName;
                txtLastName.Text = EditUser.LastName;
                txtUserName.Text = EditUser.UserName;
                txtPassword.Text = EditUser.Password;
                txtConfirmPassword.Text = EditUser.Password;
                txtAddress.Text = EditUser.Address;
                numNationalCode.Value = EditUser.NationalCode;
                numStu_Per_Code.Value = EditUser.StuPerCode;
                numPhone.Value = EditUser.Phone;
                mskbirthday.Text = EditUser.Birthday;
                if (EditUser.Gender == 0) radWoman.Checked = true;
                else radMan.Checked = true;
            }
            radMan.Checked = true;
        }

        private void radWoman_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
