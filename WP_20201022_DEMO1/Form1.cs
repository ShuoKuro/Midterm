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
        int index;
        int lastIndex;
        int showIndex;
        int lastClick;
        int clickCounter;
        bool coverIt;


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

            //把卡背显示在每个picbox上
            coverUPAll();

            //预设值
            index = 9999;
            lastIndex = 8888;
            countCorrect = 0;
            countWrong = 0;
            clickCounter = 0;

            //打乱
            poker = p.GetPoker(32); 
            for (int i = 0; i < poker.Count; i++)
            {
                //制造重复的值
                if (poker[i] >= 16)
                {
                    poker[i] -= 16;
                }
            }

        }

        /// <summary>
        /// 重新打乱一次
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGo_Click(object sender, EventArgs e)
        {
            coverUPAll();
            poker = p.GetPoker(32); 
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

        /// <summary>
        /// 把现在这一张和上一张翻到卡背
        /// </summary>
        private void coverUP()
        {
            coverlist();
            cheakClick = lastClick;
            coverlist();
            clickCounter = 0;
        }

        /// <summary>
        /// 当图片被按下
        /// </summary>
        private void clicking()
        {
            switch (cheakClick)
            {
                case 1:
                    index = poker[0] + 1;
                    cheak();
                    picCards1.Image = imagelist[showIndex];
                    break;

                case 2:
                    index = poker[1] + 1;
                    cheak();
                    picCards2.Image = imagelist[showIndex];
                    break;

                case 3:
                    index = poker[2] + 1;
                    cheak();
                    picCards3.Image = imagelist[showIndex];
                    break;

                case 4:
                    index = poker[3] + 1;
                    cheak();
                    picCards4.Image = imagelist[showIndex];
                    break;

                case 5:
                    index = poker[4] + 1;
                    cheak();
                    picCards5.Image = imagelist[showIndex];
                    break;

                case 6:
                    index = poker[5] + 1;
                    cheak();
                    picCards6.Image = imagelist[showIndex];
                    break;

                case 7:
                    index = poker[6] + 1;
                    cheak();
                    picCards7.Image = imagelist[showIndex];
                    break;

                case 8:
                    index = poker[7] + 1;
                    cheak();
                    picCards8.Image = imagelist[showIndex];
                    break;

                case 9:
                    index = poker[8] + 1;
                    cheak();
                    picCards9.Image = imagelist[showIndex];
                    break;

                case 10:
                    index = poker[9] + 1;
                    cheak();
                    picCards10.Image = imagelist[showIndex];
                    break;

                case 11:
                    index = poker[10] + 1;
                    cheak();
                    picCards11.Image = imagelist[showIndex];
                    break;

                case 12:
                    index = poker[11] + 1;
                    cheak();
                    picCards12.Image = imagelist[showIndex];
                    break;

                case 13:
                    index = poker[12] + 1;
                    cheak();
                    picCards13.Image = imagelist[showIndex];
                    break;

                case 14:
                    index = poker[13] + 1;
                    cheak();
                    picCards14.Image = imagelist[showIndex];
                    break;

                case 15:
                    index = poker[14] + 1;
                    cheak();
                    picCards15.Image = imagelist[showIndex];
                    break;

                case 16:
                    index = poker[15] + 1;
                    cheak();
                    picCards16.Image = imagelist[showIndex];
                    break;

                case 17:
                    index = poker[16] + 1;
                    cheak();
                    picCards17.Image = imagelist[showIndex];
                    break;

                case 18:
                    index = poker[17] + 1;
                    cheak();
                    picCards18.Image = imagelist[showIndex];
                    break;

                case 19:
                    index = poker[18] + 1;
                    cheak();
                    picCards19.Image = imagelist[showIndex];
                    break;

                case 20:
                    index = poker[19] + 1;
                    cheak();
                    picCards20.Image = imagelist[showIndex];
                    break;

                case 21:
                    index = poker[20] + 1;
                    cheak();
                    picCards21.Image = imagelist[showIndex];
                    break;

                case 22:
                    index = poker[21] + 1;
                    cheak();
                    picCards22.Image = imagelist[showIndex];
                    break;

                case 23:
                    index = poker[22] + 1;
                    cheak();
                    picCards23.Image = imagelist[showIndex];
                    break;

                case 24:
                    index = poker[23] + 1;
                    cheak();
                    picCards24.Image = imagelist[showIndex];
                    break;

                case 25:
                    index = poker[24] + 1;
                    cheak();
                    picCards25.Image = imagelist[showIndex];
                    break;

                case 26:
                    index = poker[25] + 1;
                    cheak();
                    picCards26.Image = imagelist[showIndex];
                    break;

                case 27:
                    index = poker[26] + 1;
                    cheak();
                    picCards27.Image = imagelist[showIndex];
                    break;

                case 28:
                    index = poker[27] + 1;
                    cheak();
                    picCards28.Image = imagelist[showIndex];
                    break;

                case 29:
                    index = poker[28] + 1;
                    cheak();
                    picCards29.Image = imagelist[showIndex];
                    break;

                case 30:
                    index = poker[29] + 1;
                    cheak();
                    picCards30.Image = imagelist[showIndex];
                    break;

                case 31:
                    index = poker[30] + 1;
                    cheak();
                    picCards31.Image = imagelist[showIndex];
                    break;

                case 32:
                    index = poker[31] + 1;
                    cheak();
                    picCards32.Image = imagelist[showIndex];
                    break;
            }
        }

        /// <summary>
        /// 使某个图片需要翻到卡背
        /// </summary>
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

        /// <summary>
        /// 检查正确还是错误
        /// </summary>
        private void cheak()
        {
            switch (clickCounter)
            {
                case 1:
                    lastClick = cheakClick;
                    showIndex = index; //显示a
                    lastIndex = index; //记下上一次按的什么
                    break;
                case 2:
                    showIndex = index;
                    clickCounter = 0;
                    if (index == lastIndex)
                    {
                        countCorrect += 1;
                        labCorrect.Text = countCorrect + "";
                    }
                    if (index != lastIndex)
                    {
                        countWrong += 1;
                        labWrong.Text = countWrong + "";
                        coverIt = true;
                    }
                    break;
            }
        }

        #region 按下pic
        private void picCards1_Click(object sender, EventArgs e)
        {
            if (picCards1.Image == imagelist[0])
            {
                cheakClick = 1;
                clickCounter += 1;
                clicking();
            }
        }

        private void picCards2_Click(object sender, EventArgs e)
        {
            if (picCards2.Image == imagelist[0])
            {
                cheakClick = 2;
                clickCounter += 1;
                clicking();
            }

        }

        private void picCards3_Click(object sender, EventArgs e)
        {
            if (picCards3.Image == imagelist[0])
            {
                cheakClick = 3;
                clickCounter += 1;
                clicking();
            }

        }

        private void picCards4_Click(object sender, EventArgs e)
        {
            if (picCards4.Image == imagelist[0])
            {
                cheakClick = 4;
                clickCounter += 1;
                clicking();
            }

        }

        private void picCards5_Click(object sender, EventArgs e)
        {
            if (picCards5.Image == imagelist[0])
            {
                cheakClick = 5;
                clickCounter += 1;
                clicking();
            }

        }

        private void picCards6_Click(object sender, EventArgs e)
        {
            if (picCards6.Image == imagelist[0])
            {
                cheakClick = 6;
                clickCounter += 1;
                clicking();
            }

        }

        private void picCards7_Click(object sender, EventArgs e)
        {
            if (picCards7.Image == imagelist[0])
            {
                cheakClick = 7;
                clickCounter += 1;
                clicking();
            }

        }

        private void picCards8_Click(object sender, EventArgs e)
        {
            if (picCards8.Image == imagelist[0])
            {
                cheakClick = 8;
                clickCounter += 1;
                clicking();
            }

        }

        private void picCards9_Click(object sender, EventArgs e)
        {
            if (picCards9.Image == imagelist[0])
            {
                cheakClick = 9;
                clickCounter += 1;
                clicking();
            }

        }

        private void picCards10_Click(object sender, EventArgs e)
        {
            if (picCards10.Image == imagelist[0])
            {
                cheakClick = 10;
                clickCounter += 1;
                clicking();
            }

        }

        private void picCards11_Click(object sender, EventArgs e)
        {
            if (picCards11.Image == imagelist[0])
            {
                cheakClick = 11;
                clickCounter += 1;
                clicking();
            }

        }

        private void picCards12_Click(object sender, EventArgs e)
        {
            if (picCards12.Image == imagelist[0])
            {
                cheakClick = 12;
                clickCounter += 1;
                clicking();
            }

        }

        private void picCards13_Click(object sender, EventArgs e)
        {
            if (picCards13.Image == imagelist[0])
            {
                cheakClick = 13;
                clickCounter += 1;
                clicking();
            }

        }

        private void picCards14_Click(object sender, EventArgs e)
        {
            if (picCards14.Image == imagelist[0])
            {
                cheakClick = 14;
                clickCounter += 1;
                clicking();
            }

        }

        private void picCards15_Click(object sender, EventArgs e)
        {
            if (picCards15.Image == imagelist[0])
            {
                cheakClick = 15;
                clickCounter += 1;
                clicking();
            }

        }

        private void picCards16_Click(object sender, EventArgs e)
        {
            if (picCards16.Image == imagelist[0])
            {
                cheakClick = 16;
                clickCounter += 1;
                clicking();
            }

        }

        private void picCards17_Click(object sender, EventArgs e)
        {
            if (picCards17.Image == imagelist[0])
            {
                cheakClick = 17;
                clickCounter += 1;
                clicking();
            }

        }

        private void picCards18_Click(object sender, EventArgs e)
        {
            if (picCards18.Image == imagelist[0])
            {
                cheakClick = 18;
                clickCounter += 1;
                clicking();
            }

        }

        private void picCards19_Click(object sender, EventArgs e)
        {
            if (picCards19.Image == imagelist[0])
            {
                cheakClick = 19;
                clickCounter += 1;
                clicking();
            }

        }

        private void picCards20_Click(object sender, EventArgs e)
        {
            if (picCards20.Image == imagelist[0])
            {
                cheakClick = 20;
                clickCounter += 1;
                clicking();
            }

        }

        private void picCards21_Click(object sender, EventArgs e)
        {
            if (picCards21.Image == imagelist[0])
            {
                cheakClick = 21;
                clickCounter += 1;
                clicking();
            }

        }

        private void picCards22_Click(object sender, EventArgs e)
        {
            if (picCards22.Image == imagelist[0])
            {
                cheakClick = 22;
                clickCounter += 1;
                clicking();
            }

        }

        private void picCards23_Click(object sender, EventArgs e)
        {
            if (picCards23.Image == imagelist[0])
            {
                cheakClick = 23;
                clickCounter += 1;
                clicking();
            }

        }

        private void picCards24_Click(object sender, EventArgs e)
        {
            if (picCards24.Image == imagelist[0])
            {
                cheakClick = 24;
                clickCounter += 1;
                clicking();
            }

        }

        private void picCards25_Click(object sender, EventArgs e)
        {
            if (picCards25.Image == imagelist[0])
            {
                cheakClick = 25;
                clickCounter += 1;
                clicking();
            }

        }

        private void picCards26_Click(object sender, EventArgs e)
        {
            if (picCards26.Image == imagelist[0])
            {
                cheakClick = 26;
                clickCounter += 1;
                clicking();
            }

        }

        private void picCards27_Click(object sender, EventArgs e)
        {
            if (picCards27.Image == imagelist[0])
            {
                cheakClick = 27;
                clickCounter += 1;
                clicking();
            }

        }

        private void picCards28_Click(object sender, EventArgs e)
        {
            if (picCards28.Image == imagelist[0])
            {
                cheakClick = 28;
                clickCounter += 1;
                clicking();
            }

        }

        private void picCards29_Click(object sender, EventArgs e)
        {
            if (picCards29.Image == imagelist[0])
            {
                cheakClick = 29;
                clickCounter += 1;
                clicking();
            }

        }

        private void picCards30_Click(object sender, EventArgs e)
        {
            if (picCards30.Image == imagelist[0])
            {
                cheakClick = 30;
                clickCounter += 1;
                clicking();
            }

        }

        private void picCards31_Click(object sender, EventArgs e)
        {
            if (picCards31.Image == imagelist[0])
            {
                cheakClick = 31;
                clickCounter += 1;
                clicking();
            }

        }

        private void picCards32_Click(object sender, EventArgs e)
        {
            if (picCards32.Image == imagelist[0])
            {
                cheakClick = 32;
                clickCounter += 1;
                clicking();
            }

        }

        #endregion

        #region 检查
        private void picCards1_MouseLeave(object sender, EventArgs e)
        {
            if (coverIt)
            {
                coverUP();
                coverIt = false;
            }
        }

        private void picCards2_MouseLeave(object sender, EventArgs e)
        {
            if (coverIt)
            {
                coverUP();
                coverIt = false;
            }
        }

        private void picCards3_MouseLeave(object sender, EventArgs e)
        {
            if (coverIt)
            {
                coverUP();
                coverIt = false;
            }
        }

        private void picCards4_MouseLeave(object sender, EventArgs e)
        {
            if (coverIt)
            {
                coverUP();
                coverIt = false;
            }
        }

        private void picCards5_MouseLeave(object sender, EventArgs e)
        {
            if (coverIt)
            {
                coverUP();
                coverIt = false;
            }
        }

        private void picCards6_MouseLeave(object sender, EventArgs e)
        {
            if (coverIt)
            {
                coverUP();
                coverIt = false;
            }
        }

        private void picCards7_MouseLeave(object sender, EventArgs e)
        {
            if (coverIt)
            {
                coverUP();
                coverIt = false;
            }
        }

        private void picCards8_MouseLeave(object sender, EventArgs e)
        {
            if (coverIt)
            {
                coverUP();
                coverIt = false;
            }
        }

        private void picCards9_MouseLeave(object sender, EventArgs e)
        {
            if (coverIt)
            {
                coverUP();
                coverIt = false;
            }
        }

        private void picCards10_MouseLeave(object sender, EventArgs e)
        {
            if (coverIt)
            {
                coverUP();
                coverIt = false;
            }
        }

        private void picCards11_MouseLeave(object sender, EventArgs e)
        {
            if (coverIt)
            {
                coverUP();
                coverIt = false;
            }
        }

        private void picCards12_MouseLeave(object sender, EventArgs e)
        {
            if (coverIt)
            {
                coverUP();
                coverIt = false;
            }
        }

        private void picCards13_MouseLeave(object sender, EventArgs e)
        {
            if (coverIt)
            {
                coverUP();
                coverIt = false;
            }
        }

        private void picCards14_MouseLeave(object sender, EventArgs e)
        {
            if (coverIt)
            {
                coverUP();
                coverIt = false;
            }
        }

        private void picCards15_MouseLeave(object sender, EventArgs e)
        {
            if (coverIt)
            {
                coverUP();
                coverIt = false;
            }
        }

        private void picCards16_MouseLeave(object sender, EventArgs e)
        {
            if (coverIt)
            {
                coverUP();
                coverIt = false;
            }
        }

        private void picCards17_MouseLeave(object sender, EventArgs e)
        {
            if (coverIt)
            {
                coverUP();
                coverIt = false;
            }
        }

        private void picCards18_MouseLeave(object sender, EventArgs e)
        {
            if (coverIt)
            {
                coverUP();
                coverIt = false;
            }
        }

        private void picCards19_MouseLeave(object sender, EventArgs e)
        {
            if (coverIt)
            {
                coverUP();
                coverIt = false;
            }
        }

        private void picCards20_MouseLeave(object sender, EventArgs e)
        {
            if (coverIt)
            {
                coverUP();
                coverIt = false;
            }
        }

        private void picCards21_MouseLeave(object sender, EventArgs e)
        {
            if (coverIt)
            {
                coverUP();
                coverIt = false;
            }
        }

        private void picCards22_MouseLeave(object sender, EventArgs e)
        {
            if (coverIt)
            {
                coverUP();
                coverIt = false;
            }
        }

        private void picCards23_MouseLeave(object sender, EventArgs e)
        {
            if (coverIt)
            {
                coverUP();
                coverIt = false;
            }
        }

        private void picCards24_MouseLeave(object sender, EventArgs e)
        {
            if (coverIt)
            {
                coverUP();
                coverIt = false;
            }
        }

        private void picCards25_MouseLeave(object sender, EventArgs e)
        {
            if (coverIt)
            {
                coverUP();
                coverIt = false;
            }
        }

        private void picCards26_MouseLeave(object sender, EventArgs e)
        {
            if (coverIt)
            {
                coverUP();
                coverIt = false;
            }
        }

        private void picCards27_MouseLeave(object sender, EventArgs e)
        {
            if (coverIt)
            {
                coverUP();
                coverIt = false;
            }
        }

        private void picCards28_MouseLeave(object sender, EventArgs e)
        {
            if (coverIt)
            {
                coverUP();
                coverIt = false;
            }
        }

        private void picCards29_MouseLeave(object sender, EventArgs e)
        {
            if (coverIt)
            {
                coverUP();
                coverIt = false;
            }
        }

        private void picCards30_MouseLeave(object sender, EventArgs e)
        {
            if (coverIt)
            {
                coverUP();
                coverIt = false;
            }
        }

        private void picCards31_MouseLeave(object sender, EventArgs e)
        {
            if (coverIt)
            {
                coverUP();
                coverIt = false;
            }
        }

        private void picCards32_MouseLeave(object sender, EventArgs e)
        {
            if (coverIt)
            {
                coverUP();
                coverIt = false;
            }
        }
        #endregion
    }
}
