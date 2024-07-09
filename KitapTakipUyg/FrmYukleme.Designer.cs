namespace KitapTakipUyg
{
    partial class FrmYukleme
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            progressBar1 = new ProgressBar();
            lblBilgi = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(653, 164);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.books;
            pictureBox1.Location = new Point(3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DeepPink;
            panel2.Location = new Point(-17, -5);
            panel2.Name = "panel2";
            panel2.Size = new Size(679, 70);
            panel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(0, 68);
            label1.Name = "label1";
            label1.Size = new Size(653, 89);
            label1.TabIndex = 1;
            label1.Text = "    BtkAkademi";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F);
            label2.Location = new Point(71, 222);
            label2.Name = "label2";
            label2.Size = new Size(533, 67);
            label2.TabIndex = 1;
            label2.Text = "Kitap Takip Uygulaması";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(518, 302);
            label3.Name = "label3";
            label3.Size = new Size(65, 28);
            label3.TabIndex = 2;
            label3.Text = "V1.0.1";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(193, 350);
            progressBar1.Maximum = 4;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(274, 21);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 3;
            // 
            // lblBilgi
            // 
            lblBilgi.Font = new Font("Segoe UI", 12F);
            lblBilgi.ForeColor = Color.OrangeRed;
            lblBilgi.Location = new Point(12, 378);
            lblBilgi.Name = "lblBilgi";
            lblBilgi.Size = new Size(629, 37);
            lblBilgi.TabIndex = 4;
            lblBilgi.Text = "Uygulama Yükleniyor";
            lblBilgi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // FrmYukleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(653, 415);
            Controls.Add(lblBilgi);
            Controls.Add(progressBar1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmYukleme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmYukleme";
            TransparencyKey = Color.DeepPink;
            Shown += FrmYukleme_Shown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ProgressBar progressBar1;
        private Label lblBilgi;
        private System.Windows.Forms.Timer timer1;
        private Panel panel2;
    }
}