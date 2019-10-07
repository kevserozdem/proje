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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Oyuna başla butonu ile bilgisayar, rakamları birbirinden farklı 4 basamaklı bir sayı tutmaktadır." +
                " Kullanıcı bilgisayarın tahmin ettiği sayıyı bulmaya çalışır." +
                " Tahminler sonucunda tutulan sayı ile ilgili ipuçları verilir." +
                " Eğer tahmin edilen sayı içinde tutulan sayının rakamlarından varsa ve basamak değeri doğruysa “+” değer olarak ipucu verilir, basamak değeri yanlış ise “-” değer olarak ipucu verilir." +
                " Örneğin bilgisayar 5483 sayısını tutsun. Kullanıcı 3468 tahmini yaptığında 4 sayısının basamak değeri doğru olduğu için +1, 3 ve 8 sayısının basamak değeri yanlış olduğu için -2 değeri dönmektedir." +
                " Yani “+1 - 2” dönüşü olacaktır.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
        }
    }
}
