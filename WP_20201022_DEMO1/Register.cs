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
        }

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
        private void btn_check_Click(object sender, EventArgs e)
        {
            validCodeCheck();
            if (validCodeOK)
            {
                Close();
            }
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
    }
}
