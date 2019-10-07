using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiTahmin
{
    public partial class Form1 : Form
    {
        Random rnd = new Random(); //rastgele değer atamak için
        int bas1, bas2, bas3, bas4; //tutulan sayının basamakları
        int deneme_sayisi;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ipucu.Visible = false;
            tahmin_text.Visible = false;
            tahmin_but.Visible = false;
            tahmin_gecmis.Visible = false;
            baslik.Visible = false;
            tahmin_text.MaxLength = 4;
        }

        private void tahmin_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) //rakamsa yazılır
            {
                e.Handled = false;
            }

            else if ((int)e.KeyChar == 8) //backspace (ASCII karşılığı 8) yazılabilir
            {
                e.Handled = false;
            }
            else //diğer karakterler yazılmaz
            {
                e.Handled = true;
            }
        } 
        
        private void tahmin_but_Click(object sender, EventArgs e)
        {
            int index;
            String tahmin; //kullanıcının tahmini
            int dogru = 0, yanlis = 0; //doğru ve yanlış yerdeki rakamların sayısı
            if (tahmin_text.TextLength < 4 || tahmin_text.Text.StartsWith("0")) //kullanıcı dört basamaktan az girerse veya binler basamağı 0 olursa
                Hata();
            else
            {
                deneme_sayisi++; //kullanıcının kaçıncı tahmininde bulunduğu
                tahmin = tahmin_text.Text; //kullanıcının tahmini
                index = tahmin.IndexOf(Convert.ToString(bas1)); //tutulan sayının binler basamağı tahminde var mı
                if (index == 0) //rakam tahminde doğru yerde mi
                    dogru++;
                else if (index == 1 || index == 2 || index == 3) //rakam var ama yanlış yerde
                    yanlis++;

                index = tahmin.IndexOf(Convert.ToString(bas2)); //yüzler basamağı için
                if (index == 1)
                    dogru++;
                else if (index == 0 || index == 2 || index == 3)
                    yanlis++;

                index = tahmin.IndexOf(Convert.ToString(bas3)); //onlar basamağı için
                if (index == 2)
                    dogru++;
                else if (index == 0 || index == 1 || index == 3)
                    yanlis++;

                index = tahmin.IndexOf(Convert.ToString(bas4)); //birler basamağı için
                if (index == 3)
                    dogru++;
                else if (index == 0 || index == 1 || index == 2)
                    yanlis++;

                if (dogru == 4) //bütün basamaklar doğru ise
                {
                    ipucu.Text = "Tebrikler! Sayıyı " + deneme_sayisi + ". denemede doğru tahmin ettiniz.";
                    tahmin_but.Visible = false;
                    basla_but.Visible = true;
                }
                else
                { //sayı doğru tahmin edilemediyse ipucu verilir
                    ipucu.Text = "İPUCU:  +" + dogru + " -" + yanlis;
                    tahmin_gecmis.Items.Add(tahmin + "  --->  " + "+" + dogru + " -" + yanlis); //tahmin geçmişi listesine eklenir
                }
                dogru = 0;
                yanlis = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show(); //nasıl oynanır formunu açar
        }

        private void basla_but_Click(object sender, EventArgs e) //oyun başlatılarak rakamları farklı bir sayı üretilir
        {
            int sayi = SayiTut();
            Console.WriteLine(sayi); //kontrol için tutulan sayıyı konsola yazdırdım


            //oyun her başladığında sıfırlanan değerler
            deneme_sayisi = 0;
            ipucu.Text = "4 basamaklı sayıyı tahmin ediniz.";
            tahmin_text.Text = "";
            tahmin_gecmis.Items.Clear();
            ipucu.Visible = true;
            tahmin_text.Visible = true;
            tahmin_but.Visible = true;
            tahmin_gecmis.Visible = true;
            baslik.Visible = true;
            basla_but.Visible = false;

        }

        private void Hata()
        {
            ipucu.Text = "Lütfen 4 basamaklı sayı giriniz.";
        }

        private int SayiTut()
        {
            int basamak, sayi;
            do
            {
                basamak = rnd.Next(0, 9);
            } while (basamak == 0); //4 basamaklı olması için binler basamağı 0 olmamalı
            bas1 = basamak;

            do
            {
                basamak = rnd.Next(0, 9);
            } while (basamak == bas1); //yüzler basamağı binler basamağından farklı olmalı
            bas2 = basamak;

            do
            {
                basamak = rnd.Next(0, 9);
            } while (basamak == bas1 || basamak == bas2); //onlar basamağını atamak için
            bas3 = basamak;

            do
            {
                basamak = rnd.Next(0, 9);
            } while (basamak == bas1 || basamak == bas2 || basamak == bas3); //birler basamağı için
            bas4 = basamak;

            sayi = bas1 * 1000 + bas2 * 100 + bas3 * 10 + bas4; //tutulan sayı
            return sayi;
        }
        
    }
}
