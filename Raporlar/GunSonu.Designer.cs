namespace PizzaciSon1.Raporlar
{
    partial class GunSonu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GunSonu));
            ımageList3 = new ImageList(components);
            btnCikis = new Button();
            lstViewGunSonu = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            lstViewGunSonuFiyatlar = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
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
            btnCikis.Location = new Point(1215, 9);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(46, 43);
            btnCikis.TabIndex = 41;
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // lstViewGunSonu
            // 
            lstViewGunSonu.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader3, columnHeader4, columnHeader5, columnHeader2 });
            lstViewGunSonu.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lstViewGunSonu.GridLines = true;
            lstViewGunSonu.Location = new Point(12, 90);
            lstViewGunSonu.Name = "lstViewGunSonu";
            lstViewGunSonu.Size = new Size(522, 73);
            lstViewGunSonu.TabIndex = 42;
            lstViewGunSonu.UseCompatibleStateImageBehavior = false;
            lstViewGunSonu.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "İkram";
            columnHeader1.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Yiyecek";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "İçecek";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "İptal Yiyecek";
            columnHeader5.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "İptal İçecek";
            columnHeader2.Width = 100;
            // 
            // lstViewGunSonuFiyatlar
            // 
            lstViewGunSonuFiyatlar.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            lstViewGunSonuFiyatlar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lstViewGunSonuFiyatlar.GridLines = true;
            lstViewGunSonuFiyatlar.Location = new Point(12, 271);
            lstViewGunSonuFiyatlar.Name = "lstViewGunSonuFiyatlar";
            lstViewGunSonuFiyatlar.Size = new Size(522, 73);
            lstViewGunSonuFiyatlar.TabIndex = 43;
            lstViewGunSonuFiyatlar.UseCompatibleStateImageBehavior = false;
            lstViewGunSonuFiyatlar.View = View.Details;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "İkram";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Yiyecek";
            columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "İçecek";
            columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "İptal Yiyecek";
            columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "İptal İçecek";
            columnHeader10.Width = 100;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(44, 20);
            label1.Name = "label1";
            label1.Size = new Size(216, 45);
            label1.TabIndex = 44;
            label1.Text = "Gün Sonu:";
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(44, 208);
            label2.Name = "label2";
            label2.Size = new Size(305, 45);
            label2.TabIndex = 45;
            label2.Text = "Gün Sonu Fiyatlar:";
            // 
            // GunSonu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1269, 591);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstViewGunSonuFiyatlar);
            Controls.Add(lstViewGunSonu);
            Controls.Add(btnCikis);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GunSonu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GunSonu";
            Load += GunSonu_Load;
            ResumeLayout(false);
        }

        #endregion

        private ImageList ımageList3;
        private Button btnCikis;
        private ListView lstViewGunSonu;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader2;
        private ListView lstViewGunSonuFiyatlar;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private Label label1;
        private Label label2;
    }
}