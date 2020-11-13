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
        Form1 playform = new Form1();

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "eBgOAQI5uIW06LFti2BPAhchhDxep692YdWcflsT",
            BasePath = "https://db-midterm-789ff.firebaseio.com/"
        };
        public Main()
        {
           
            InitializeComponent();
           
        }

        private void ts_startGame_Click(object sender, EventArgs e)
        {
            playform.MdiParent = this;
            playform.Show();
        }
    }
}
