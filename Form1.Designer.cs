namespace PizzaciSon1
{
    partial class Form1
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            lstViewSiparis = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            txtBxToplamTutar = new TextBox();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(27, 26);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(391, 385);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // lstViewSiparis
            // 
            lstViewSiparis.BorderStyle = BorderStyle.None;
            lstViewSiparis.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            lstViewSiparis.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lstViewSiparis.FullRowSelect = true;
            lstViewSiparis.Location = new Point(424, 26);
            lstViewSiparis.Name = "lstViewSiparis";
            lstViewSiparis.Size = new Size(303, 351);
            lstViewSiparis.TabIndex = 29;
            lstViewSiparis.UseCompatibleStateImageBehavior = false;
            lstViewSiparis.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "yazdır";
            columnHeader1.Width = 1;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Adet";
            columnHeader2.Width = 48;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ürün";
            columnHeader3.Width = 185;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Fiyatı";
            columnHeader4.Width = 65;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "urun";
            columnHeader5.Width = 3;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "kategori";
            columnHeader6.Width = 1;
            // 
            // txtBxToplamTutar
            // 
            txtBxToplamTutar.BackColor = Color.Black;
            txtBxToplamTutar.BorderStyle = BorderStyle.None;
            txtBxToplamTutar.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxToplamTutar.ForeColor = Color.White;
            txtBxToplamTutar.Location = new Point(424, 383);
            txtBxToplamTutar.Multiline = true;
            txtBxToplamTutar.Name = "txtBxToplamTutar";
            txtBxToplamTutar.Size = new Size(305, 48);
            txtBxToplamTutar.TabIndex = 31;
            txtBxToplamTutar.Text = "Toplam Tutar: 0.00";
            txtBxToplamTutar.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 447);
            Controls.Add(txtBxToplamTutar);
            Controls.Add(lstViewSiparis);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private ListView lstViewSiparis;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        public TextBox txtBxToplamTutar;
    }
}