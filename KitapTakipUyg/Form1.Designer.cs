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
            btnKategoriler = new Button();
            btnKaydet = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnKategoriler
            // 
            btnKategoriler.Location = new Point(33, 39);
            btnKategoriler.Name = "btnKategoriler";
            btnKategoriler.Size = new Size(197, 63);
            btnKategoriler.TabIndex = 0;
            btnKategoriler.Text = "Kategoriler";
            btnKategoriler.UseVisualStyleBackColor = true;
            btnKategoriler.Click += btnKategoriler_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(732, 25);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(123, 47);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // button1
            // 
            button1.Location = new Point(33, 108);
            button1.Name = "button1";
            button1.Size = new Size(197, 63);
            button1.TabIndex = 0;
            button1.Text = "Kitaplar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 471);
            Controls.Add(btnKaydet);
            Controls.Add(button1);
            Controls.Add(btnKategoriler);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnKategoriler;
        private Button btnKaydet;
        private Button button1;
    }
}
