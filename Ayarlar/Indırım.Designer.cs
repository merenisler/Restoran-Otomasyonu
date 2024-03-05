namespace PizzaciSon1.Ayarlar
{
    partial class Indırım
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Indırım));
            ımageList3 = new ImageList(components);
            btnCikis = new Button();
            label1 = new Label();
            lstViewIndırımKodları = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            label6 = new Label();
            label5 = new Label();
            btnEkle = new Button();
            txtBxIndırımKodu = new TextBox();
            sonKullanmaTarihi = new DateTimePicker();
            sonKullanmaTarihi2 = new DateTimePicker();
            txtBxIndırımKodu2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnDuzenle = new Button();
            btnKaldir = new Button();
            txtBxId2 = new TextBox();
            label4 = new Label();
            txtBxId = new TextBox();
            label7 = new Label();
            txtBxIndirimOrani2 = new TextBox();
            label8 = new Label();
            txtBxIndirimOrani = new TextBox();
            label9 = new Label();
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
            btnCikis.Location = new Point(1232, 8);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(46, 43);
            btnCikis.TabIndex = 46;
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 35.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(858, 67);
            label1.TabIndex = 52;
            label1.Text = "İndirim Kodu Ekle/Kaldır/Düzenle Ekranı";
            // 
            // lstViewIndırımKodları
            // 
            lstViewIndırımKodları.BorderStyle = BorderStyle.None;
            lstViewIndırımKodları.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader2, columnHeader5, columnHeader1 });
            lstViewIndırımKodları.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lstViewIndırımKodları.FullRowSelect = true;
            lstViewIndırımKodları.GridLines = true;
            lstViewIndırımKodları.Location = new Point(379, 160);
            lstViewIndırımKodları.Name = "lstViewIndırımKodları";
            lstViewIndırımKodları.Size = new Size(533, 463);
            lstViewIndırımKodları.TabIndex = 53;
            lstViewIndırımKodları.UseCompatibleStateImageBehavior = false;
            lstViewIndırımKodları.View = View.Details;
            lstViewIndırımKodları.SelectedIndexChanged += lstViewIndırımKodları_SelectedIndexChanged;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "İndirim Kodu";
            columnHeader4.Width = 170;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "İndirim Oranı";
            columnHeader2.Width = 135;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Son Kullanma Tarihi";
            columnHeader5.Width = 210;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "id";
            columnHeader1.Width = 1;
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(11, 332);
            label6.Name = "label6";
            label6.Size = new Size(155, 41);
            label6.TabIndex = 70;
            label6.Text = "İndirim Kodu:";
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(-2, 415);
            label5.Name = "label5";
            label5.Size = new Size(168, 64);
            label5.TabIndex = 68;
            label5.Text = "Son Kullanma Tarihi:";
            label5.TextAlign = ContentAlignment.TopCenter;
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
            btnEkle.Location = new Point(184, 475);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(187, 40);
            btnEkle.TabIndex = 67;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtBxIndırımKodu
            // 
            txtBxIndırımKodu.BorderStyle = BorderStyle.None;
            txtBxIndırımKodu.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxIndırımKodu.Location = new Point(171, 329);
            txtBxIndırımKodu.Multiline = true;
            txtBxIndırımKodu.Name = "txtBxIndırımKodu";
            txtBxIndırımKodu.Size = new Size(200, 35);
            txtBxIndırımKodu.TabIndex = 71;
            txtBxIndırımKodu.TextAlign = HorizontalAlignment.Center;
            // 
            // sonKullanmaTarihi
            // 
            sonKullanmaTarihi.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            sonKullanmaTarihi.Format = DateTimePickerFormat.Short;
            sonKullanmaTarihi.Location = new Point(171, 419);
            sonKullanmaTarihi.Name = "sonKullanmaTarihi";
            sonKullanmaTarihi.Size = new Size(200, 35);
            sonKullanmaTarihi.TabIndex = 72;
            sonKullanmaTarihi.Value = new DateTime(2023, 9, 16, 0, 0, 0, 0);
            // 
            // sonKullanmaTarihi2
            // 
            sonKullanmaTarihi2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            sonKullanmaTarihi2.Format = DateTimePickerFormat.Short;
            sonKullanmaTarihi2.Location = new Point(1076, 428);
            sonKullanmaTarihi2.Name = "sonKullanmaTarihi2";
            sonKullanmaTarihi2.Size = new Size(202, 35);
            sonKullanmaTarihi2.TabIndex = 77;
            // 
            // txtBxIndırımKodu2
            // 
            txtBxIndırımKodu2.BorderStyle = BorderStyle.None;
            txtBxIndırımKodu2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxIndırımKodu2.Location = new Point(1076, 338);
            txtBxIndırımKodu2.Multiline = true;
            txtBxIndırımKodu2.Name = "txtBxIndırımKodu2";
            txtBxIndırımKodu2.Size = new Size(202, 35);
            txtBxIndırımKodu2.TabIndex = 76;
            txtBxIndırımKodu2.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(922, 338);
            label2.Name = "label2";
            label2.Size = new Size(155, 41);
            label2.TabIndex = 75;
            label2.Text = "İndirim Kodu:";
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(912, 424);
            label3.Name = "label3";
            label3.Size = new Size(168, 64);
            label3.TabIndex = 74;
            label3.Text = "Son Kullanma Tarihi:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnDuzenle
            // 
            btnDuzenle.BackColor = Color.Orange;
            btnDuzenle.FlatAppearance.BorderSize = 0;
            btnDuzenle.FlatStyle = FlatStyle.Flat;
            btnDuzenle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDuzenle.ForeColor = Color.Black;
            btnDuzenle.ImageAlign = ContentAlignment.MiddleLeft;
            btnDuzenle.ImageIndex = 0;
            btnDuzenle.Location = new Point(1083, 484);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(187, 40);
            btnDuzenle.TabIndex = 73;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.UseVisualStyleBackColor = false;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnKaldir
            // 
            btnKaldir.BackColor = Color.Red;
            btnKaldir.FlatAppearance.BorderSize = 0;
            btnKaldir.FlatStyle = FlatStyle.Flat;
            btnKaldir.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnKaldir.ForeColor = Color.Black;
            btnKaldir.ImageAlign = ContentAlignment.MiddleLeft;
            btnKaldir.ImageIndex = 0;
            btnKaldir.Location = new Point(546, 114);
            btnKaldir.Name = "btnKaldir";
            btnKaldir.Size = new Size(187, 40);
            btnKaldir.TabIndex = 78;
            btnKaldir.Text = "Kaldır";
            btnKaldir.UseVisualStyleBackColor = false;
            btnKaldir.Click += btnKaldir_Click;
            // 
            // txtBxId2
            // 
            txtBxId2.BorderStyle = BorderStyle.None;
            txtBxId2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxId2.Location = new Point(1076, 292);
            txtBxId2.Multiline = true;
            txtBxId2.Name = "txtBxId2";
            txtBxId2.Size = new Size(202, 35);
            txtBxId2.TabIndex = 80;
            txtBxId2.TextAlign = HorizontalAlignment.Center;
            txtBxId2.KeyPress += txtBxId2_KeyPress;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(1035, 297);
            label4.Name = "label4";
            label4.Size = new Size(42, 41);
            label4.TabIndex = 79;
            label4.Text = "Id:";
            // 
            // txtBxId
            // 
            txtBxId.BorderStyle = BorderStyle.None;
            txtBxId.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxId.Location = new Point(171, 283);
            txtBxId.Multiline = true;
            txtBxId.Name = "txtBxId";
            txtBxId.Size = new Size(200, 35);
            txtBxId.TabIndex = 82;
            txtBxId.TextAlign = HorizontalAlignment.Center;
            txtBxId.KeyPress += txtBxId_KeyPress;
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(128, 287);
            label7.Name = "label7";
            label7.Size = new Size(42, 41);
            label7.TabIndex = 81;
            label7.Text = "Id:";
            // 
            // txtBxIndirimOrani2
            // 
            txtBxIndirimOrani2.BorderStyle = BorderStyle.None;
            txtBxIndirimOrani2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxIndirimOrani2.Location = new Point(1076, 383);
            txtBxIndirimOrani2.Multiline = true;
            txtBxIndirimOrani2.Name = "txtBxIndirimOrani2";
            txtBxIndirimOrani2.Size = new Size(202, 35);
            txtBxIndirimOrani2.TabIndex = 84;
            txtBxIndirimOrani2.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(919, 383);
            label8.Name = "label8";
            label8.Size = new Size(157, 41);
            label8.TabIndex = 83;
            label8.Text = "İndirim Oranı:";
            // 
            // txtBxIndirimOrani
            // 
            txtBxIndirimOrani.BorderStyle = BorderStyle.None;
            txtBxIndirimOrani.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxIndirimOrani.Location = new Point(171, 374);
            txtBxIndirimOrani.Multiline = true;
            txtBxIndirimOrani.Name = "txtBxIndirimOrani";
            txtBxIndirimOrani.Size = new Size(200, 35);
            txtBxIndirimOrani.TabIndex = 86;
            txtBxIndirimOrani.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(12, 375);
            label9.Name = "label9";
            label9.Size = new Size(157, 41);
            label9.TabIndex = 85;
            label9.Text = "İndirim Oranı:";
            // 
            // Indırım
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1285, 635);
            Controls.Add(txtBxIndirimOrani);
            Controls.Add(label9);
            Controls.Add(txtBxIndirimOrani2);
            Controls.Add(label8);
            Controls.Add(txtBxId);
            Controls.Add(label7);
            Controls.Add(txtBxId2);
            Controls.Add(label4);
            Controls.Add(btnKaldir);
            Controls.Add(txtBxIndırımKodu2);
            Controls.Add(sonKullanmaTarihi2);
            Controls.Add(btnDuzenle);
            Controls.Add(lstViewIndırımKodları);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(sonKullanmaTarihi);
            Controls.Add(txtBxIndırımKodu);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnEkle);
            Controls.Add(label1);
            Controls.Add(btnCikis);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Indırım";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Indırım";
            Load += Indırım_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCikis;
        private ImageList ımageList3;
        private Label label1;
        private ListView lstViewIndırımKodları;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label6;
        private Label label5;
        private Button btnEkle;
        private DateTimePicker sonKullanmaTarihi;
        private TextBox txtBxIndırımKodu;
        private Button btnKaldir;
        private TextBox txtBxIndırımKodu2;
        private DateTimePicker sonKullanmaTarihi2;
        private Button btnDuzenle;
        private Label label2;
        private Label label3;
        private TextBox txtBxIndirimOrani;
        private Label label7;
        private TextBox txtBxId2;
        private Label label4;
        private TextBox txtBxId;
        private ColumnHeader columnHeader1;
        private TextBox txtBxIndirimOrani2;
        private Label label8;
        private Label label9;
        private ColumnHeader columnHeader2;
    }
}