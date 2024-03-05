namespace PizzaciSon1.Siparis
{
    partial class Indirim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Indirim));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtBxToplamTutar = new TextBox();
            txtBxIndırımKodu = new TextBox();
            txtBxIndırımlıTutar = new TextBox();
            btnUygula = new Button();
            btnOnayla = new Button();
            ımageList3 = new ImageList(components);
            btnCikis = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 44);
            label1.Name = "label1";
            label1.Size = new Size(198, 43);
            label1.TabIndex = 19;
            label1.Text = "Toplam Tutar:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(11, 102);
            label2.Name = "label2";
            label2.Size = new Size(207, 43);
            label2.TabIndex = 20;
            label2.Text = "İndirim Kodu:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(5, 202);
            label3.Name = "label3";
            label3.Size = new Size(207, 43);
            label3.TabIndex = 21;
            label3.Text = "İndirimli Tutar: ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBxToplamTutar
            // 
            txtBxToplamTutar.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxToplamTutar.Location = new Point(221, 53);
            txtBxToplamTutar.Multiline = true;
            txtBxToplamTutar.Name = "txtBxToplamTutar";
            txtBxToplamTutar.Size = new Size(228, 31);
            txtBxToplamTutar.TabIndex = 22;
            txtBxToplamTutar.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBxIndırımKodu
            // 
            txtBxIndırımKodu.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxIndırımKodu.Location = new Point(221, 110);
            txtBxIndırımKodu.Multiline = true;
            txtBxIndırımKodu.Name = "txtBxIndırımKodu";
            txtBxIndırımKodu.Size = new Size(228, 31);
            txtBxIndırımKodu.TabIndex = 23;
            // 
            // txtBxIndırımlıTutar
            // 
            txtBxIndırımlıTutar.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxIndırımlıTutar.Location = new Point(221, 211);
            txtBxIndırımlıTutar.Multiline = true;
            txtBxIndırımlıTutar.Name = "txtBxIndırımlıTutar";
            txtBxIndırımlıTutar.Size = new Size(228, 31);
            txtBxIndırımlıTutar.TabIndex = 24;
            txtBxIndırımlıTutar.TextAlign = HorizontalAlignment.Center;
            // 
            // btnUygula
            // 
            btnUygula.BackColor = Color.Teal;
            btnUygula.FlatAppearance.BorderSize = 0;
            btnUygula.FlatStyle = FlatStyle.Flat;
            btnUygula.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnUygula.ForeColor = Color.White;
            btnUygula.Location = new Point(221, 156);
            btnUygula.Name = "btnUygula";
            btnUygula.Size = new Size(228, 36);
            btnUygula.TabIndex = 25;
            btnUygula.Text = "Uygula";
            btnUygula.UseVisualStyleBackColor = false;
            btnUygula.Click += btnUygula_Click;
            // 
            // btnOnayla
            // 
            btnOnayla.BackColor = Color.ForestGreen;
            btnOnayla.FlatAppearance.BorderSize = 0;
            btnOnayla.FlatStyle = FlatStyle.Flat;
            btnOnayla.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnOnayla.ForeColor = Color.White;
            btnOnayla.Location = new Point(221, 254);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(228, 36);
            btnOnayla.TabIndex = 26;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = false;
            btnOnayla.Click += btnOnayla_Click;
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
            btnCikis.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnCikis.ForeColor = Color.White;
            btnCikis.ImageKey = "x-g66b252b67_640.png";
            btnCikis.ImageList = ımageList3;
            btnCikis.Location = new Point(476, 12);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(43, 35);
            btnCikis.TabIndex = 27;
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // Indirim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(531, 313);
            Controls.Add(btnCikis);
            Controls.Add(btnOnayla);
            Controls.Add(btnUygula);
            Controls.Add(txtBxIndırımlıTutar);
            Controls.Add(txtBxIndırımKodu);
            Controls.Add(txtBxToplamTutar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Indirim";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Indirim";
            Load += Indirim_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBxToplamTutar;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtBxIndırımlıTutar;
        private TextBox txtBxIndırımKodu;
        private Button btnUygula;
        private Button btnOnayla;
        private Button btnCikis;
        private ImageList ımageList3;
    }
}