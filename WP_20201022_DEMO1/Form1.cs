using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP_20201022_DEMO1.Properties;

namespace WP_20201022_DEMO1
{
    public partial class Form1 : Form
    {
        List<Image> list = new List<Image>();
        Poker p = new Poker();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            #region 加入图片
            list.Add(Resources._000);
            list.Add(Resources._001);
            list.Add(Resources._002);
            list.Add(Resources._003);
            list.Add(Resources._004);
            list.Add(Resources._005);
            list.Add(Resources._006);
            list.Add(Resources._007);
            list.Add(Resources._008);
            list.Add(Resources._009);
            list.Add(Resources._010);
            list.Add(Resources._011);
            list.Add(Resources._012);
            list.Add(Resources._013);
            list.Add(Resources._014);
            list.Add(Resources._015);
            list.Add(Resources._016);
            #endregion

            coverUp();

            List<int> poker = p.GetPoker(32); //打乱图片
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            List<int> poker = p.GetPoker(32);


            string msg = "";
            for (int i = 0; i < poker.Count; i++)
            {
                msg += $"{poker[i]} ,";
            }
        }


        /// <summary>
        /// 翻到卡背
        /// </summary>
        private void coverUp()
        {
            picCards1.Image = list[0];
            picCards2.Image = list[0];
            picCards3.Image = list[0];
            picCards4.Image = list[0];
            picCards5.Image = list[0];
            picCards6.Image = list[0];
            picCards7.Image = list[0];
            picCards8.Image = list[0];
            picCards9.Image = list[0];
            picCards10.Image = list[0];
            picCards11.Image = list[0];
            picCards12.Image = list[0];
            picCards13.Image = list[0];
            picCards14.Image = list[0];
            picCards15.Image = list[0];
            picCards16.Image = list[0];
            picCards17.Image = list[0];
            picCards18.Image = list[0];
            picCards19.Image = list[0];
            picCards20.Image = list[0];
            picCards21.Image = list[0];
            picCards22.Image = list[0];
            picCards23.Image = list[0];
            picCards24.Image = list[0];
            picCards25.Image = list[0];
            picCards26.Image = list[0];
            picCards27.Image = list[0];
            picCards28.Image = list[0];
            picCards29.Image = list[0];
            picCards30.Image = list[0];
            picCards31.Image = list[0];
            picCards32.Image = list[0];
        }

    }
}
