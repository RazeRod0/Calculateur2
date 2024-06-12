namespace Calculateur
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            DecimalIP1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            BinaireIP1 = new TextBox();
            DecimalIP2 = new TextBox();
            DecimalIP3 = new TextBox();
            DecimalIP4 = new TextBox();
            BinaireIP2 = new TextBox();
            BinaireIP3 = new TextBox();
            BinaireIP4 = new TextBox();
            CIDR = new TextBox();
            label4 = new Label();
            Mask1 = new TextBox();
            Mask2 = new TextBox();
            Mask3 = new TextBox();
            Mask4 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            BoutonCalcul = new Button();
            Separation = new Label();
            Classe = new TextBox();
            label7 = new Label();
            ReseauIP4 = new TextBox();
            ReseauIP3 = new TextBox();
            ReseauIP2 = new TextBox();
            ReseauIP1 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            BroadCastIP4 = new TextBox();
            BroadCastIP3 = new TextBox();
            BroadCastIP2 = new TextBox();
            BroadCastIP1 = new TextBox();
            FIP4 = new TextBox();
            FIP3 = new TextBox();
            FIP2 = new TextBox();
            FIP1 = new TextBox();
            LIP4 = new TextBox();
            LIP3 = new TextBox();
            LIP2 = new TextBox();
            LIP1 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            NbIP = new TextBox();
            NbMac = new TextBox();
            label12 = new Label();
            label13 = new Label();
            Notice = new Button();
            label14 = new Label();
            label15 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe Script", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(240, 5);
            label1.Name = "label1";
            label1.Size = new Size(419, 62);
            label1.TabIndex = 0;
            label1.Text = "Calculateur de masque réseau";
            // 
            // DecimalIP1
            // 
            DecimalIP1.BackColor = Color.DeepSkyBlue;
            DecimalIP1.Location = new Point(323, 62);
            DecimalIP1.Name = "DecimalIP1";
            DecimalIP1.Size = new Size(79, 23);
            DecimalIP1.TabIndex = 1;
            DecimalIP1.TextChanged += DecimalIP1_textChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(267, 65);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 5;
            label2.Text = "Décimal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(267, 94);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 7;
            label3.Text = "Binaire";
            // 
            // BinaireIP1
            // 
            BinaireIP1.BackColor = Color.DeepSkyBlue;
            BinaireIP1.Location = new Point(323, 91);
            BinaireIP1.Name = "BinaireIP1";
            BinaireIP1.ReadOnly = true;
            BinaireIP1.Size = new Size(79, 23);
            BinaireIP1.TabIndex = 6;
            // 
            // DecimalIP2
            // 
            DecimalIP2.BackColor = Color.DeepSkyBlue;
            DecimalIP2.Location = new Point(394, 62);
            DecimalIP2.Name = "DecimalIP2";
            DecimalIP2.Size = new Size(79, 23);
            DecimalIP2.TabIndex = 8;
            DecimalIP2.TextChanged += DecimalIP2_textChanged;
            // 
            // DecimalIP3
            // 
            DecimalIP3.BackColor = Color.DeepSkyBlue;
            DecimalIP3.Location = new Point(463, 62);
            DecimalIP3.Name = "DecimalIP3";
            DecimalIP3.Size = new Size(79, 23);
            DecimalIP3.TabIndex = 9;
            DecimalIP3.TextChanged += DecimalIP3_textChanged;
            // 
            // DecimalIP4
            // 
            DecimalIP4.BackColor = Color.DeepSkyBlue;
            DecimalIP4.Location = new Point(536, 62);
            DecimalIP4.Name = "DecimalIP4";
            DecimalIP4.Size = new Size(79, 23);
            DecimalIP4.TabIndex = 10;
            DecimalIP4.TextChanged += DecimalIP4_textChanged;
            // 
            // BinaireIP2
            // 
            BinaireIP2.BackColor = Color.DeepSkyBlue;
            BinaireIP2.Location = new Point(394, 91);
            BinaireIP2.Name = "BinaireIP2";
            BinaireIP2.ReadOnly = true;
            BinaireIP2.Size = new Size(79, 23);
            BinaireIP2.TabIndex = 11;
            // 
            // BinaireIP3
            // 
            BinaireIP3.BackColor = Color.DeepSkyBlue;
            BinaireIP3.Location = new Point(465, 91);
            BinaireIP3.Name = "BinaireIP3";
            BinaireIP3.ReadOnly = true;
            BinaireIP3.Size = new Size(79, 23);
            BinaireIP3.TabIndex = 12;
            // 
            // BinaireIP4
            // 
            BinaireIP4.BackColor = Color.DeepSkyBlue;
            BinaireIP4.Location = new Point(536, 91);
            BinaireIP4.Name = "BinaireIP4";
            BinaireIP4.ReadOnly = true;
            BinaireIP4.Size = new Size(79, 23);
            BinaireIP4.TabIndex = 13;
            // 
            // CIDR
            // 
            CIDR.BackColor = Color.DarkOrange;
            CIDR.Location = new Point(219, 147);
            CIDR.Name = "CIDR";
            CIDR.Size = new Size(71, 23);
            CIDR.TabIndex = 14;
            CIDR.TextChanged += CIDR_textChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(292, 150);
            label4.Name = "label4";
            label4.Size = new Size(24, 15);
            label4.TabIndex = 15;
            label4.Text = "OU";
            // 
            // Mask1
            // 
            Mask1.BackColor = Color.DarkOrange;
            Mask1.Location = new Point(322, 147);
            Mask1.Name = "Mask1";
            Mask1.Size = new Size(80, 23);
            Mask1.TabIndex = 16;
            Mask1.TextChanged += Mask_textChanged;
            // 
            // Mask2
            // 
            Mask2.BackColor = Color.DarkOrange;
            Mask2.Location = new Point(394, 147);
            Mask2.Name = "Mask2";
            Mask2.Size = new Size(80, 23);
            Mask2.TabIndex = 17;
            Mask2.TextChanged += Mask_textChanged;
            // 
            // Mask3
            // 
            Mask3.BackColor = Color.DarkOrange;
            Mask3.Location = new Point(463, 147);
            Mask3.Name = "Mask3";
            Mask3.Size = new Size(80, 23);
            Mask3.TabIndex = 18;
            Mask3.TextChanged += Mask_textChanged;
            // 
            // Mask4
            // 
            Mask4.BackColor = Color.DarkOrange;
            Mask4.Location = new Point(535, 147);
            Mask4.Name = "Mask4";
            Mask4.Size = new Size(80, 23);
            Mask4.TabIndex = 19;
            Mask4.TextChanged += Mask_textChanged;
            // 
            // label5
            // 
            label5.Location = new Point(236, 129);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 20;
            label5.Text = "CIDR";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(436, 129);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 21;
            label6.Text = "Masque";
            // 
            // BoutonCalcul
            // 
            BoutonCalcul.BackColor = Color.FromArgb(224, 224, 224);
            BoutonCalcul.FlatStyle = FlatStyle.Popup;
            BoutonCalcul.Location = new Point(414, 198);
            BoutonCalcul.Name = "BoutonCalcul";
            BoutonCalcul.Size = new Size(98, 38);
            BoutonCalcul.TabIndex = 22;
            BoutonCalcul.Text = "Calcul";
            BoutonCalcul.UseVisualStyleBackColor = false;
            BoutonCalcul.Click += BoutonCalcul_Click;
            // 
            // Separation
            // 
            Separation.Location = new Point(-2, 239);
            Separation.Name = "Separation";
            Separation.Size = new Size(899, 23);
            Separation.TabIndex = 23;
            Separation.Text = resources.GetString("Separation.Text");
            // 
            // Classe
            // 
            Classe.BackColor = Color.FromArgb(128, 128, 255);
            Classe.Location = new Point(446, 283);
            Classe.Name = "Classe";
            Classe.ReadOnly = true;
            Classe.Size = new Size(34, 23);
            Classe.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(414, 262);
            label7.Name = "label7";
            label7.Size = new Size(98, 15);
            label7.TabIndex = 25;
            label7.Text = "Adresse de classe";
            // 
            // ReseauIP4
            // 
            ReseauIP4.BackColor = Color.FromArgb(255, 128, 128);
            ReseauIP4.Location = new Point(535, 320);
            ReseauIP4.Name = "ReseauIP4";
            ReseauIP4.ReadOnly = true;
            ReseauIP4.Size = new Size(65, 23);
            ReseauIP4.TabIndex = 29;
            // 
            // ReseauIP3
            // 
            ReseauIP3.BackColor = Color.FromArgb(255, 128, 128);
            ReseauIP3.Location = new Point(464, 320);
            ReseauIP3.Name = "ReseauIP3";
            ReseauIP3.ReadOnly = true;
            ReseauIP3.Size = new Size(65, 23);
            ReseauIP3.TabIndex = 28;
            // 
            // ReseauIP2
            // 
            ReseauIP2.BackColor = Color.FromArgb(255, 128, 128);
            ReseauIP2.Location = new Point(393, 320);
            ReseauIP2.Name = "ReseauIP2";
            ReseauIP2.ReadOnly = true;
            ReseauIP2.Size = new Size(65, 23);
            ReseauIP2.TabIndex = 27;
            // 
            // ReseauIP1
            // 
            ReseauIP1.BackColor = Color.FromArgb(255, 128, 128);
            ReseauIP1.Location = new Point(322, 320);
            ReseauIP1.Name = "ReseauIP1";
            ReseauIP1.ReadOnly = true;
            ReseauIP1.Size = new Size(65, 23);
            ReseauIP1.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(228, 323);
            label8.Name = "label8";
            label8.Size = new Size(88, 15);
            label8.TabIndex = 30;
            label8.Text = "Adresse Réseau";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(213, 352);
            label9.Name = "label9";
            label9.Size = new Size(103, 15);
            label9.TabIndex = 35;
            label9.Text = "Adresse Broadcast";
            // 
            // BroadCastIP4
            // 
            BroadCastIP4.BackColor = Color.FromArgb(255, 128, 128);
            BroadCastIP4.Location = new Point(535, 349);
            BroadCastIP4.Name = "BroadCastIP4";
            BroadCastIP4.ReadOnly = true;
            BroadCastIP4.Size = new Size(65, 23);
            BroadCastIP4.TabIndex = 34;
            // 
            // BroadCastIP3
            // 
            BroadCastIP3.BackColor = Color.FromArgb(255, 128, 128);
            BroadCastIP3.Location = new Point(464, 349);
            BroadCastIP3.Name = "BroadCastIP3";
            BroadCastIP3.ReadOnly = true;
            BroadCastIP3.Size = new Size(65, 23);
            BroadCastIP3.TabIndex = 33;
            // 
            // BroadCastIP2
            // 
            BroadCastIP2.BackColor = Color.FromArgb(255, 128, 128);
            BroadCastIP2.Location = new Point(393, 349);
            BroadCastIP2.Name = "BroadCastIP2";
            BroadCastIP2.ReadOnly = true;
            BroadCastIP2.Size = new Size(65, 23);
            BroadCastIP2.TabIndex = 32;
            // 
            // BroadCastIP1
            // 
            BroadCastIP1.BackColor = Color.FromArgb(255, 128, 128);
            BroadCastIP1.Location = new Point(322, 349);
            BroadCastIP1.Name = "BroadCastIP1";
            BroadCastIP1.ReadOnly = true;
            BroadCastIP1.Size = new Size(65, 23);
            BroadCastIP1.TabIndex = 31;
            // 
            // FIP4
            // 
            FIP4.BackColor = Color.FromArgb(255, 192, 128);
            FIP4.Location = new Point(535, 411);
            FIP4.Name = "FIP4";
            FIP4.ReadOnly = true;
            FIP4.Size = new Size(65, 23);
            FIP4.TabIndex = 39;
            // 
            // FIP3
            // 
            FIP3.BackColor = Color.FromArgb(255, 192, 128);
            FIP3.Location = new Point(464, 411);
            FIP3.Name = "FIP3";
            FIP3.ReadOnly = true;
            FIP3.Size = new Size(65, 23);
            FIP3.TabIndex = 38;
            // 
            // FIP2
            // 
            FIP2.BackColor = Color.FromArgb(255, 192, 128);
            FIP2.Location = new Point(393, 411);
            FIP2.Name = "FIP2";
            FIP2.ReadOnly = true;
            FIP2.Size = new Size(65, 23);
            FIP2.TabIndex = 37;
            // 
            // FIP1
            // 
            FIP1.BackColor = Color.FromArgb(255, 192, 128);
            FIP1.Location = new Point(322, 411);
            FIP1.Name = "FIP1";
            FIP1.ReadOnly = true;
            FIP1.Size = new Size(65, 23);
            FIP1.TabIndex = 36;
            // 
            // LIP4
            // 
            LIP4.BackColor = Color.FromArgb(255, 192, 128);
            LIP4.Location = new Point(535, 440);
            LIP4.Name = "LIP4";
            LIP4.ReadOnly = true;
            LIP4.Size = new Size(65, 23);
            LIP4.TabIndex = 43;
            // 
            // LIP3
            // 
            LIP3.BackColor = Color.FromArgb(255, 192, 128);
            LIP3.Location = new Point(464, 440);
            LIP3.Name = "LIP3";
            LIP3.ReadOnly = true;
            LIP3.Size = new Size(65, 23);
            LIP3.TabIndex = 42;
            // 
            // LIP2
            // 
            LIP2.BackColor = Color.FromArgb(255, 192, 128);
            LIP2.Location = new Point(393, 440);
            LIP2.Name = "LIP2";
            LIP2.ReadOnly = true;
            LIP2.Size = new Size(65, 23);
            LIP2.TabIndex = 41;
            // 
            // LIP1
            // 
            LIP1.BackColor = Color.FromArgb(255, 192, 128);
            LIP1.Location = new Point(322, 440);
            LIP1.Name = "LIP1";
            LIP1.ReadOnly = true;
            LIP1.Size = new Size(65, 23);
            LIP1.TabIndex = 40;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(280, 414);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 44;
            label10.Text = "1ère IP";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(256, 443);
            label11.Name = "label11";
            label11.Size = new Size(64, 15);
            label11.TabIndex = 45;
            label11.Text = "Dernière IP";
            // 
            // NbIP
            // 
            NbIP.BackColor = Color.FromArgb(128, 255, 128);
            NbIP.Location = new Point(302, 522);
            NbIP.Name = "NbIP";
            NbIP.ReadOnly = true;
            NbIP.Size = new Size(65, 23);
            NbIP.TabIndex = 46;
            // 
            // NbMac
            // 
            NbMac.BackColor = Color.FromArgb(128, 255, 128);
            NbMac.Location = new Point(550, 522);
            NbMac.Name = "NbMac";
            NbMac.ReadOnly = true;
            NbMac.Size = new Size(65, 23);
            NbMac.TabIndex = 47;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(302, 504);
            label12.Name = "label12";
            label12.Size = new Size(74, 15);
            label12.TabIndex = 48;
            label12.Text = "Nombre d'IP";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(524, 504);
            label13.Name = "label13";
            label13.Size = new Size(121, 15);
            label13.TabIndex = 49;
            label13.Text = "Nombre de machines";
            // 
            // Notice
            // 
            Notice.Location = new Point(845, 13);
            Notice.Name = "Notice";
            Notice.Size = new Size(36, 31);
            Notice.TabIndex = 50;
            Notice.Text = "?";
            Notice.UseVisualStyleBackColor = true;
            Notice.Click += btnNotice_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(768, 504);
            label14.Name = "label14";
            label14.Size = new Size(103, 75);
            label14.TabIndex = 51;
            label14.Text = "Made by \r\nVaucher Gabriel\r\nBoubrit Maryam\r\nDiop Mahamadou\r\nYoussouf El korchi\r\n";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(12, 564);
            label15.Name = "label15";
            label15.Size = new Size(31, 15);
            label15.TabIndex = 52;
            label15.Text = "2024";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(893, 588);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(Notice);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(NbMac);
            Controls.Add(NbIP);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(LIP4);
            Controls.Add(LIP3);
            Controls.Add(LIP2);
            Controls.Add(LIP1);
            Controls.Add(FIP4);
            Controls.Add(FIP3);
            Controls.Add(FIP2);
            Controls.Add(FIP1);
            Controls.Add(label9);
            Controls.Add(BroadCastIP4);
            Controls.Add(BroadCastIP3);
            Controls.Add(BroadCastIP2);
            Controls.Add(BroadCastIP1);
            Controls.Add(label8);
            Controls.Add(ReseauIP4);
            Controls.Add(ReseauIP3);
            Controls.Add(ReseauIP2);
            Controls.Add(ReseauIP1);
            Controls.Add(label7);
            Controls.Add(Classe);
            Controls.Add(Separation);
            Controls.Add(BoutonCalcul);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Mask4);
            Controls.Add(Mask3);
            Controls.Add(Mask2);
            Controls.Add(Mask1);
            Controls.Add(label4);
            Controls.Add(CIDR);
            Controls.Add(BinaireIP4);
            Controls.Add(BinaireIP3);
            Controls.Add(BinaireIP2);
            Controls.Add(DecimalIP4);
            Controls.Add(DecimalIP3);
            Controls.Add(DecimalIP2);
            Controls.Add(label3);
            Controls.Add(BinaireIP1);
            Controls.Add(label2);
            Controls.Add(DecimalIP1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox DecimalIP1;
        private Label label2;
        private Label label3;
        private TextBox BinaireIP1;
        private TextBox DecimalIP2;
        private TextBox DecimalIP3;
        private TextBox DecimalIP4;
        private TextBox BinaireIP2;
        private TextBox BinaireIP3;
        private TextBox BinaireIP4;
        private TextBox CIDR;
        private Label label4;
        private TextBox Mask1;
        private TextBox Mask2;
        private TextBox Mask3;
        private TextBox Mask4;
        private Label label5;
        private Label label6;
        private Button BoutonCalcul;
        private Label Separation;
        private TextBox Classe;
        private Label label7;
        private TextBox ReseauIP4;
        private TextBox ReseauIP3;
        private TextBox ReseauIP2;
        private TextBox ReseauIP1;
        private Label label8;
        private Label label9;
        private TextBox BroadCastIP4;
        private TextBox BroadCastIP3;
        private TextBox BroadCastIP2;
        private TextBox BroadCastIP1;
        private TextBox FIP4;
        private TextBox FIP3;
        private TextBox FIP2;
        private TextBox FIP1;
        private TextBox LIP4;
        private TextBox LIP3;
        private TextBox LIP2;
        private TextBox LIP1;
        private Label label10;
        private Label label11;
        private TextBox NbIP;
        private TextBox NbMac;
        private Label label12;
        private Label label13;
        private Button Notice;
        private Label label14;
        private Label label15;
    }
}
