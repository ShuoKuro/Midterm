using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WP_20201022_DEMO1
{
    public partial class Register : Form
    {
        checkCode checkCode = new checkCode();
        bool userNameOK;
        bool passwordOK;
        bool passwordCheckOK;
        bool validCodeOK;

        private const int valiCodeLength = 4;
        private string strValidCode = "";

        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            upDateValidCode();
            validCodeOK = false;
            userNameOK = false;
            passwordOK = false;
            passwordCheckOK = false;

            tb_userName.MaxLength = 16;
            tb_userPw.MaxLength = 20;
            tb_userPw.PasswordChar = '*';
            tb_confirmPw.MaxLength = 20;
            tb_confirmPw.PasswordChar = '*';

            lb_checkUserName.Text = "";
            lb_checkPw.Text = "";
            lb_checkConfirm.Text = "";
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            validCodeCheck();
            if (validCodeOK)
            {
                if (userNameOK && passwordOK && passwordCheckOK)
                {
                    MessageBox.Show("注册完成！！");

                    Close();
                }
                if (!passwordCheckOK)
                {
                    checkPasswordwrong();
                    tb_confirmPw.Focus();
                }
                if (!passwordOK)
                {
                    userPasswordWrong();
                    tb_userPw.Focus();
                }
                if (!userNameOK)
                {
                    userNameWrong();
                    tb_userName.Focus();
                }
            }
        }



        private void tb_userName_GotFocus(object sender,EventArgs e)
        {
            lb_checkUserName.Text = "输入8~16位字母或数字，首位为字母";
            lb_checkUserName.ForeColor = Color.Black;
        }
        private void tb_userName_LostFocus(object sender,EventArgs e)
        {
            string checkString = tb_userName.Text.Replace(" ", "");
            if (tb_userName.TextLength < 8)
            {
                userNameWrong();
                userNameOK = false;
            }
            else
            {
                if (checkString == tb_userName.Text)
                {
                    char[] checkChar = tb_userName.Text.ToCharArray();
                    if (char.IsLetter(checkChar[0]))
                    {
                        userNameCorrect();
                        userNameOK = true;
                    }
                    else
                    {
                        userNameWrong();
                        userNameOK = false;
                    }
                }
                else
                {
                    userNameWrong();
                    userNameOK = false;
                }
            }
        }

        private void tb_userPw_GotFocus(object sender,EventArgs e)
        {
            lb_checkPw.Text = "输入8~20字母或数字";
            lb_checkPw.ForeColor = Color.Black;
        }
        private void tb_userPw_LostFocus(object sender,EventArgs e)
        {
            string checkString = tb_userPw.Text.Replace(" ", "");
            if (tb_userPw.TextLength < 8)
            {
                userPasswordWrong();
                passwordOK = false;
            }
            else
            {
                if (checkString == tb_userPw.Text)
                {
                    userPasswordCorrect();
                    passwordOK = true;
                }
                else
                {
                    userPasswordWrong();
                    passwordOK = false;
                }
            }
        }

        private void tb_confirmPw_GotFocus(object sender,EventArgs e)
        {
            lb_checkConfirm.Text = "重复输入一次密码";
            lb_checkConfirm.ForeColor = Color.Black;
        }
        private void tb_confirmPw_LostFocus(object sender,EventArgs e)
        {
            if (tb_userPw.Text != tb_confirmPw.Text)
            {
                checkPasswordwrong();
                passwordCheckOK = false;
            }
            else
            {
                if (passwordOK)
                {
                    checkPasswordCorrect();
                    passwordCheckOK = true;
                }
                else
                {
                    checkPasswordwrong();
                    passwordCheckOK = false;
                }
            }
        }

        private void tb_userName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
        private void tb_userPw_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        #region 检查正确
        private void userNameCorrect()
        {
            lb_checkUserName.Text = "正确";
            lb_checkUserName.ForeColor = Color.Green;
        }

        private void userPasswordCorrect()
        {
            lb_checkPw.Text = "正确";
            lb_checkPw.ForeColor = Color.Green;
        }

        private void checkPasswordCorrect()
        {
            lb_checkConfirm.Text = "正确";
            lb_checkConfirm.ForeColor = Color.Green;
        }


        #endregion

        #region 检查错误
        private void userNameWrong()
        {
            lb_checkUserName.Text = "输入错误";
            lb_checkUserName.ForeColor = Color.Red;
        }

        private void userPasswordWrong()
        {
            lb_checkPw.Text = "输入错误";
            lb_checkPw.ForeColor = Color.Red;
        }

        private void checkPasswordwrong()
        {
            lb_checkConfirm.Text = "输入错误";
            lb_checkConfirm.ForeColor = Color.Red;
        }
        #endregion


        #region 验证码
        private void upDateValidCode()
        {
            strValidCode = checkCode.createRandomCode(valiCodeLength);
            if (strValidCode == "") return;
            checkCode.createImage(strValidCode, pb_checkCode);
        }

        private void lab_upDateValidCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            upDateValidCode();
            tb_validCode.Text = "";
        }

        private void validCodeCheck()
        {
            string validCode = tb_validCode.Text.Trim();
            if (string.IsNullOrEmpty(validCode) != true)
            {
                if (validCode.ToLower() == strValidCode.ToLower())
                {
                    validCodeOK = true;
                }
                else
                {
                    MessageBox.Show("验证码错误", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    upDateValidCode();
                    tb_validCode.Text = "";
                    tb_validCode.Focus();
                }
            }
            else
            {
                MessageBox.Show("你还没有输入验证码", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                upDateValidCode();
                tb_validCode.Text = "";
                tb_validCode.Focus();
            }

        }
        #endregion

    }
}
