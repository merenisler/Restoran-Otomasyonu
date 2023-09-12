namespace PizzaciSon1.StokTakibi
{
    partial class Fire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fire));
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            btnEkle = new Button();
            txtBxMiktar = new TextBox();
            label1 = new Label();
            lblFireYiyecek = new Label();
            ımageList3 = new ImageList(components);
            btnCikis = new Button();
            lblFire = new Label();
            SuspendLayout();
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 5;
            bunifuElipse1.TargetControl = this;
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
            btnEkle.Location = new Point(222, 164);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(200, 43);
            btnEkle.TabIndex = 46;
            btnEkle.Text = "Onayla";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtBxMiktar
            // 
            txtBxMiktar.BorderStyle = BorderStyle.None;
            txtBxMiktar.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxMiktar.Location = new Point(222, 124);
            txtBxMiktar.Multiline = true;
            txtBxMiktar.Name = "txtBxMiktar";
            txtBxMiktar.Size = new Size(200, 34);
            txtBxMiktar.TabIndex = 45;
            txtBxMiktar.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 38.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(641, 67);
            label1.TabIndex = 47;
            label1.Text = "Yiyecek Fire";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblFireYiyecek
            // 
            lblFireYiyecek.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblFireYiyecek.ForeColor = Color.Black;
            lblFireYiyecek.Location = new Point(17, 231);
            lblFireYiyecek.Name = "lblFireYiyecek";
            lblFireYiyecek.Size = new Size(641, 67);
            lblFireYiyecek.TabIndex = 48;
            lblFireYiyecek.Text = "Yiyecek Fire Tutar: ";
            lblFireYiyecek.TextAlign = ContentAlignment.TopCenter;
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
            btnCikis.Location = new Point(615, 7);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(43, 40);
            btnCikis.TabIndex = 51;
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // lblFire
            // 
            lblFire.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblFire.ForeColor = Color.Black;
            lblFire.Location = new Point(17, 296);
            lblFire.Name = "lblFire";
            lblFire.Size = new Size(641, 67);
            lblFire.TabIndex = 52;
            lblFire.Text = "Toplam Fire Tutar: ";
            lblFire.TextAlign = ContentAlignment.TopCenter;
            // 
            // Fire
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(665, 375);
            Controls.Add(lblFire);
            Controls.Add(btnCikis);
            Controls.Add(lblFireYiyecek);
            Controls.Add(label1);
            Controls.Add(btnEkle);
            Controls.Add(txtBxMiktar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Fire";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fire";
            Load += Fire_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Button btnEkle;
        private TextBox txtBxMiktar;
        private Label lblFireYiyecek;
        private Label label1;
        private Button btnCikis;
        private ImageList ımageList3;
        private Label lblFire;
    }
}