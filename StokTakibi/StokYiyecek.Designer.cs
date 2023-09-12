namespace PizzaciSon1.StokTakibi
{
    partial class StokYiyecek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokYiyecek));
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            btnCikis = new Button();
            ımageList3 = new ImageList(components);
            lstViewStok = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            btnDus = new Button();
            txtBxMiktar2 = new TextBox();
            cmbBxStokAdi2 = new ComboBox();
            label3 = new Label();
            btnEkle = new Button();
            txtBxMiktar = new TextBox();
            cmbBxStokAdi = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 5;
            bunifuElipse1.TargetControl = this;
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
            btnCikis.Location = new Point(1229, 8);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(46, 43);
            btnCikis.TabIndex = 50;
            btnCikis.UseVisualStyleBackColor = false;
            // 
            // ımageList3
            // 
            ımageList3.ColorDepth = ColorDepth.Depth32Bit;
            ımageList3.ImageStream = (ImageListStreamer)resources.GetObject("ımageList3.ImageStream");
            ımageList3.TransparentColor = Color.Transparent;
            ımageList3.Images.SetKeyName(0, "x-g66b252b67_640.png");
            // 
            // lstViewStok
            // 
            lstViewStok.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lstViewStok.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lstViewStok.Location = new Point(187, 108);
            lstViewStok.Name = "lstViewStok";
            lstViewStok.Size = new Size(439, 489);
            lstViewStok.TabIndex = 49;
            lstViewStok.UseCompatibleStateImageBehavior = false;
            lstViewStok.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Stok Adı";
            columnHeader1.Width = 215;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Stok Miktarı";
            columnHeader2.Width = 215;
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
            btnDus.Location = new Point(798, 436);
            btnDus.Name = "btnDus";
            btnDus.Size = new Size(200, 43);
            btnDus.TabIndex = 48;
            btnDus.Text = "Stok Düş";
            btnDus.UseVisualStyleBackColor = false;
            // 
            // txtBxMiktar2
            // 
            txtBxMiktar2.BorderStyle = BorderStyle.None;
            txtBxMiktar2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxMiktar2.Location = new Point(798, 396);
            txtBxMiktar2.Multiline = true;
            txtBxMiktar2.Name = "txtBxMiktar2";
            txtBxMiktar2.Size = new Size(200, 34);
            txtBxMiktar2.TabIndex = 47;
            // 
            // cmbBxStokAdi2
            // 
            cmbBxStokAdi2.FlatStyle = FlatStyle.Flat;
            cmbBxStokAdi2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBxStokAdi2.FormattingEnabled = true;
            cmbBxStokAdi2.Location = new Point(798, 358);
            cmbBxStokAdi2.Name = "cmbBxStokAdi2";
            cmbBxStokAdi2.Size = new Size(200, 32);
            cmbBxStokAdi2.TabIndex = 46;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(692, 396);
            label3.Name = "label3";
            label3.Size = new Size(100, 40);
            label3.TabIndex = 45;
            label3.Text = "Miktar:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
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
            btnEkle.Location = new Point(798, 285);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(200, 43);
            btnEkle.TabIndex = 44;
            btnEkle.Text = "Stok Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            // 
            // txtBxMiktar
            // 
            txtBxMiktar.BorderStyle = BorderStyle.None;
            txtBxMiktar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxMiktar.Location = new Point(798, 245);
            txtBxMiktar.Multiline = true;
            txtBxMiktar.Name = "txtBxMiktar";
            txtBxMiktar.Size = new Size(200, 34);
            txtBxMiktar.TabIndex = 43;
            // 
            // cmbBxStokAdi
            // 
            cmbBxStokAdi.FlatStyle = FlatStyle.Flat;
            cmbBxStokAdi.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBxStokAdi.FormattingEnabled = true;
            cmbBxStokAdi.Location = new Point(798, 207);
            cmbBxStokAdi.Name = "cmbBxStokAdi";
            cmbBxStokAdi.Size = new Size(200, 32);
            cmbBxStokAdi.TabIndex = 42;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(692, 245);
            label2.Name = "label2";
            label2.Size = new Size(100, 40);
            label2.TabIndex = 41;
            label2.Text = "Miktar:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 8);
            label1.Name = "label1";
            label1.Size = new Size(1261, 67);
            label1.TabIndex = 40;
            label1.Text = "Yiyecek Stok";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // StokYiyecek
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1285, 635);
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
            Name = "StokYiyecek";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StokYiyecek";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Button btnCikis;
        private ImageList ımageList3;
        private ListView lstViewStok;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button btnDus;
        private TextBox txtBxMiktar2;
        private ComboBox cmbBxStokAdi2;
        private Label label3;
        private Button btnEkle;
        private TextBox txtBxMiktar;
        private ComboBox cmbBxStokAdi;
        private Label label2;
        private Label label1;
    }
}