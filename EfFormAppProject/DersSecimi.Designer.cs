namespace EfFormAppProject
{
    partial class DersSecimi
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
            dataGridViewDersler = new DataGridView();
            lblOgrenciBilgi = new Label();
            btnKaydet = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDersler).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDersler
            // 
            dataGridViewDersler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDersler.Location = new Point(50, 144);
            dataGridViewDersler.Margin = new Padding(3, 4, 3, 4);
            dataGridViewDersler.Name = "dataGridViewDersler";
            dataGridViewDersler.RowHeadersWidth = 51;
            dataGridViewDersler.Size = new Size(542, 256);
            dataGridViewDersler.TabIndex = 0;
            // 
            // lblOgrenciBilgi
            // 
            lblOgrenciBilgi.AutoSize = true;
            lblOgrenciBilgi.Location = new Point(173, 40);
            lblOgrenciBilgi.Name = "lblOgrenciBilgi";
            lblOgrenciBilgi.Size = new Size(0, 20);
            lblOgrenciBilgi.TabIndex = 1;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(283, 424);
            btnKaydet.Margin = new Padding(3, 4, 3, 4);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(86, 31);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // DersSecimi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 495);
            Controls.Add(btnKaydet);
            Controls.Add(lblOgrenciBilgi);
            Controls.Add(dataGridViewDersler);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DersSecimi";
            Text = "DersSecimi";
            Load += DersSecimi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDersler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewDersler;
        private Label lblOgrenciBilgi;
        private Button btnKaydet;
    }
}