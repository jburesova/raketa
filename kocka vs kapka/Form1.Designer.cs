namespace KockaAkapka
{
    partial class Raketa
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raketa));
            this.pictureBox_kapka1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_kocka = new System.Windows.Forms.PictureBox();
            this.pictureBox_kapka2 = new System.Windows.Forms.PictureBox();
            this.txt_score = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_zivoty = new System.Windows.Forms.Label();
            this.txt_palivo = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox_srdce1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_srdce2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_srdce3 = new System.Windows.Forms.PictureBox();
            this.groupBox_hraciPlocha = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_mrak1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_mrak2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_kapka1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_kocka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_kapka2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_srdce1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_srdce2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_srdce3)).BeginInit();
            this.groupBox_hraciPlocha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mrak1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mrak2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_kapka1
            // 
            this.pictureBox_kapka1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_kapka1.Image")));
            this.pictureBox_kapka1.Location = new System.Drawing.Point(283, 39);
            this.pictureBox_kapka1.Name = "pictureBox_kapka1";
            this.pictureBox_kapka1.Size = new System.Drawing.Size(73, 111);
            this.pictureBox_kapka1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_kapka1.TabIndex = 0;
            this.pictureBox_kapka1.TabStop = false;
            // 
            // pictureBox_kocka
            // 
            this.pictureBox_kocka.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_kocka.Image")));
            this.pictureBox_kocka.Location = new System.Drawing.Point(329, 290);
            this.pictureBox_kocka.Name = "pictureBox_kocka";
            this.pictureBox_kocka.Size = new System.Drawing.Size(117, 127);
            this.pictureBox_kocka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_kocka.TabIndex = 1;
            this.pictureBox_kocka.TabStop = false;
            this.pictureBox_kocka.Click += new System.EventHandler(this.pictureBox_kocka_Click);
            // 
            // pictureBox_kapka2
            // 
            this.pictureBox_kapka2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_kapka2.Image")));
            this.pictureBox_kapka2.Location = new System.Drawing.Point(415, 117);
            this.pictureBox_kapka2.Name = "pictureBox_kapka2";
            this.pictureBox_kapka2.Size = new System.Drawing.Size(75, 111);
            this.pictureBox_kapka2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_kapka2.TabIndex = 2;
            this.pictureBox_kapka2.TabStop = false;
            // 
            // txt_score
            // 
            this.txt_score.AutoSize = true;
            this.txt_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_score.Location = new System.Drawing.Point(27, 525);
            this.txt_score.Name = "txt_score";
            this.txt_score.Size = new System.Drawing.Size(53, 18);
            this.txt_score.TabIndex = 3;
            this.txt_score.Text = "Score";
            this.txt_score.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(374, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(288, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 5;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_zivoty
            // 
            this.txt_zivoty.AutoSize = true;
            this.txt_zivoty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_zivoty.Location = new System.Drawing.Point(300, 525);
            this.txt_zivoty.Name = "txt_zivoty";
            this.txt_zivoty.Size = new System.Drawing.Size(53, 18);
            this.txt_zivoty.TabIndex = 6;
            this.txt_zivoty.Text = "Životy";
            this.txt_zivoty.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_palivo
            // 
            this.txt_palivo.AutoSize = true;
            this.txt_palivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_palivo.Location = new System.Drawing.Point(587, 525);
            this.txt_palivo.Name = "txt_palivo";
            this.txt_palivo.Size = new System.Drawing.Size(54, 18);
            this.txt_palivo.TabIndex = 7;
            this.txt_palivo.Text = "Palivo";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(647, 520);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // pictureBox_srdce1
            // 
            this.pictureBox_srdce1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_srdce1.Image")));
            this.pictureBox_srdce1.Location = new System.Drawing.Point(359, 512);
            this.pictureBox_srdce1.Name = "pictureBox_srdce1";
            this.pictureBox_srdce1.Size = new System.Drawing.Size(44, 40);
            this.pictureBox_srdce1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_srdce1.TabIndex = 9;
            this.pictureBox_srdce1.TabStop = false;
            // 
            // pictureBox_srdce2
            // 
            this.pictureBox_srdce2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_srdce2.Image")));
            this.pictureBox_srdce2.Location = new System.Drawing.Point(409, 512);
            this.pictureBox_srdce2.Name = "pictureBox_srdce2";
            this.pictureBox_srdce2.Size = new System.Drawing.Size(44, 40);
            this.pictureBox_srdce2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_srdce2.TabIndex = 10;
            this.pictureBox_srdce2.TabStop = false;
            // 
            // pictureBox_srdce3
            // 
            this.pictureBox_srdce3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_srdce3.Image")));
            this.pictureBox_srdce3.Location = new System.Drawing.Point(459, 512);
            this.pictureBox_srdce3.Name = "pictureBox_srdce3";
            this.pictureBox_srdce3.Size = new System.Drawing.Size(44, 40);
            this.pictureBox_srdce3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_srdce3.TabIndex = 11;
            this.pictureBox_srdce3.TabStop = false;
            // 
            // groupBox_hraciPlocha
            // 
            this.groupBox_hraciPlocha.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox_hraciPlocha.Controls.Add(this.pictureBox_kapka1);
            this.groupBox_hraciPlocha.Controls.Add(this.pictureBox_kapka2);
            this.groupBox_hraciPlocha.Controls.Add(this.pictureBox_kocka);
            this.groupBox_hraciPlocha.Location = new System.Drawing.Point(30, 65);
            this.groupBox_hraciPlocha.Name = "groupBox_hraciPlocha";
            this.groupBox_hraciPlocha.Size = new System.Drawing.Size(743, 423);
            this.groupBox_hraciPlocha.TabIndex = 12;
            this.groupBox_hraciPlocha.TabStop = false;
            this.groupBox_hraciPlocha.Text = "groupBox_hraciPlocha";
            this.groupBox_hraciPlocha.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kocka VS Kapka";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox_mrak1
            // 
            this.pictureBox_mrak1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_mrak1.Image")));
            this.pictureBox_mrak1.Location = new System.Drawing.Point(145, 9);
            this.pictureBox_mrak1.Name = "pictureBox_mrak1";
            this.pictureBox_mrak1.Size = new System.Drawing.Size(133, 50);
            this.pictureBox_mrak1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_mrak1.TabIndex = 13;
            this.pictureBox_mrak1.TabStop = false;
            // 
            // pictureBox_mrak2
            // 
            this.pictureBox_mrak2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_mrak2.Image")));
            this.pictureBox_mrak2.Location = new System.Drawing.Point(547, 9);
            this.pictureBox_mrak2.Name = "pictureBox_mrak2";
            this.pictureBox_mrak2.Size = new System.Drawing.Size(120, 50);
            this.pictureBox_mrak2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_mrak2.TabIndex = 14;
            this.pictureBox_mrak2.TabStop = false;
            // 
            // Raketa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this.pictureBox_mrak2);
            this.Controls.Add(this.pictureBox_mrak1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox_hraciPlocha);
            this.Controls.Add(this.pictureBox_srdce3);
            this.Controls.Add(this.pictureBox_srdce2);
            this.Controls.Add(this.pictureBox_srdce1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txt_palivo);
            this.Controls.Add(this.txt_zivoty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_score);
            this.Name = "Raketa";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_kapka1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_kocka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_kapka2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_srdce1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_srdce2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_srdce3)).EndInit();
            this.groupBox_hraciPlocha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mrak1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mrak2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_kapka1;
        private System.Windows.Forms.PictureBox pictureBox_kocka;
        private System.Windows.Forms.PictureBox pictureBox_kapka2;
        private System.Windows.Forms.Label txt_score;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txt_zivoty;
        private System.Windows.Forms.Label txt_palivo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox_srdce1;
        private System.Windows.Forms.PictureBox pictureBox_srdce2;
        private System.Windows.Forms.PictureBox pictureBox_srdce3;
        private System.Windows.Forms.GroupBox groupBox_hraciPlocha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_mrak1;
        private System.Windows.Forms.PictureBox pictureBox_mrak2;
    }
}

