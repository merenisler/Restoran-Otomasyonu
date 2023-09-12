namespace PizzaciSon1.Siparis
{
    partial class Adres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adres));
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            label1 = new Label();
            txtBxAdres = new TextBox();
            btnOnayla = new Button();
            btnCikis = new Button();
            ımageList3 = new ImageList(components);
            SuspendLayout();
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 5;
            bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(213, 25);
            label1.Name = "label1";
            label1.Size = new Size(118, 46);
            label1.TabIndex = 1;
            label1.Text = "Adres:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBxAdres
            // 
            txtBxAdres.BorderStyle = BorderStyle.None;
            txtBxAdres.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxAdres.Location = new Point(18, 112);
            txtBxAdres.Multiline = true;
            txtBxAdres.Name = "txtBxAdres";
            txtBxAdres.Size = new Size(305, 138);
            txtBxAdres.TabIndex = 16;
            txtBxAdres.TextAlign = HorizontalAlignment.Center;
            // 
            // btnOnayla
            // 
            btnOnayla.BackColor = Color.ForestGreen;
            btnOnayla.FlatAppearance.BorderSize = 0;
            btnOnayla.FlatStyle = FlatStyle.Flat;
            btnOnayla.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnOnayla.ForeColor = Color.White;
            btnOnayla.Location = new Point(338, 154);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(193, 56);
            btnOnayla.TabIndex = 17;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = false;
            btnOnayla.Click += btnOnayla_Click;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.Red;
            btnCikis.FlatAppearance.BorderSize = 0;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnCikis.ForeColor = Color.White;
            btnCikis.ImageKey = "x-g66b252b67_640.png";
            btnCikis.ImageList = ımageList3;
            btnCikis.Location = new Point(506, 9);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(43, 35);
            btnCikis.TabIndex = 18;
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // ımageList3
            // 
            ımageList3.ColorDepth = ColorDepth.Depth32Bit;
            ımageList3.ImageStream = (ImageListStreamer)resources.GetObject("ımageList3.ImageStream");
            ımageList3.TransparentColor = Color.Transparent;
            ımageList3.Images.SetKeyName(0, "x-g66b252b67_640.png");
            // 
            // Adres
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(557, 298);
            Controls.Add(btnCikis);
            Controls.Add(btnOnayla);
            Controls.Add(txtBxAdres);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Adres";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adres";
            Load += Adres_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Label label1;
        private TextBox txtBxAdres;
        private Button btnOnayla;
        private Button btnCikis;
        private ImageList ımageList3;
    }
}