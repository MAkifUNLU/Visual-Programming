using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enson
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

    // tane rasgele sayı üretilecek buton ile en küçük ve en büyüğü bulacaksın
    //ortalama buldur


        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult  result = MessageBox.Show("Silmek istediğinden emin misin", "silme işlemi"
                , MessageBoxButtons.YesNo,MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                int index = listBox1.SelectedIndex;
                if (index > 0 && index < listBox1.Items.Count)
                    listBox1.Items.RemoveAt(index);
                else
                    MessageBox.Show("Veri seçilmedi");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_rast_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next();


            for (int i = 0; i < 17; i++)
            {
                sayi = rastgele.Next(100);
                listBox1.Items.Add(sayi);
                Console.WriteLine(sayi + " ");           
            }
            int[] dizi = new int[sayi];
            int enkucuk = 0;
            for (int i = 0; i < dizi.Length; i++)
            {

                if (dizi[i] < enkucuk)
                {
                    enkucuk = dizi[i];
                }
            }
            lbl_kucuk.Text = enkucuk.ToString();

        }
        private void btn_kucuk_Click(object sender, EventArgs e)
        {
            int a = listBox1.Items.Count;
            int[] arr = new int[a];
            int kucuk = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (kucuk > arr[i])
                { kucuk = arr[i]; }
            }
            lbl_kucuk.Text = kucuk.ToString();
        }

        private void btn_buyuk_Click(object sender, EventArgs e)
        {
            
            int a = listBox1.Items.Count;
            
            int[] arr = new int[a];
            
            int buyuk = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (buyuk < arr[i])
                { buyuk = arr[i]; }
            }
            lbl_buyuk.Text = buyuk.ToString();
        }

        private void btn_ort_Click(object sender, EventArgs e)
        {
            int a = listBox1.Items.Count;
            int[] arr = new int[a];
            int toplam = 0;
            for (int i = 0; i < a; i++)
            {
                toplam = Int32.Parse(listBox1.Items[i].ToString()) + toplam ;
            }
            lbl_ort.Text = (toplam / 16).ToString();
        }
    }
}
