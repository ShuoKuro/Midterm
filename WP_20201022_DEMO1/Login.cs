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

        public Login()
        {
            InitializeComponent();
        }

        private void btn_loginCheck_Click(object sender, EventArgs e)
        {
            logined = true;
            Close();
        }
    }
}
