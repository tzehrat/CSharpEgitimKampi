﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If

            //Console.Write("Lütefen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("şifre doğru");
            //}

            //else
            //{
            //    Console.WriteLine("şifre yanlış");
            //}



            //string capital, country;
            //Console.Write("başkenti gir:  ");
            //capital = Console.ReadLine();
            //Console.Write("ülkeyi giriniz:  ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("veriler doğru");
            //}
            //else
            //{
            //    Console.WriteLine("yanlış veriler");
            //}



            //int sayi;
            //Console.Write("sayiyi giriniz:  ");
            //sayi = int.Parse(Console.ReadLine());

            //if (sayi == 21)
            //{
            //    Console.WriteLine("sayi doğru");

            //}
            //else
            //{
            //    Console.WriteLine("sayı hatalı");
            //}






            //int exam1, exam2, exam3, average;
            //string result = "hata ";

            //Console.Write("sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Sınavların ortalamsı: " + average);

            //if (average > 0 & average <= 50)
            //{

            //    result = "Sonuç vasat";
            //}

            //if (average > 50 & average <= 85)
            //{

            //    result = "Sonuç ortalama";

            //}




            //if (average > 85 & average <= 100)
            //{

            //    result = "Sonuç İyi";

            //}


            //Console.WriteLine(result);






            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if (city == "adana" || city == "ankara" || city == "bursa" || city == "trabzon")
            //{

            //    Console.WriteLine("şehir mevcut");
            //}

            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}


            //Console.Write("Lütfen Kullancıı Adını Giriniz:  ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("bu kullanıcı adı kabul edilemez");
            //}














            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 23;

            //int result = number % 2;

            //Console.WriteLine(result);


            //Console.Write("lütfen 1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("lütfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;


            //Console.Write("1. sayının 2. sayıya bölümündn kalan :  " + result);


            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("sayı çifttir");
            //}

            //else
            //{
            //    Console.Write("sayi tektir");

            //}

















            #endregion

            #region Char Değişkenler ile Karar Yapılar


            //char team;
            //Console.Write("lğtfen takım sembolünü igiriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' || team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}

            //if (team == 'f' || team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}


            //if (team == 'b' || team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}

            //#endregion

            //#region Örnek Proje Uygulaması 

            //Console.WriteLine("*******C# eğitim kampı restoranı********");

            //Console.WriteLine();

            //Console.WriteLine("---------------------------------");

            //Console.WriteLine("1-Ana Yemekler");

            //Console.WriteLine("2-Çorbalar");

            //Console.WriteLine("3-Pizzalar");

            //Console.WriteLine("4-İçecekler");

            //Console.WriteLine("5-Tatlılar");

            //Console.WriteLine("-----------------------------------");

            //string menuItem;

            //Console.WriteLine("Detayını görmek istediğiniz menü seçimi: ");

            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();

            //    Console.WriteLine("-----------Ana Yemekler-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Ana Yemekler-----------");
            //    Console.WriteLine();

            //}





            //if (menuItem == "2")
            //{
            //    Console.WriteLine();

            //    Console.WriteLine("-----------Çorbalar-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Ezogelin Çorbası");
            //    Console.WriteLine("2-Tarhana Çorbası");
            //    Console.WriteLine("3-Mantar Çorbası");
            //    Console.WriteLine("4-Yayla Çorbası");
            //    Console.WriteLine("5-Tavuk Çorbası");
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Çorbalar-----------");
            //    Console.WriteLine();

            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();

            //    Console.WriteLine("-----------Pizzalar-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-MArgarita Pizza");
            //    Console.WriteLine("2-Bol Malzemos");
            //    Console.WriteLine("3-Peynir Sarımsaklı Pizza");
            //    Console.WriteLine("4-Pastırmalı Pizza");
            //    Console.WriteLine("5-Pizza Mozarella");
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Pizzalar-----------");
            //    Console.WriteLine();

            //}


            //if (menuItem == "4")
            //{
            //    Console.WriteLine();

            //    Console.WriteLine("-----------İçecekler-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Limonata");
            //    Console.WriteLine("3-Ayran");
            //    Console.WriteLine("4-Soda");
            //    Console.WriteLine("5-Su");
            //    Console.WriteLine();
            //    Console.WriteLine("-----------İçecekler-----------");
            //    Console.WriteLine();

            //}


            //if (menuItem == "5")
            //{
            //    Console.WriteLine();

            //    Console.WriteLine("-----------Tatlılar-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Browni");
            //    Console.WriteLine("2-Profiterol");
            //    Console.WriteLine("3-Kurabiye");
            //    Console.WriteLine("4-Dondurma");
            //    Console.WriteLine("5-Baklava");
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Tatlılar-----------");
            //    Console.WriteLine();

            //}















            #endregion

            #region Switch-Case 

            //Console.Write("Lütfen Ay Girişi Yapınız:  ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default: Console.WriteLine("Hatalı veri girişi"); break;

            //}

            #endregion

            #region Hesap Makinesi- Switch-Case

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1. sayıyı giriniz: ");
            //number1=int.Parse(Console.ReadLine());


            //Console.Write("2. sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());


            //Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz: ");

            //symbol=char.Parse(Console.ReadLine());


            //switch (symbol)
            //{
            //    case '+':
            //        result=number1 + number2;
            //        Console.WriteLine("Toplama İşleminin Sonucu: " + result);
            //        break;
            //    case '-':
            //        result=number1 - number2;
            //        Console.WriteLine("Çıkarma İşleminin Sonucu: " + result);

            //        break;

            //    case '*':   result= number1 * number2;
            //        Console.WriteLine("Çarpma İşleminin Sonucu: " + result);

            //        break;

            //    case'/': result= number1 / number2;

            //        Console.WriteLine("Bölme İşleminin Sonucu: " + result);

            //        break;



            //}






            #endregion











            Console.ReadKey();
        }
    }
}
