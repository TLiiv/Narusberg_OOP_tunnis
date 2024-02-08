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
    public partial class TL_Form_2024_01_25 : Form
    {
        public TL_Form_2024_01_25()
        {
            InitializeComponent();
        }

        private void TL_lisa_Click(object sender, EventArgs e)
        {
            string t = TL_txt1.Text;
            int valitud = TL_list1.SelectedIndex; // valid listis mingi rea ja saad ta numbri
            if(valitud == -1)
            {
                TL_list1.Items.Add(t);//kui midagi pole valitud lisab suvalt
            }
            else
            {
                TL_list1.Items.Insert(valitud,t);// kui on valitud siis uus input tekib valitud ette
                TL_list1.SelectedIndex = -1;// et hakkaks jälle suvalises järjekorras lisama
            }
            //TL_txt1.Clear();
            TL_txt1.Text = "";
            TL_txt1.Focus();
        }

        private void TL_chk1_CheckedChanged(object sender, EventArgs e)
        {
            if(TL_chk1.Checked)
            {
                TL_chk1.Text = "Sorted";
                TL_list1.Sorted = TL_chk1.Checked;
            }
            else
            { 
                TL_chk1.Text = "Unsorted";
                
            }
        }

        private void TL_kustuta_Click(object sender, EventArgs e)
        {
            int valitud = TL_list1.SelectedIndex;
            if(valitud == -1)
            {
                MessageBox.Show("Valik puudub");
                return; //et alamprogrammist välja läheks
            }
            else
            {
                string t = "Kas soovite kustutada:\n" + TL_list1.Items[valitud];
                DialogResult vastus = MessageBox.Show(t, "Hoiatus", MessageBoxButtons.YesNo);
                if(vastus == DialogResult.Yes)
                {
                    TL_list1.Items.RemoveAt(valitud);//removeAt removeib indexi järgi Remove objecti järgi
                }
                else
                {
                    TL_list1.SelectedIndex = -1;
                }
            }
        }
    }
}
