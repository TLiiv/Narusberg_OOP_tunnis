namespace TL_OOP_Projekt_KTA_23E
{
    partial class TL_Form_08_02_2024
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
            this.TL_Frame1 = new System.Windows.Forms.GroupBox();
            this.TL_pic1 = new System.Windows.Forms.PictureBox();
            this.TL_Menu = new System.Windows.Forms.MenuStrip();
            this.TL_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.TL_openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TL_rbtn1 = new System.Windows.Forms.RadioButton();
            this.TL_rbtn2 = new System.Windows.Forms.RadioButton();
            this.TL_rbtn3 = new System.Windows.Forms.RadioButton();
            this.TL_rbtn4 = new System.Windows.Forms.RadioButton();
            this.TL_rbtn5 = new System.Windows.Forms.RadioButton();
            this.TL_Frame1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TL_pic1)).BeginInit();
            this.TL_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TL_Frame1
            // 
            this.TL_Frame1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.TL_Frame1.Controls.Add(this.TL_rbtn5);
            this.TL_Frame1.Controls.Add(this.TL_rbtn4);
            this.TL_Frame1.Controls.Add(this.TL_rbtn3);
            this.TL_Frame1.Controls.Add(this.TL_rbtn2);
            this.TL_Frame1.Controls.Add(this.TL_rbtn1);
            this.TL_Frame1.Controls.Add(this.TL_pic1);
            this.TL_Frame1.Location = new System.Drawing.Point(36, 43);
            this.TL_Frame1.Name = "TL_Frame1";
            this.TL_Frame1.Size = new System.Drawing.Size(631, 315);
            this.TL_Frame1.TabIndex = 0;
            this.TL_Frame1.TabStop = false;
            this.TL_Frame1.Text = "Pildid";
            // 
            // TL_pic1
            // 
            this.TL_pic1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TL_pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TL_pic1.Location = new System.Drawing.Point(188, 47);
            this.TL_pic1.Name = "TL_pic1";
            this.TL_pic1.Size = new System.Drawing.Size(397, 232);
            this.TL_pic1.TabIndex = 0;
            this.TL_pic1.TabStop = false;
            this.TL_pic1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TL_pic1_MouseDown);
            this.TL_pic1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TL_pic1_MouseMove);
            this.TL_pic1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TL_pic1_MouseUp);
            // 
            // TL_Menu
            // 
            this.TL_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TL_Open});
            this.TL_Menu.Location = new System.Drawing.Point(0, 0);
            this.TL_Menu.Name = "TL_Menu";
            this.TL_Menu.Size = new System.Drawing.Size(759, 29);
            this.TL_Menu.TabIndex = 1;
            this.TL_Menu.Text = "menuStrip2";
            // 
            // TL_Open
            // 
            this.TL_Open.BackColor = System.Drawing.Color.White;
            this.TL_Open.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TL_Open.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TL_Open.Name = "TL_Open";
            this.TL_Open.Size = new System.Drawing.Size(88, 25);
            this.TL_Open.Text = "Open File";
            this.TL_Open.Click += new System.EventHandler(this.TL_Open_Click);
            // 
            // TL_openFileDialog1
            // 
            this.TL_openFileDialog1.FileName = "openFileDialog1";
            // 
            // TL_rbtn1
            // 
            this.TL_rbtn1.AutoSize = true;
            this.TL_rbtn1.Checked = true;
            this.TL_rbtn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TL_rbtn1.Location = new System.Drawing.Point(21, 47);
            this.TL_rbtn1.Name = "TL_rbtn1";
            this.TL_rbtn1.Size = new System.Drawing.Size(86, 22);
            this.TL_rbtn1.TabIndex = 1;
            this.TL_rbtn1.TabStop = true;
            this.TL_rbtn1.Text = "Normal";
            this.TL_rbtn1.UseVisualStyleBackColor = true;
            this.TL_rbtn1.CheckedChanged += new System.EventHandler(this.TL_rbtn1_CheckedChanged);
            // 
            // TL_rbtn2
            // 
            this.TL_rbtn2.AutoSize = true;
            this.TL_rbtn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TL_rbtn2.Location = new System.Drawing.Point(21, 75);
            this.TL_rbtn2.Name = "TL_rbtn2";
            this.TL_rbtn2.Size = new System.Drawing.Size(96, 22);
            this.TL_rbtn2.TabIndex = 2;
            this.TL_rbtn2.Text = "Stretch";
            this.TL_rbtn2.UseVisualStyleBackColor = true;
            this.TL_rbtn2.CheckedChanged += new System.EventHandler(this.TL_rbtn2_CheckedChanged);
            // 
            // TL_rbtn3
            // 
            this.TL_rbtn3.AutoSize = true;
            this.TL_rbtn3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TL_rbtn3.Location = new System.Drawing.Point(21, 103);
            this.TL_rbtn3.Name = "TL_rbtn3";
            this.TL_rbtn3.Size = new System.Drawing.Size(106, 22);
            this.TL_rbtn3.TabIndex = 3;
            this.TL_rbtn3.Text = "AutoSize";
            this.TL_rbtn3.UseVisualStyleBackColor = true;
            this.TL_rbtn3.CheckedChanged += new System.EventHandler(this.TL_rbtn3_CheckedChanged);
            // 
            // TL_rbtn4
            // 
            this.TL_rbtn4.AutoSize = true;
            this.TL_rbtn4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TL_rbtn4.Location = new System.Drawing.Point(21, 131);
            this.TL_rbtn4.Name = "TL_rbtn4";
            this.TL_rbtn4.Size = new System.Drawing.Size(86, 22);
            this.TL_rbtn4.TabIndex = 4;
            this.TL_rbtn4.Text = "Center";
            this.TL_rbtn4.UseVisualStyleBackColor = true;
            this.TL_rbtn4.CheckedChanged += new System.EventHandler(this.TL_rbtn4_CheckedChanged);
            // 
            // TL_rbtn5
            // 
            this.TL_rbtn5.AutoSize = true;
            this.TL_rbtn5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TL_rbtn5.Location = new System.Drawing.Point(21, 159);
            this.TL_rbtn5.Name = "TL_rbtn5";
            this.TL_rbtn5.Size = new System.Drawing.Size(66, 22);
            this.TL_rbtn5.TabIndex = 5;
            this.TL_rbtn5.Text = "Zoom";
            this.TL_rbtn5.UseVisualStyleBackColor = true;
            this.TL_rbtn5.CheckedChanged += new System.EventHandler(this.TL_rbtn5_CheckedChanged);
            // 
            // TL_Form_08_02_2024
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 370);
            this.Controls.Add(this.TL_Frame1);
            this.Controls.Add(this.TL_Menu);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "TL_Form_08_02_2024";
            this.Text = "TL_Form_08_02_2024";
            this.TL_Frame1.ResumeLayout(false);
            this.TL_Frame1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TL_pic1)).EndInit();
            this.TL_Menu.ResumeLayout(false);
            this.TL_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox TL_Frame1;
        private System.Windows.Forms.PictureBox TL_pic1;
        private System.Windows.Forms.MenuStrip TL_Menu;
        private System.Windows.Forms.ToolStripMenuItem TL_Open;
        private System.Windows.Forms.OpenFileDialog TL_openFileDialog1;
        private System.Windows.Forms.RadioButton TL_rbtn5;
        private System.Windows.Forms.RadioButton TL_rbtn4;
        private System.Windows.Forms.RadioButton TL_rbtn3;
        private System.Windows.Forms.RadioButton TL_rbtn2;
        private System.Windows.Forms.RadioButton TL_rbtn1;
    }
}