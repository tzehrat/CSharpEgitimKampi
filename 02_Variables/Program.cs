using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)

        {

            //ÖDEV: TL Sembolünü nasıl eklersin
            //Find-Replace : ctrl+F

            #region Double Değişkenler

            //// Konsolun kodlamasını UTF-8'e ayarlıyoruz
            //Console.OutputEncoding = Encoding.UTF8;

            //double number;

            //number = 5.843;

            //Console.WriteLine(number);

            //Console.WriteLine("****** Fiyat Listesi ******");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 12.34;
            //potatoPrice = 5.24;
            //orangePrice = 13.432;
            //strawberryPrice = 50.34;
            //tomatoPrice = 40.23;


            //Console.WriteLine("----Elma Birim Fiyatı: " + applePrice + " \u20BA");
            //Console.WriteLine("----Portakal Birim Fiyatı: " + orangePrice + " \u20BA");
            //Console.WriteLine("----Patates Birim Fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("----Domates Birim Fiyatı: " + tomatoPrice + " TL");
            //Console.WriteLine("----Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.232;
            //orangeGram = 6.786;
            //strawberryGram = 2.112;
            //potatoGram = 4.474;
            //tomatoGram = 3.2323;

            //double appleTotalPrice = appleGram * applePrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //double totalPrice = appleTotalPrice + orangeTotalPrice + potatoTotalPrice +
            //    tomatoTotalPrice + strawberryTotalPrice;

            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Elmanın Toplam Fiyatı: " + appleTotalPrice + " TL");
            //Console.WriteLine("Patatesin Toplam Fiyatı: " + potatoTotalPrice + " TL");
            //Console.WriteLine("Portakalın Toplam Fiyatı: " + orangeTotalPrice + " TL");
            //Console.WriteLine("Çileğin Toplam Fiyatı: " + strawberryTotalPrice + " TL");
            //Console.WriteLine("tomato Toplam Fiyatı: " + tomatoTotalPrice + " TL");
            //Console.WriteLine("------------------------------");
            //Console.WriteLine();

            //Console.WriteLine("Toplam Tutar: " + totalPrice + " TL");




            #endregion

            #region Char Değişkenler


            //char symbol;
            //symbol = 'f';
            //Console.WriteLine(symbol);




            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("****** CSharp Hava Yolları Yolcu Bilgisi ******");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge,passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName =Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("T.C. Kimlik Numarası: ");
            //passengerIdentityNumber = Console.ReadLine();



            //Console.WriteLine("----------------");

            //Console.WriteLine("Yolcu: " + passengerName + " " + passengerSurname);
            //Console.WriteLine("TC Kimlik Numarası: " + passengerIdentityNumber);
            //Console.WriteLine("Yaş Bilgisi: " + passengerAge);
            //Console.WriteLine("Varış Yeri: " + passengerDistrict + "/" + passengerCity);


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler


            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1500;
            //computerPrice = 100000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;


            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine()); // dönüştürmek için kullanılıyor

            //Console.Write("Lütfen aldığınız Bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız TV sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız Sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());


            //int totalPrice = shoesCount * shoePrice +
            //    computerCount * computerPrice +
            //    chairPrice *chairCount +
            //    tvCount * tvPrice;

            //Console.WriteLine("Toplam Tutar: " + totalPrice + " TL");





            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("1. Sınav notunu Giriniz: ");
            //exam1 =double.Parse(Console.ReadLine()); // Stringi double a çevirdik

            //Console.Write("2. Sınav notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("3. Sınav notunu Giriniz: ");

            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1+exam2 + exam3)/3;

            //Console.WriteLine();
            //Console.Write("Sınav Ortalamanız: "+result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;

            //Console.Write("Lütfen Cinsiyet Seçiniz: ");

            //gender = char.Parse( Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: "+ gender);



            #endregion

            Console.Read();
        }
    }
}
