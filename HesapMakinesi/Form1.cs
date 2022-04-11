using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 0 a bölümde hata döndür
        // text box da sadece sayı yazdır
        // tek if kullanmaya çalış
        // MessasgeBox.Show la hata göster

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            int bir = Convert.ToInt32(txt_bir.Text);
            int iki = Convert.ToInt32(txt_iki.Text);
            int sonuc = 0;
            if (rdb_topla.Checked) {
                sonuc = bir + iki;
            }
            else if(rdb_cikar.Checked)
            {
                sonuc = bir - iki;
            }
            else if(rdb_carp.Checked)
            {
                sonuc = bir * iki;
            }
            else if(rdb_bol.Checked)
            {
                sonuc = bir / iki;
            }
            lbl_sonuc.Text = "SONUÇ : " + sonuc;
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            txt_bir.Text = "";
            txt_iki.Text = "";
            lbl_sonuc.Text = "SONUÇ : ";
        }

        private void lbl_iki_Click(object sender, EventArgs e)
        {

        }
    }
}
