namespace PizzaciSon1.Siparis
{
    partial class AdisyonRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdisyonRapor));
            btnCikis = new Button();
            ımageList3 = new ImageList(components);
            lstViewAdisyonRapor = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            lstViewSiparis = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            txtBxToplamTutar = new TextBox();
            btnYazdir = new Button();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            btnDuzenle = new Button();
            SuspendLayout();
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
            btnCikis.Location = new Point(1231, 8);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(46, 43);
            btnCikis.TabIndex = 41;
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // ımageList3
            // 
            ımageList3.ColorDepth = ColorDepth.Depth32Bit;
            ımageList3.ImageStream = (ImageListStreamer)resources.GetObject("ımageList3.ImageStream");
            ımageList3.TransparentColor = Color.Transparent;
            ımageList3.Images.SetKeyName(0, "x-g66b252b67_640.png");
            // 
            // lstViewAdisyonRapor
            // 
            lstViewAdisyonRapor.BorderStyle = BorderStyle.None;
            lstViewAdisyonRapor.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader3, columnHeader4, columnHeader5, columnHeader2, columnHeader6, columnHeader13 });
            lstViewAdisyonRapor.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lstViewAdisyonRapor.FullRowSelect = true;
            lstViewAdisyonRapor.GridLines = true;
            lstViewAdisyonRapor.Location = new Point(8, 8);
            lstViewAdisyonRapor.Name = "lstViewAdisyonRapor";
            lstViewAdisyonRapor.Size = new Size(866, 621);
            lstViewAdisyonRapor.TabIndex = 42;
            lstViewAdisyonRapor.UseCompatibleStateImageBehavior = false;
            lstViewAdisyonRapor.View = View.Details;
            lstViewAdisyonRapor.SelectedIndexChanged += lstViewAdisyonRapor_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Adisyon No";
            columnHeader1.Width = 125;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Açılış Saati";
            columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Kapanış Saati";
            columnHeader4.Width = 155;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Ödeme Durumu";
            columnHeader5.Width = 170;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "İşlem";
            columnHeader2.Width = 115;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Tutar(TL)";
            columnHeader6.Width = 115;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Fiş İçeriği";
            columnHeader13.Width = 250;
            // 
            // lstViewSiparis
            // 
            lstViewSiparis.BorderStyle = BorderStyle.None;
            lstViewSiparis.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12 });
            lstViewSiparis.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lstViewSiparis.Location = new Point(880, 8);
            lstViewSiparis.Name = "lstViewSiparis";
            lstViewSiparis.Size = new Size(303, 567);
            lstViewSiparis.TabIndex = 43;
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
            txtBxToplamTutar.Location = new Point(880, 581);
            txtBxToplamTutar.Multiline = true;
            txtBxToplamTutar.Name = "txtBxToplamTutar";
            txtBxToplamTutar.Size = new Size(305, 48);
            txtBxToplamTutar.TabIndex = 44;
            txtBxToplamTutar.Text = "Toplam Tutar: 0.00";
            txtBxToplamTutar.TextAlign = HorizontalAlignment.Center;
            // 
            // btnYazdir
            // 
            btnYazdir.BackColor = Color.DarkSeaGreen;
            btnYazdir.FlatAppearance.BorderSize = 0;
            btnYazdir.FlatStyle = FlatStyle.Flat;
            btnYazdir.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnYazdir.ImageAlign = ContentAlignment.MiddleLeft;
            btnYazdir.ImageIndex = 0;
            btnYazdir.Location = new Point(1191, 553);
            btnYazdir.Name = "btnYazdir";
            btnYazdir.Size = new Size(86, 76);
            btnYazdir.TabIndex = 45;
            btnYazdir.Text = "Yazdır";
            btnYazdir.UseVisualStyleBackColor = false;
            btnYazdir.Click += btnYazdir_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // btnDuzenle
            // 
            btnDuzenle.BackColor = Color.LimeGreen;
            btnDuzenle.FlatAppearance.BorderSize = 0;
            btnDuzenle.FlatStyle = FlatStyle.Flat;
            btnDuzenle.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDuzenle.ImageAlign = ContentAlignment.MiddleLeft;
            btnDuzenle.ImageIndex = 0;
            btnDuzenle.Location = new Point(1191, 471);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(86, 76);
            btnDuzenle.TabIndex = 46;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.UseVisualStyleBackColor = false;
            btnDuzenle.Visible = false;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // AdisyonRapor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1285, 635);
            Controls.Add(btnDuzenle);
            Controls.Add(btnYazdir);
            Controls.Add(txtBxToplamTutar);
            Controls.Add(lstViewSiparis);
            Controls.Add(lstViewAdisyonRapor);
            Controls.Add(btnCikis);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdisyonRapor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdisyonRapor";
            Load += AdisyonRapor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCikis;
        private ImageList ımageList3;
        private ListView lstViewAdisyonRapor;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader6;
        private ListView lstViewSiparis;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private TextBox txtBxToplamTutar;
        private Button btnYazdir;
        private ColumnHeader columnHeader13;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button btnDuzenle;
    }
}