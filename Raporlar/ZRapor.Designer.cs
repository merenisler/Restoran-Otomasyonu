namespace PizzaciSon1.Siparis
{
    partial class ZRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZRapor));
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            ımageList3 = new ImageList(components);
            btnCikis = new Button();
            lstViewZRapor = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            btnYazdir = new Button();
            printPreviewDialog1 = new PrintPreviewDialog();
            printZRapor = new System.Drawing.Printing.PrintDocument();
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
            btnCikis.Location = new Point(1233, 6);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(46, 43);
            btnCikis.TabIndex = 40;
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // lstViewZRapor
            // 
            lstViewZRapor.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader3, columnHeader4, columnHeader5, columnHeader2 });
            lstViewZRapor.Font = new Font("Microsoft Sans Serif", 18.75F, FontStyle.Regular, GraphicsUnit.Point);
            lstViewZRapor.GridLines = true;
            lstViewZRapor.Location = new Point(2, 55);
            lstViewZRapor.Name = "lstViewZRapor";
            lstViewZRapor.Size = new Size(1280, 577);
            lstViewZRapor.TabIndex = 41;
            lstViewZRapor.UseCompatibleStateImageBehavior = false;
            lstViewZRapor.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Satıcı";
            columnHeader1.Width = 210;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ödeme Saati";
            columnHeader3.Width = 335;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Ödeme Durumu";
            columnHeader4.Width = 310;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "İşlem";
            columnHeader5.Width = 210;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tutar(TL)";
            columnHeader2.Width = 205;
            // 
            // btnYazdir
            // 
            btnYazdir.BackColor = Color.Lime;
            btnYazdir.FlatAppearance.BorderSize = 0;
            btnYazdir.FlatStyle = FlatStyle.Flat;
            btnYazdir.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnYazdir.ForeColor = Color.Black;
            btnYazdir.ImageAlign = ContentAlignment.MiddleLeft;
            btnYazdir.ImageIndex = 0;
            btnYazdir.Location = new Point(4, 3);
            btnYazdir.Name = "btnYazdir";
            btnYazdir.Size = new Size(150, 50);
            btnYazdir.TabIndex = 42;
            btnYazdir.Text = "Yazdır";
            btnYazdir.UseVisualStyleBackColor = false;
            btnYazdir.Click += btnYazdir_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printZRapor;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printZRapor
            // 
            printZRapor.PrintPage += printZRapor_PrintPage;
            // 
            // ZRapor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1285, 635);
            Controls.Add(btnYazdir);
            Controls.Add(lstViewZRapor);
            Controls.Add(btnCikis);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ZRapor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ZRapor";
            Load += ZRapor_Load;
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Button btnCikis;
        private ImageList ımageList3;
        private ListView lstViewZRapor;
        private Button btnYazdir;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader2;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printZRapor;
    }
}