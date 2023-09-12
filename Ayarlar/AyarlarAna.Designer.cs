namespace PizzaciSon1.Ayarlar
{
    partial class AyarlarAna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AyarlarAna));
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            btnUrunEkleKaldir = new Button();
            ımageList3 = new ImageList(components);
            btnUrunDuzenle = new Button();
            btnMasaEkleKaldir = new Button();
            btnCikis = new Button();
            SuspendLayout();
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 5;
            bunifuElipse1.TargetControl = this;
            // 
            // btnUrunEkleKaldir
            // 
            btnUrunEkleKaldir.BackColor = Color.MediumPurple;
            btnUrunEkleKaldir.FlatAppearance.BorderSize = 0;
            btnUrunEkleKaldir.FlatStyle = FlatStyle.Flat;
            btnUrunEkleKaldir.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnUrunEkleKaldir.ForeColor = Color.Black;
            btnUrunEkleKaldir.ImageAlign = ContentAlignment.MiddleLeft;
            btnUrunEkleKaldir.ImageIndex = 0;
            btnUrunEkleKaldir.Location = new Point(182, 165);
            btnUrunEkleKaldir.Name = "btnUrunEkleKaldir";
            btnUrunEkleKaldir.Size = new Size(370, 140);
            btnUrunEkleKaldir.TabIndex = 44;
            btnUrunEkleKaldir.Text = "Ürün Ekle/Kaldır";
            btnUrunEkleKaldir.UseVisualStyleBackColor = false;
            btnUrunEkleKaldir.Click += btnUrunEkleKaldir_Click;
            // 
            // ımageList3
            // 
            ımageList3.ColorDepth = ColorDepth.Depth32Bit;
            ımageList3.ImageStream = (ImageListStreamer)resources.GetObject("ımageList3.ImageStream");
            ımageList3.TransparentColor = Color.Transparent;
            ımageList3.Images.SetKeyName(0, "x-g66b252b67_640.png");
            // 
            // btnUrunDuzenle
            // 
            btnUrunDuzenle.BackColor = Color.MediumPurple;
            btnUrunDuzenle.FlatAppearance.BorderSize = 0;
            btnUrunDuzenle.FlatStyle = FlatStyle.Flat;
            btnUrunDuzenle.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnUrunDuzenle.ForeColor = Color.Black;
            btnUrunDuzenle.ImageAlign = ContentAlignment.MiddleLeft;
            btnUrunDuzenle.ImageIndex = 0;
            btnUrunDuzenle.Location = new Point(733, 165);
            btnUrunDuzenle.Name = "btnUrunDuzenle";
            btnUrunDuzenle.Size = new Size(370, 140);
            btnUrunDuzenle.TabIndex = 48;
            btnUrunDuzenle.Text = "Ürün Düzenle";
            btnUrunDuzenle.UseVisualStyleBackColor = false;
            btnUrunDuzenle.Click += btnUrunDuzenle_Click;
            // 
            // btnMasaEkleKaldir
            // 
            btnMasaEkleKaldir.BackColor = Color.MediumPurple;
            btnMasaEkleKaldir.FlatAppearance.BorderSize = 0;
            btnMasaEkleKaldir.FlatStyle = FlatStyle.Flat;
            btnMasaEkleKaldir.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnMasaEkleKaldir.ForeColor = Color.Black;
            btnMasaEkleKaldir.ImageAlign = ContentAlignment.MiddleLeft;
            btnMasaEkleKaldir.ImageIndex = 0;
            btnMasaEkleKaldir.Location = new Point(452, 333);
            btnMasaEkleKaldir.Name = "btnMasaEkleKaldir";
            btnMasaEkleKaldir.Size = new Size(370, 140);
            btnMasaEkleKaldir.TabIndex = 46;
            btnMasaEkleKaldir.Text = "Masa Ekle/Kaldır";
            btnMasaEkleKaldir.UseVisualStyleBackColor = false;
            btnMasaEkleKaldir.Click += btnMasaEkleKaldir_Click;
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
            btnCikis.Location = new Point(1232, 9);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(46, 43);
            btnCikis.TabIndex = 45;
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // AyarlarAna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1285, 635);
            Controls.Add(btnUrunEkleKaldir);
            Controls.Add(btnUrunDuzenle);
            Controls.Add(btnMasaEkleKaldir);
            Controls.Add(btnCikis);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AyarlarAna";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AyarlarAna";
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Button btnUrunEkleKaldir;
        private Button btnUrunDuzenle;
        private Button btnMasaEkleKaldir;
        private Button btnCikis;
        private ImageList ımageList3;
    }
}