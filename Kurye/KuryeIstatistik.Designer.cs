namespace PizzaciSon1.Kurye
{
    partial class KuryeIstatistik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KuryeIstatistik));
            ımageList5 = new ImageList(components);
            btnSiparisAtama = new Button();
            btnKuryeEkleCikar = new Button();
            btnCikis = new Button();
            label1 = new Label();
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
            btnSiparisAtama.TabIndex = 63;
            btnSiparisAtama.Text = "Siparis Atama ";
            btnSiparisAtama.UseVisualStyleBackColor = false;
            btnSiparisAtama.Click += btnSiparisAtama_Click;
            // 
            // btnKuryeEkleCikar
            // 
            btnKuryeEkleCikar.BackColor = Color.MistyRose;
            btnKuryeEkleCikar.FlatAppearance.BorderSize = 0;
            btnKuryeEkleCikar.FlatStyle = FlatStyle.Flat;
            btnKuryeEkleCikar.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnKuryeEkleCikar.ImageAlign = ContentAlignment.MiddleLeft;
            btnKuryeEkleCikar.ImageIndex = 0;
            btnKuryeEkleCikar.Location = new Point(944, 8);
            btnKuryeEkleCikar.Name = "btnKuryeEkleCikar";
            btnKuryeEkleCikar.Size = new Size(280, 50);
            btnKuryeEkleCikar.TabIndex = 62;
            btnKuryeEkleCikar.Text = "Kurye Ekle/Çıkar";
            btnKuryeEkleCikar.UseVisualStyleBackColor = false;
            btnKuryeEkleCikar.Click += btnKuryeEkleCikar_Click;
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
            btnCikis.TabIndex = 61;
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
            label1.TabIndex = 64;
            label1.Text = "Kurye İstatistik";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // KuryeIstatistik
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1285, 635);
            Controls.Add(label1);
            Controls.Add(btnSiparisAtama);
            Controls.Add(btnKuryeEkleCikar);
            Controls.Add(btnCikis);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KuryeIstatistik";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KuryeIstatistik";
            ResumeLayout(false);
        }

        #endregion

        private ImageList ımageList5;
        private Button btnSiparisAtama;
        private Button btnKuryeEkleCikar;
        private Button btnCikis;
        private Label label1;
    }
}