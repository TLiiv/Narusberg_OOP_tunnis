using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TL_OOP_Projekt_KTA_23E
{
    public partial class TL_form_22_02_2024 : Form
    {
        Image pic = null;
        int w,h;
        int kx = 3,ky = 4;
        PictureBox[] TL_PicMas1;
        PictureBox[] TL_PicMas2;
        public TL_form_22_02_2024()
        {
            
            InitializeComponent();
            TL_PicMas1 = new PictureBox[kx*ky];
            TL_PicMas2 = new PictureBox[kx*ky];
        }

        private void TL_Game_Click(object sender, EventArgs e)
        {
            int k = kx * ky;
            int ww = w / kx;
            int hh = h / ky;
            for (int i = 0; i < k; i++)
            {
                //ruudud pildi peal
                TL_PicMas2[i] = new PictureBox();
                TL_Pic2.Controls.Add(TL_PicMas2[i]);
                TL_PicMas2[i].Click += new EventHandler(TL_PicMas2_Click);
                TL_PicMas2[i].Width = ww;
                TL_PicMas2[i].Height = hh;
                TL_PicMas2[i].BackColor = Color.White;
                TL_PicMas2[i].BorderStyle = BorderStyle.FixedSingle;

                int row = i / kx;
                int col = i % kx;
                TL_PicMas2[i].Left = col * w / kx;
                TL_PicMas2[i].Top = row * h / ky;

            }
            for (int i = 0; i < k; i++)
            {
                TL_PicMas2[i].Image = TL_PicMas1[i].Image;
            }
        }

        private void TL_PicMas1_Click(object sender, EventArgs e)
        {
            int n1 = Array.IndexOf(TL_PicMas1,(PictureBox)sender);
            this.Text = n1.ToString();

        }
        private void TL_PicMas2_Click(object sender, EventArgs e)
        {
            int n2 = Array.IndexOf(TL_PicMas2, (PictureBox)sender);
            this.Text = n2.ToString();

        }

        private void TL_Open_Click(object sender, EventArgs e)
        {

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
            w = pic.Width;
            h = pic.Height;
            TL_Pic2.Width = w;
            TL_Pic2.Height = h;
            TL_Pic2.Left = TL_pic1.Left + w + 20;
        }

        private void TL_Array_Click(object sender, EventArgs e)
        {
            int k = kx * ky;
            int ww = w / kx;
            int hh = h / ky;
            for(int i  = 0; i < k; i++)
            {
                //ruudud pildi peal
                TL_PicMas1[i] = new PictureBox();
                TL_pic1.Controls.Add(TL_PicMas1[i]);
                TL_PicMas1[i].Click += new EventHandler(TL_PicMas1_Click);
                TL_PicMas1[i].Width = ww;
                TL_PicMas1[i].Height = hh;
                TL_PicMas1[i].BackColor = Color.White;
                TL_PicMas1[i].BorderStyle = BorderStyle.FixedSingle;
                
                int row = i / kx;
                int col = i % kx;
                TL_PicMas1[i].Left = col * w/kx;
                TL_PicMas1[i].Top = row * h/ky;
                //ruudu täide
                Bitmap area = new Bitmap(ww, hh);
                Graphics g = Graphics.FromImage(area);
                Rectangle in_rectangle = new Rectangle(col * ww, row*hh, ww,hh);
                Rectangle out_rectangle = new Rectangle(0,0, ww, hh);
                g.DrawImage(TL_pic1.Image,out_rectangle,in_rectangle, GraphicsUnit.Pixel);
                TL_PicMas1[i].Image = area;
            }
            
        }
    }
}
