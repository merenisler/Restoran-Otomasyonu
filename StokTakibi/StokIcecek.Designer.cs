namespace PizzaciSon1.StokTakibi
{
    partial class StokIcecek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokIcecek));
            label1 = new Label();
            label2 = new Label();
            cmbBxStokAdi = new ComboBox();
            txtBxMiktar = new TextBox();
            btnEkle = new Button();
            btnDus = new Button();
            txtBxMiktar2 = new TextBox();
            cmbBxStokAdi2 = new ComboBox();
            label3 = new Label();
            lstViewStok = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            ımageList3 = new ImageList(components);
            btnCikis = new Button();
            btnFire = new Button();
            txtFire = new TextBox();
            label4 = new Label();
            lblFireIcecek = new Label();
            lblFire = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(1261, 67);
            label1.TabIndex = 1;
            label1.Text = "İçecek";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(637, 246);
            label2.Name = "label2";
            label2.Size = new Size(100, 40);
            label2.TabIndex = 2;
            label2.Text = "Miktar:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbBxStokAdi
            // 
            cmbBxStokAdi.FlatStyle = FlatStyle.Flat;
            cmbBxStokAdi.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBxStokAdi.FormattingEnabled = true;
            cmbBxStokAdi.Location = new Point(743, 208);
            cmbBxStokAdi.Name = "cmbBxStokAdi";
            cmbBxStokAdi.Size = new Size(200, 32);
            cmbBxStokAdi.TabIndex = 5;
            // 
            // txtBxMiktar
            // 
            txtBxMiktar.BorderStyle = BorderStyle.None;
            txtBxMiktar.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxMiktar.Location = new Point(743, 246);
            txtBxMiktar.Multiline = true;
            txtBxMiktar.Name = "txtBxMiktar";
            txtBxMiktar.Size = new Size(200, 34);
            txtBxMiktar.TabIndex = 16;
            txtBxMiktar.TextAlign = HorizontalAlignment.Center;
            txtBxMiktar.KeyPress += txtBxMiktar_KeyPress;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Coral;
            btnEkle.FlatAppearance.BorderSize = 0;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnEkle.ForeColor = Color.Black;
            btnEkle.ImageAlign = ContentAlignment.MiddleLeft;
            btnEkle.ImageIndex = 0;
            btnEkle.Location = new Point(743, 286);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(200, 43);
            btnEkle.TabIndex = 33;
            btnEkle.Text = "Stok Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnDus
            // 
            btnDus.BackColor = Color.Coral;
            btnDus.FlatAppearance.BorderSize = 0;
            btnDus.FlatStyle = FlatStyle.Flat;
            btnDus.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnDus.ForeColor = Color.Black;
            btnDus.ImageAlign = ContentAlignment.MiddleLeft;
            btnDus.ImageIndex = 0;
            btnDus.Location = new Point(743, 437);
            btnDus.Name = "btnDus";
            btnDus.Size = new Size(200, 43);
            btnDus.TabIndex = 37;
            btnDus.Text = "Stok Düş";
            btnDus.UseVisualStyleBackColor = false;
            btnDus.Click += btnDus_Click;
            // 
            // txtBxMiktar2
            // 
            txtBxMiktar2.BorderStyle = BorderStyle.None;
            txtBxMiktar2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxMiktar2.Location = new Point(743, 397);
            txtBxMiktar2.Multiline = true;
            txtBxMiktar2.Name = "txtBxMiktar2";
            txtBxMiktar2.Size = new Size(200, 34);
            txtBxMiktar2.TabIndex = 36;
            txtBxMiktar2.TextAlign = HorizontalAlignment.Center;
            txtBxMiktar2.KeyPress += txtBxMiktar2_KeyPress;
            // 
            // cmbBxStokAdi2
            // 
            cmbBxStokAdi2.FlatStyle = FlatStyle.Flat;
            cmbBxStokAdi2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBxStokAdi2.FormattingEnabled = true;
            cmbBxStokAdi2.Location = new Point(743, 359);
            cmbBxStokAdi2.Name = "cmbBxStokAdi2";
            cmbBxStokAdi2.Size = new Size(200, 32);
            cmbBxStokAdi2.TabIndex = 35;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(637, 397);
            label3.Name = "label3";
            label3.Size = new Size(100, 40);
            label3.TabIndex = 34;
            label3.Text = "Miktar:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lstViewStok
            // 
            lstViewStok.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lstViewStok.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lstViewStok.FullRowSelect = true;
            lstViewStok.Location = new Point(145, 109);
            lstViewStok.Name = "lstViewStok";
            lstViewStok.Size = new Size(439, 489);
            lstViewStok.TabIndex = 38;
            lstViewStok.UseCompatibleStateImageBehavior = false;
            lstViewStok.View = View.Details;
            lstViewStok.SelectedIndexChanged += lstViewStok_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Stok Adı";
            columnHeader1.Width = 270;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Stok Miktarı";
            columnHeader2.Width = 140;
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
            btnCikis.TabIndex = 39;
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnFire
            // 
            btnFire.BackColor = Color.Coral;
            btnFire.FlatAppearance.BorderSize = 0;
            btnFire.FlatStyle = FlatStyle.Flat;
            btnFire.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnFire.ForeColor = Color.Black;
            btnFire.ImageAlign = ContentAlignment.MiddleLeft;
            btnFire.ImageIndex = 0;
            btnFire.Location = new Point(1069, 358);
            btnFire.Name = "btnFire";
            btnFire.Size = new Size(200, 43);
            btnFire.TabIndex = 42;
            btnFire.Text = "Fire";
            btnFire.UseVisualStyleBackColor = false;
            btnFire.Click += btnFire_Click;
            // 
            // txtFire
            // 
            txtFire.BorderStyle = BorderStyle.None;
            txtFire.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFire.Location = new Point(1069, 318);
            txtFire.Multiline = true;
            txtFire.Name = "txtFire";
            txtFire.Size = new Size(200, 34);
            txtFire.TabIndex = 41;
            txtFire.TextAlign = HorizontalAlignment.Center;
            txtFire.KeyPress += txtFire_KeyPress;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(965, 318);
            label4.Name = "label4";
            label4.Size = new Size(100, 40);
            label4.TabIndex = 40;
            label4.Text = "Miktar:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFireIcecek
            // 
            lblFireIcecek.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblFireIcecek.Location = new Point(1030, 421);
            lblFireIcecek.Name = "lblFireIcecek";
            lblFireIcecek.Size = new Size(250, 38);
            lblFireIcecek.TabIndex = 43;
            lblFireIcecek.Text = "İçecek Fire Tutarı: ";
            lblFireIcecek.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFire
            // 
            lblFire.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblFire.Location = new Point(1030, 460);
            lblFire.Name = "lblFire";
            lblFire.Size = new Size(250, 38);
            lblFire.TabIndex = 44;
            lblFire.Text = "Toplam Fire Tutarı: ";
            lblFire.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // StokIcecek
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1285, 635);
            Controls.Add(lblFire);
            Controls.Add(lblFireIcecek);
            Controls.Add(btnFire);
            Controls.Add(txtFire);
            Controls.Add(label4);
            Controls.Add(btnCikis);
            Controls.Add(lstViewStok);
            Controls.Add(btnDus);
            Controls.Add(txtBxMiktar2);
            Controls.Add(cmbBxStokAdi2);
            Controls.Add(label3);
            Controls.Add(btnEkle);
            Controls.Add(txtBxMiktar);
            Controls.Add(cmbBxStokAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StokIcecek";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StokIcecek";
            Load += StokIcecek_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbBxStokAdi;
        private Label label2;
        private Label label1;
        private TextBox txtBxMiktar;
        private ListView lstViewStok;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button btnDus;
        private TextBox txtBxMiktar2;
        private ComboBox cmbBxStokAdi2;
        private Label label3;
        private Button btnEkle;
        private Button btnCikis;
        private ImageList ımageList3;
        private Label lblFireIcecek;
        private Button btnFire;
        private TextBox txtFire;
        private Label label4;
        private Label lblFire;
    }
}