namespace PizzaciSon1.Siparis
{
    partial class Tahsilat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tahsilat));
            txtBxToplamTutar = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtBxOdenen = new TextBox();
            txtBxKalan = new TextBox();
            txtBxBahsis = new TextBox();
            btnUygula = new Button();
            ımageList3 = new ImageList(components);
            btnCikis = new Button();
            SuspendLayout();
            // 
            // txtBxToplamTutar
            // 
            txtBxToplamTutar.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxToplamTutar.Location = new Point(211, 29);
            txtBxToplamTutar.Multiline = true;
            txtBxToplamTutar.Name = "txtBxToplamTutar";
            txtBxToplamTutar.Size = new Size(186, 34);
            txtBxToplamTutar.TabIndex = 24;
            txtBxToplamTutar.TextAlign = HorizontalAlignment.Center;
            txtBxToplamTutar.KeyPress += txtBxToplamTutar_KeyPress;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 25);
            label1.Name = "label1";
            label1.Size = new Size(173, 43);
            label1.TabIndex = 23;
            label1.Text = "Toplam Miktar:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 72);
            label2.Name = "label2";
            label2.Size = new Size(178, 43);
            label2.TabIndex = 25;
            label2.Text = "Ödenen Miktar:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(27, 118);
            label3.Name = "label3";
            label3.Size = new Size(178, 43);
            label3.TabIndex = 26;
            label3.Text = "Kalan Miktar:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(27, 163);
            label4.Name = "label4";
            label4.Size = new Size(178, 43);
            label4.TabIndex = 27;
            label4.Text = "Bahşiş Miktar:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBxOdenen
            // 
            txtBxOdenen.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxOdenen.Location = new Point(211, 75);
            txtBxOdenen.Multiline = true;
            txtBxOdenen.Name = "txtBxOdenen";
            txtBxOdenen.Size = new Size(186, 34);
            txtBxOdenen.TabIndex = 28;
            txtBxOdenen.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBxKalan
            // 
            txtBxKalan.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxKalan.Location = new Point(211, 121);
            txtBxKalan.Multiline = true;
            txtBxKalan.Name = "txtBxKalan";
            txtBxKalan.Size = new Size(186, 34);
            txtBxKalan.TabIndex = 29;
            txtBxKalan.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBxBahsis
            // 
            txtBxBahsis.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxBahsis.Location = new Point(211, 167);
            txtBxBahsis.Multiline = true;
            txtBxBahsis.Name = "txtBxBahsis";
            txtBxBahsis.Size = new Size(186, 34);
            txtBxBahsis.TabIndex = 30;
            txtBxBahsis.TextAlign = HorizontalAlignment.Center;
            // 
            // btnUygula
            // 
            btnUygula.BackColor = Color.Teal;
            btnUygula.FlatAppearance.BorderSize = 0;
            btnUygula.FlatStyle = FlatStyle.Flat;
            btnUygula.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnUygula.ForeColor = Color.White;
            btnUygula.Location = new Point(211, 214);
            btnUygula.Name = "btnUygula";
            btnUygula.Size = new Size(186, 36);
            btnUygula.TabIndex = 31;
            btnUygula.Text = "Öde";
            btnUygula.UseVisualStyleBackColor = false;
            btnUygula.Click += btnUygula_Click;
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
            btnCikis.Location = new Point(440, 8);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(43, 35);
            btnCikis.TabIndex = 32;
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // Tahsilat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(491, 270);
            Controls.Add(btnCikis);
            Controls.Add(btnUygula);
            Controls.Add(txtBxBahsis);
            Controls.Add(txtBxKalan);
            Controls.Add(txtBxOdenen);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtBxToplamTutar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Tahsilat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tahsilat";
            Load += Tahsilat_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBxBahsis;
        private TextBox txtBxKalan;
        private TextBox txtBxOdenen;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtBxToplamTutar;
        private Label label1;
        private Button btnUygula;
        private ImageList ımageList3;
        private Button btnCikis;
    }
}