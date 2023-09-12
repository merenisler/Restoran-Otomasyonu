namespace PizzaciSon1.Raporlar
{
    partial class RaporlarAna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaporlarAna));
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            btnZRapor = new Button();
            ımageList3 = new ImageList(components);
            btnCikis = new Button();
            btnPaketServis = new Button();
            btnBahşiş = new Button();
            btnAdisyonRapor = new Button();
            SuspendLayout();
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 5;
            bunifuElipse1.TargetControl = this;
            // 
            // btnZRapor
            // 
            btnZRapor.BackColor = Color.Lime;
            btnZRapor.FlatAppearance.BorderSize = 0;
            btnZRapor.FlatStyle = FlatStyle.Flat;
            btnZRapor.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnZRapor.ForeColor = Color.Black;
            btnZRapor.ImageAlign = ContentAlignment.MiddleLeft;
            btnZRapor.ImageIndex = 0;
            btnZRapor.Location = new Point(179, 165);
            btnZRapor.Name = "btnZRapor";
            btnZRapor.Size = new Size(370, 140);
            btnZRapor.TabIndex = 35;
            btnZRapor.Text = "ZRaporu";
            btnZRapor.UseVisualStyleBackColor = false;
            btnZRapor.Click += btnZRapor_Click;
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
            btnCikis.Location = new Point(1230, 9);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(46, 43);
            btnCikis.TabIndex = 40;
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnPaketServis
            // 
            btnPaketServis.BackColor = Color.Lime;
            btnPaketServis.FlatAppearance.BorderSize = 0;
            btnPaketServis.FlatStyle = FlatStyle.Flat;
            btnPaketServis.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPaketServis.ForeColor = Color.Black;
            btnPaketServis.ImageAlign = ContentAlignment.MiddleLeft;
            btnPaketServis.ImageIndex = 0;
            btnPaketServis.Location = new Point(179, 335);
            btnPaketServis.Name = "btnPaketServis";
            btnPaketServis.Size = new Size(370, 140);
            btnPaketServis.TabIndex = 41;
            btnPaketServis.Text = "Paket Servis";
            btnPaketServis.UseVisualStyleBackColor = false;
            btnPaketServis.Click += btnPaketServis_Click;
            // 
            // btnBahşiş
            // 
            btnBahşiş.BackColor = Color.Lime;
            btnBahşiş.FlatAppearance.BorderSize = 0;
            btnBahşiş.FlatStyle = FlatStyle.Flat;
            btnBahşiş.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBahşiş.ForeColor = Color.Black;
            btnBahşiş.ImageAlign = ContentAlignment.MiddleLeft;
            btnBahşiş.ImageIndex = 0;
            btnBahşiş.Location = new Point(730, 335);
            btnBahşiş.Name = "btnBahşiş";
            btnBahşiş.Size = new Size(370, 140);
            btnBahşiş.TabIndex = 42;
            btnBahşiş.Text = "Bahşiş Miktarı";
            btnBahşiş.UseVisualStyleBackColor = false;
            btnBahşiş.Click += btnBahşiş_Click;
            // 
            // btnAdisyonRapor
            // 
            btnAdisyonRapor.BackColor = Color.Lime;
            btnAdisyonRapor.FlatAppearance.BorderSize = 0;
            btnAdisyonRapor.FlatStyle = FlatStyle.Flat;
            btnAdisyonRapor.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdisyonRapor.ForeColor = Color.Black;
            btnAdisyonRapor.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdisyonRapor.ImageIndex = 0;
            btnAdisyonRapor.Location = new Point(730, 165);
            btnAdisyonRapor.Name = "btnAdisyonRapor";
            btnAdisyonRapor.Size = new Size(370, 140);
            btnAdisyonRapor.TabIndex = 43;
            btnAdisyonRapor.Text = "Adisyon Raporu";
            btnAdisyonRapor.UseVisualStyleBackColor = false;
            btnAdisyonRapor.Click += btnAdisyonRapor_Click;
            // 
            // RaporlarAna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1285, 630);
            Controls.Add(btnAdisyonRapor);
            Controls.Add(btnBahşiş);
            Controls.Add(btnPaketServis);
            Controls.Add(btnCikis);
            Controls.Add(btnZRapor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RaporlarAna";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RaporlarAna";
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Button btnZRapor;
        private Button btnAdisyonRapor;
        private Button btnBahşiş;
        private Button btnPaketServis;
        private Button btnCikis;
        private ImageList ımageList3;
    }
}