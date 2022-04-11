
namespace HesapMakinesi
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
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.txt_bir = new System.Windows.Forms.TextBox();
            this.txt_iki = new System.Windows.Forms.TextBox();
            this.lbl_bir = new System.Windows.Forms.Label();
            this.lbl_iki = new System.Windows.Forms.Label();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            this.rdb_topla = new System.Windows.Forms.RadioButton();
            this.rdb_carp = new System.Windows.Forms.RadioButton();
            this.rdb_cikar = new System.Windows.Forms.RadioButton();
            this.rdb_bol = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(67, 240);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(86, 58);
            this.btn_hesapla.TabIndex = 4;
            this.btn_hesapla.Text = "HESAPLA";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // txt_bir
            // 
            this.txt_bir.Location = new System.Drawing.Point(164, 58);
            this.txt_bir.Name = "txt_bir";
            this.txt_bir.Size = new System.Drawing.Size(82, 22);
            this.txt_bir.TabIndex = 5;
            // 
            // txt_iki
            // 
            this.txt_iki.Location = new System.Drawing.Point(164, 111);
            this.txt_iki.Name = "txt_iki";
            this.txt_iki.Size = new System.Drawing.Size(82, 22);
            this.txt_iki.TabIndex = 6;
            // 
            // lbl_bir
            // 
            this.lbl_bir.AutoSize = true;
            this.lbl_bir.Location = new System.Drawing.Point(64, 58);
            this.lbl_bir.Name = "lbl_bir";
            this.lbl_bir.Size = new System.Drawing.Size(52, 17);
            this.lbl_bir.TabIndex = 7;
            this.lbl_bir.Text = "İlk Sayı";
            // 
            // lbl_iki
            // 
            this.lbl_iki.AutoSize = true;
            this.lbl_iki.Location = new System.Drawing.Point(64, 111);
            this.lbl_iki.Name = "lbl_iki";
            this.lbl_iki.Size = new System.Drawing.Size(70, 17);
            this.lbl_iki.TabIndex = 8;
            this.lbl_iki.Text = "İkinci Sayı";
            this.lbl_iki.Click += new System.EventHandler(this.lbl_iki_Click);
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Location = new System.Drawing.Point(64, 341);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(0, 17);
            this.lbl_sonuc.TabIndex = 9;
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(160, 240);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(86, 58);
            this.btn_sil.TabIndex = 10;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // rdb_topla
            // 
            this.rdb_topla.AutoSize = true;
            this.rdb_topla.Location = new System.Drawing.Point(67, 157);
            this.rdb_topla.Name = "rdb_topla";
            this.rdb_topla.Size = new System.Drawing.Size(75, 21);
            this.rdb_topla.TabIndex = 11;
            this.rdb_topla.TabStop = true;
            this.rdb_topla.Text = "TOPLA";
            this.rdb_topla.UseVisualStyleBackColor = true;
            // 
            // rdb_carp
            // 
            this.rdb_carp.AutoSize = true;
            this.rdb_carp.Location = new System.Drawing.Point(68, 196);
            this.rdb_carp.Name = "rdb_carp";
            this.rdb_carp.Size = new System.Drawing.Size(66, 21);
            this.rdb_carp.TabIndex = 12;
            this.rdb_carp.TabStop = true;
            this.rdb_carp.Text = "ÇARP";
            this.rdb_carp.UseVisualStyleBackColor = true;
            // 
            // rdb_cikar
            // 
            this.rdb_cikar.AutoSize = true;
            this.rdb_cikar.Location = new System.Drawing.Point(170, 157);
            this.rdb_cikar.Name = "rdb_cikar";
            this.rdb_cikar.Size = new System.Drawing.Size(69, 21);
            this.rdb_cikar.TabIndex = 13;
            this.rdb_cikar.TabStop = true;
            this.rdb_cikar.Text = "ÇIKAR";
            this.rdb_cikar.UseVisualStyleBackColor = true;
            // 
            // rdb_bol
            // 
            this.rdb_bol.AutoSize = true;
            this.rdb_bol.Location = new System.Drawing.Point(170, 196);
            this.rdb_bol.Name = "rdb_bol";
            this.rdb_bol.Size = new System.Drawing.Size(57, 21);
            this.rdb_bol.TabIndex = 14;
            this.rdb_bol.TabStop = true;
            this.rdb_bol.Text = "BÖL";
            this.rdb_bol.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 410);
            this.Controls.Add(this.rdb_bol);
            this.Controls.Add(this.rdb_cikar);
            this.Controls.Add(this.rdb_carp);
            this.Controls.Add(this.rdb_topla);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.lbl_iki);
            this.Controls.Add(this.lbl_bir);
            this.Controls.Add(this.txt_iki);
            this.Controls.Add(this.txt_bir);
            this.Controls.Add(this.btn_hesapla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.TextBox txt_bir;
        private System.Windows.Forms.TextBox txt_iki;
        private System.Windows.Forms.Label lbl_bir;
        private System.Windows.Forms.Label lbl_iki;
        private System.Windows.Forms.Label lbl_sonuc;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.RadioButton rdb_topla;
        private System.Windows.Forms.RadioButton rdb_carp;
        private System.Windows.Forms.RadioButton rdb_cikar;
        private System.Windows.Forms.RadioButton rdb_bol;
    }
}

