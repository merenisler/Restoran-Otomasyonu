namespace PizzaciSon1.Ayarlar
{
    partial class UrunEkleKaldir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunEkleKaldir));
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            ımageList3 = new ImageList(components);
            label1 = new Label();
            btnMasaEkleKaldir = new Button();
            btnUrunDuzenle = new Button();
            btnCikis = new Button();
            cmbBxStokKategori = new ComboBox();
            cmbBxUrunKategori = new ComboBox();
            txtBxUrunFiyati = new TextBox();
            txtBxUrunAdi = new TextBox();
            label2 = new Label();
            btnListele = new Button();
            cmbBxKategori = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnEkle = new Button();
            lstViewUrunler = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            btnKaldir = new Button();
            SuspendLayout();
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 5;
            bunifuElipse1.TargetControl = this;
            // 
            // ımageList3
            // 
            ımageList3.ColorDepth = ColorDepth.Depth32Bit;
            ımageList3.ImageStream = (ImageListStreamer)resources.GetObject("ımageList3.ImageStream");
            ımageList3.TransparentColor = Color.Transparent;
            ımageList3.Images.SetKeyName(0, "x-g66b252b67_640.png");
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 35.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(9, 10);
            label1.Name = "label1";
            label1.Size = new Size(531, 67);
            label1.TabIndex = 56;
            label1.Text = "Ürün Ekle/Kaldır Ekranı";
            // 
            // btnMasaEkleKaldir
            // 
            btnMasaEkleKaldir.BackColor = Color.CornflowerBlue;
            btnMasaEkleKaldir.FlatAppearance.BorderSize = 0;
            btnMasaEkleKaldir.FlatStyle = FlatStyle.Flat;
            btnMasaEkleKaldir.Font = new Font("Microsoft Sans Serif", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnMasaEkleKaldir.ForeColor = Color.Black;
            btnMasaEkleKaldir.ImageAlign = ContentAlignment.MiddleLeft;
            btnMasaEkleKaldir.ImageIndex = 0;
            btnMasaEkleKaldir.Location = new Point(577, 10);
            btnMasaEkleKaldir.Name = "btnMasaEkleKaldir";
            btnMasaEkleKaldir.Size = new Size(320, 59);
            btnMasaEkleKaldir.TabIndex = 55;
            btnMasaEkleKaldir.Text = "Masa Ekle/Kaldır";
            btnMasaEkleKaldir.UseVisualStyleBackColor = false;
            btnMasaEkleKaldir.Click += btnMasaEkleKaldir_Click;
            // 
            // btnUrunDuzenle
            // 
            btnUrunDuzenle.BackColor = Color.Coral;
            btnUrunDuzenle.FlatAppearance.BorderSize = 0;
            btnUrunDuzenle.FlatStyle = FlatStyle.Flat;
            btnUrunDuzenle.Font = new Font("Microsoft Sans Serif", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnUrunDuzenle.ForeColor = Color.Black;
            btnUrunDuzenle.ImageAlign = ContentAlignment.MiddleLeft;
            btnUrunDuzenle.ImageIndex = 0;
            btnUrunDuzenle.Location = new Point(902, 10);
            btnUrunDuzenle.Name = "btnUrunDuzenle";
            btnUrunDuzenle.Size = new Size(320, 59);
            btnUrunDuzenle.TabIndex = 54;
            btnUrunDuzenle.Text = "Ürün Düzenle";
            btnUrunDuzenle.UseVisualStyleBackColor = false;
            btnUrunDuzenle.Click += btnUrunDuzenle_Click;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.Red;
            btnCikis.FlatAppearance.BorderSize = 0;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCikis.ForeColor = Color.Black;
            btnCikis.ImageIndex = 0;
            btnCikis.ImageList = ımageList3;
            btnCikis.Location = new Point(1228, 10);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(46, 43);
            btnCikis.TabIndex = 53;
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // cmbBxStokKategori
            // 
            cmbBxStokKategori.FlatStyle = FlatStyle.Flat;
            cmbBxStokKategori.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBxStokKategori.FormattingEnabled = true;
            cmbBxStokKategori.Location = new Point(1042, 473);
            cmbBxStokKategori.Name = "cmbBxStokKategori";
            cmbBxStokKategori.Size = new Size(225, 33);
            cmbBxStokKategori.TabIndex = 68;
            // 
            // cmbBxUrunKategori
            // 
            cmbBxUrunKategori.FlatStyle = FlatStyle.Flat;
            cmbBxUrunKategori.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBxUrunKategori.FormattingEnabled = true;
            cmbBxUrunKategori.Items.AddRange(new object[] { "Yiyecek", "İçecek" });
            cmbBxUrunKategori.Location = new Point(1042, 434);
            cmbBxUrunKategori.Name = "cmbBxUrunKategori";
            cmbBxUrunKategori.Size = new Size(225, 33);
            cmbBxUrunKategori.TabIndex = 67;
            cmbBxUrunKategori.SelectedIndexChanged += cmbBxUrunKategori_SelectedIndexChanged;
            // 
            // txtBxUrunFiyati
            // 
            txtBxUrunFiyati.BorderStyle = BorderStyle.None;
            txtBxUrunFiyati.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxUrunFiyati.Location = new Point(1042, 389);
            txtBxUrunFiyati.Multiline = true;
            txtBxUrunFiyati.Name = "txtBxUrunFiyati";
            txtBxUrunFiyati.Size = new Size(225, 38);
            txtBxUrunFiyati.TabIndex = 66;
            // 
            // txtBxUrunAdi
            // 
            txtBxUrunAdi.BorderStyle = BorderStyle.None;
            txtBxUrunAdi.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxUrunAdi.Location = new Point(1042, 344);
            txtBxUrunAdi.Multiline = true;
            txtBxUrunAdi.Name = "txtBxUrunAdi";
            txtBxUrunAdi.Size = new Size(225, 38);
            txtBxUrunAdi.TabIndex = 65;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(34, 139);
            label2.Name = "label2";
            label2.Size = new Size(130, 41);
            label2.TabIndex = 71;
            label2.Text = "Kategori:";
            // 
            // btnListele
            // 
            btnListele.BackColor = Color.GreenYellow;
            btnListele.FlatAppearance.BorderSize = 0;
            btnListele.FlatStyle = FlatStyle.Flat;
            btnListele.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnListele.ForeColor = Color.Black;
            btnListele.ImageAlign = ContentAlignment.MiddleLeft;
            btnListele.ImageIndex = 0;
            btnListele.Location = new Point(174, 184);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(187, 40);
            btnListele.TabIndex = 70;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = false;
            btnListele.Click += btnListele_Click;
            // 
            // cmbBxKategori
            // 
            cmbBxKategori.FlatStyle = FlatStyle.Flat;
            cmbBxKategori.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBxKategori.FormattingEnabled = true;
            cmbBxKategori.Items.AddRange(new object[] { "Yiyecek", "İçecek" });
            cmbBxKategori.Location = new Point(174, 142);
            cmbBxKategori.Name = "cmbBxKategori";
            cmbBxKategori.Size = new Size(187, 33);
            cmbBxKategori.TabIndex = 69;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(846, 342);
            label4.Name = "label4";
            label4.Size = new Size(160, 41);
            label4.TabIndex = 73;
            label4.Text = "Ürün Adı:";
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(846, 387);
            label3.Name = "label3";
            label3.Size = new Size(189, 41);
            label3.TabIndex = 72;
            label3.Text = "Ürün Fiyatı:";
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(847, 430);
            label5.Name = "label5";
            label5.Size = new Size(189, 41);
            label5.TabIndex = 74;
            label5.Text = "Kategori:";
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(847, 471);
            label6.Name = "label6";
            label6.Size = new Size(189, 41);
            label6.TabIndex = 75;
            label6.Text = "Stok Kategori:";
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.LimeGreen;
            btnEkle.FlatAppearance.BorderSize = 0;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Regular, GraphicsUnit.Point);
            btnEkle.ForeColor = Color.Black;
            btnEkle.ImageAlign = ContentAlignment.MiddleLeft;
            btnEkle.ImageIndex = 0;
            btnEkle.Location = new Point(1062, 521);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(187, 45);
            btnEkle.TabIndex = 76;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // lstViewUrunler
            // 
            lstViewUrunler.BorderStyle = BorderStyle.None;
            lstViewUrunler.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lstViewUrunler.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstViewUrunler.FullRowSelect = true;
            lstViewUrunler.GridLines = true;
            lstViewUrunler.Location = new Point(9, 256);
            lstViewUrunler.Name = "lstViewUrunler";
            lstViewUrunler.Size = new Size(830, 368);
            lstViewUrunler.TabIndex = 77;
            lstViewUrunler.UseCompatibleStateImageBehavior = false;
            lstViewUrunler.View = View.Details;
            lstViewUrunler.SelectedIndexChanged += lstViewUrunler_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Ürün Adı";
            columnHeader1.Width = 375;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ürün Fiyatı";
            columnHeader2.Width = 175;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Kategori";
            columnHeader3.Width = 220;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "id";
            columnHeader4.Width = 1;
            // 
            // btnKaldir
            // 
            btnKaldir.BackColor = Color.Crimson;
            btnKaldir.FlatAppearance.BorderSize = 0;
            btnKaldir.FlatStyle = FlatStyle.Flat;
            btnKaldir.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnKaldir.ForeColor = Color.Black;
            btnKaldir.ImageAlign = ContentAlignment.MiddleLeft;
            btnKaldir.ImageIndex = 0;
            btnKaldir.Location = new Point(652, 202);
            btnKaldir.Name = "btnKaldir";
            btnKaldir.Size = new Size(187, 48);
            btnKaldir.TabIndex = 78;
            btnKaldir.Text = "Kaldır";
            btnKaldir.UseVisualStyleBackColor = false;
            btnKaldir.Click += btnKaldir_Click;
            // 
            // UrunEkleKaldir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1285, 635);
            Controls.Add(btnKaldir);
            Controls.Add(btnEkle);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnListele);
            Controls.Add(cmbBxKategori);
            Controls.Add(cmbBxStokKategori);
            Controls.Add(cmbBxUrunKategori);
            Controls.Add(txtBxUrunFiyati);
            Controls.Add(txtBxUrunAdi);
            Controls.Add(label1);
            Controls.Add(btnMasaEkleKaldir);
            Controls.Add(btnUrunDuzenle);
            Controls.Add(btnCikis);
            Controls.Add(lstViewUrunler);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UrunEkleKaldir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UrunEkleKaldir";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Label label1;
        private Button btnMasaEkleKaldir;
        private Button btnUrunDuzenle;
        private Button btnCikis;
        private ImageList ımageList3;
        private Label label2;
        private Button btnListele;
        private ComboBox cmbBxKategori;
        private ComboBox cmbBxStokKategori;
        private ComboBox cmbBxUrunKategori;
        private TextBox txtBxUrunFiyati;
        private TextBox txtBxUrunAdi;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
        private Button btnEkle;
        private ListView lstViewUrunler;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnKaldir;
        private ColumnHeader columnHeader4;
    }
}