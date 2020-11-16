using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
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
    public partial class Main : Form
    {
        Form1 playForm = new Form1();
        Login loginForm = new Login();
        Register register = new Register();
        int saveMark;



        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "eBgOAQI5uIW06LFti2BPAhchhDxep692YdWcflsT",
            BasePath = "https://db-midterm-789ff.firebaseio.com/"
        };

        IFirebaseClient client;

        public Main()
        {
            InitializeComponent();
        }


        #region 生命周期
        private void Main_Load(object sender, EventArgs e)
        {
            client = new FirebaseClient(config);
            if (client == null)
            {
                MessageBox.Show("无法建立连线，登入功能无法使用！");
            }
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(saveMark != playForm.playMark)
            {
                if (loginForm.logined)
                {
                    DialogResult closingSaveCheckResult;
                    closingSaveCheckResult = MessageBox.Show("你是否不储存就离开", "提示", MessageBoxButtons.YesNo);
                    if (closingSaveCheckResult == System.Windows.Forms.DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
                else
                {
                    DialogResult closingSaveCheckResult;
                    closingSaveCheckResult = MessageBox.Show("你是否不储存就离开", "提示", MessageBoxButtons.YesNo);
                    if (closingSaveCheckResult == System.Windows.Forms.DialogResult.No)
                    {
                        e.Cancel = true;
                        MessageBox.Show("没登入是无法储存的", "注意");
                    }
                }
            }
        }
        #endregion

        #region 选单
        private void ts_login_Click(object sender, EventArgs e)
        {
            loginForm = new Login();
            loginForm.Show();
        }

        private void ts_register_Click(object sender, EventArgs e)
        {
            register = new Register();
            register.Show();
        }

        private void ts_startGame_Click(object sender, EventArgs e)
        {
            if (!loginForm.logined)
            {
                DialogResult loginCheckResult;
                loginCheckResult = MessageBox.Show("你是否不登入就开始游戏", "", MessageBoxButtons.YesNo);
                if (loginCheckResult == System.Windows.Forms.DialogResult.Yes)
                {
                    playForm.MdiParent = this;
                    playForm.userName = "游客";
                    playForm.Show();
                    playForm.esayMode();
                    this.Width = 894;
                    this.Height = 754;
                    loginForm.logined = true;
                    loginForm.notLoginStart = true;
                }
                if (loginCheckResult == System.Windows.Forms.DialogResult.No)
                {
                    loginForm = new Login();
                    loginForm.Show();
                }
            }
            else
            {
                playForm.MdiParent = this;
                this.Width = 894;
                this.Height = 754;
                playForm.Show();
                playForm.esayMode();
            }
        }

        private void ts_saveGame_Click(object sender, EventArgs e)
        {
            if (loginForm.notLoginStart)
            {
                MessageBox.Show("你还没登入，无法储存！", "警告");
            }
            else
            {
                MessageBox.Show("已经成功储存！");
                saveMark = playForm.playMark;
            }
        }
        #endregion

        #region 难度
        private void ts_esay_Click(object sender, EventArgs e)
        {
            if (playForm.formShowed)
            {
                playForm.esayMode();
                this.Width = 894;
                this.Height = 754;
                playForm.modeChange = 0;
            }
            else
            {
                MessageBox.Show("你还没有开始游戏！！", "警告");
            }
        }

        private void ts_normal_Click(object sender, EventArgs e)
        {
            if (playForm.formShowed)
            {
                playForm.normalMode();
                this.Width = 1322;
                this.Height = 968;
                playForm.modeChange = 1;
            }
            else
            {
                MessageBox.Show("你还没有开始游戏！！", "警告");
            }
        }

        private void ts_hard_Click(object sender, EventArgs e)
        {
            if (playForm.formShowed)
            {
                playForm.hardMode();
                this.Width = 1750;
                this.Height = 968;
                playForm.modeChange = 2;
            }
            else
            {
                MessageBox.Show("你还没有开始游戏！！", "警告");
            }
        }
        #endregion=
    }
}
