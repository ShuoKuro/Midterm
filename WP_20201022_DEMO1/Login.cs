using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
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
    public partial class Login : Form
    {
        public bool logined;
        public bool notLoginStart;
        public string userName;
        public string password;
        public int playMark;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "eBgOAQI5uIW06LFti2BPAhchhDxep692YdWcflsT",
            BasePath = "https://db-midterm-789ff.firebaseio.com/"
        };

        IFirebaseClient client;
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            client = new FirebaseClient(config);
            tb_loginName.MaxLength = 16;
            tb_password.MaxLength = 20;
            tb_password.PasswordChar = '*';
        }


        private async void btn_loginCheck_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.GetAsync("User/" + tb_loginName.Text);
            Data obj = response.ResultAs<Data>();
            if (response.ResultAs<Data>() != null)
            {
                if (tb_password.Text == obj.Password)
                {
                    logined = true;
                    notLoginStart = false;
                    userName = obj.UserName;
                    playMark = obj.PlayMark;
                    password = obj.Password;
                    Close();
                }
                else
                {
                    MessageBox.Show("密码或账号错误!!");
                }
            }
            else
            {
                MessageBox.Show("密码或账号错误!!");
            }

        }

        private void tb_loginName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar);

        }

        private void tb_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar);

        }
    }
}
