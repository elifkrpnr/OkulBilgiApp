namespace OkulBilgiApp
{
    partial class Form2
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
            lbl = new Label();
            btnDersKaydet = new Button();
            dataGridView1 = new DataGridView();
            lblOgrenciBilgileri = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(75, 114);
            lbl.Name = "lbl";
            lbl.Size = new Size(56, 20);
            lbl.TabIndex = 11;
            lbl.Text = "Dersler";
            // 
            // btnDersKaydet
            // 
            btnDersKaydet.Location = new Point(246, 362);
            btnDersKaydet.Name = "btnDersKaydet";
            btnDersKaydet.Size = new Size(320, 29);
            btnDersKaydet.TabIndex = 10;
            btnDersKaydet.Text = "Öğrencinin Derslerini Kaydet";
            btnDersKaydet.UseVisualStyleBackColor = true;
            btnDersKaydet.Click += btnDersKaydet_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(75, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(650, 188);
            dataGridView1.TabIndex = 9;
            // 
            // lblOgrenciBilgileri
            // 
            lblOgrenciBilgileri.AutoSize = true;
            lblOgrenciBilgileri.Location = new Point(75, 59);
            lblOgrenciBilgileri.Name = "lblOgrenciBilgileri";
            lblOgrenciBilgileri.Size = new Size(116, 20);
            lblOgrenciBilgileri.TabIndex = 8;
            lblOgrenciBilgileri.Text = "Öğrenci Bilgileri";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl);
            Controls.Add(btnDersKaydet);
            Controls.Add(dataGridView1);
            Controls.Add(lblOgrenciBilgileri);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl;
        private Button btnDersKaydet;
        private DataGridView dataGridView1;
        private Label lblOgrenciBilgileri;
    }
}