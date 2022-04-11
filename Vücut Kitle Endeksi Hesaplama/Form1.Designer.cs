
namespace Vücut_Kitle_Endeksi_Hesaplama
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
            this.lbl_boy = new System.Windows.Forms.Label();
            this.lbl_kilo = new System.Windows.Forms.Label();
            this.txt_boy = new System.Windows.Forms.TextBox();
            this.txt_kilo = new System.Windows.Forms.TextBox();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.lbl_baslık = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_boy
            // 
            this.lbl_boy.AutoSize = true;
            this.lbl_boy.Location = new System.Drawing.Point(141, 104);
            this.lbl_boy.Name = "lbl_boy";
            this.lbl_boy.Size = new System.Drawing.Size(141, 17);
            this.lbl_boy.TabIndex = 0;
            this.lbl_boy.Text = "Boyunuzu Girin (cm):";
            // 
            // lbl_kilo
            // 
            this.lbl_kilo.AutoSize = true;
            this.lbl_kilo.Location = new System.Drawing.Point(141, 155);
            this.lbl_kilo.Name = "lbl_kilo";
            this.lbl_kilo.Size = new System.Drawing.Size(129, 17);
            this.lbl_kilo.TabIndex = 1;
            this.lbl_kilo.Text = "Kilonuzu Girin (kg):";
            // 
            // txt_boy
            // 
            this.txt_boy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_boy.Location = new System.Drawing.Point(288, 104);
            this.txt_boy.Name = "txt_boy";
            this.txt_boy.Size = new System.Drawing.Size(80, 22);
            this.txt_boy.TabIndex = 2;
            this.txt_boy.Tag = "";
            // 
            // txt_kilo
            // 
            this.txt_kilo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_kilo.Location = new System.Drawing.Point(288, 155);
            this.txt_kilo.Name = "txt_kilo";
            this.txt_kilo.Size = new System.Drawing.Size(80, 22);
            this.txt_kilo.TabIndex = 3;
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Location = new System.Drawing.Point(141, 302);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(145, 17);
            this.lbl_sonuc.TabIndex = 4;
            this.lbl_sonuc.Text = "Vücut Kitle İndeksiniz:";
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(144, 212);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(94, 62);
            this.btn_hesapla.TabIndex = 5;
            this.btn_hesapla.Text = "HESAPLA";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(274, 212);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(94, 62);
            this.btn_sil.TabIndex = 6;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // lbl_baslık
            // 
            this.lbl_baslık.AutoSize = true;
            this.lbl_baslık.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_baslık.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_baslık.Location = new System.Drawing.Point(93, 29);
            this.lbl_baslık.Name = "lbl_baslık";
            this.lbl_baslık.Size = new System.Drawing.Size(385, 25);
            this.lbl_baslık.TabIndex = 7;
            this.lbl_baslık.Text = "VÜCUT KİTLE İNDEKSİ HESAPLAMA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.lbl_baslık);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.txt_kilo);
            this.Controls.Add(this.txt_boy);
            this.Controls.Add(this.lbl_kilo);
            this.Controls.Add(this.lbl_boy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_boy;
        private System.Windows.Forms.Label lbl_kilo;
        private System.Windows.Forms.TextBox txt_boy;
        private System.Windows.Forms.TextBox txt_kilo;
        private System.Windows.Forms.Label lbl_sonuc;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Label lbl_baslık;
    }
}

