namespace PizzaciSon1.Siparis
{
    partial class UrunNotu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunNotu));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnOnayla = new Button();
            btnCikis = new Button();
            ımageList3 = new ImageList(components);
            gridViewOzellikler = new DataGridView();
            Secim = new DataGridViewCheckBoxColumn();
            Ozellik = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridViewOzellikler).BeginInit();
            SuspendLayout();
            // 
            // btnOnayla
            // 
            btnOnayla.BackColor = Color.DarkSeaGreen;
            btnOnayla.FlatAppearance.BorderSize = 0;
            btnOnayla.FlatStyle = FlatStyle.Flat;
            btnOnayla.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOnayla.ImageAlign = ContentAlignment.MiddleLeft;
            btnOnayla.ImageIndex = 0;
            btnOnayla.Location = new Point(413, 352);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(74, 70);
            btnOnayla.TabIndex = 9;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = false;
            btnOnayla.Click += btnOnayla_Click;
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
            btnCikis.Location = new Point(416, 8);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(71, 38);
            btnCikis.TabIndex = 36;
            btnCikis.UseVisualStyleBackColor = false;
            // 
            // ımageList3
            // 
            ımageList3.ColorDepth = ColorDepth.Depth32Bit;
            ımageList3.ImageStream = (ImageListStreamer)resources.GetObject("ımageList3.ImageStream");
            ımageList3.TransparentColor = Color.Transparent;
            ımageList3.Images.SetKeyName(0, "x-g66b252b67_640.png");
            // 
            // gridViewOzellikler
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridViewOzellikler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridViewOzellikler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewOzellikler.Columns.AddRange(new DataGridViewColumn[] { Secim, Ozellik });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridViewOzellikler.DefaultCellStyle = dataGridViewCellStyle2;
            gridViewOzellikler.Location = new Point(12, 12);
            gridViewOzellikler.Name = "gridViewOzellikler";
            gridViewOzellikler.RowTemplate.Height = 25;
            gridViewOzellikler.Size = new Size(395, 410);
            gridViewOzellikler.TabIndex = 37;
            // 
            // Secim
            // 
            Secim.HeaderText = "";
            Secim.Name = "Secim";
            // 
            // Ozellik
            // 
            Ozellik.HeaderText = "Özellik";
            Ozellik.Name = "Ozellik";
            Ozellik.Resizable = DataGridViewTriState.True;
            Ozellik.SortMode = DataGridViewColumnSortMode.NotSortable;
            Ozellik.ToolTipText = "jghfj";
            Ozellik.Width = 250;
            // 
            // UrunNotu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(490, 430);
            Controls.Add(gridViewOzellikler);
            Controls.Add(btnCikis);
            Controls.Add(btnOnayla);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UrunNotu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UrunNotu";
            Load += UrunNotu_Load;
            ((System.ComponentModel.ISupportInitialize)gridViewOzellikler).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnCikis;
        private ImageList ımageList3;
        public Button btnOnayla;
        private DataGridView gridViewOzellikler;
        private DataGridViewCheckBoxColumn Secim;
        private DataGridViewTextBoxColumn Ozellik;
    }
}