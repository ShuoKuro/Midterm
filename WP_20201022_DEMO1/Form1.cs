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
        int cheakClick;
        int countCorrect;
        int countWrong;
        int a;
        int b;
        int clickCounter;

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

            a = 9999;
            b = 8888;
            countCorrect = 0;
            countWrong = 0;
            clickCounter = 0;

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

        private void cheak()
        {
            switch (cheakClick)
            {
                case 1:
                    picCards1.Image = imagelist[poker[0] + 1];
                    a = poker[0] + 1;
                    break;
                case 2:
                    picCards2.Image = imagelist[poker[1] + 1];
                    a = poker[1] + 1;
                    break;
                case 3:
                    picCards3.Image = imagelist[poker[2] + 1];
                    a = poker[2] + 1;
                    break;
                case 4:
                    picCards4.Image = imagelist[poker[3] + 1];
                    a = poker[3] + 1;
                    break;
                case 5:
                    picCards5.Image = imagelist[poker[4] + 1];
                    a = poker[4] + 1;
                    break;
                case 6:
                    picCards6.Image = imagelist[poker[5] + 1];
                    a = poker[5] + 1;
                    break;
                case 7:
                    picCards7.Image = imagelist[poker[6] + 1];
                    a = poker[6] + 1;
                    break;
                case 8:
                    picCards8.Image = imagelist[poker[7] + 1];
                    a = poker[7] + 1;
                    break;
                case 9:
                    picCards9.Image = imagelist[poker[8] + 1];
                    a = poker[8] + 1;
                    break;
                case 10:
                    picCards10.Image = imagelist[poker[9] + 1];
                    a = poker[9] + 1;
                    break;
                case 11:
                    picCards11.Image = imagelist[poker[10] + 1];
                    a = poker[10] + 1;
                    break;
                case 12:
                    picCards12.Image = imagelist[poker[11] + 1];
                    a = poker[11] + 1;
                    break;
                case 13:
                    picCards13.Image = imagelist[poker[12] + 1];
                    a = poker[12] + 1;
                    break;
                case 14:
                    picCards14.Image = imagelist[poker[13] + 1];
                    a = poker[13] + 1;
                    break;
                case 15:
                    picCards15.Image = imagelist[poker[14] + 1];
                    a = poker[14] + 1;
                    break;
                case 16:
                    picCards16.Image = imagelist[poker[15] + 1];
                    a = poker[15] + 1;
                    break;
                case 17:
                    picCards17.Image = imagelist[poker[16] + 1];
                    a = poker[16] + 1;
                    break;
                case 18:
                    picCards18.Image = imagelist[poker[17] + 1];
                    a = poker[17] + 1;
                    break;
                case 19:
                    picCards19.Image = imagelist[poker[18] + 1];
                    a = poker[18] + 1;
                    break;
                case 20:
                    picCards20.Image = imagelist[poker[19] + 1];
                    a = poker[19] + 1;
                    break;
                case 21:
                    picCards21.Image = imagelist[poker[20] + 1];
                    a = poker[20] + 1;
                    break;
                case 22:
                    picCards22.Image = imagelist[poker[21] + 1];
                    a = poker[21] + 1;
                    break;
                case 23:
                    picCards23.Image = imagelist[poker[22] + 1];
                    a = poker[22] + 1;
                    break;
                case 24:
                    picCards24.Image = imagelist[poker[23] + 1];
                    a = poker[23] + 1;
                    break;
                case 25:
                    picCards25.Image = imagelist[poker[24] + 1];
                    a = poker[24] + 1;
                    break;
                case 26:
                    picCards26.Image = imagelist[poker[25] + 1];
                    a = poker[25] + 1;
                    break;
                case 27:
                    picCards27.Image = imagelist[poker[26] + 1];
                    a = poker[26] + 1;
                    break;
                case 28:
                    picCards28.Image = imagelist[poker[27] + 1];
                    a = poker[27] + 1;
                    break;
                case 29:
                    picCards29.Image = imagelist[poker[28] + 1];
                    a = poker[28] + 1;
                    break;
                case 30:
                    picCards30.Image = imagelist[poker[29] + 1];
                    a = poker[29] + 1;
                    break;
                case 31:
                    picCards31.Image = imagelist[poker[30] + 1];
                    a = poker[30] + 1;
                    break;
                case 32:
                    picCards32.Image = imagelist[poker[31] + 1];
                    a = poker[31] + 1;
                    break;



            }
            if (clickCounter > 2)
            {
                clickCounter = 0;
                if (a == b)
                {
                    countCorrect += 1;
                    labCorrect.Text = countCorrect + "";
                }
                if (a != b)
                {
                    countWrong += 1;
                    labWrong.Text = countWrong + "";
                }
                b = 8888;
            }
            else
            {
                clickCounter += 1;
                b = a;
            }
        }

            
        #region 按下pic
        private void picCards1_Click(object sender, EventArgs e)
        {
            cheakClick = 1;
            cheak();
        }

        private void picCards2_Click(object sender, EventArgs e)
        {
            cheakClick = 2;
            cheak();
        }

        private void picCards3_Click(object sender, EventArgs e)
        {
            cheakClick = 3;
            cheak();
        }

        private void picCards4_Click(object sender, EventArgs e)
        {
            cheakClick = 4;
            cheak();
        }

        private void picCards5_Click(object sender, EventArgs e)
        {
            cheakClick = 5;
            cheak();
        }

        private void picCards6_Click(object sender, EventArgs e)
        {
            cheakClick = 6;
            cheak();
        }

        private void picCards7_Click(object sender, EventArgs e)
        {
            cheakClick = 7;
            cheak();
        }

        private void picCards8_Click(object sender, EventArgs e)
        {
            cheakClick = 8;
            cheak();
        }

        private void picCards9_Click(object sender, EventArgs e)
        {
            cheakClick = 9;
            cheak();
        }

        private void picCards10_Click(object sender, EventArgs e)
        {
            cheakClick = 10;
            cheak();
        }

        private void picCards11_Click(object sender, EventArgs e)
        {
            cheakClick = 11;
            cheak();
        }

        private void picCards12_Click(object sender, EventArgs e)
        {
            cheakClick = 12;
            cheak();
        }

        private void picCards13_Click(object sender, EventArgs e)
        {
            cheakClick = 13;
            cheak();
        }

        private void picCards14_Click(object sender, EventArgs e)
        {
            cheakClick = 14;
            cheak();
        }

        private void picCards15_Click(object sender, EventArgs e)
        {
            cheakClick = 15;
            cheak();
        }

        private void picCards16_Click(object sender, EventArgs e)
        {
            cheakClick = 16;
            cheak();
        }

        private void picCards17_Click(object sender, EventArgs e)
        {
            cheakClick = 17;
            cheak();
        }

        private void picCards18_Click(object sender, EventArgs e)
        {
            cheakClick = 18;
            cheak();
        }

        private void picCards19_Click(object sender, EventArgs e)
        {
            cheakClick = 19;
            cheak();
        }

        private void picCards20_Click(object sender, EventArgs e)
        {
            cheakClick = 20;
            cheak();
        }

        private void picCards21_Click(object sender, EventArgs e)
        {
            cheakClick = 21;
            cheak();
        }

        private void picCards22_Click(object sender, EventArgs e)
        {
            cheakClick = 22;
            cheak();
        }

        private void picCards23_Click(object sender, EventArgs e)
        {
            cheakClick = 23;
            cheak();
        }

        private void picCards24_Click(object sender, EventArgs e)
        {
            cheakClick = 24;
            cheak();
        }

        private void picCards25_Click(object sender, EventArgs e)
        {
            cheakClick = 25;
            cheak();
        }

        private void picCards26_Click(object sender, EventArgs e)
        {
            cheakClick = 26;
            cheak();
        }

        private void picCards27_Click(object sender, EventArgs e)
        {
            cheakClick = 27;
            cheak();
        }

        private void picCards28_Click(object sender, EventArgs e)
        {
            cheakClick = 28;
            cheak();
        }

        private void picCards29_Click(object sender, EventArgs e)
        {
            cheakClick = 29;
            cheak();
        }

        private void picCards30_Click(object sender, EventArgs e)
        {
            cheakClick = 30;
            cheak();
        }

        private void picCards31_Click(object sender, EventArgs e)
        {
            cheakClick = 31;
            cheak();
        }

        private void picCards32_Click(object sender, EventArgs e)
        {
            cheakClick = 32;
            cheak();
        }
        #endregion


    }
}
