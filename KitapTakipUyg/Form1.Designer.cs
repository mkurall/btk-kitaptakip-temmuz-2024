namespace KitapTakipUyg
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnKategoriler = new Button();
            btnKaydet = new Button();
            button1 = new Button();
            panel1 = new Panel();
            btnKullanici = new Button();
            btnKullanicilar = new Button();
            panel2 = new Panel();
            btnAra = new Button();
            txtAranan = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            colAd = new DataGridViewTextBoxColumn();
            colKategori = new DataGridViewComboBoxColumn();
            colFiyat = new DataGridViewTextBoxColumn();
            colRafNo = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            bilgilerimiDüzenleToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            oturumuKapatToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnKategoriler
            // 
            btnKategoriler.Location = new Point(127, 13);
            btnKategoriler.Name = "btnKategoriler";
            btnKategoriler.Size = new Size(98, 34);
            btnKategoriler.TabIndex = 0;
            btnKategoriler.Text = "Kategoriler";
            btnKategoriler.UseVisualStyleBackColor = true;
            btnKategoriler.Click += btnKategoriler_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Image = Properties.Resources.floppy_disk__1_;
            btnKaydet.ImageAlign = ContentAlignment.MiddleLeft;
            btnKaydet.Location = new Point(434, 12);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(125, 35);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // button1
            // 
            button1.Location = new Point(17, 13);
            button1.Name = "button1";
            button1.Size = new Size(92, 34);
            button1.TabIndex = 0;
            button1.Text = "Kitaplar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(btnKullanici);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnKaydet);
            panel1.Controls.Add(btnKullanicilar);
            panel1.Controls.Add(btnKategoriler);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(931, 55);
            panel1.TabIndex = 2;
            // 
            // btnKullanici
            // 
            btnKullanici.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnKullanici.FlatAppearance.BorderSize = 0;
            btnKullanici.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btnKullanici.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            btnKullanici.FlatStyle = FlatStyle.Flat;
            btnKullanici.Image = Properties.Resources.profile_user;
            btnKullanici.ImageAlign = ContentAlignment.MiddleLeft;
            btnKullanici.Location = new Point(758, 12);
            btnKullanici.Name = "btnKullanici";
            btnKullanici.Size = new Size(161, 30);
            btnKullanici.TabIndex = 3;
            btnKullanici.Text = "Ad Soyad";
            btnKullanici.UseVisualStyleBackColor = true;
            btnKullanici.Click += btnKullanici_Click;
            // 
            // btnKullanicilar
            // 
            btnKullanicilar.Location = new Point(242, 13);
            btnKullanicilar.Name = "btnKullanicilar";
            btnKullanicilar.Size = new Size(151, 34);
            btnKullanicilar.TabIndex = 0;
            btnKullanicilar.Text = "Kullanıcı Tanımları";
            btnKullanicilar.UseVisualStyleBackColor = true;
            btnKullanicilar.Visible = false;
            btnKullanicilar.Click += btnKullanicilar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Beige;
            panel2.Controls.Add(btnAra);
            panel2.Controls.Add(txtAranan);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(931, 49);
            panel2.TabIndex = 3;
            // 
            // btnAra
            // 
            btnAra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAra.Location = new Point(880, 9);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(46, 29);
            btnAra.TabIndex = 2;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // txtAranan
            // 
            txtAranan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtAranan.Location = new Point(606, 11);
            txtAranan.Name = "txtAranan";
            txtAranan.Size = new Size(270, 27);
            txtAranan.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(548, 14);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "Aranan";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colAd, colKategori, colFiyat, colRafNo });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionBackColor = Color.Fuchsia;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(931, 296);
            dataGridView1.TabIndex = 4;
            // 
            // colAd
            // 
            colAd.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colAd.DataPropertyName = "Ad";
            colAd.HeaderText = "Kitap Adı";
            colAd.MinimumWidth = 6;
            colAd.Name = "colAd";
            colAd.ReadOnly = true;
            // 
            // colKategori
            // 
            colKategori.DataPropertyName = "KategoriId";
            colKategori.HeaderText = "Kategori";
            colKategori.MinimumWidth = 6;
            colKategori.Name = "colKategori";
            colKategori.ReadOnly = true;
            colKategori.Width = 200;
            // 
            // colFiyat
            // 
            colFiyat.DataPropertyName = "Fiyat";
            colFiyat.HeaderText = "Fiyat";
            colFiyat.MinimumWidth = 6;
            colFiyat.Name = "colFiyat";
            colFiyat.ReadOnly = true;
            colFiyat.Width = 125;
            // 
            // colRafNo
            // 
            colRafNo.DataPropertyName = "RafNo";
            colRafNo.HeaderText = "Raf Numarası";
            colRafNo.MinimumWidth = 6;
            colRafNo.Name = "colRafNo";
            colRafNo.ReadOnly = true;
            colRafNo.Width = 125;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { bilgilerimiDüzenleToolStripMenuItem, toolStripMenuItem1, oturumuKapatToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(205, 58);
            // 
            // bilgilerimiDüzenleToolStripMenuItem
            // 
            bilgilerimiDüzenleToolStripMenuItem.Name = "bilgilerimiDüzenleToolStripMenuItem";
            bilgilerimiDüzenleToolStripMenuItem.Size = new Size(204, 24);
            bilgilerimiDüzenleToolStripMenuItem.Text = "Bilgilerimi Düzenle";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(201, 6);
            // 
            // oturumuKapatToolStripMenuItem
            // 
            oturumuKapatToolStripMenuItem.Name = "oturumuKapatToolStripMenuItem";
            oturumuKapatToolStripMenuItem.Size = new Size(204, 24);
            oturumuKapatToolStripMenuItem.Text = "Oturumu Kapat";
            oturumuKapatToolStripMenuItem.Click += oturumuKapatToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 400);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "BtkAkademi - Kitap Takip Uygulaması";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            Shown += Form1_Shown;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnKategoriler;
        private Button btnKaydet;
        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private Button btnAra;
        private TextBox txtAranan;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colAd;
        private DataGridViewComboBoxColumn colKategori;
        private DataGridViewTextBoxColumn colFiyat;
        private DataGridViewTextBoxColumn colRafNo;
        private Button btnKullanici;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem bilgilerimiDüzenleToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem oturumuKapatToolStripMenuItem;
        private Button btnKullanicilar;
    }
}
