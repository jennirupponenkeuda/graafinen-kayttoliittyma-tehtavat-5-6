﻿namespace graafinentehtava5
{
    partial class LukujenJarjestys
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            uusiLukuTB = new TextBox();
            VastausLB = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 44);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 0;
            label1.Text = "Anna luku (-999 lopetus):”";
            // 
            // uusiLukuTB
            // 
            uusiLukuTB.Location = new Point(213, 41);
            uusiLukuTB.Name = "uusiLukuTB";
            uusiLukuTB.Size = new Size(100, 23);
            uusiLukuTB.TabIndex = 1;
            uusiLukuTB.KeyPress += uusiLukuTB_KeyPress;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Location = new Point(29, 78);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(38, 15);
            VastausLB.TabIndex = 2;
            VastausLB.Text = "label2";
            VastausLB.Visible = false;
            // 
            // LukujenJarjestys
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(VastausLB);
            Controls.Add(uusiLukuTB);
            Controls.Add(label1);
            Name = "LukujenJarjestys";
            Text = "LukujenJarjestys";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox uusiLukuTB;
        private Label VastausLB;
    }
}
