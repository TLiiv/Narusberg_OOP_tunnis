﻿using System;
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
    public partial class TL_Form_Main : Form
    {
        Form F2 = new TL_Form_08_02_2024();
        Form F3 = new TL_form_22_02_2024();
        Form F4 = new TL_Form_07_03_2024();
        public TL_Form_Main()
        {
            InitializeComponent();
        }

        private void TL_btn1_Click(object sender, EventArgs e)
        {
            Form F1 = new TL_Form_2024_01_25();
            F1.Visible = true;
            F1.Activate();
            TL_btn1.Enabled = false;
        }

        private void TL_btn2_Click(object sender, EventArgs e)
        {
            if (F2.Visible==false)
            {
                Form F2 = new TL_Form_08_02_2024();
                F2.Visible = true;
                F2.Activate();
            }

           
        }

        private void TL_btn3_Click(object sender, EventArgs e)
        {
            if(F3.Visible == false)
            {
                Form F3 = new TL_form_22_02_2024();
                F3.Visible = true;
                F3.Activate();
            }
        }

        private void TL_btn4_Click(object sender, EventArgs e)
        {
            if (F4.Visible == false)
            {
                Form F4 = new TL_Form_07_03_2024();
                F4.Visible = true;
                F4.Activate();
            }
        }
    }
}
