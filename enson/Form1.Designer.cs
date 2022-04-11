
namespace enson
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_rast = new System.Windows.Forms.Button();
            this.btn_kucuk = new System.Windows.Forms.Button();
            this.btn_buyuk = new System.Windows.Forms.Button();
            this.lbl_kucuk = new System.Windows.Forms.Label();
            this.lbl_buyuk = new System.Windows.Forms.Label();
            this.btn_ort = new System.Windows.Forms.Button();
            this.lbl_ort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(47, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(251, 276);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(445, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 22);
            this.textBox1.TabIndex = 1;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(445, 158);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(195, 62);
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.Text = "Sayıyı Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_rast
            // 
            this.btn_rast.Location = new System.Drawing.Point(445, 253);
            this.btn_rast.Name = "btn_rast";
            this.btn_rast.Size = new System.Drawing.Size(195, 69);
            this.btn_rast.TabIndex = 4;
            this.btn_rast.Text = "Rastgele Sayı Üret";
            this.btn_rast.UseVisualStyleBackColor = true;
            this.btn_rast.Click += new System.EventHandler(this.btn_rast_Click);
            // 
            // btn_kucuk
            // 
            this.btn_kucuk.Location = new System.Drawing.Point(450, 351);
            this.btn_kucuk.Name = "btn_kucuk";
            this.btn_kucuk.Size = new System.Drawing.Size(87, 43);
            this.btn_kucuk.TabIndex = 5;
            this.btn_kucuk.Text = "En Küçük";
            this.btn_kucuk.UseVisualStyleBackColor = true;
            this.btn_kucuk.Click += new System.EventHandler(this.btn_kucuk_Click);
            // 
            // btn_buyuk
            // 
            this.btn_buyuk.Location = new System.Drawing.Point(553, 351);
            this.btn_buyuk.Name = "btn_buyuk";
            this.btn_buyuk.Size = new System.Drawing.Size(87, 43);
            this.btn_buyuk.TabIndex = 6;
            this.btn_buyuk.Text = "En Büyük";
            this.btn_buyuk.UseVisualStyleBackColor = true;
            this.btn_buyuk.Click += new System.EventHandler(this.btn_buyuk_Click);
            // 
            // lbl_kucuk
            // 
            this.lbl_kucuk.AutoSize = true;
            this.lbl_kucuk.Location = new System.Drawing.Point(457, 411);
            this.lbl_kucuk.Name = "lbl_kucuk";
            this.lbl_kucuk.Size = new System.Drawing.Size(46, 17);
            this.lbl_kucuk.TabIndex = 7;
            this.lbl_kucuk.Text = "label1";
            // 
            // lbl_buyuk
            // 
            this.lbl_buyuk.AutoSize = true;
            this.lbl_buyuk.Location = new System.Drawing.Point(550, 411);
            this.lbl_buyuk.Name = "lbl_buyuk";
            this.lbl_buyuk.Size = new System.Drawing.Size(46, 17);
            this.lbl_buyuk.TabIndex = 8;
            this.lbl_buyuk.Text = "label1";
            // 
            // btn_ort
            // 
            this.btn_ort.Location = new System.Drawing.Point(658, 351);
            this.btn_ort.Name = "btn_ort";
            this.btn_ort.Size = new System.Drawing.Size(87, 43);
            this.btn_ort.TabIndex = 9;
            this.btn_ort.Text = "Ortalama Bul";
            this.btn_ort.UseVisualStyleBackColor = true;
            this.btn_ort.Click += new System.EventHandler(this.btn_ort_Click);
            // 
            // lbl_ort
            // 
            this.lbl_ort.AutoSize = true;
            this.lbl_ort.Location = new System.Drawing.Point(655, 411);
            this.lbl_ort.Name = "lbl_ort";
            this.lbl_ort.Size = new System.Drawing.Size(46, 17);
            this.lbl_ort.TabIndex = 10;
            this.lbl_ort.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_ort);
            this.Controls.Add(this.btn_ort);
            this.Controls.Add(this.lbl_buyuk);
            this.Controls.Add(this.lbl_kucuk);
            this.Controls.Add(this.btn_buyuk);
            this.Controls.Add(this.btn_kucuk);
            this.Controls.Add(this.btn_rast);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_rast;
        private System.Windows.Forms.Button btn_kucuk;
        private System.Windows.Forms.Button btn_buyuk;
        private System.Windows.Forms.Label lbl_kucuk;
        private System.Windows.Forms.Label lbl_buyuk;
        private System.Windows.Forms.Button btn_ort;
        private System.Windows.Forms.Label lbl_ort;
    }
}

