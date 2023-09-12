namespace PizzaciSon1.StokTakibi
{
    partial class StokTakibiAna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokTakibiAna));
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            btnYiyecekStok = new Button();
            btnIcecekStok = new Button();
            ımageList5 = new ImageList(components);
            btnCikis = new Button();
            SuspendLayout();
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 5;
            bunifuElipse1.TargetControl = this;
            // 
            // btnYiyecekStok
            // 
            btnYiyecekStok.BackColor = Color.MediumPurple;
            btnYiyecekStok.FlatAppearance.BorderSize = 0;
            btnYiyecekStok.FlatStyle = FlatStyle.Flat;
            btnYiyecekStok.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnYiyecekStok.ForeColor = Color.Black;
            btnYiyecekStok.ImageAlign = ContentAlignment.MiddleLeft;
            btnYiyecekStok.ImageIndex = 0;
            btnYiyecekStok.Location = new Point(186, 231);
            btnYiyecekStok.Name = "btnYiyecekStok";
            btnYiyecekStok.Size = new Size(370, 140);
            btnYiyecekStok.TabIndex = 32;
            btnYiyecekStok.Text = "Yiyecek Stok";
            btnYiyecekStok.UseVisualStyleBackColor = false;
            btnYiyecekStok.Click += btnYiyecekStok_Click;
            // 
            // btnIcecekStok
            // 
            btnIcecekStok.BackColor = Color.MediumPurple;
            btnIcecekStok.FlatAppearance.BorderSize = 0;
            btnIcecekStok.FlatStyle = FlatStyle.Flat;
            btnIcecekStok.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnIcecekStok.ForeColor = Color.Black;
            btnIcecekStok.ImageAlign = ContentAlignment.MiddleLeft;
            btnIcecekStok.ImageIndex = 0;
            btnIcecekStok.Location = new Point(737, 231);
            btnIcecekStok.Name = "btnIcecekStok";
            btnIcecekStok.Size = new Size(370, 140);
            btnIcecekStok.TabIndex = 34;
            btnIcecekStok.Text = "İçecek Stok";
            btnIcecekStok.UseVisualStyleBackColor = false;
            btnIcecekStok.Click += btnIcecekStok_Click;
            // 
            // ımageList5
            // 
            ımageList5.ColorDepth = ColorDepth.Depth32Bit;
            ımageList5.ImageStream = (ImageListStreamer)resources.GetObject("ımageList5.ImageStream");
            ımageList5.TransparentColor = Color.Transparent;
            ımageList5.Images.SetKeyName(0, "x-g66b252b67_640.png");
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
            btnCikis.Location = new Point(1230, 8);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(47, 47);
            btnCikis.TabIndex = 58;
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // StokTakibiAna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1285, 635);
            Controls.Add(btnCikis);
            Controls.Add(btnIcecekStok);
            Controls.Add(btnYiyecekStok);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StokTakibiAna";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StokTakibiAna";
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Button btnIcecekStok;
        private Button btnYiyecekStok;
        private Button btnCikis;
        private ImageList ımageList5;
    }
}