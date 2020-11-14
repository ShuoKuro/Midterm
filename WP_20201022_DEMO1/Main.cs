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
        private void Main_Load(object sender, EventArgs e)
        {
            client = new FirebaseClient(config);
            if (client == null)
            {
                MessageBox.Show("无法建立连线");
            }
        }

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
                    playForm.Show();
                    playForm.esayMode();
                    this.Width = 894;
                    this.Height = 754;
                    loginForm.logined = true;
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
                playForm.Show();
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
        #endregion
    }
}
