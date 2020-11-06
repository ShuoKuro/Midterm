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
        List<Image> imagelist = new List<Image>();
        Poker p = new Poker();
        List<int> poker;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            #region 加入图片
            imagelist.Add(Resources._000);
            imagelist.Add(Resources._001);
            imagelist.Add(Resources._002);
            imagelist.Add(Resources._003);
            imagelist.Add(Resources._004);
            imagelist.Add(Resources._005);
            imagelist.Add(Resources._006);
            imagelist.Add(Resources._007);
            imagelist.Add(Resources._008);
            imagelist.Add(Resources._009);
            imagelist.Add(Resources._010);
            imagelist.Add(Resources._011);
            imagelist.Add(Resources._012);
            imagelist.Add(Resources._013);
            imagelist.Add(Resources._014);
            imagelist.Add(Resources._015);
            imagelist.Add(Resources._016);
            #endregion

            coverUp();

            poker = p.GetPoker(32); //打乱
            for (int i = 0; i < poker.Count; i++)
            {
                if (poker[i] >= 16)
                {
                    poker[i] -= 16;
                }
            }

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            coverUp();
            poker = p.GetPoker(32); //打乱
            for (int i = 0; i < poker.Count; i++)
            {
                if (poker[i] >= 16)
                {
                    poker[i] -= 16;
                }
            }
        }


        /// <summary>
        /// 翻到卡背
        /// </summary>
        private void coverUp()
        {
            picCards1.Image = imagelist[0];
            picCards2.Image = imagelist[0];
            picCards3.Image = imagelist[0];
            picCards4.Image = imagelist[0];
            picCards5.Image = imagelist[0];
            picCards6.Image = imagelist[0];
            picCards7.Image = imagelist[0];
            picCards8.Image = imagelist[0];
            picCards9.Image = imagelist[0];
            picCards10.Image = imagelist[0];
            picCards11.Image = imagelist[0];
            picCards12.Image = imagelist[0];
            picCards13.Image = imagelist[0];
            picCards14.Image = imagelist[0];
            picCards15.Image = imagelist[0];
            picCards16.Image = imagelist[0];
            picCards17.Image = imagelist[0];
            picCards18.Image = imagelist[0];
            picCards19.Image = imagelist[0];
            picCards20.Image = imagelist[0];
            picCards21.Image = imagelist[0];
            picCards22.Image = imagelist[0];
            picCards23.Image = imagelist[0];
            picCards24.Image = imagelist[0];
            picCards25.Image = imagelist[0];
            picCards26.Image = imagelist[0];
            picCards27.Image = imagelist[0];
            picCards28.Image = imagelist[0];
            picCards29.Image = imagelist[0];
            picCards30.Image = imagelist[0];
            picCards31.Image = imagelist[0];
            picCards32.Image = imagelist[0];
        }



        #region 按下pic
        private void picCards1_Click(object sender, EventArgs e)
        {
            picCards1.Image = imagelist[poker[0] + 1];
        }

        private void picCards2_Click(object sender, EventArgs e)
        {
            picCards2.Image = imagelist[poker[1] + 1];
        }

        private void picCards3_Click(object sender, EventArgs e)
        {
            picCards3.Image = imagelist[poker[2] + 1];
        }

        private void picCards4_Click(object sender, EventArgs e)
        {
            picCards4.Image = imagelist[poker[3] + 1];
        }

        private void picCards5_Click(object sender, EventArgs e)
        {
            picCards5.Image = imagelist[poker[4] + 1];
        }

        private void picCards6_Click(object sender, EventArgs e)
        {
            picCards6.Image = imagelist[poker[5] + 1];
        }

        private void picCards7_Click(object sender, EventArgs e)
        {
            picCards7.Image = imagelist[poker[6] + 1];
        }

        private void picCards8_Click(object sender, EventArgs e)
        {
            picCards8.Image = imagelist[poker[7] + 1];
        }

        private void picCards9_Click(object sender, EventArgs e)
        {
            picCards9.Image = imagelist[poker[8] + 1];
        }

        private void picCards10_Click(object sender, EventArgs e)
        {
            picCards10.Image = imagelist[poker[9] + 1];
        }

        private void picCards11_Click(object sender, EventArgs e)
        {
            picCards11.Image = imagelist[poker[10] + 1];
        }

        private void picCards12_Click(object sender, EventArgs e)
        {
            picCards12.Image = imagelist[poker[11] + 1];
        }

        private void picCards13_Click(object sender, EventArgs e)
        {
            picCards13.Image = imagelist[poker[12] + 1];
        }

        private void picCards14_Click(object sender, EventArgs e)
        {
            picCards14.Image = imagelist[poker[13] + 1];
        }

        private void picCards15_Click(object sender, EventArgs e)
        {
            picCards15.Image = imagelist[poker[14] + 1];
        }

        private void picCards16_Click(object sender, EventArgs e)
        {
            picCards16.Image = imagelist[poker[15] + 1];
        }

        private void picCards17_Click(object sender, EventArgs e)
        {
            picCards17.Image = imagelist[poker[16] + 1];
        }

        private void picCards18_Click(object sender, EventArgs e)
        {
            picCards18.Image = imagelist[poker[17] + 1];
        }

        private void picCards19_Click(object sender, EventArgs e)
        {
            picCards19.Image = imagelist[poker[18] + 1];
        }

        private void picCards20_Click(object sender, EventArgs e)
        {
            picCards20.Image = imagelist[poker[19] + 1];
        }

        private void picCards21_Click(object sender, EventArgs e)
        {
            picCards21.Image = imagelist[poker[20] + 1];
        }

        private void picCards22_Click(object sender, EventArgs e)
        {
            picCards22.Image = imagelist[poker[21] + 1];
        }

        private void picCards23_Click(object sender, EventArgs e)
        {
            picCards23.Image = imagelist[poker[22] + 1];
        }

        private void picCards24_Click(object sender, EventArgs e)
        {
            picCards24.Image = imagelist[poker[23] + 1];
        }

        private void picCards25_Click(object sender, EventArgs e)
        {
            picCards25.Image = imagelist[poker[24] + 1];
        }

        private void picCards26_Click(object sender, EventArgs e)
        {
            picCards26.Image = imagelist[poker[25] + 1];
        }

        private void picCards27_Click(object sender, EventArgs e)
        {
            picCards27.Image = imagelist[poker[26] + 1];
        }

        private void picCards28_Click(object sender, EventArgs e)
        {
            picCards28.Image = imagelist[poker[27] + 1];
        }

        private void picCards29_Click(object sender, EventArgs e)
        {
            picCards29.Image = imagelist[poker[28] + 1];
        }

        private void picCards30_Click(object sender, EventArgs e)
        {
            picCards30.Image = imagelist[poker[29] + 1];
        }

        private void picCards31_Click(object sender, EventArgs e)
        {
            picCards31.Image = imagelist[poker[30] + 1];
        }

        private void picCards32_Click(object sender, EventArgs e)
        {
            picCards32.Image = imagelist[poker[31] + 1];
        }
        #endregion


    }
}
