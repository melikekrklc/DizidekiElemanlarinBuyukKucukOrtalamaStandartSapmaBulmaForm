using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DizidekiElemanlarınBüyükKüçükOrtalamaStandartSapmaBulmaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] dizi = new double[10] { 15, 24, 57, 89, 41, 25, 24, 12, 90, 85 };
            double enBuyuk = dizi[0];//Dizinin ilk elemanını en büyük al.
            double enKucuk = dizi[0];//Dizinin ilk elemanını en küçük al.
            double toplam = 0;
            double ortalama;
            double standartSapma = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] > enBuyuk)
                {
                    enBuyuk = dizi[i];
                }
                if (dizi[i]<enKucuk)
                {
                    enKucuk = dizi[i];
                }

                toplam = toplam + dizi[i];
            }
            ortalama = toplam / dizi.Length;

            //standart sapma formülü= elemanlardan ortalamayı çıkarıp karesini alıp topla . Daha sonra eleman sayısına böl ve karekökünü al.

            for (int j = 0; j < dizi.Length; j++)
            {
                standartSapma += Math.Pow((dizi[j] - ortalama),2);
            }

            standartSapma = Math.Sqrt(standartSapma / dizi.Length);

            listBox1.Items.Add("En küçük:" + enKucuk);
            listBox1.Items.Add("En büyük:" + enBuyuk);
            listBox1.Items.Add("Toplam:" + toplam);
            listBox1.Items.Add("Ortalama:" + ortalama);
            listBox1.Items.Add("Standart sapma:" + standartSapma);
        }
    }
}
