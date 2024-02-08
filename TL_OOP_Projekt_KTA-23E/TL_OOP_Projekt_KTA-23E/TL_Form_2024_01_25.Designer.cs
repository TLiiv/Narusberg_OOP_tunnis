namespace TL_OOP_Projekt_KTA_23E
{
    partial class TL_Form_2024_01_25
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TL_txt1 = new System.Windows.Forms.TextBox();
            this.TL_lisa = new System.Windows.Forms.Button();
            this.TL_list1 = new System.Windows.Forms.ListBox();
            this.TL_chk1 = new System.Windows.Forms.CheckBox();
            this.TL_kustuta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TL_txt1
            // 
            this.TL_txt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TL_txt1.Location = new System.Drawing.Point(36, 36);
            this.TL_txt1.Name = "TL_txt1";
            this.TL_txt1.Size = new System.Drawing.Size(260, 29);
            this.TL_txt1.TabIndex = 0;
            // 
            // TL_lisa
            // 
            this.TL_lisa.BackColor = System.Drawing.Color.Green;
            this.TL_lisa.Location = new System.Drawing.Point(311, 36);
            this.TL_lisa.Name = "TL_lisa";
            this.TL_lisa.Size = new System.Drawing.Size(128, 42);
            this.TL_lisa.TabIndex = 1;
            this.TL_lisa.Text = "Lisada";
            this.TL_lisa.UseVisualStyleBackColor = false;
            this.TL_lisa.Click += new System.EventHandler(this.TL_lisa_Click);
            // 
            // TL_list1
            // 
            this.TL_list1.FormattingEnabled = true;
            this.TL_list1.ItemHeight = 22;
            this.TL_list1.Location = new System.Drawing.Point(453, 36);
            this.TL_list1.Name = "TL_list1";
            this.TL_list1.Size = new System.Drawing.Size(322, 290);
            this.TL_list1.TabIndex = 2;
            // 
            // TL_chk1
            // 
            this.TL_chk1.AutoSize = true;
            this.TL_chk1.Location = new System.Drawing.Point(453, 332);
            this.TL_chk1.Name = "TL_chk1";
            this.TL_chk1.Size = new System.Drawing.Size(117, 26);
            this.TL_chk1.TabIndex = 3;
            this.TL_chk1.Text = "Unsorted";
            this.TL_chk1.UseVisualStyleBackColor = true;
            this.TL_chk1.CheckedChanged += new System.EventHandler(this.TL_chk1_CheckedChanged);
            // 
            // TL_kustuta
            // 
            this.TL_kustuta.BackColor = System.Drawing.Color.DarkRed;
            this.TL_kustuta.Location = new System.Drawing.Point(311, 84);
            this.TL_kustuta.Name = "TL_kustuta";
            this.TL_kustuta.Size = new System.Drawing.Size(128, 42);
            this.TL_kustuta.TabIndex = 4;
            this.TL_kustuta.Text = "Kustutada";
            this.TL_kustuta.UseVisualStyleBackColor = false;
            this.TL_kustuta.Click += new System.EventHandler(this.TL_kustuta_Click);
            // 
            // TL_Form_2024_01_25
            // 
            this.AcceptButton = this.TL_lisa;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 496);
            this.Controls.Add(this.TL_kustuta);
            this.Controls.Add(this.TL_chk1);
            this.Controls.Add(this.TL_list1);
            this.Controls.Add(this.TL_lisa);
            this.Controls.Add(this.TL_txt1);
            this.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "TL_Form_2024_01_25";
            this.Text = "TL_Form_2024_01_25";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TL_txt1;
        private System.Windows.Forms.Button TL_lisa;
        private System.Windows.Forms.ListBox TL_list1;
        private System.Windows.Forms.CheckBox TL_chk1;
        private System.Windows.Forms.Button TL_kustuta;
    }
}