using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region For Döngüsü

            //int i;

            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# eğitim kampı");
            //}





            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine(i);
            //}





            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}






            //Console.Write("Lütfen ekrana yazımasını istediğiniz değeri giriniz: ");


            //int finishValue = int.Parse(Console.ReadLine());


            //for (int i = 0; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}







            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //int total = 0;

            //for (int i = 0; i <= 10; i++)
            //{
            //    total += i;

            //}
            //Console.WriteLine(total);



            //int totalValue = 0;

            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }

            //}

            //Console.WriteLine("------------");
            //Console.WriteLine("toplam değer: " + totalValue);





            //int count = 0;
            //for (int i = 1; i <= 59; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine(count);





            //int bacteria = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacteria *= 2;

            //    Console.WriteLine(i + "Saat sonunda oluşan bakteri: " + bacteria);

            //}











            #endregion

            #region While Döngüsü

            ////Şart sağladnığı müddetçe

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Herşey Çok Güzel Olucak Prenses ");
            //    i++;


            //}

            //int j = 1;
            //while (j <= 100)
            //{
            //    if (j % 6 == 0)
            //    {
            //        Console.WriteLine("Herşey Çok Güzel Olucak Prenses " + j);
            //    }
            //    j++;
            //}

            //int sum = 0;
            //int i = 1;
            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);


            //#endregion

            //#region Örnek Sınav Sorusu

            //int value;
            //int tens, ones, hundreds;
            //int sum;
            //Console.Write("Sayıyı Giriniz: ");
            //value = int.Parse(Console.ReadLine());

            //ones = value % 10;
            //hundreds = value / 100;
            //tens = (value - (hundreds * 100 + ones)) / 10; //(value%100)/10
            //sum = hundreds + tens + ones;
            //Console.WriteLine("sayının yüzler basamağı: " + hundreds);
            //Console.WriteLine("sayının onlar basmaağı: " + tens);
            //Console.WriteLine("sayının birler basamağı: " + ones);
            //Console.WriteLine("sayının basamak değerleri toplamı: " + sum);

            #endregion //Klavyeden girilen 3 bas sayının basamkaları toplamını giriniz


            Console.Read();
        }


    }
}
