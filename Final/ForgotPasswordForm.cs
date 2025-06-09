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
    public partial class ForgotPasswordForm : Form
    {
        User? _user = new User();
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            string Stu_Per_Code = txtStu_Per_Code.Text.Trim();
            string NationalCode = txtNationalCode.Text.Trim();

            _user = User.FindUserByNationalCode(Stu_Per_Code, NationalCode);

            if (_user != null)
            {
                MessageBoxTool.msgr("اطلاعات تأیید شد");
                txtStu_Per_Code.Enabled = false;
                txtNationalCode.Enabled = false;
                btnVerify.Enabled = false;

                txtNewPassword.Enabled = true;
                txtConfirmPassword.Enabled = true;
                btnSubmit.Enabled = true;
                chkShowPassword.Enabled = true;
            }
            else
            {
                MessageBoxTool.msger("اطلاعات وارد شده نادرست است");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == txtConfirmPassword.Text && txtNewPassword.Text.Length >= 4)
            {
                User.ChangePassword(_user, txtNewPassword.Text);
                MessageBoxTool.msgr("رمز جدید با موفقیت ثبت شد");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBoxTool.msger("رمزها با هم مطابقت ندارند");
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool show = chkShowPassword.Checked;

            txtNewPassword.UseSystemPasswordChar = !show;
            txtConfirmPassword.UseSystemPasswordChar = !show;
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void ForgotPasswordForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
