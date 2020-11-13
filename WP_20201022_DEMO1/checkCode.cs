using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WP_20201022_DEMO1
{
    public class checkCode
    {
        public static string createRandomCode(int codeLength)
        {
            int rand;
            char code;
            string randomCode = string.Empty;

            Random random = new Random();
            for (int i = 0; i < codeLength; i++)
            {
                rand = random.Next();
                if (rand % 3 == 1)
                {
                    code = (char)('A' + (char)(rand % 26));
                }
                else if (rand % 3 == 2)
                {
                    code = (char)('a' + (char)(rand % 26));
                }
                else
                {
                    code = (char)('0' + (char)(rand % 10));
                }
                randomCode += code.ToString();
            }
            return randomCode;
        }

        public static void createImage(string strValidCode, PictureBox pbox)
        {
            try
            {
                int randAngle = 45;
                int mapWidth = (int)(strValidCode.Length * 21);
                Bitmap map = new Bitmap(mapWidth, 28);

                Graphics graph = Graphics.FromImage(map);
                graph.Clear(Color.AliceBlue);
                graph.DrawRectangle(new Pen(Color.Black, 0), 0, 0, map.Width - 1, map.Height - 1);
                graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                Random rand = new Random();

                Pen blackPen = new Pen(Color.LightGray, 0);
                for (int i = 0; i < 50; i++)
                {
                    int x = rand.Next(0, map.Width);
                    int y = rand.Next(0, map.Height);
                    graph.DrawRectangle(blackPen, x, y, 1, 1);
                }

                char[] chars = strValidCode.ToCharArray();
                StringFormat format = new StringFormat(StringFormatFlags.NoClip);
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;

                Color[] c = { Color.Black, Color.Red, Color.DarkBlue, Color.Green, Color.Orange, Color.Brown, Color.DarkCyan, Color.Purple };

                string[] font = { "Verdana", "Microsoft Sans Serif", "Comic Sans MS", "Arial"};
                for (int i = 0; i < chars.Length; i++)
                {
                    int cIndex = rand.Next(8);
                    int fIndex = rand.Next(4);
                    Font f = new System.Drawing.Font(font[fIndex], 13, System.Drawing.FontStyle.Bold);
                    Brush b = new System.Drawing.SolidBrush(c[cIndex]);
                    Point dot = new Point(16, 16);

                    float angle = rand.Next(-randAngle, randAngle);
                    graph.TranslateTransform(dot.X, dot.Y);
                    graph.RotateTransform(angle);
                    graph.DrawString(chars[i].ToString(), f, b, 1, 1, format);

                    graph.RotateTransform(-angle);
                    graph.TranslateTransform(2, -dot.Y);
                }
                pbox.Image = map;
            }
            catch (Exception)
            {
                MessageBox.Show("图片建立失败!!");
                throw;
            }
        }
    }
}
