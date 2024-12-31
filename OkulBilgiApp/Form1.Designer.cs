namespace OkulBilgiApp
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
            btnDersSeç = new Button();
            btnGuncelle = new Button();
            btnBul = new Button();
            btnKaydet = new Button();
            grpEkleme = new GroupBox();
            cbxSınıfSeç = new ComboBox();
            lblSınıfSeç = new Label();
            txtNumara = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            lblNum = new Label();
            lblSoyad = new Label();
            lblAd = new Label();
            grpEkleme.SuspendLayout();
            SuspendLayout();
            // 
            // btnDersSeç
            // 
            btnDersSeç.Location = new Point(165, 350);
            btnDersSeç.Name = "btnDersSeç";
            btnDersSeç.Size = new Size(124, 29);
            btnDersSeç.TabIndex = 18;
            btnDersSeç.Text = "Ders Seçimi";
            btnDersSeç.UseVisualStyleBackColor = true;
            btnDersSeç.Click += btnDersSeç_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(46, 300);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 17;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnBul
            // 
            btnBul.Location = new Point(322, 300);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(94, 29);
            btnBul.TabIndex = 16;
            btnBul.Text = "Bul";
            btnBul.UseVisualStyleBackColor = true;
            btnBul.Click += btnBul_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(182, 300);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 29);
            btnKaydet.TabIndex = 15;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // grpEkleme
            // 
            grpEkleme.Controls.Add(cbxSınıfSeç);
            grpEkleme.Controls.Add(lblSınıfSeç);
            grpEkleme.Controls.Add(txtNumara);
            grpEkleme.Controls.Add(txtSoyad);
            grpEkleme.Controls.Add(txtAd);
            grpEkleme.Controls.Add(lblNum);
            grpEkleme.Controls.Add(lblSoyad);
            grpEkleme.Controls.Add(lblAd);
            grpEkleme.Location = new Point(46, 44);
            grpEkleme.Name = "grpEkleme";
            grpEkleme.Size = new Size(370, 230);
            grpEkleme.TabIndex = 14;
            grpEkleme.TabStop = false;
            grpEkleme.Text = "Öğrenci Ekleme";
            // 
            // cbxSınıfSeç
            // 
            cbxSınıfSeç.FormattingEnabled = true;
            cbxSınıfSeç.Location = new Point(168, 188);
            cbxSınıfSeç.Name = "cbxSınıfSeç";
            cbxSınıfSeç.Size = new Size(125, 28);
            cbxSınıfSeç.TabIndex = 7;
            // 
            // lblSınıfSeç
            // 
            lblSınıfSeç.AutoSize = true;
            lblSınıfSeç.Location = new Point(55, 191);
            lblSınıfSeç.Name = "lblSınıfSeç";
            lblSınıfSeç.Size = new Size(88, 20);
            lblSınıfSeç.TabIndex = 6;
            lblSınıfSeç.Text = "Sınıf Seçiniz";
            // 
            // txtNumara
            // 
            txtNumara.Location = new Point(168, 138);
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(125, 27);
            txtNumara.TabIndex = 5;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(168, 88);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 4;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(168, 34);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 3;
            // 
            // lblNum
            // 
            lblNum.AutoSize = true;
            lblNum.Location = new Point(55, 141);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(62, 20);
            lblNum.TabIndex = 2;
            lblNum.Text = "Numara";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(55, 91);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(50, 20);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(55, 41);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(28, 20);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 423);
            Controls.Add(btnDersSeç);
            Controls.Add(btnGuncelle);
            Controls.Add(btnBul);
            Controls.Add(btnKaydet);
            Controls.Add(grpEkleme);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Click += btnBul_Click;
            grpEkleme.ResumeLayout(false);
            grpEkleme.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDersSeç;
        private Button btnGuncelle;
        private Button btnBul;
        private Button btnKaydet;
        private GroupBox grpEkleme;
        private ComboBox cbxSınıfSeç;
        private Label lblSınıfSeç;
        private TextBox txtNumara;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label lblNum;
        private Label lblSoyad;
        private Label lblAd;
    }
}