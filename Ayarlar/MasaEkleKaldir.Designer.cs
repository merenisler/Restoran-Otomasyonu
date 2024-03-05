namespace PizzaciSon1.Ayarlar
{
    partial class MasaEkleKaldir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasaEkleKaldir));
            ımageList3 = new ImageList(components);
            btnCikis = new Button();
            btnUrunDuzenle = new Button();
            btnUrunEkleKaldir = new Button();
            label1 = new Label();
            lstViewMasalar = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            cmbBxMasaYeri = new ComboBox();
            btnListele = new Button();
            label2 = new Label();
            btnKaldir = new Button();
            label5 = new Label();
            btnEkle = new Button();
            cmbBxMasaYeri2 = new ComboBox();
            label6 = new Label();
            cmbBxMasaNo = new ComboBox();
            SuspendLayout();
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
            // btnUrunDuzenle
            // 
            btnUrunDuzenle.BackColor = Color.Coral;
            btnUrunDuzenle.FlatAppearance.BorderSize = 0;
            btnUrunDuzenle.FlatStyle = FlatStyle.Flat;
            btnUrunDuzenle.Font = new Font("Microsoft Sans Serif", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnUrunDuzenle.ForeColor = Color.Black;
            btnUrunDuzenle.ImageAlign = ContentAlignment.MiddleLeft;
            btnUrunDuzenle.ImageIndex = 0;
            btnUrunDuzenle.Location = new Point(905, 9);
            btnUrunDuzenle.Name = "btnUrunDuzenle";
            btnUrunDuzenle.Size = new Size(320, 59);
            btnUrunDuzenle.TabIndex = 49;
            btnUrunDuzenle.Text = "Ürün Düzenle";
            btnUrunDuzenle.UseVisualStyleBackColor = false;
            btnUrunDuzenle.Click += btnUrunDuzenle_Click;
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
            btnUrunEkleKaldir.Location = new Point(580, 9);
            btnUrunEkleKaldir.Name = "btnUrunEkleKaldir";
            btnUrunEkleKaldir.Size = new Size(320, 59);
            btnUrunEkleKaldir.TabIndex = 50;
            btnUrunEkleKaldir.Text = "Ürün Ekle/Kaldır";
            btnUrunEkleKaldir.UseVisualStyleBackColor = false;
            btnUrunEkleKaldir.Click += btnUrunEkleKaldir_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 35.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(531, 67);
            label1.TabIndex = 51;
            label1.Text = "Masa Ekle/Kaldır Ekranı";
            // 
            // lstViewMasalar
            // 
            lstViewMasalar.BorderStyle = BorderStyle.None;
            lstViewMasalar.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5 });
            lstViewMasalar.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstViewMasalar.FullRowSelect = true;
            lstViewMasalar.GridLines = true;
            lstViewMasalar.Location = new Point(12, 255);
            lstViewMasalar.Name = "lstViewMasalar";
            lstViewMasalar.Size = new Size(830, 368);
            lstViewMasalar.TabIndex = 52;
            lstViewMasalar.UseCompatibleStateImageBehavior = false;
            lstViewMasalar.View = View.Details;
            lstViewMasalar.SelectedIndexChanged += lstViewMasalar_SelectedIndexChanged;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Masa No";
            columnHeader4.Width = 275;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Masa Yeri";
            columnHeader5.Width = 275;
            // 
            // cmbBxMasaYeri
            // 
            cmbBxMasaYeri.FlatStyle = FlatStyle.Flat;
            cmbBxMasaYeri.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBxMasaYeri.FormattingEnabled = true;
            cmbBxMasaYeri.Items.AddRange(new object[] { "Salon", "Bahçe" });
            cmbBxMasaYeri.Location = new Point(174, 142);
            cmbBxMasaYeri.Name = "cmbBxMasaYeri";
            cmbBxMasaYeri.Size = new Size(187, 33);
            cmbBxMasaYeri.TabIndex = 53;
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
            btnListele.TabIndex = 55;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = false;
            btnListele.Click += btnListele_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 139);
            label2.Name = "label2";
            label2.Size = new Size(155, 41);
            label2.TabIndex = 56;
            label2.Text = "Masa Yeri:";
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
            btnKaldir.Location = new Point(655, 201);
            btnKaldir.Name = "btnKaldir";
            btnKaldir.Size = new Size(187, 48);
            btnKaldir.TabIndex = 58;
            btnKaldir.Text = "Kaldır";
            btnKaldir.UseVisualStyleBackColor = false;
            btnKaldir.Click += btnKaldir_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(880, 421);
            label5.Name = "label5";
            label5.Size = new Size(155, 41);
            label5.TabIndex = 62;
            label5.Text = "Masa Yeri:";
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.LimeGreen;
            btnEkle.FlatAppearance.BorderSize = 0;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEkle.ForeColor = Color.Black;
            btnEkle.ImageAlign = ContentAlignment.MiddleLeft;
            btnEkle.ImageIndex = 0;
            btnEkle.Location = new Point(1038, 463);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(187, 40);
            btnEkle.TabIndex = 61;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // cmbBxMasaYeri2
            // 
            cmbBxMasaYeri2.FlatStyle = FlatStyle.Flat;
            cmbBxMasaYeri2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBxMasaYeri2.FormattingEnabled = true;
            cmbBxMasaYeri2.Items.AddRange(new object[] { "Salon", "Bahçe" });
            cmbBxMasaYeri2.Location = new Point(1038, 423);
            cmbBxMasaYeri2.Name = "cmbBxMasaYeri2";
            cmbBxMasaYeri2.Size = new Size(187, 33);
            cmbBxMasaYeri2.TabIndex = 59;
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(880, 382);
            label6.Name = "label6";
            label6.Size = new Size(155, 41);
            label6.TabIndex = 65;
            label6.Text = "Masa No:";
            // 
            // cmbBxMasaNo
            // 
            cmbBxMasaNo.FlatStyle = FlatStyle.Flat;
            cmbBxMasaNo.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBxMasaNo.FormattingEnabled = true;
            cmbBxMasaNo.Location = new Point(1038, 383);
            cmbBxMasaNo.Name = "cmbBxMasaNo";
            cmbBxMasaNo.Size = new Size(187, 33);
            cmbBxMasaNo.TabIndex = 64;
            // 
            // MasaEkleKaldir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1285, 635);
            Controls.Add(cmbBxMasaYeri);
            Controls.Add(label6);
            Controls.Add(cmbBxMasaNo);
            Controls.Add(label5);
            Controls.Add(btnEkle);
            Controls.Add(cmbBxMasaYeri2);
            Controls.Add(btnKaldir);
            Controls.Add(label2);
            Controls.Add(btnListele);
            Controls.Add(lstViewMasalar);
            Controls.Add(label1);
            Controls.Add(btnUrunEkleKaldir);
            Controls.Add(btnUrunDuzenle);
            Controls.Add(btnCikis);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MasaEkleKaldir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MasaEkleKaldir";
            ResumeLayout(false);
        }

        #endregion
        private Button btnCikis;
        private ImageList ımageList3;
        private Button btnUrunDuzenle;
        private Button btnUrunEkleKaldir;
        private Label label1;
        private ListView lstViewMasalar;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ComboBox cmbBxMasaYeri;
        private Button btnListele;
        private Button btnKaldir;
        private Label label2;
        private Label label6;
        private ComboBox cmbBxMasaNo;
        private Label label5;
        private Button btnEkle;
        private ComboBox cmbBxMasaYeri2;
    }
}