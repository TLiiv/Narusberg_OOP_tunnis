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
    public partial class TL_Form_07_03_2024 : Form
    {
        int kx = 4, ky = 4;
        Button[] TL_btnArr;
        int dx, dy;//nuppude suurus
        Random rnd = new Random();

        public TL_Form_07_03_2024()
        {
            InitializeComponent();
            TL_btnArr = new Button[kx*ky]; //Mitu nuppu on vaja genereerida
            dx = TL_frame1.Width / kx; 
            dy = TL_frame1.Height / ky;
            Massiivi_Loomine();
            TL_Numbrid();
        }

        public void Massiivi_Loomine()
        {
            int k = kx * ky;
            for(int i= 0; i < k; i++)
            {
                TL_btnArr[i] = new Button(); // teeb nii nalju buttoneid kui k väärtus;
                TL_frame1.Controls.Add(TL_btnArr[i]);  //lisab frameile buttonid
                
                //nupu suurus 
                TL_btnArr[i].Width = dx;
                TL_btnArr[i].Height = dy;
                //asukoht
                int rida = i / kx;
                int veerg = i % kx;
                TL_btnArr[i].Left = veerg * dx;
                TL_btnArr[i].Top = rida * dy;

                
                //TL_btnArr[i].Text = i.ToString();
                TL_btnArr[i].BackColor = Color.Gold;
                TL_btnArr[i].ForeColor = Color.Red;
                TL_btnArr[i].Click += new EventHandler(TL_btnArr_Click); // kuna ise arrayst genereerime peab ise ka eventhandleri panema

            }

           
        }

        private void TL_uusMäng_Click(object sender, EventArgs e)
        {
            TL_Numbrid();
        }

        private void TL_btnArr_Click(object sender, EventArgs e)
        {
            int n = Array.IndexOf(TL_btnArr, (Button)sender);
            TL_btnArr[n].BackColor = Color.Green;
        }

        private void TL_Numbrid()
        {
            int k = kx * ky;
            int asukoht;
            for (int i= 0; i< k; i++)
            {
                TL_btnArr[i].Text = "";
            }

            for(int n = 1; n < k; n++)
            {
                do
                {

                    asukoht = rnd.Next(0,k);
                    
                } while (TL_btnArr[asukoht].Text != "");
                TL_btnArr[asukoht].Text = n.ToString();
            }
        }
    }
}
