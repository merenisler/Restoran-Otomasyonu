namespace PizzaciSon1
{
    partial class SiparisAtama
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisAtama));
            ımageList5 = new ImageList(components);
            btnCikis = new Button();
            btnKuryeEkleCikar = new Button();
            btnKuryeIstatistik = new Button();
            label1 = new Label();
            lstView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            lstViewSiparis = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            txtBxToplamTutar = new TextBox();
            cmbBxKuryeAd = new ComboBox();
            btnKuryeAta = new Button();
            btnDurumDegistir = new Button();
            columnHeader6 = new ColumnHeader();
            SuspendLayout();
            // 
            // ımageList5
            // 
            ımageList5.ColorDepth = ColorDepth.Depth32Bit;
            ımageList5.ImageStream = (ImageListStreamer)resources.GetObject("ımageList5.ImageStream");
            ımageList5.TransparentColor = Color.Transparent;
            ımageList5.Images.SetKeyName(0, "x-g66b252b67_640.png");
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.Red;
            btnCikis.FlatAppearance.BorderSize = 0;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCikis.ForeColor = Color.Black;
            btnCikis.ImageIndex = 0;
            btnCikis.ImageList = ımageList5;
            btnCikis.Location = new Point(1230, 10);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(47, 47);
            btnCikis.TabIndex = 58;
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnKuryeEkleCikar
            // 
            btnKuryeEkleCikar.BackColor = Color.MistyRose;
            btnKuryeEkleCikar.FlatAppearance.BorderSize = 0;
            btnKuryeEkleCikar.FlatStyle = FlatStyle.Flat;
            btnKuryeEkleCikar.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnKuryeEkleCikar.ImageAlign = ContentAlignment.MiddleLeft;
            btnKuryeEkleCikar.ImageIndex = 0;
            btnKuryeEkleCikar.Location = new Point(944, 8);
            btnKuryeEkleCikar.Name = "btnKuryeEkleCikar";
            btnKuryeEkleCikar.Size = new Size(280, 50);
            btnKuryeEkleCikar.TabIndex = 59;
            btnKuryeEkleCikar.Text = "Kurye Ekle/Çıkar";
            btnKuryeEkleCikar.UseVisualStyleBackColor = false;
            btnKuryeEkleCikar.Click += btnKuryeEkleCikar_Click;
            // 
            // btnKuryeIstatistik
            // 
            btnKuryeIstatistik.BackColor = Color.MistyRose;
            btnKuryeIstatistik.FlatAppearance.BorderSize = 0;
            btnKuryeIstatistik.FlatStyle = FlatStyle.Flat;
            btnKuryeIstatistik.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnKuryeIstatistik.ImageAlign = ContentAlignment.MiddleLeft;
            btnKuryeIstatistik.ImageIndex = 0;
            btnKuryeIstatistik.Location = new Point(658, 8);
            btnKuryeIstatistik.Name = "btnKuryeIstatistik";
            btnKuryeIstatistik.Size = new Size(280, 50);
            btnKuryeIstatistik.TabIndex = 60;
            btnKuryeIstatistik.Text = "Kurye İstatistik";
            btnKuryeIstatistik.UseVisualStyleBackColor = false;
            btnKuryeIstatistik.Click += btnKuryeIstatistik_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 35.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(0, 8);
            label1.Name = "label1";
            label1.Size = new Size(659, 67);
            label1.TabIndex = 61;
            label1.Text = "Sipariş Atama";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lstView
            // 
            lstView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            lstView.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lstView.FullRowSelect = true;
            lstView.Location = new Point(12, 90);
            lstView.Name = "lstView";
            lstView.Size = new Size(720, 540);
            lstView.TabIndex = 62;
            lstView.UseCompatibleStateImageBehavior = false;
            lstView.View = View.Details;
            lstView.SelectedIndexChanged += lstView_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "SiparisId";
            columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Kurye İsmi";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Sipariş Saat";
            columnHeader3.Width = 125;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Kurye Yola Çıkış Saat";
            columnHeader4.Width = 145;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Teslim Saat";
            columnHeader5.Width = 130;
            // 
            // lstViewSiparis
            // 
            lstViewSiparis.BorderStyle = BorderStyle.None;
            lstViewSiparis.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12 });
            lstViewSiparis.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lstViewSiparis.Location = new Point(734, 90);
            lstViewSiparis.Name = "lstViewSiparis";
            lstViewSiparis.Size = new Size(305, 492);
            lstViewSiparis.TabIndex = 63;
            lstViewSiparis.UseCompatibleStateImageBehavior = false;
            lstViewSiparis.View = View.Details;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "yazdır";
            columnHeader7.Width = 1;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Adet";
            columnHeader8.Width = 48;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Ürün";
            columnHeader9.Width = 185;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Fiyatı";
            columnHeader10.Width = 65;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "urun";
            columnHeader11.Width = 3;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "kategori";
            columnHeader12.Width = 1;
            // 
            // txtBxToplamTutar
            // 
            txtBxToplamTutar.BackColor = Color.Black;
            txtBxToplamTutar.BorderStyle = BorderStyle.None;
            txtBxToplamTutar.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxToplamTutar.ForeColor = Color.White;
            txtBxToplamTutar.Location = new Point(734, 583);
            txtBxToplamTutar.Multiline = true;
            txtBxToplamTutar.Name = "txtBxToplamTutar";
            txtBxToplamTutar.Size = new Size(306, 48);
            txtBxToplamTutar.TabIndex = 64;
            txtBxToplamTutar.Text = "Toplam Tutar: 0.00";
            txtBxToplamTutar.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbBxKuryeAd
            // 
            cmbBxKuryeAd.FlatStyle = FlatStyle.Flat;
            cmbBxKuryeAd.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBxKuryeAd.FormattingEnabled = true;
            cmbBxKuryeAd.Location = new Point(1059, 310);
            cmbBxKuryeAd.Name = "cmbBxKuryeAd";
            cmbBxKuryeAd.Size = new Size(210, 33);
            cmbBxKuryeAd.TabIndex = 65;
            // 
            // btnKuryeAta
            // 
            btnKuryeAta.BackColor = Color.GreenYellow;
            btnKuryeAta.FlatAppearance.BorderSize = 0;
            btnKuryeAta.FlatStyle = FlatStyle.Flat;
            btnKuryeAta.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnKuryeAta.ImageAlign = ContentAlignment.MiddleLeft;
            btnKuryeAta.ImageIndex = 0;
            btnKuryeAta.Location = new Point(1064, 354);
            btnKuryeAta.Name = "btnKuryeAta";
            btnKuryeAta.Size = new Size(200, 40);
            btnKuryeAta.TabIndex = 66;
            btnKuryeAta.Text = "Kurye Ata";
            btnKuryeAta.UseVisualStyleBackColor = false;
            btnKuryeAta.Click += btnKuryeAta_Click;
            // 
            // btnDurumDegistir
            // 
            btnDurumDegistir.BackColor = Color.GreenYellow;
            btnDurumDegistir.FlatAppearance.BorderSize = 0;
            btnDurumDegistir.FlatStyle = FlatStyle.Flat;
            btnDurumDegistir.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDurumDegistir.ImageAlign = ContentAlignment.MiddleLeft;
            btnDurumDegistir.ImageIndex = 0;
            btnDurumDegistir.Location = new Point(1055, 408);
            btnDurumDegistir.Name = "btnDurumDegistir";
            btnDurumDegistir.Size = new Size(219, 40);
            btnDurumDegistir.TabIndex = 68;
            btnDurumDegistir.Text = "Sipariş Teslim Edildi";
            btnDurumDegistir.UseVisualStyleBackColor = false;
            btnDurumDegistir.Click += btnDurumDegistir_Click;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Sipariş Durumu";
            columnHeader6.Width = 120;
            // 
            // SiparisAtama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1285, 635);
            Controls.Add(btnDurumDegistir);
            Controls.Add(btnKuryeAta);
            Controls.Add(cmbBxKuryeAd);
            Controls.Add(txtBxToplamTutar);
            Controls.Add(lstViewSiparis);
            Controls.Add(lstView);
            Controls.Add(label1);
            Controls.Add(btnKuryeIstatistik);
            Controls.Add(btnKuryeEkleCikar);
            Controls.Add(btnCikis);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SiparisAtama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KuryeIslemleri";
            Load += SiparisAtama_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList ımageList5;
        private Button btnCikis;
        private Button btnKuryeEkleCikar;
        private Button btnKuryeIstatistik;
        private Label label1;
        private ListView lstView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ListView lstViewSiparis;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private TextBox txtBxToplamTutar;
        private ComboBox cmbBxKuryeAd;
        private ColumnHeader columnHeader5;
        private Button btnKuryeAta;
        private Button btnDurumDegistir;
        private ColumnHeader columnHeader6;
    }
}