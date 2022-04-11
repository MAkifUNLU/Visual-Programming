using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SınavForm
{
    public partial class Form1 : Form
    {
        string[,] sorular = new string[6, 6];
        int index = 0;
        int ds = 0;
        int ys = 0;


        public Form1()
        {
            InitializeComponent();
            sorular[0, 0] = "2+2 = ?";
            sorular[0, 1] = "1";
            sorular[0, 2] = "2";
            sorular[0, 3] = "3";
            sorular[0, 4] = "4";
            sorular[0, 5] = "4";

            sorular[1, 0] = "Çay hangi dağda içilir ?";
            sorular[1, 1] = "Ağrı Dağı";
            sorular[1, 2] = "Bey Dağı";
            sorular[1, 3] = "Çaybar Dağı";
            sorular[1, 4] = "Everest Dağı";
            sorular[1, 5] = "Çaybar Dağı";

            sorular[2, 0] = "Türkiyenin en büyük takımı hangisidir ?";
            sorular[2, 1] = "Malatya Spor";
            sorular[2, 2] = "Adana Demir Spor";
            sorular[2, 3] = "Galatasaray";
            sorular[2, 4] = "Göztepe";
            sorular[2, 5] = "Malatya Spor";

            sorular[3, 0] = "Merve Hocanın en sevdiği öğrenci kimdir ?";
            sorular[3, 1] = "Ben";
            sorular[3, 2] = "Akif";
            sorular[3, 3] = "アキフ";
            sorular[3, 4] = "Bu kodu yazan kişi";
            sorular[3, 5] = "アキフ";

            sorular[4, 0] = "Hasan Onur'un halası oğludur.\nBurcu Onur'unkarısı ve amcası kızıdır." + 
                "Zeynep ise Hasan'ın teyzesinin kızıdır. \nBurcu Zeynep'in nesidir ? ";
            sorular[4, 1] = "Amcasının kızı";
            sorular[4, 2] = "Dayısının kızı";
            sorular[4, 3] = "Halasının kızı";
            sorular[4, 4] = "Yengesi";
            sorular[4, 5] = "Dayısının kızı";

            sorular[5, 0] = "Dün yarın olsaydı bugün perşembe olurdu diyen biri bu sözü hangi gün söylemiştir ?";
            sorular[5, 1] = "Cumartesi";
            sorular[5, 2] = "Pazar";
            sorular[5, 3] = "Pazartesi";
            sorular[5, 4] = "Cuma";
            sorular[5, 5] = "Cumartesi";

            sorular[5, 0] = "Satranç tahtasında kaç tane kare vardır?";
            sorular[5, 1] = "64";
            sorular[5, 2] = "128";
            sorular[5, 3] = "204";
            sorular[5, 4] = "326";
            sorular[5, 5] = "204";

            soruListele();

        }

        public void soruListele()
        {
            //buraya bak bir alt satır
            if (index < sorular.GetLength(0))
            {
                lbl_soru.Text = sorular[index, 0];
                radioButton1.Text = sorular[index, 1];
                radioButton2.Text = sorular[index, 2];
                radioButton3.Text = sorular[index, 3];
                radioButton4.Text = sorular[index, 4];
            }
            else
            {
                lbl_soru.Text = "Sınav Tamamlanmıştır!";
                groupBox1.Visible = false;
                button1.Enabled = false;                
            }           
        }
        private void button1_Click(object sender, EventArgs e)
        {            
            foreach (RadioButton rbt in groupBox1.Controls.OfType<RadioButton>())
            {
                if (rbt.Checked)
                {
                    if (rbt.Text.Equals(sorular[index, 5]))
                    {
                        ds++;
                        lbl_dogru.Text = "Doğru Sayısı : " + ds;
                        lbl_mesaj.Text = "Afferim Böyle Devam Et";

                    }
                    else
                    {
                        ys++;
                        lbl_yanlıs.Text = "Yanlış Sayısı : " + ys;                      
                        lbl_mesaj.Text = "Dikkatli OLLLL !!";
                    }
                    break;
                }
            }
            index++;
            soruListele();
        }    
    }
}
