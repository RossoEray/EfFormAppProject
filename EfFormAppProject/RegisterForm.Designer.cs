namespace EfFormAppProject
{
    partial class RegisterForm
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
            grpOgrenciBul = new GroupBox();
            cbSinifSecimi = new ComboBox();
            txtNumara = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            lblSinifSecimi = new Label();
            lblNumara = new Label();
            lblSoyad = new Label();
            lblAd = new Label();
            btnKaydet = new Button();
            btnGuncelle = new Button();
            btnBul = new Button();
            btnDersSecimi = new Button();
            grpOgrenciBul.SuspendLayout();
            SuspendLayout();
            // 
            // grpOgrenciBul
            // 
            grpOgrenciBul.Controls.Add(cbSinifSecimi);
            grpOgrenciBul.Controls.Add(txtNumara);
            grpOgrenciBul.Controls.Add(txtSoyad);
            grpOgrenciBul.Controls.Add(txtAd);
            grpOgrenciBul.Controls.Add(lblSinifSecimi);
            grpOgrenciBul.Controls.Add(lblNumara);
            grpOgrenciBul.Controls.Add(lblSoyad);
            grpOgrenciBul.Controls.Add(lblAd);
            grpOgrenciBul.Location = new Point(14, 16);
            grpOgrenciBul.Margin = new Padding(3, 4, 3, 4);
            grpOgrenciBul.Name = "grpOgrenciBul";
            grpOgrenciBul.Padding = new Padding(3, 4, 3, 4);
            grpOgrenciBul.Size = new Size(488, 269);
            grpOgrenciBul.TabIndex = 0;
            grpOgrenciBul.TabStop = false;
            grpOgrenciBul.Text = "Öğrenci Ekleme";
            // 
            // cbSinifSecimi
            // 
            cbSinifSecimi.FormattingEnabled = true;
            cbSinifSecimi.Location = new Point(155, 200);
            cbSinifSecimi.Margin = new Padding(3, 4, 3, 4);
            cbSinifSecimi.Name = "cbSinifSecimi";
            cbSinifSecimi.Size = new Size(138, 28);
            cbSinifSecimi.TabIndex = 7;
            // 
            // txtNumara
            // 
            txtNumara.Location = new Point(155, 157);
            txtNumara.Margin = new Padding(3, 4, 3, 4);
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(138, 27);
            txtNumara.TabIndex = 6;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(155, 113);
            txtSoyad.Margin = new Padding(3, 4, 3, 4);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(138, 27);
            txtSoyad.TabIndex = 5;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(155, 75);
            txtAd.Margin = new Padding(3, 4, 3, 4);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(138, 27);
            txtAd.TabIndex = 4;
            // 
            // lblSinifSecimi
            // 
            lblSinifSecimi.AutoSize = true;
            lblSinifSecimi.Location = new Point(23, 200);
            lblSinifSecimi.Name = "lblSinifSecimi";
            lblSinifSecimi.Size = new Size(88, 20);
            lblSinifSecimi.TabIndex = 3;
            lblSinifSecimi.Text = "Sınıf Seçiniz";
            // 
            // lblNumara
            // 
            lblNumara.AutoSize = true;
            lblNumara.Location = new Point(22, 157);
            lblNumara.Name = "lblNumara";
            lblNumara.Size = new Size(62, 20);
            lblNumara.TabIndex = 2;
            lblNumara.Text = "Numara";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(22, 117);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(50, 20);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(22, 68);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(28, 20);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(191, 293);
            btnKaydet.Margin = new Padding(3, 4, 3, 4);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(137, 31);
            btnKaydet.TabIndex = 0;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(35, 293);
            btnGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(133, 31);
            btnGuncelle.TabIndex = 1;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnBul
            // 
            btnBul.Location = new Point(353, 293);
            btnBul.Margin = new Padding(3, 4, 3, 4);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(133, 31);
            btnBul.TabIndex = 2;
            btnBul.Text = "Bul";
            btnBul.UseVisualStyleBackColor = true;
            btnBul.Click += btnBul_Click;
            // 
            // btnDersSecimi
            // 
            btnDersSecimi.Location = new Point(191, 355);
            btnDersSecimi.Margin = new Padding(3, 4, 3, 4);
            btnDersSecimi.Name = "btnDersSecimi";
            btnDersSecimi.Size = new Size(137, 32);
            btnDersSecimi.TabIndex = 3;
            btnDersSecimi.Text = "Ders Seçimi";
            btnDersSecimi.UseVisualStyleBackColor = true;
            btnDersSecimi.Click += btnDersSecimi_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 439);
            Controls.Add(btnDersSecimi);
            Controls.Add(btnBul);
            Controls.Add(btnKaydet);
            Controls.Add(btnGuncelle);
            Controls.Add(grpOgrenciBul);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegisterForm";
            Text = "Bul";
            Load += Form1_Load;
            grpOgrenciBul.ResumeLayout(false);
            grpOgrenciBul.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpOgrenciBul;
        private Button btnKaydet;
        private Button btnGuncelle;
        private Button btnBul;
        private Button btnDersSecimi;
        private ComboBox cbSinifSecimi;
        private TextBox txtNumara;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label lblSinifSecimi;
        private Label lblNumara;
        private Label lblSoyad;
        private Label lblAd;
    }
}
