namespace PizzaciSon1
{
    partial class GunlukGiderler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GunlukGiderler));
            lstViewPersonel = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            lstViewMarketMutfak = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            txtBxPesonelAd = new TextBox();
            txtBxPesonelFiyat = new TextBox();
            btnPersonel = new Button();
            btnMarketMutfak = new Button();
            txtBxMutfak = new TextBox();
            txtBxMarket = new TextBox();
            ımageList3 = new ImageList(components);
            btnCikis = new Button();
            btnPersonelKaldir = new Button();
            btnMarketMutfakKaldir = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lstViewPersonel
            // 
            lstViewPersonel.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lstViewPersonel.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lstViewPersonel.FullRowSelect = true;
            lstViewPersonel.GridLines = true;
            lstViewPersonel.Location = new Point(12, 213);
            lstViewPersonel.Name = "lstViewPersonel";
            lstViewPersonel.Size = new Size(525, 410);
            lstViewPersonel.TabIndex = 39;
            lstViewPersonel.UseCompatibleStateImageBehavior = false;
            lstViewPersonel.View = View.Details;
            lstViewPersonel.SelectedIndexChanged += lstViewPersonel_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Personel Adı";
            columnHeader1.Width = 310;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Personel Gider";
            columnHeader2.Width = 200;
            // 
            // lstViewMarketMutfak
            // 
            lstViewMarketMutfak.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4 });
            lstViewMarketMutfak.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lstViewMarketMutfak.FullRowSelect = true;
            lstViewMarketMutfak.GridLines = true;
            lstViewMarketMutfak.Location = new Point(748, 213);
            lstViewMarketMutfak.Name = "lstViewMarketMutfak";
            lstViewMarketMutfak.Size = new Size(525, 410);
            lstViewMarketMutfak.TabIndex = 40;
            lstViewMarketMutfak.UseCompatibleStateImageBehavior = false;
            lstViewMarketMutfak.View = View.Details;
            lstViewMarketMutfak.SelectedIndexChanged += lstViewMarketMutfak_SelectedIndexChanged;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Market Giderleri";
            columnHeader3.Width = 255;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Mutfak Giderleri";
            columnHeader4.Width = 255;
            // 
            // txtBxPesonelAd
            // 
            txtBxPesonelAd.BorderStyle = BorderStyle.None;
            txtBxPesonelAd.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxPesonelAd.ForeColor = SystemColors.ScrollBar;
            txtBxPesonelAd.Location = new Point(12, 104);
            txtBxPesonelAd.Multiline = true;
            txtBxPesonelAd.Name = "txtBxPesonelAd";
            txtBxPesonelAd.Size = new Size(395, 40);
            txtBxPesonelAd.TabIndex = 41;
            txtBxPesonelAd.Text = "Personel Adı";
            txtBxPesonelAd.TextAlign = HorizontalAlignment.Center;
            txtBxPesonelAd.Click += txtBxPesonelAd_Click;
            // 
            // txtBxPesonelFiyat
            // 
            txtBxPesonelFiyat.BorderStyle = BorderStyle.None;
            txtBxPesonelFiyat.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxPesonelFiyat.ForeColor = SystemColors.ScrollBar;
            txtBxPesonelFiyat.Location = new Point(413, 104);
            txtBxPesonelFiyat.Multiline = true;
            txtBxPesonelFiyat.Name = "txtBxPesonelFiyat";
            txtBxPesonelFiyat.Size = new Size(124, 40);
            txtBxPesonelFiyat.TabIndex = 42;
            txtBxPesonelFiyat.Text = "Ücret";
            txtBxPesonelFiyat.TextAlign = HorizontalAlignment.Center;
            txtBxPesonelFiyat.Click += txtBxPesonelFiyat_Click;
            txtBxPesonelFiyat.KeyPress += txtBxPesonelFiyat_KeyPress;
            // 
            // btnPersonel
            // 
            btnPersonel.BackColor = Color.Coral;
            btnPersonel.FlatAppearance.BorderSize = 0;
            btnPersonel.FlatStyle = FlatStyle.Flat;
            btnPersonel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnPersonel.ForeColor = Color.Black;
            btnPersonel.ImageAlign = ContentAlignment.MiddleLeft;
            btnPersonel.ImageIndex = 0;
            btnPersonel.Location = new Point(12, 157);
            btnPersonel.Name = "btnPersonel";
            btnPersonel.Size = new Size(343, 43);
            btnPersonel.TabIndex = 43;
            btnPersonel.Text = "Günlük Personel Gider Ekle";
            btnPersonel.UseVisualStyleBackColor = false;
            btnPersonel.Click += btnPersonel_Click;
            // 
            // btnMarketMutfak
            // 
            btnMarketMutfak.BackColor = Color.Coral;
            btnMarketMutfak.FlatAppearance.BorderSize = 0;
            btnMarketMutfak.FlatStyle = FlatStyle.Flat;
            btnMarketMutfak.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnMarketMutfak.ForeColor = Color.Black;
            btnMarketMutfak.ImageAlign = ContentAlignment.MiddleLeft;
            btnMarketMutfak.ImageIndex = 0;
            btnMarketMutfak.Location = new Point(748, 157);
            btnMarketMutfak.Name = "btnMarketMutfak";
            btnMarketMutfak.Size = new Size(343, 43);
            btnMarketMutfak.TabIndex = 46;
            btnMarketMutfak.Text = "Market Mutfak Gideri Ekle";
            btnMarketMutfak.UseVisualStyleBackColor = false;
            btnMarketMutfak.Click += btnMarketMutfak_Click;
            // 
            // txtBxMutfak
            // 
            txtBxMutfak.BorderStyle = BorderStyle.None;
            txtBxMutfak.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxMutfak.ForeColor = SystemColors.ScrollBar;
            txtBxMutfak.Location = new Point(1019, 104);
            txtBxMutfak.Multiline = true;
            txtBxMutfak.Name = "txtBxMutfak";
            txtBxMutfak.Size = new Size(254, 40);
            txtBxMutfak.TabIndex = 45;
            txtBxMutfak.Text = "Mutfak";
            txtBxMutfak.TextAlign = HorizontalAlignment.Center;
            txtBxMutfak.Click += txtBxMutfak_Click;
            txtBxMutfak.KeyPress += txtBxMutfak_KeyPress;
            // 
            // txtBxMarket
            // 
            txtBxMarket.BorderStyle = BorderStyle.None;
            txtBxMarket.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxMarket.ForeColor = SystemColors.ScrollBar;
            txtBxMarket.Location = new Point(748, 104);
            txtBxMarket.Multiline = true;
            txtBxMarket.Name = "txtBxMarket";
            txtBxMarket.Size = new Size(265, 40);
            txtBxMarket.TabIndex = 44;
            txtBxMarket.Text = "Market";
            txtBxMarket.TextAlign = HorizontalAlignment.Center;
            txtBxMarket.Click += txtBxMarket_Click;
            txtBxMarket.KeyPress += txtBxMarket_KeyPress;
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
            btnCikis.TabIndex = 47;
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnPersonelKaldir
            // 
            btnPersonelKaldir.BackColor = Color.Red;
            btnPersonelKaldir.FlatAppearance.BorderSize = 0;
            btnPersonelKaldir.FlatStyle = FlatStyle.Flat;
            btnPersonelKaldir.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPersonelKaldir.ForeColor = Color.White;
            btnPersonelKaldir.ImageIndex = 0;
            btnPersonelKaldir.Location = new Point(391, 157);
            btnPersonelKaldir.Name = "btnPersonelKaldir";
            btnPersonelKaldir.Size = new Size(146, 43);
            btnPersonelKaldir.TabIndex = 48;
            btnPersonelKaldir.Text = "Kaldır";
            btnPersonelKaldir.UseVisualStyleBackColor = false;
            btnPersonelKaldir.Click += btnPersonelKaldir_Click;
            // 
            // btnMarketMutfakKaldir
            // 
            btnMarketMutfakKaldir.BackColor = Color.Red;
            btnMarketMutfakKaldir.FlatAppearance.BorderSize = 0;
            btnMarketMutfakKaldir.FlatStyle = FlatStyle.Flat;
            btnMarketMutfakKaldir.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnMarketMutfakKaldir.ForeColor = Color.White;
            btnMarketMutfakKaldir.ImageIndex = 0;
            btnMarketMutfakKaldir.Location = new Point(1127, 155);
            btnMarketMutfakKaldir.Name = "btnMarketMutfakKaldir";
            btnMarketMutfakKaldir.Size = new Size(146, 43);
            btnMarketMutfakKaldir.TabIndex = 49;
            btnMarketMutfakKaldir.Text = "Kaldır";
            btnMarketMutfakKaldir.UseVisualStyleBackColor = false;
            btnMarketMutfakKaldir.Click += btnMarketMutfakKaldir_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 32.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(488, 9);
            label1.Name = "label1";
            label1.Size = new Size(354, 66);
            label1.TabIndex = 50;
            label1.Text = "Günlük Giderler";
            // 
            // GunlukGiderler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1285, 635);
            Controls.Add(label1);
            Controls.Add(btnMarketMutfakKaldir);
            Controls.Add(btnPersonelKaldir);
            Controls.Add(btnCikis);
            Controls.Add(btnMarketMutfak);
            Controls.Add(txtBxMutfak);
            Controls.Add(txtBxMarket);
            Controls.Add(btnPersonel);
            Controls.Add(txtBxPesonelFiyat);
            Controls.Add(txtBxPesonelAd);
            Controls.Add(lstViewMarketMutfak);
            Controls.Add(lstViewPersonel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GunlukGiderler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GunlukGiderler";
            Load += GunlukGiderler_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView lstViewMarketMutfak;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ListView lstViewPersonel;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private TextBox txtBxPesonelFiyat;
        private TextBox txtBxPesonelAd;
        private Button btnMarketMutfak;
        private TextBox txtBxMutfak;
        private TextBox txtBxMarket;
        private Button btnPersonel;
        private Button btnCikis;
        private ImageList ımageList3;
        private Button btnPersonelKaldir;
        private Button btnMarketMutfakKaldir;
        private Label label1;
    }
}