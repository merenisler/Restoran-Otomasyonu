namespace PizzaciSon1.Kurye
{
    partial class KuryeEkleCikar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KuryeEkleCikar));
            ımageList5 = new ImageList(components);
            btnSiparisAtama = new Button();
            btnKuryeIstatistik = new Button();
            btnCikis = new Button();
            label1 = new Label();
            lstViewKuryeler = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            btnKaldir = new Button();
            btnEkle = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtBxTelefon2 = new TextBox();
            txtBxAdiSoyadi2 = new TextBox();
            txtBxTCNo2 = new TextBox();
            txtBxAdiSoyadi = new TextBox();
            txtBxTCNo = new TextBox();
            btnGuncelle = new Button();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtBxTelefon = new TextBox();
            txtBxId2 = new TextBox();
            label8 = new Label();
            txtBxId = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // ımageList5
            // 
            ımageList5.ColorDepth = ColorDepth.Depth32Bit;
            ımageList5.ImageStream = (ImageListStreamer)resources.GetObject("ımageList5.ImageStream");
            ımageList5.TransparentColor = Color.Transparent;
            ımageList5.Images.SetKeyName(0, "x-g66b252b67_640.png");
            // 
            // btnSiparisAtama
            // 
            btnSiparisAtama.BackColor = Color.MistyRose;
            btnSiparisAtama.FlatAppearance.BorderSize = 0;
            btnSiparisAtama.FlatStyle = FlatStyle.Flat;
            btnSiparisAtama.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSiparisAtama.ImageAlign = ContentAlignment.MiddleLeft;
            btnSiparisAtama.ImageIndex = 0;
            btnSiparisAtama.Location = new Point(658, 8);
            btnSiparisAtama.Name = "btnSiparisAtama";
            btnSiparisAtama.Size = new Size(280, 50);
            btnSiparisAtama.TabIndex = 66;
            btnSiparisAtama.Text = "Siparis Atama ";
            btnSiparisAtama.UseVisualStyleBackColor = false;
            btnSiparisAtama.Click += btnSiparisAtama_Click;
            // 
            // btnKuryeIstatistik
            // 
            btnKuryeIstatistik.BackColor = Color.MistyRose;
            btnKuryeIstatistik.FlatAppearance.BorderSize = 0;
            btnKuryeIstatistik.FlatStyle = FlatStyle.Flat;
            btnKuryeIstatistik.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnKuryeIstatistik.ImageAlign = ContentAlignment.MiddleLeft;
            btnKuryeIstatistik.ImageIndex = 0;
            btnKuryeIstatistik.Location = new Point(944, 8);
            btnKuryeIstatistik.Name = "btnKuryeIstatistik";
            btnKuryeIstatistik.Size = new Size(280, 50);
            btnKuryeIstatistik.TabIndex = 65;
            btnKuryeIstatistik.Text = "Kurye İstatistik";
            btnKuryeIstatistik.UseVisualStyleBackColor = false;
            btnKuryeIstatistik.Click += btnKuryeIstatistik_Click;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.Red;
            btnCikis.FlatAppearance.BorderSize = 0;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCikis.ForeColor = Color.Black;
            btnCikis.ImageIndex = 0;
            btnCikis.ImageList = ımageList5;
            btnCikis.Location = new Point(1230, 10);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(47, 47);
            btnCikis.TabIndex = 64;
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 35.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(0, 8);
            label1.Name = "label1";
            label1.Size = new Size(659, 67);
            label1.TabIndex = 67;
            label1.Text = "Kurye Ekle/Çıkar";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lstViewKuryeler
            // 
            lstViewKuryeler.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lstViewKuryeler.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstViewKuryeler.FullRowSelect = true;
            lstViewKuryeler.GridLines = true;
            lstViewKuryeler.Location = new Point(366, 166);
            lstViewKuryeler.Name = "lstViewKuryeler";
            lstViewKuryeler.Size = new Size(551, 457);
            lstViewKuryeler.TabIndex = 68;
            lstViewKuryeler.UseCompatibleStateImageBehavior = false;
            lstViewKuryeler.View = View.Details;
            lstViewKuryeler.SelectedIndexChanged += lstViewKuryeler_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "KuryeID";
            columnHeader1.Width = 85;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ad Soyad";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Telefon";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "TC No";
            columnHeader4.Width = 150;
            // 
            // btnKaldir
            // 
            btnKaldir.BackColor = Color.Red;
            btnKaldir.FlatAppearance.BorderSize = 0;
            btnKaldir.FlatStyle = FlatStyle.Flat;
            btnKaldir.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnKaldir.ImageAlign = ContentAlignment.MiddleLeft;
            btnKaldir.ImageIndex = 0;
            btnKaldir.Location = new Point(551, 118);
            btnKaldir.Name = "btnKaldir";
            btnKaldir.Size = new Size(196, 42);
            btnKaldir.TabIndex = 69;
            btnKaldir.Text = "Kaldır";
            btnKaldir.UseVisualStyleBackColor = false;
            btnKaldir.Click += btnKaldir_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.LimeGreen;
            btnEkle.FlatAppearance.BorderSize = 0;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Regular, GraphicsUnit.Point);
            btnEkle.ForeColor = Color.Black;
            btnEkle.ImageAlign = ContentAlignment.MiddleLeft;
            btnEkle.ImageIndex = 0;
            btnEkle.Location = new Point(152, 431);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(187, 45);
            btnEkle.TabIndex = 85;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(921, 397);
            label5.Name = "label5";
            label5.Size = new Size(114, 41);
            label5.TabIndex = 83;
            label5.Text = "TC No:";
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(920, 309);
            label4.Name = "label4";
            label4.Size = new Size(140, 41);
            label4.TabIndex = 82;
            label4.Text = "Ad Soyad:";
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(920, 354);
            label3.Name = "label3";
            label3.Size = new Size(114, 41);
            label3.TabIndex = 81;
            label3.Text = "Telefon:";
            // 
            // txtBxTelefon2
            // 
            txtBxTelefon2.BorderStyle = BorderStyle.None;
            txtBxTelefon2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxTelefon2.Location = new Point(1060, 356);
            txtBxTelefon2.Multiline = true;
            txtBxTelefon2.Name = "txtBxTelefon2";
            txtBxTelefon2.Size = new Size(215, 38);
            txtBxTelefon2.TabIndex = 78;
            // 
            // txtBxAdiSoyadi2
            // 
            txtBxAdiSoyadi2.BorderStyle = BorderStyle.None;
            txtBxAdiSoyadi2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxAdiSoyadi2.Location = new Point(1060, 311);
            txtBxAdiSoyadi2.Multiline = true;
            txtBxAdiSoyadi2.Name = "txtBxAdiSoyadi2";
            txtBxAdiSoyadi2.Size = new Size(215, 38);
            txtBxAdiSoyadi2.TabIndex = 77;
            // 
            // txtBxTCNo2
            // 
            txtBxTCNo2.BorderStyle = BorderStyle.None;
            txtBxTCNo2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxTCNo2.Location = new Point(1060, 400);
            txtBxTCNo2.Multiline = true;
            txtBxTCNo2.Name = "txtBxTCNo2";
            txtBxTCNo2.Size = new Size(215, 38);
            txtBxTCNo2.TabIndex = 86;
            // 
            // txtBxAdiSoyadi
            // 
            txtBxAdiSoyadi.BorderStyle = BorderStyle.None;
            txtBxAdiSoyadi.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxAdiSoyadi.Location = new Point(141, 289);
            txtBxAdiSoyadi.Multiline = true;
            txtBxAdiSoyadi.Name = "txtBxAdiSoyadi";
            txtBxAdiSoyadi.Size = new Size(215, 38);
            txtBxAdiSoyadi.TabIndex = 87;
            // 
            // txtBxTCNo
            // 
            txtBxTCNo.BorderStyle = BorderStyle.None;
            txtBxTCNo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxTCNo.Location = new Point(141, 378);
            txtBxTCNo.Multiline = true;
            txtBxTCNo.Name = "txtBxTCNo";
            txtBxTCNo.Size = new Size(215, 38);
            txtBxTCNo.TabIndex = 93;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.LightSalmon;
            btnGuncelle.FlatAppearance.BorderSize = 0;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuncelle.ForeColor = Color.Black;
            btnGuncelle.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuncelle.ImageIndex = 0;
            btnGuncelle.Location = new Point(1072, 456);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(187, 45);
            btnGuncelle.TabIndex = 92;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(2, 375);
            label2.Name = "label2";
            label2.Size = new Size(114, 41);
            label2.TabIndex = 91;
            label2.Text = "TC No:";
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(1, 287);
            label6.Name = "label6";
            label6.Size = new Size(140, 41);
            label6.TabIndex = 90;
            label6.Text = "Ad Soyad:";
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(1, 332);
            label7.Name = "label7";
            label7.Size = new Size(114, 41);
            label7.TabIndex = 89;
            label7.Text = "Telefon:";
            // 
            // txtBxTelefon
            // 
            txtBxTelefon.BorderStyle = BorderStyle.None;
            txtBxTelefon.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxTelefon.Location = new Point(141, 334);
            txtBxTelefon.Multiline = true;
            txtBxTelefon.Name = "txtBxTelefon";
            txtBxTelefon.Size = new Size(215, 38);
            txtBxTelefon.TabIndex = 88;
            // 
            // txtBxId2
            // 
            txtBxId2.BorderStyle = BorderStyle.None;
            txtBxId2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxId2.Location = new Point(1060, 267);
            txtBxId2.Multiline = true;
            txtBxId2.Name = "txtBxId2";
            txtBxId2.ReadOnly = true;
            txtBxId2.Size = new Size(215, 38);
            txtBxId2.TabIndex = 94;
            // 
            // label8
            // 
            label8.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(921, 265);
            label8.Name = "label8";
            label8.Size = new Size(140, 41);
            label8.TabIndex = 95;
            label8.Text = "Id:";
            // 
            // txtBxId
            // 
            txtBxId.BorderStyle = BorderStyle.None;
            txtBxId.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxId.Location = new Point(141, 245);
            txtBxId.Multiline = true;
            txtBxId.Name = "txtBxId";
            txtBxId.ReadOnly = true;
            txtBxId.Size = new Size(215, 38);
            txtBxId.TabIndex = 96;
            // 
            // label9
            // 
            label9.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(2, 243);
            label9.Name = "label9";
            label9.Size = new Size(140, 41);
            label9.TabIndex = 97;
            label9.Text = "Id:";
            // 
            // KuryeEkleCikar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1285, 635);
            Controls.Add(txtBxId);
            Controls.Add(label9);
            Controls.Add(txtBxId2);
            Controls.Add(label8);
            Controls.Add(txtBxAdiSoyadi);
            Controls.Add(txtBxTCNo);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtBxTelefon);
            Controls.Add(txtBxAdiSoyadi2);
            Controls.Add(txtBxTCNo2);
            Controls.Add(btnEkle);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtBxTelefon2);
            Controls.Add(btnKaldir);
            Controls.Add(lstViewKuryeler);
            Controls.Add(label1);
            Controls.Add(btnSiparisAtama);
            Controls.Add(btnKuryeIstatistik);
            Controls.Add(btnCikis);
            Controls.Add(btnGuncelle);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KuryeEkleCikar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KuryeEkleCikar";
            Load += KuryeEkleCikar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList ımageList5;
        private Button btnSiparisAtama;
        private Button btnKuryeIstatistik;
        private Button btnCikis;
        private Label label1;
        private ListView lstViewKuryeler;
        private Button btnKaldir;
        private Button btnEkle;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtBxTelefon2;
        private TextBox txtBxAdiSoyadi2;
        private TextBox txtBxTCNo2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox txtBxAdiSoyadi;
        private TextBox txtBxTCNo;
        private Button btnGuncelle;
        private Label label2;
        private Label label6;
        private Label label7;
        private TextBox txtBxTelefon;
        private TextBox txtBxId2;
        private Label label8;
        private TextBox txtBxId;
        private Label label9;
    }
}