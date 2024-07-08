namespace KitapTakipUyg
{
    partial class FrmKitaplar
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            panel2 = new Panel();
            btnTamam = new Button();
            dataGridView1 = new DataGridView();
            colAd = new DataGridViewTextBoxColumn();
            colKategori = new DataGridViewComboBoxColumn();
            colFiyat = new DataGridViewTextBoxColumn();
            colRafNo = new DataGridViewTextBoxColumn();
            colSil = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(999, 56);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(594, 15);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 2;
            label2.Text = "Kategori Filtresi";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(719, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(258, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(42, 9);
            label1.Name = "label1";
            label1.Size = new Size(158, 37);
            label1.TabIndex = 0;
            label1.Text = "Kitap Listesi";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnTamam);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 443);
            panel2.Name = "panel2";
            panel2.Size = new Size(999, 62);
            panel2.TabIndex = 3;
            // 
            // btnTamam
            // 
            btnTamam.Location = new Point(866, 9);
            btnTamam.Name = "btnTamam";
            btnTamam.Size = new Size(121, 45);
            btnTamam.TabIndex = 0;
            btnTamam.Text = "Tamam";
            btnTamam.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colAd, colKategori, colFiyat, colRafNo, colSil });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(999, 387);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.DataError += dataGridView1_DataError;
            // 
            // colAd
            // 
            colAd.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colAd.DataPropertyName = "Ad";
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 255);
            colAd.DefaultCellStyle = dataGridViewCellStyle1;
            colAd.HeaderText = "Kitap Adı";
            colAd.MinimumWidth = 6;
            colAd.Name = "colAd";
            // 
            // colKategori
            // 
            colKategori.DataPropertyName = "KategoriId";
            colKategori.HeaderText = "Kategori";
            colKategori.MinimumWidth = 6;
            colKategori.Name = "colKategori";
            colKategori.Width = 200;
            // 
            // colFiyat
            // 
            colFiyat.DataPropertyName = "Fiyat";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0";
            colFiyat.DefaultCellStyle = dataGridViewCellStyle2;
            colFiyat.HeaderText = "Fiyat";
            colFiyat.MinimumWidth = 6;
            colFiyat.Name = "colFiyat";
            colFiyat.Width = 125;
            // 
            // colRafNo
            // 
            colRafNo.DataPropertyName = "RafNo";
            colRafNo.HeaderText = "Raf Numarası";
            colRafNo.MinimumWidth = 6;
            colRafNo.Name = "colRafNo";
            colRafNo.Width = 125;
            // 
            // colSil
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            colSil.DefaultCellStyle = dataGridViewCellStyle3;
            colSil.HeaderText = "Sil";
            colSil.MinimumWidth = 6;
            colSil.Name = "colSil";
            colSil.Text = "Sil";
            colSil.UseColumnTextForButtonValue = true;
            colSil.Width = 125;
            // 
            // FrmKitaplar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 505);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmKitaplar";
            Text = "FrmKitaplar";
            Load += FrmKitaplar_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnTamam;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colAd;
        private DataGridViewComboBoxColumn colKategori;
        private DataGridViewTextBoxColumn colFiyat;
        private DataGridViewTextBoxColumn colRafNo;
        private DataGridViewButtonColumn colSil;
        private Label label2;
        private ComboBox comboBox1;
    }
}