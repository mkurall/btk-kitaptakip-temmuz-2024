namespace KitapTakipUyg
{
    partial class FrmKategoriler
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
            listBox1 = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            yeniToolStripMenuItem = new ToolStripMenuItem();
            silToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnTamam = new Button();
            label2 = new Label();
            txtKategoriAdi = new TextBox();
            panel3 = new Panel();
            btnYeni = new Button();
            btnEkleGuncelle = new Button();
            contextMenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.ContextMenuStrip = contextMenuStrip1;
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(0, 135);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(357, 294);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox1.MouseDown += listBox1_MouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { yeniToolStripMenuItem, silToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(110, 56);
            // 
            // yeniToolStripMenuItem
            // 
            yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            yeniToolStripMenuItem.Size = new Size(109, 26);
            yeniToolStripMenuItem.Text = "Yeni";
            yeniToolStripMenuItem.Click += btnYeni_Click;
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Image = Properties.Resources.trash16;
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new Size(109, 26);
            silToolStripMenuItem.Text = "Sil";
            silToolStripMenuItem.Click += silToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 56);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(42, 9);
            label1.Name = "label1";
            label1.Size = new Size(224, 37);
            label1.TabIndex = 0;
            label1.Text = "Kitap Kategorileri";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnTamam);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 429);
            panel2.Name = "panel2";
            panel2.Size = new Size(357, 62);
            panel2.TabIndex = 2;
            // 
            // btnTamam
            // 
            btnTamam.Location = new Point(222, 9);
            btnTamam.Name = "btnTamam";
            btnTamam.Size = new Size(121, 45);
            btnTamam.TabIndex = 0;
            btnTamam.Text = "Tamam";
            btnTamam.UseVisualStyleBackColor = true;
            btnTamam.Click += btnTamam_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 15);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 3;
            label2.Text = "Kategori Adı";
            // 
            // txtKategoriAdi
            // 
            txtKategoriAdi.Location = new Point(12, 38);
            txtKategoriAdi.Name = "txtKategoriAdi";
            txtKategoriAdi.Size = new Size(254, 27);
            txtKategoriAdi.TabIndex = 4;
            txtKategoriAdi.KeyDown += txtKategoriAdi_KeyDown;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnYeni);
            panel3.Controls.Add(btnEkleGuncelle);
            panel3.Controls.Add(txtKategoriAdi);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 56);
            panel3.Name = "panel3";
            panel3.Size = new Size(357, 79);
            panel3.TabIndex = 5;
            // 
            // btnYeni
            // 
            btnYeni.Location = new Point(271, 9);
            btnYeni.Name = "btnYeni";
            btnYeni.Size = new Size(82, 29);
            btnYeni.TabIndex = 6;
            btnYeni.Text = "Yeni";
            btnYeni.UseVisualStyleBackColor = true;
            btnYeni.Click += btnYeni_Click;
            // 
            // btnEkleGuncelle
            // 
            btnEkleGuncelle.Location = new Point(271, 38);
            btnEkleGuncelle.Name = "btnEkleGuncelle";
            btnEkleGuncelle.Size = new Size(82, 29);
            btnEkleGuncelle.TabIndex = 5;
            btnEkleGuncelle.Text = "Ekle";
            btnEkleGuncelle.UseVisualStyleBackColor = true;
            btnEkleGuncelle.Click += btnEkleGuncelle_Click;
            // 
            // FrmKategoriler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 491);
            Controls.Add(listBox1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmKategoriler";
            ShowInTaskbar = false;
            Text = "FrmKategoriler";
            Load += FrmKategoriler_Load;
            contextMenuStrip1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnTamam;
        private Label label2;
        private TextBox txtKategoriAdi;
        private Panel panel3;
        private Button btnYeni;
        private Button btnEkleGuncelle;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem yeniToolStripMenuItem;
        private ToolStripMenuItem silToolStripMenuItem;
    }
}