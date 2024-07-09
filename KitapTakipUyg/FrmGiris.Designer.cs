namespace KitapTakipUyg
{
    partial class FrmGiris
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
            txtKullaniciAdi = new TextBox();
            txtParola = new TextBox();
            btnOturumAc = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            lblHata = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(35, 118);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(309, 27);
            txtKullaniciAdi.TabIndex = 0;
            // 
            // txtParola
            // 
            txtParola.Location = new Point(35, 171);
            txtParola.Name = "txtParola";
            txtParola.PasswordChar = '●';
            txtParola.Size = new Size(309, 27);
            txtParola.TabIndex = 1;
            // 
            // btnOturumAc
            // 
            btnOturumAc.Location = new Point(217, 236);
            btnOturumAc.Name = "btnOturumAc";
            btnOturumAc.Size = new Size(127, 48);
            btnOturumAc.TabIndex = 2;
            btnOturumAc.Text = "Oturum Aç";
            btnOturumAc.UseVisualStyleBackColor = true;
            btnOturumAc.Click += btnOturumAc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 95);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 148);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "Parola";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 78);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.shield;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            label3.Location = new Point(89, 7);
            label3.Name = "label3";
            label3.Size = new Size(270, 60);
            label3.TabIndex = 0;
            label3.Text = "Hoşgeldiniz";
            // 
            // lblHata
            // 
            lblHata.AutoSize = true;
            lblHata.ForeColor = Color.Red;
            lblHata.Location = new Point(126, 201);
            lblHata.Name = "lblHata";
            lblHata.Size = new Size(218, 20);
            lblHata.TabIndex = 4;
            lblHata.Text = "Kullanıcı Adı yada Parola hatalı!";
            lblHata.Visible = false;
            // 
            // FrmGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 296);
            Controls.Add(lblHata);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnOturumAc);
            Controls.Add(txtParola);
            Controls.Add(txtKullaniciAdi);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmGiris";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Oturum Aç";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKullaniciAdi;
        private TextBox txtParola;
        private Button btnOturumAc;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox1;
        private Label lblHata;
    }
}