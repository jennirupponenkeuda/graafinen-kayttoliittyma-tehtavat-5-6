namespace graafinentehtava6
{
    partial class SalasanaForm
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
            SalasanaPanel = new Panel();
            VirheviestiLB = new TextBox();
            TarkistaBT = new Button();
            label2 = new Label();
            label1 = new Label();
            SalasanaTB = new TextBox();
            KayttajaTB = new TextBox();
            SalasanaOikeinPanel = new Panel();
            label3 = new Label();
            SalasanaPanel.SuspendLayout();
            SalasanaOikeinPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SalasanaPanel
            // 
            SalasanaPanel.BackColor = Color.MidnightBlue;
            SalasanaPanel.Controls.Add(VirheviestiLB);
            SalasanaPanel.Controls.Add(TarkistaBT);
            SalasanaPanel.Controls.Add(label2);
            SalasanaPanel.Controls.Add(label1);
            SalasanaPanel.Controls.Add(SalasanaTB);
            SalasanaPanel.Controls.Add(KayttajaTB);
            SalasanaPanel.Dock = DockStyle.Fill;
            SalasanaPanel.Font = new Font("Segoe UI", 18F);
            SalasanaPanel.ForeColor = Color.Gold;
            SalasanaPanel.Location = new Point(0, 0);
            SalasanaPanel.Name = "SalasanaPanel";
            SalasanaPanel.Size = new Size(725, 472);
            SalasanaPanel.TabIndex = 0;
            // 
            // VirheviestiLB
            // 
            VirheviestiLB.BackColor = Color.MidnightBlue;
            VirheviestiLB.ForeColor = Color.Gold;
            VirheviestiLB.Location = new Point(117, 282);
            VirheviestiLB.Name = "VirheviestiLB";
            VirheviestiLB.Size = new Size(504, 39);
            VirheviestiLB.TabIndex = 5;
            VirheviestiLB.Text = "Virhe!";
            VirheviestiLB.Visible = false;
            // 
            // TarkistaBT
            // 
            TarkistaBT.ForeColor = Color.Black;
            TarkistaBT.Location = new Point(317, 214);
            TarkistaBT.Name = "TarkistaBT";
            TarkistaBT.Size = new Size(126, 43);
            TarkistaBT.TabIndex = 4;
            TarkistaBT.Text = "Tarkista";
            TarkistaBT.UseVisualStyleBackColor = true;
            TarkistaBT.Click += TarkistaBT_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 138);
            label2.Name = "label2";
            label2.Size = new Size(110, 32);
            label2.TabIndex = 3;
            label2.Text = "Salasana:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 74);
            label1.Name = "label1";
            label1.Size = new Size(177, 32);
            label1.TabIndex = 2;
            label1.Text = "Käyttäjätunnus:";
            // 
            // SalasanaTB
            // 
            SalasanaTB.Location = new Point(343, 135);
            SalasanaTB.Name = "SalasanaTB";
            SalasanaTB.Size = new Size(100, 39);
            SalasanaTB.TabIndex = 1;
            // 
            // KayttajaTB
            // 
            KayttajaTB.Location = new Point(343, 71);
            KayttajaTB.Name = "KayttajaTB";
            KayttajaTB.Size = new Size(100, 39);
            KayttajaTB.TabIndex = 0;
            // 
            // SalasanaOikeinPanel
            // 
            SalasanaOikeinPanel.BackColor = Color.DarkRed;
            SalasanaOikeinPanel.Controls.Add(label3);
            SalasanaOikeinPanel.Dock = DockStyle.Fill;
            SalasanaOikeinPanel.Font = new Font("Segoe Script", 36F, FontStyle.Bold | FontStyle.Italic);
            SalasanaOikeinPanel.ForeColor = Color.Snow;
            SalasanaOikeinPanel.Location = new Point(0, 0);
            SalasanaOikeinPanel.Name = "SalasanaOikeinPanel";
            SalasanaOikeinPanel.Size = new Size(725, 472);
            SalasanaOikeinPanel.TabIndex = 1;
            SalasanaOikeinPanel.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 44);
            label3.Name = "label3";
            label3.Size = new Size(574, 80);
            label3.TabIndex = 0;
            label3.Text = "Tervetuloa sivuilleni";
            // 
            // SalasanaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 472);
            Controls.Add(SalasanaOikeinPanel);
            Controls.Add(SalasanaPanel);
            Name = "SalasanaForm";
            Text = "Salasanan tarkastus ";
            SalasanaPanel.ResumeLayout(false);
            SalasanaPanel.PerformLayout();
            SalasanaOikeinPanel.ResumeLayout(false);
            SalasanaOikeinPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel SalasanaPanel;
        private TextBox KayttajaTB;
        private TextBox SalasanaTB;
        private Label label2;
        private Label label1;
        private Button TarkistaBT;
        private TextBox VirheviestiLB;
        private Panel SalasanaOikeinPanel;
        private Label label3;
    }
}
