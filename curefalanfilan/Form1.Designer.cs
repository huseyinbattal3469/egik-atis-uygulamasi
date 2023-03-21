
namespace curefalanfilan
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxHiz = new System.Windows.Forms.TextBox();
            this.maskedTextBoxAci = new System.Windows.Forms.MaskedTextBox();
            this.panelGirdi = new System.Windows.Forms.Panel();
            this.buttonOlc = new System.Windows.Forms.Button();
            this.panelCikti = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.trackBarGrafikCarpani = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelGirdi.SuspendLayout();
            this.panelCikti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGrafikCarpani)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hız m/s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(60, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Açı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Maks. Yükseklik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(63, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Menzili";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(44, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Uçuş Süresi";
            // 
            // textBoxHiz
            // 
            this.textBoxHiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxHiz.Location = new System.Drawing.Point(105, 15);
            this.textBoxHiz.Name = "textBoxHiz";
            this.textBoxHiz.Size = new System.Drawing.Size(59, 31);
            this.textBoxHiz.TabIndex = 6;
            this.textBoxHiz.Text = "20,50";
            this.textBoxHiz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxHiz.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // maskedTextBoxAci
            // 
            this.maskedTextBoxAci.Culture = new System.Globalization.CultureInfo("en-001");
            this.maskedTextBoxAci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxAci.Location = new System.Drawing.Point(105, 83);
            this.maskedTextBoxAci.Mask = "00";
            this.maskedTextBoxAci.Name = "maskedTextBoxAci";
            this.maskedTextBoxAci.Size = new System.Drawing.Size(59, 31);
            this.maskedTextBoxAci.TabIndex = 7;
            this.maskedTextBoxAci.Text = "45";
            this.maskedTextBoxAci.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxAci.ValidatingType = typeof(int);
            // 
            // panelGirdi
            // 
            this.panelGirdi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelGirdi.Controls.Add(this.buttonOlc);
            this.panelGirdi.Controls.Add(this.label1);
            this.panelGirdi.Controls.Add(this.maskedTextBoxAci);
            this.panelGirdi.Controls.Add(this.label2);
            this.panelGirdi.Controls.Add(this.textBoxHiz);
            this.panelGirdi.Location = new System.Drawing.Point(9, 12);
            this.panelGirdi.Name = "panelGirdi";
            this.panelGirdi.Size = new System.Drawing.Size(200, 133);
            this.panelGirdi.TabIndex = 8;
            // 
            // buttonOlc
            // 
            this.buttonOlc.Location = new System.Drawing.Point(105, 54);
            this.buttonOlc.Name = "buttonOlc";
            this.buttonOlc.Size = new System.Drawing.Size(59, 23);
            this.buttonOlc.TabIndex = 8;
            this.buttonOlc.Text = "Ölç";
            this.buttonOlc.UseVisualStyleBackColor = true;
            this.buttonOlc.Click += new System.EventHandler(this.buttonOlc_Click);
            // 
            // panelCikti
            // 
            this.panelCikti.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCikti.Controls.Add(this.label8);
            this.panelCikti.Controls.Add(this.label7);
            this.panelCikti.Controls.Add(this.label6);
            this.panelCikti.Controls.Add(this.label3);
            this.panelCikti.Controls.Add(this.label4);
            this.panelCikti.Controls.Add(this.label5);
            this.panelCikti.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panelCikti.Location = new System.Drawing.Point(9, 193);
            this.panelCikti.Name = "panelCikti";
            this.panelCikti.Size = new System.Drawing.Size(200, 356);
            this.panelCikti.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "VERİ YOK";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "VERİ YOK";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "VERİ YOK";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(6, 162);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(35, 13);
            this.labelError.TabIndex = 10;
            this.labelError.Text = "label9";
            this.labelError.Visible = false;
            // 
            // trackBarGrafikCarpani
            // 
            this.trackBarGrafikCarpani.LargeChange = 2;
            this.trackBarGrafikCarpani.Location = new System.Drawing.Point(103, 147);
            this.trackBarGrafikCarpani.Maximum = 15;
            this.trackBarGrafikCarpani.Minimum = 1;
            this.trackBarGrafikCarpani.Name = "trackBarGrafikCarpani";
            this.trackBarGrafikCarpani.Size = new System.Drawing.Size(104, 45);
            this.trackBarGrafikCarpani.TabIndex = 11;
            this.trackBarGrafikCarpani.Value = 15;
            this.trackBarGrafikCarpani.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Grafik Çözünürlüğü";
            this.label9.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(215, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 604);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Orange;
            this.label11.Location = new System.Drawing.Point(-2, 442);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "VERİ";
            this.label11.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label10.Location = new System.Drawing.Point(2, 577);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "VERİ";
            this.label10.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::curefalanfilan.Properties.Resources.topb;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 504);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 628);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.trackBarGrafikCarpani);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.panelCikti);
            this.Controls.Add(this.panelGirdi);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "202010614009 Hüseyin Battal Bilgisayar Programcılığı Bölümü ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelGirdi.ResumeLayout(false);
            this.panelGirdi.PerformLayout();
            this.panelCikti.ResumeLayout(false);
            this.panelCikti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGrafikCarpani)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxHiz;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAci;
        private System.Windows.Forms.Panel panelGirdi;
        private System.Windows.Forms.Button buttonOlc;
        private System.Windows.Forms.Panel panelCikti;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.TrackBar trackBarGrafikCarpani;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

