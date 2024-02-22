namespace TL_OOP_Projekt_KTA_23E
{
    partial class TL_form_22_02_2024
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
            this.TL_pic1 = new System.Windows.Forms.PictureBox();
            this.TL_openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TL_Menu = new System.Windows.Forms.MenuStrip();
            this.TL_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.TL_Array = new System.Windows.Forms.ToolStripMenuItem();
            this.TL_Pic2 = new System.Windows.Forms.PictureBox();
            this.TL_Game = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.TL_pic1)).BeginInit();
            this.TL_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TL_Pic2)).BeginInit();
            this.SuspendLayout();
            // 
            // TL_pic1
            // 
            this.TL_pic1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TL_pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TL_pic1.Location = new System.Drawing.Point(22, 51);
            this.TL_pic1.Name = "TL_pic1";
            this.TL_pic1.Size = new System.Drawing.Size(397, 232);
            this.TL_pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.TL_pic1.TabIndex = 1;
            this.TL_pic1.TabStop = false;
            // 
            // TL_openFileDialog1
            // 
            this.TL_openFileDialog1.FileName = "openFileDialog1";
            // 
            // TL_Menu
            // 
            this.TL_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TL_Open,
            this.TL_Array,
            this.TL_Game});
            this.TL_Menu.Location = new System.Drawing.Point(0, 0);
            this.TL_Menu.Name = "TL_Menu";
            this.TL_Menu.Size = new System.Drawing.Size(867, 29);
            this.TL_Menu.TabIndex = 2;
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
            // TL_Array
            // 
            this.TL_Array.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TL_Array.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TL_Array.Name = "TL_Array";
            this.TL_Array.Size = new System.Drawing.Size(110, 25);
            this.TL_Array.Text = "Pic Array";
            this.TL_Array.Click += new System.EventHandler(this.TL_Array_Click);
            // 
            // TL_Pic2
            // 
            this.TL_Pic2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TL_Pic2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TL_Pic2.Location = new System.Drawing.Point(445, 51);
            this.TL_Pic2.Name = "TL_Pic2";
            this.TL_Pic2.Size = new System.Drawing.Size(397, 232);
            this.TL_Pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.TL_Pic2.TabIndex = 3;
            this.TL_Pic2.TabStop = false;
            // 
            // TL_Game
            // 
            this.TL_Game.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TL_Game.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TL_Game.Name = "TL_Game";
            this.TL_Game.Size = new System.Drawing.Size(60, 25);
            this.TL_Game.Text = "Game";
            this.TL_Game.Click += new System.EventHandler(this.TL_Game_Click);
            // 
            // TL_form_22_02_2024
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(867, 727);
            this.Controls.Add(this.TL_Pic2);
            this.Controls.Add(this.TL_Menu);
            this.Controls.Add(this.TL_pic1);
            this.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "TL_form_22_02_2024";
            this.Text = "TL_form_22_02_2024";
            ((System.ComponentModel.ISupportInitialize)(this.TL_pic1)).EndInit();
            this.TL_Menu.ResumeLayout(false);
            this.TL_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TL_Pic2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TL_pic1;
        private System.Windows.Forms.OpenFileDialog TL_openFileDialog1;
        private System.Windows.Forms.MenuStrip TL_Menu;
        private System.Windows.Forms.ToolStripMenuItem TL_Open;
        private System.Windows.Forms.ToolStripMenuItem TL_Array;
        private System.Windows.Forms.PictureBox TL_Pic2;
        private System.Windows.Forms.ToolStripMenuItem TL_Game;
    }
}