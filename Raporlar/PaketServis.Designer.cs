namespace PizzaciSon1.Raporlar
{
    partial class PaketServis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaketServis));
            lstViewPaketServis = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            ımageList3 = new ImageList(components);
            btnCikis = new Button();
            lstViewSiparis = new ListView();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            txtBxToplamTutar = new TextBox();
            label1 = new Label();
            txtBxAdres = new TextBox();
            label2 = new Label();
            btnYazdir = new Button();
            txtBxTelefon = new TextBox();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            SuspendLayout();
            // 
            // lstViewPaketServis
            // 
            lstViewPaketServis.BorderStyle = BorderStyle.None;
            lstViewPaketServis.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader3, columnHeader4, columnHeader5, columnHeader2, columnHeader6, columnHeader7 });
            lstViewPaketServis.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstViewPaketServis.FullRowSelect = true;
            lstViewPaketServis.GridLines = true;
            lstViewPaketServis.Location = new Point(8, 8);
            lstViewPaketServis.Name = "lstViewPaketServis";
            lstViewPaketServis.Size = new Size(866, 621);
            lstViewPaketServis.TabIndex = 43;
            lstViewPaketServis.UseCompatibleStateImageBehavior = false;
            lstViewPaketServis.View = View.Details;
            lstViewPaketServis.SelectedIndexChanged += lstViewPaketServis_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Adisyon No";
            columnHeader1.Width = 110;
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
            columnHeader5.Text = "Adres";
            columnHeader5.Width = 175;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Telefon";
            columnHeader2.Width = 145;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Tutar(TL)";
            columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Fiş İçeriği";
            columnHeader7.Width = 250;
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
            btnCikis.Location = new Point(1231, 8);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(46, 43);
            btnCikis.TabIndex = 44;
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // lstViewSiparis
            // 
            lstViewSiparis.BorderStyle = BorderStyle.None;
            lstViewSiparis.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader13 });
            lstViewSiparis.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lstViewSiparis.Location = new Point(880, 8);
            lstViewSiparis.Name = "lstViewSiparis";
            lstViewSiparis.Size = new Size(303, 365);
            lstViewSiparis.TabIndex = 45;
            lstViewSiparis.UseCompatibleStateImageBehavior = false;
            lstViewSiparis.View = View.Details;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "yazdır";
            columnHeader8.Width = 1;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Adet";
            columnHeader9.Width = 48;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Ürün";
            columnHeader10.Width = 185;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Fiyatı";
            columnHeader11.Width = 65;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "urun";
            columnHeader12.Width = 3;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "kategori";
            columnHeader13.Width = 1;
            // 
            // txtBxToplamTutar
            // 
            txtBxToplamTutar.BackColor = Color.Black;
            txtBxToplamTutar.BorderStyle = BorderStyle.None;
            txtBxToplamTutar.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxToplamTutar.ForeColor = Color.White;
            txtBxToplamTutar.Location = new Point(879, 374);
            txtBxToplamTutar.Multiline = true;
            txtBxToplamTutar.Name = "txtBxToplamTutar";
            txtBxToplamTutar.Size = new Size(305, 48);
            txtBxToplamTutar.TabIndex = 46;
            txtBxToplamTutar.Text = "Toplam Tutar: 0.00";
            txtBxToplamTutar.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(879, 430);
            label1.Name = "label1";
            label1.Size = new Size(118, 41);
            label1.TabIndex = 47;
            label1.Text = "Adres:";
            // 
            // txtBxAdres
            // 
            txtBxAdres.BorderStyle = BorderStyle.None;
            txtBxAdres.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxAdres.Location = new Point(880, 474);
            txtBxAdres.Multiline = true;
            txtBxAdres.Name = "txtBxAdres";
            txtBxAdres.Size = new Size(305, 57);
            txtBxAdres.TabIndex = 48;
            txtBxAdres.KeyPress += txtBxAdres_KeyPress;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(879, 541);
            label2.Name = "label2";
            label2.Size = new Size(180, 41);
            label2.TabIndex = 49;
            label2.Text = "Telefon:";
            // 
            // btnYazdir
            // 
            btnYazdir.BackColor = Color.DarkSeaGreen;
            btnYazdir.FlatAppearance.BorderSize = 0;
            btnYazdir.FlatStyle = FlatStyle.Flat;
            btnYazdir.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnYazdir.ImageAlign = ContentAlignment.MiddleLeft;
            btnYazdir.ImageIndex = 0;
            btnYazdir.Location = new Point(1191, 552);
            btnYazdir.Name = "btnYazdir";
            btnYazdir.Size = new Size(86, 76);
            btnYazdir.TabIndex = 51;
            btnYazdir.Text = "Yazdır";
            btnYazdir.UseVisualStyleBackColor = false;
            btnYazdir.Click += btnYazdir_Click;
            // 
            // txtBxTelefon
            // 
            txtBxTelefon.BorderStyle = BorderStyle.None;
            txtBxTelefon.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxTelefon.Location = new Point(880, 582);
            txtBxTelefon.Multiline = true;
            txtBxTelefon.Name = "txtBxTelefon";
            txtBxTelefon.Size = new Size(305, 46);
            txtBxTelefon.TabIndex = 52;
            txtBxTelefon.KeyPress += txtBxTelefon_KeyPress;
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
            // PaketServis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1285, 635);
            Controls.Add(txtBxTelefon);
            Controls.Add(btnYazdir);
            Controls.Add(label2);
            Controls.Add(txtBxAdres);
            Controls.Add(label1);
            Controls.Add(txtBxToplamTutar);
            Controls.Add(lstViewSiparis);
            Controls.Add(btnCikis);
            Controls.Add(lstViewPaketServis);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PaketServis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PaketServis";
            Load += PaketServis_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView lstViewPaketServis;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Button btnCikis;
        private ImageList ımageList3;
        private ListView lstViewSiparis;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private TextBox txtBxToplamTutar;
        private Label label1;
        private TextBox txtBxAdres;
        private Label label2;
        private Button btnYazdir;
        private TextBox txtBxTelefon;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}