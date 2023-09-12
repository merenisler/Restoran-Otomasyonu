namespace PizzaciSon1.Ayarlar
{
    partial class UrunDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunDuzenle));
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            ımageList3 = new ImageList(components);
            btnCikis = new Button();
            ımageList1 = new ImageList(components);
            lstViewUrunler = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            label1 = new Label();
            btnUrunEkleKaldir = new Button();
            btnMasaEkleKaldir = new Button();
            label2 = new Label();
            btnListele = new Button();
            cmbBxKategori = new ComboBox();
            txtBxUrunAdi = new TextBox();
            txtBxUrunFiyati = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnGuncelle = new Button();
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
            // btnCikis
            // 
            btnCikis.BackColor = Color.Red;
            btnCikis.FlatAppearance.BorderSize = 0;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCikis.ForeColor = Color.Black;
            btnCikis.ImageIndex = 0;
            btnCikis.ImageList = ımageList3;
            btnCikis.Location = new Point(1231, 9);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(46, 43);
            btnCikis.TabIndex = 42;
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "x-g66b252b67_640.png");
            // 
            // lstViewUrunler
            // 
            lstViewUrunler.BorderStyle = BorderStyle.None;
            lstViewUrunler.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader1, columnHeader3 });
            lstViewUrunler.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstViewUrunler.FullRowSelect = true;
            lstViewUrunler.GridLines = true;
            lstViewUrunler.Location = new Point(10, 256);
            lstViewUrunler.Name = "lstViewUrunler";
            lstViewUrunler.Size = new Size(830, 368);
            lstViewUrunler.TabIndex = 57;
            lstViewUrunler.UseCompatibleStateImageBehavior = false;
            lstViewUrunler.View = View.Details;
            lstViewUrunler.SelectedIndexChanged += lstViewUrunler_SelectedIndexChanged;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Ürün Adı";
            columnHeader4.Width = 375;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Ürün Fiyatı";
            columnHeader5.Width = 175;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Kategori";
            columnHeader1.Width = 220;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "id";
            columnHeader3.Width = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 35.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(531, 67);
            label1.TabIndex = 56;
            label1.Text = "Ürün Düzenle Ekranı";
            // 
            // btnUrunEkleKaldir
            // 
            btnUrunEkleKaldir.BackColor = Color.CornflowerBlue;
            btnUrunEkleKaldir.FlatAppearance.BorderSize = 0;
            btnUrunEkleKaldir.FlatStyle = FlatStyle.Flat;
            btnUrunEkleKaldir.Font = new Font("Microsoft Sans Serif", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnUrunEkleKaldir.ForeColor = Color.Black;
            btnUrunEkleKaldir.ImageAlign = ContentAlignment.MiddleLeft;
            btnUrunEkleKaldir.ImageIndex = 0;
            btnUrunEkleKaldir.Location = new Point(578, 10);
            btnUrunEkleKaldir.Name = "btnUrunEkleKaldir";
            btnUrunEkleKaldir.Size = new Size(320, 59);
            btnUrunEkleKaldir.TabIndex = 55;
            btnUrunEkleKaldir.Text = "Ürün Ekle/Kaldır";
            btnUrunEkleKaldir.UseVisualStyleBackColor = false;
            btnUrunEkleKaldir.Click += btnUrunEkleKaldir_Click;
            // 
            // btnMasaEkleKaldir
            // 
            btnMasaEkleKaldir.BackColor = Color.Coral;
            btnMasaEkleKaldir.FlatAppearance.BorderSize = 0;
            btnMasaEkleKaldir.FlatStyle = FlatStyle.Flat;
            btnMasaEkleKaldir.Font = new Font("Microsoft Sans Serif", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnMasaEkleKaldir.ForeColor = Color.Black;
            btnMasaEkleKaldir.ImageAlign = ContentAlignment.MiddleLeft;
            btnMasaEkleKaldir.ImageIndex = 0;
            btnMasaEkleKaldir.Location = new Point(903, 10);
            btnMasaEkleKaldir.Name = "btnMasaEkleKaldir";
            btnMasaEkleKaldir.Size = new Size(320, 59);
            btnMasaEkleKaldir.TabIndex = 54;
            btnMasaEkleKaldir.Text = "Masa Ekle/Kaldır";
            btnMasaEkleKaldir.UseVisualStyleBackColor = false;
            btnMasaEkleKaldir.Click += btnMasaEkleKaldir_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(34, 139);
            label2.Name = "label2";
            label2.Size = new Size(130, 41);
            label2.TabIndex = 60;
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
            btnListele.TabIndex = 59;
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
            cmbBxKategori.TabIndex = 58;
            // 
            // txtBxUrunAdi
            // 
            txtBxUrunAdi.BorderStyle = BorderStyle.None;
            txtBxUrunAdi.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxUrunAdi.Location = new Point(1023, 371);
            txtBxUrunAdi.Multiline = true;
            txtBxUrunAdi.Name = "txtBxUrunAdi";
            txtBxUrunAdi.Size = new Size(230, 38);
            txtBxUrunAdi.TabIndex = 61;
            txtBxUrunAdi.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBxUrunFiyati
            // 
            txtBxUrunFiyati.BorderStyle = BorderStyle.None;
            txtBxUrunFiyati.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxUrunFiyati.Location = new Point(1023, 417);
            txtBxUrunFiyati.Multiline = true;
            txtBxUrunFiyati.Name = "txtBxUrunFiyati";
            txtBxUrunFiyati.Size = new Size(230, 38);
            txtBxUrunFiyati.TabIndex = 62;
            txtBxUrunFiyati.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(858, 416);
            label3.Name = "label3";
            label3.Size = new Size(159, 41);
            label3.TabIndex = 65;
            label3.Text = "Ürün Fiyatı:";
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(858, 371);
            label4.Name = "label4";
            label4.Size = new Size(130, 41);
            label4.TabIndex = 66;
            label4.Text = "Ürün Adı:";
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.LimeGreen;
            btnGuncelle.FlatAppearance.BorderSize = 0;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuncelle.ForeColor = Color.Black;
            btnGuncelle.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuncelle.ImageIndex = 0;
            btnGuncelle.Location = new Point(1045, 471);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(187, 45);
            btnGuncelle.TabIndex = 67;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // UrunDuzenle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1285, 635);
            Controls.Add(btnGuncelle);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtBxUrunFiyati);
            Controls.Add(txtBxUrunAdi);
            Controls.Add(label2);
            Controls.Add(btnListele);
            Controls.Add(cmbBxKategori);
            Controls.Add(lstViewUrunler);
            Controls.Add(label1);
            Controls.Add(btnUrunEkleKaldir);
            Controls.Add(btnMasaEkleKaldir);
            Controls.Add(btnCikis);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UrunDuzenle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UrunDuzenle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Button btnCikis;
        private ImageList ımageList3;
        private ListView lstViewUrunler;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label1;
        private Button btnUrunEkleKaldir;
        private Button btnMasaEkleKaldir;
        private ImageList ımageList1;
        private Label label2;
        private Button btnListele;
        private ComboBox cmbBxKategori;
        private TextBox txtBxUrunAdi;
        private TextBox txtBxUrunFiyati;
        private Label label3;
        private Label label4;
        private Button btnGuncelle;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
    }
}