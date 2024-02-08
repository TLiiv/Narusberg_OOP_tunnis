using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TL_OOP_Projekt_KTA_23E
{
    public partial class TL_Form_08_02_2024 : Form
    {
        int w, h;
        int x1, y1,x2,y2;
        Image pic = null;
        public TL_Form_08_02_2024()
        {
            InitializeComponent();
            w = TL_pic1.Width;
            h = TL_pic1.Height;

        }

        private void TL_Open_Click(object sender, EventArgs e)
        {
            //TL_openFileDialog1.Filter = "JPG failid|*.jpg|PNG failid|*.png|Kõik graf failid|*.jpg;*.png";
            string t = "JPG failid|*.jpg";
            t = t + "|PNG failid| *.png";
            t = t + "|Kõik graf failid| *.jpg; *.png;*.bmp";
            t = t + "|Kõik failid|*.*";
            TL_openFileDialog1.Filter = t;
            TL_openFileDialog1.FileName = "";
            TL_openFileDialog1.ShowDialog();
            string failinimi = TL_openFileDialog1.FileName;
            if (failinimi == "")
            {
                return;
            }
            TL_pic1.Image = Image.FromFile(failinimi);
            pic = Image.FromFile(failinimi);

        }

        private void TL_rbtn1_CheckedChanged(object sender, EventArgs e)
        {
            TL_pic1.Width = w;
            TL_pic1.Height = h;
            TL_pic1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void TL_rbtn2_CheckedChanged(object sender, EventArgs e)
        {
            TL_pic1.Width = w;
            TL_pic1.Height = h;
            TL_pic1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void TL_rbtn3_CheckedChanged(object sender, EventArgs e)
        {
            TL_pic1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void TL_pic1_MouseDown(object sender, MouseEventArgs e)
        {
            string t = e.Button.ToString(); // saame teada mis hiirenuppu on vajutatud(left right center)
            if (t != "Left")
            {
                return;
            }
            if(pic == null)
            {
                return;
            }
            x1 = e.X;
            y1 = e.Y;
        }

        private void TL_pic1_MouseUp(object sender, MouseEventArgs e)
        {
            string t = e.Button.ToString(); // saame teada mis nuppu on vajutatud(left right center)
            if (t != "Left")
            {
                return;
            }
            if (pic == null)
            {
                return;
            }
            x2 = e.X;
            y2 = e.Y;
            TL_Joonista(Color.Orange, 3);
        }
        

        private void TL_pic1_MouseMove(object sender, MouseEventArgs e)
        {
            string t = e.Button.ToString(); // saame teada mis nuppu on vajutatud(left right center)
            if (t != "Left")
            {
                return;
            }
            if (pic == null)
            {
                return;
            }
            x2 = e.X; //koordinaadid läbi evendi
            y2 = e.Y;
            TL_Joonista(Color.Orange, 1);
        }

        private void TL_Joonista(Color c,int k)
        {
            Bitmap bm = new Bitmap(pic);// et joonistada
            Graphics g = Graphics.FromImage(bm);
            Pen pencil = new Pen(c, k);
            int x0 = Math.Min(x1, x2);
            int y0 = Math.Min(y1, y2);
            int dx = Math.Abs(x2 - x1);
            int dy = Math.Abs(y2 - y1);
            g.DrawRectangle(pencil, x0, y0, dx, dy);
            TL_pic1.Image = bm;
        }

        private void TL_rbtn4_CheckedChanged(object sender, EventArgs e)
        {
            TL_pic1.Width = w;
            TL_pic1.Height = h;
            TL_pic1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void TL_rbtn5_CheckedChanged(object sender, EventArgs e)
        {
            TL_pic1.Width = w;
            TL_pic1.Height = h;
            TL_pic1.SizeMode = PictureBoxSizeMode.Zoom;
        }
        

        }
    }
