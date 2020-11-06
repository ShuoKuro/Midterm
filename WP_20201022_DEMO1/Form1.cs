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
        int c;
        int lastClick;
        int clickCounter;
        bool covering;


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

            coverUPAll();

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
            coverUPAll();
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
        /// 所有翻到卡背
        /// </summary>
        private void coverUPAll()
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

        private void coverUP()
        {
            coverlist();
            cheakClick = lastClick;
            coverlist();
            clickCounter = 0;
        }
        private void clicking()
        {
            switch (cheakClick)
            {
                case 1:
                    a = poker[0] + 1;
                    cheak();
                    picCards1.Image = imagelist[c];
                    if (covering)
                    {
                        coverUP();
                        covering = false;
                    }
                    break;

                case 2:
                    a = poker[1] + 1;
                    cheak();
                    picCards2.Image = imagelist[c];
                    if (covering)
                    {
                        coverUP();
                        covering = false;
                    }
                    break;

                case 3:
                    a = poker[2] + 1;
                    cheak();
                    picCards3.Image = imagelist[c];
                    if (covering)
                    {
                        coverUP();
                        covering = false;
                    }
                    break;

                case 4:
                    a = poker[3] + 1;
                    cheak();
                    picCards4.Image = imagelist[c];
                    if (covering)
                    {
                        coverUP();
                        covering = false;
                    }
                    break;

                case 5:
                    a = poker[4] + 1;
                    cheak();
                    picCards5.Image = imagelist[c];
                    if (covering)
                    {
                        coverUP();
                        covering = false;
                    }
                    break;

                case 6:
                    a = poker[5] + 1;
                    cheak();
                    picCards6.Image = imagelist[c];
                    if (covering)
                    {
                        coverUP();
                        covering = false;
                    }
                    break;

                case 7:
                    a = poker[6] + 1;
                    cheak();
                    picCards7.Image = imagelist[c];
                    if (covering)
                    {
                        coverUP();
                        covering = false;
                    }
                    break;

                case 8:
                    a = poker[7] + 1;
                    cheak();
                    picCards8.Image = imagelist[c];
                    if (covering)
                    {
                        coverUP();
                        covering = false;
                    }
                    break;

                case 9:
                    a = poker[8] + 1;
                    cheak();
                    picCards9.Image = imagelist[c];
                    if (covering)
                    {
                        coverUP();
                        covering = false;
                    }
                    break;

                case 10:
                    a = poker[9] + 1;
                    cheak();
                    picCards10.Image = imagelist[c];
                    if (covering)
                    {
                        coverUP();
                        covering = false;
                    }
                    break;

                case 11:
                    a = poker[10] + 1;
                    cheak();
                    picCards11.Image = imagelist[c];
                    if (covering)
                    {
                        coverUP();
                        covering = false;
                    }
                    break;

                case 12:
                    a = poker[11] + 1;
                    cheak();
                    picCards12.Image = imagelist[c];
                    if (covering)
                    {
                        coverUP();
                        covering = false;
                    }
                    break;

                case 13:
                    a = poker[12] + 1;
                    cheak();
                    picCards13.Image = imagelist[c];
                    if (covering)
                    {
                        coverUP();
                        covering = false;
                    }
                    break;

                case 14:
                    a = poker[13] + 1;
                    cheak();
                    picCards14.Image = imagelist[c];
                    if (covering)
                    {
                        coverUP();
                        covering = false;
                    }
                    break;

                case 15:
                    a = poker[14] + 1;
                    cheak();
                    picCards15.Image = imagelist[c];
                    if (covering)
                    {
                        coverUP();
                        covering = false;
                    }
                    break;

                case 16:
                    a = poker[15] + 1;
                    cheak();
                    picCards16.Image = imagelist[c];
                    if (covering)
                    {
                        coverUP();
                        covering = false;
                    }
                    break;

                case 17:
                    a = poker[16] + 1;
                    cheak();
                    picCards17.Image = imagelist[c];
                    if (covering)
                    {
                        coverUP();
                        covering = false;
                    }
                    break;

                case 18:
                    a = poker[17] + 1;
                    cheak();
                    picCards18.Image = imagelist[c];
                    if (covering)
                    {
                        coverUP();
                        covering = false;
                    }
                    break;

                case 19:
                    a = poker[18] + 1;
                    cheak();
                    picCards19.Image = imagelist[c];
                    if (covering)
                    {
                        coverUP();
                        covering = false;
                    }
                    break;

                case 20:
                    a = poker[19] + 1;
                    cheak();
                    picCards20.Image = imagelist[c];
                    if (covering)
                    {
                        coverUP();
                        covering = false;
                    }
                    break;

                case 21:
                    a = poker[20] + 1;
                    cheak();
                    picCards21.Image = imagelist[c];
                    if (covering)
                    {
                        coverUP();
                        covering = false;
                    }
                    break;

                case 22:
                    a = poker[21] + 1;
                    cheak();
                    picCards22.Image = imagelist[c];
                    if (covering)
                    {
                        coverUP();
                        covering = false;
                    }
                    break;

                case 23:
                    a = poker[22] + 1;
                    cheak();
                    picCards23.Image = imagelist[c];
                    if (covering)
                    {
                        coverUP();
                        covering = false;
                    }
                    break;

                case 24:
                    a = poker[23] + 1;
                    cheak();
                    picCards24.Image = imagelist[c];
                    if (covering)
                    {
                        coverUP();
                        covering = false;
                    }
                    break;

                case 25:
                    a = poker[24] + 1;
                    cheak();
                    picCards25.Image = imagelist[c];
                    if (covering)
                    {
                        coverUP();
                        covering = false;
                    }
                    break;

                case 26:
                    a = poker[25] + 1;
                    cheak();
                    picCards26.Image = imagelist[c];
                    if (covering)
                    {
                        coverUP();
                        covering = false;
                    }
                    break;

                case 27:
                    a = poker[26] + 1;
                    cheak();
                    picCards27.Image = imagelist[c];
                    if (covering)
                    {
                        coverUP();
                        covering = false;
                    }
                    break;

                case 28:
                    a = poker[27] + 1;
                    cheak();
                    picCards28.Image = imagelist[c];
                    if (covering)
                    {
                        coverUP();
                        covering = false;
                    }
                    break;

                case 29:
                    a = poker[28] + 1;
                    cheak();
                    picCards29.Image = imagelist[c];
                    if (covering)
                    {
                        coverUP();
                        covering = false;
                    }
                    break;

                case 30:
                    a = poker[29] + 1;
                    cheak();
                    picCards30.Image = imagelist[c];
                    if (covering)
                    {
                        coverUP();
                        covering = false;
                    }
                    break;

                case 31:
                    a = poker[30] + 1;
                    cheak();
                    picCards31.Image = imagelist[c];
                    if (covering)
                    {
                        coverUP();
                        covering = false;
                    }
                    break;

                case 32:
                    a = poker[31] + 1;
                    cheak();
                    picCards32.Image = imagelist[c];
                    if (covering)
                    {
                        coverUP();
                        covering = false;
                    }
                    break;
            }
        }

        private void coverlist()
        {
            switch (cheakClick)
            {
                case 1:
                    picCards1.Image = imagelist[0];
                    break;

                case 2:
                    picCards2.Image = imagelist[0];
                    break;

                case 3:
                    picCards3.Image = imagelist[0];
                    break;

                case 4:
                    picCards4.Image = imagelist[0];
                    break;

                case 5:
                    picCards5.Image = imagelist[0];
                    break;

                case 6:
                    picCards6.Image = imagelist[0];
                    break;

                case 7:
                    picCards7.Image = imagelist[0];
                    break;

                case 8:
                    picCards8.Image = imagelist[0];
                    break;

                case 9:
                    picCards9.Image = imagelist[0];
                    break;

                case 10:
                    picCards10.Image = imagelist[0];
                    break;

                case 11:
                    picCards11.Image = imagelist[0];
                    break;

                case 12:
                    picCards12.Image = imagelist[0];
                    break;

                case 13:
                    picCards13.Image = imagelist[0];
                    break;

                case 14:
                    picCards14.Image = imagelist[0];
                    break;

                case 15:
                    picCards15.Image = imagelist[0];
                    break;

                case 16:
                    picCards16.Image = imagelist[0];
                    break;

                case 17:
                    picCards17.Image = imagelist[0];
                    break;

                case 18:
                    picCards18.Image = imagelist[0];
                    break;

                case 19:
                    picCards19.Image = imagelist[0];
                    break;

                case 20:
                    picCards20.Image = imagelist[0];
                    break;

                case 21:
                    picCards21.Image = imagelist[0];
                    break;

                case 22:
                    picCards22.Image = imagelist[0];
                    break;

                case 23:
                    picCards23.Image = imagelist[0];
                    break;

                case 24:
                    picCards24.Image = imagelist[0];
                    break;

                case 25:
                    picCards25.Image = imagelist[0];
                    break;

                case 26:
                    picCards26.Image = imagelist[0];
                    break;

                case 27:
                    picCards27.Image = imagelist[0];
                    break;

                case 28:
                    picCards28.Image = imagelist[0];
                    break;

                case 29:
                    picCards29.Image = imagelist[0];
                    break;

                case 30:
                    picCards30.Image = imagelist[0];
                    break;

                case 31:
                    picCards31.Image = imagelist[0];
                    break;

                case 32:
                    picCards32.Image = imagelist[0];
                    break;
            }
        }

        private void cheak()
        {
            if (clickCounter > 1)
            {
                
                if (a == b)
                {
                    countCorrect += 1;
                    labCorrect.Text = countCorrect + "";
                    clickCounter = 0;
                    c = a;
                }
                if (a != b)
                {
                    countWrong += 1;
                    labWrong.Text = countWrong + "";
                    c = a;
                    covering = true;
                }
            }
            else
            {
                lastClick = cheakClick;
                c = a;
                b = a; //记下上一次按的什么
            }

        }


        #region 按下pic
        private void picCards1_Click(object sender, EventArgs e)
        {
            cheakClick = 1;
            clickCounter += 1;
            clicking();
        }

        private void picCards2_Click(object sender, EventArgs e)
        {
            cheakClick = 2;
            clickCounter += 1;
            clicking();
        }

        private void picCards3_Click(object sender, EventArgs e)
        {
            cheakClick = 3;
            clickCounter += 1;
            clicking();
        }

        private void picCards4_Click(object sender, EventArgs e)
        {
            cheakClick = 4;
            clickCounter += 1;
            clicking();
        }

        private void picCards5_Click(object sender, EventArgs e)
        {
            cheakClick = 5;
            clickCounter += 1;
            clicking();
        }

        private void picCards6_Click(object sender, EventArgs e)
        {
            cheakClick = 6;
            clickCounter += 1;
            clicking();
        }

        private void picCards7_Click(object sender, EventArgs e)
        {
            cheakClick = 7;
            clickCounter += 1;
            clicking();
        }

        private void picCards8_Click(object sender, EventArgs e)
        {
            cheakClick = 8;
            clickCounter += 1;
            clicking();
        }

        private void picCards9_Click(object sender, EventArgs e)
        {
            cheakClick = 9;
            clickCounter += 1;
            clicking();
        }

        private void picCards10_Click(object sender, EventArgs e)
        {
            cheakClick = 10;
            clickCounter += 1;
            clicking();
        }

        private void picCards11_Click(object sender, EventArgs e)
        {
            cheakClick = 11;
            clickCounter += 1;
            clicking();
        }

        private void picCards12_Click(object sender, EventArgs e)
        {
            cheakClick = 12;
            clickCounter += 1;
            clicking();
        }

        private void picCards13_Click(object sender, EventArgs e)
        {
            cheakClick = 13;
            clickCounter += 1;
            clicking();
        }

        private void picCards14_Click(object sender, EventArgs e)
        {
            cheakClick = 14;
            clickCounter += 1;
            clicking();
        }

        private void picCards15_Click(object sender, EventArgs e)
        {
            cheakClick = 15;
            clickCounter += 1;
            clicking();
        }

        private void picCards16_Click(object sender, EventArgs e)
        {
            cheakClick = 16;
            clickCounter += 1;
            clicking();
        }

        private void picCards17_Click(object sender, EventArgs e)
        {
            cheakClick = 17;
            clickCounter += 1;
            clicking();
        }

        private void picCards18_Click(object sender, EventArgs e)
        {
            cheakClick = 18;
            clickCounter += 1;
            clicking();
        }

        private void picCards19_Click(object sender, EventArgs e)
        {
            cheakClick = 19;
            clickCounter += 1;
            clicking();
        }

        private void picCards20_Click(object sender, EventArgs e)
        {
            cheakClick = 20;
            clickCounter += 1;
            clicking();
        }

        private void picCards21_Click(object sender, EventArgs e)
        {
            cheakClick = 21;
            clickCounter += 1;
            clicking();
        }

        private void picCards22_Click(object sender, EventArgs e)
        {
            cheakClick = 22;
            clickCounter += 1;
            clicking();
        }

        private void picCards23_Click(object sender, EventArgs e)
        {
            cheakClick = 23;
            clickCounter += 1;
            clicking();
        }

        private void picCards24_Click(object sender, EventArgs e)
        {
            cheakClick = 24;
            clickCounter += 1;
            clicking();
        }

        private void picCards25_Click(object sender, EventArgs e)
        {
            cheakClick = 25;
            clickCounter += 1;
            clicking();
        }

        private void picCards26_Click(object sender, EventArgs e)
        {
            cheakClick = 26;
            clickCounter += 1;
            clicking();
        }

        private void picCards27_Click(object sender, EventArgs e)
        {
            cheakClick = 27;
            clickCounter += 1;
            clicking();
        }

        private void picCards28_Click(object sender, EventArgs e)
        {
            cheakClick = 28;
            clickCounter += 1;
            clicking();
        }

        private void picCards29_Click(object sender, EventArgs e)
        {
            cheakClick = 29;
            clickCounter += 1;
            clicking();
        }

        private void picCards30_Click(object sender, EventArgs e)
        {
            cheakClick = 30;
            clickCounter += 1;
            clicking();
        }

        private void picCards31_Click(object sender, EventArgs e)
        {
            cheakClick = 31;
            clickCounter += 1;
            clicking();
        }

        private void picCards32_Click(object sender, EventArgs e)
        {
            cheakClick = 32;
            clickCounter += 1;
            clicking();
        }
        #endregion


    }
}
