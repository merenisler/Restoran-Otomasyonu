namespace PizzaciSon1.Masalar
{
    partial class BahceMasalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BahceMasalar));
            btnToplamUcret = new Button();
            btnMasaSayisi = new Button();
            btnBahce = new Button();
            ımageList1 = new ImageList(components);
            btnSalon = new Button();
            btnAcikMasalar = new Button();
            btnSaat = new Button();
            PanelMasalar = new FlowLayoutPanel();
            ımageList3 = new ImageList(components);
            btnCikis = new Button();
            SuspendLayout();
            // 
            // btnToplamUcret
            // 
            btnToplamUcret.BackColor = Color.White;
            btnToplamUcret.FlatAppearance.BorderSize = 0;
            btnToplamUcret.FlatStyle = FlatStyle.Flat;
            btnToplamUcret.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnToplamUcret.ForeColor = Color.Black;
            btnToplamUcret.ImageAlign = ContentAlignment.MiddleLeft;
            btnToplamUcret.ImageIndex = 0;
            btnToplamUcret.Location = new Point(1091, 532);
            btnToplamUcret.Name = "btnToplamUcret";
            btnToplamUcret.Size = new Size(207, 48);
            btnToplamUcret.TabIndex = 47;
            btnToplamUcret.Text = "Toplam Ücret:";
            btnToplamUcret.UseVisualStyleBackColor = false;
            // 
            // btnMasaSayisi
            // 
            btnMasaSayisi.BackColor = Color.White;
            btnMasaSayisi.FlatAppearance.BorderSize = 0;
            btnMasaSayisi.FlatStyle = FlatStyle.Flat;
            btnMasaSayisi.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnMasaSayisi.ForeColor = Color.Black;
            btnMasaSayisi.ImageAlign = ContentAlignment.MiddleLeft;
            btnMasaSayisi.ImageIndex = 0;
            btnMasaSayisi.Location = new Point(1091, 481);
            btnMasaSayisi.Name = "btnMasaSayisi";
            btnMasaSayisi.Size = new Size(207, 48);
            btnMasaSayisi.TabIndex = 46;
            btnMasaSayisi.Text = "Masa Sayısı: / Açık Masa:";
            btnMasaSayisi.UseVisualStyleBackColor = false;
            // 
            // btnBahce
            // 
            btnBahce.BackColor = Color.White;
            btnBahce.FlatAppearance.BorderSize = 0;
            btnBahce.FlatStyle = FlatStyle.Flat;
            btnBahce.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBahce.ForeColor = Color.Black;
            btnBahce.ImageAlign = ContentAlignment.MiddleLeft;
            btnBahce.ImageIndex = 0;
            btnBahce.ImageList = ımageList1;
            btnBahce.Location = new Point(1091, 293);
            btnBahce.Name = "btnBahce";
            btnBahce.Size = new Size(207, 48);
            btnBahce.TabIndex = 45;
            btnBahce.Text = "Bahçe";
            btnBahce.UseVisualStyleBackColor = false;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "Circle-PNG-File.png");
            // 
            // btnSalon
            // 
            btnSalon.BackColor = Color.White;
            btnSalon.FlatAppearance.BorderSize = 0;
            btnSalon.FlatStyle = FlatStyle.Flat;
            btnSalon.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalon.ForeColor = Color.Black;
            btnSalon.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalon.ImageIndex = 0;
            btnSalon.Location = new Point(1091, 239);
            btnSalon.Name = "btnSalon";
            btnSalon.Size = new Size(207, 48);
            btnSalon.TabIndex = 44;
            btnSalon.Text = "Salon";
            btnSalon.UseVisualStyleBackColor = false;
            btnSalon.Click += btnSalon_Click;
            // 
            // btnAcikMasalar
            // 
            btnAcikMasalar.BackColor = Color.White;
            btnAcikMasalar.FlatAppearance.BorderSize = 0;
            btnAcikMasalar.FlatStyle = FlatStyle.Flat;
            btnAcikMasalar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAcikMasalar.ForeColor = Color.Black;
            btnAcikMasalar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAcikMasalar.ImageIndex = 0;
            btnAcikMasalar.Location = new Point(1091, 185);
            btnAcikMasalar.Name = "btnAcikMasalar";
            btnAcikMasalar.Size = new Size(207, 48);
            btnAcikMasalar.TabIndex = 43;
            btnAcikMasalar.Text = "Açık Masalar";
            btnAcikMasalar.UseVisualStyleBackColor = false;
            btnAcikMasalar.Click += btnAcikMasalar_Click;
            // 
            // btnSaat
            // 
            btnSaat.BackColor = Color.White;
            btnSaat.FlatAppearance.BorderSize = 0;
            btnSaat.FlatStyle = FlatStyle.Flat;
            btnSaat.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaat.ForeColor = Color.Black;
            btnSaat.ImageAlign = ContentAlignment.MiddleLeft;
            btnSaat.ImageIndex = 0;
            btnSaat.Location = new Point(1091, 4);
            btnSaat.Name = "btnSaat";
            btnSaat.Size = new Size(207, 48);
            btnSaat.TabIndex = 42;
            btnSaat.Text = "Saat/Tarih";
            btnSaat.UseVisualStyleBackColor = false;
            // 
            // PanelMasalar
            // 
            PanelMasalar.AutoScroll = true;
            PanelMasalar.Location = new Point(2, 3);
            PanelMasalar.Name = "PanelMasalar";
            PanelMasalar.Size = new Size(1088, 630);
            PanelMasalar.TabIndex = 41;
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
            btnCikis.Location = new Point(1091, 583);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(207, 50);
            btnCikis.TabIndex = 48;
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // BahceMasalar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1300, 635);
            Controls.Add(btnToplamUcret);
            Controls.Add(btnMasaSayisi);
            Controls.Add(btnBahce);
            Controls.Add(btnSalon);
            Controls.Add(btnAcikMasalar);
            Controls.Add(btnSaat);
            Controls.Add(PanelMasalar);
            Controls.Add(btnCikis);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BahceMasalar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BahceMasalar";
            Load += BahceMasalar_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnToplamUcret;
        private Button btnMasaSayisi;
        private Button btnBahce;
        private Button btnSalon;
        private Button btnAcikMasalar;
        private ImageList ımageList1;
        private Button btnSaat;
        private FlowLayoutPanel PanelMasalar;
        private Button btnCikis;
        private ImageList ımageList3;
    }
}