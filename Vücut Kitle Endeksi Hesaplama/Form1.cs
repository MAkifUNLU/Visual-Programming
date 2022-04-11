using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vücut_Kitle_Endeksi_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            int boy = Convert.ToInt32(txt_boy.Text);
            int kilo = Convert.ToInt32(txt_kilo.Text);

            double index = kilo / (Math.Pow(boy, 2) * 0.0001);
            lbl_sonuc.Text = lbl_sonuc.Text + " " + index;
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            txt_boy.Text = "";
            txt_kilo.Text = "";
            lbl_sonuc.Text = "Vücut Kitle İndeksiniz:" ;
        }
    }
}
