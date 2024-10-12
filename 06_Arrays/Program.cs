using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Temel Dizi Örnekleri
            string[] colors = new string[4];

            colors[0] = "Kırmızı";
            colors[1] = "Sari";
            colors[2] = "Beyaz";
            colors[3] = "Mavi";


            Console.WriteLine(colors[2]);

            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();


            string[] cities = new string[5];
            cities[0] = "Milano";
            cities[1] = "Budapeşte";
            cities[2] = "Lyon";
            cities[3] = "Kahire";
            cities[4] = "New York";

            Console.WriteLine(cities[4]);

            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();


            int[]numbers = new int[10];
            numbers[0] = 50;
            numbers[1] = 32;
            numbers[2] = 12;
            numbers[3] = 98;
            numbers[7] = 58;

            Console.WriteLine(numbers[5]);

            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();


            string[] city = { "Prag",  "Roma","Venedik","Edingburgh","London"};

            Console.WriteLine(city[2]) ;

            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();









            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            string[] color = { "sarı", "mavi", "lacivert", "mor", "pembe", "yağ yeşili" ,"turkuaz"};

            for (int i = 0; i < color.Length; i++)
            {
                Console.WriteLine(color[i]);
            }

            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();

            int[] number = { 12, 235, 57345, 7564, 123, 534, 456, 13313, 45657, 5654, 754543 };

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 3 == 0)
                {
                    Console.WriteLine(number[i]);
                }

            }

            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();


            char[] symbols = { 'A', 'B', 'C', '#', '£', '$', '+' };

            for (int i = 0; i < symbols.Length; i++)
            {
                Console.WriteLine(symbols[i]);
            }

            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();


            int[] myArray = { 123, 12, 14, 456, 6986, 342, 465, 372, 97, 66, 43, 33 };
            int maxNumber = myArray[0]; //başlangıçta diziniz en büyük değerinin ilk değer olarak kabul ettim
            for (int i = 0; i < myArray.Length ; i++)
            {
                if (myArray[i] > maxNumber)
                {
                    maxNumber= myArray[i];
                }
             }
            Console.WriteLine(maxNumber);


            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();

            string[] persons = { "Ali","Ayşe","Deniz","Cemil","Büşra","Aslı"};

            Console.WriteLine(persons.Length);

            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();


            int[] sayilar = { 43, 436, 678, 234, 098, 34, 6786, 1234, 547454, 23424, 3421465, 2362 };

            Array.Sort(sayilar);

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);


            };
            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();

            int[] sayilar2 = { 43, 436, 678, 234, 098, 34, 6786, 1234, 547454, 23424, 3421465, 2362 };

            Array.Reverse(sayilar2); //Diziyi tersten sıralıyor

            for (int i = 0; i < sayilar2.Length; i++)
            {
                Console.WriteLine(sayilar2[i]);
            }

            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();

            #endregion

            #region Dizi Metotları

            string[] customers = { "Zehra", "Hiya", "Kaya", "Umut", "Hayal" };
           var x= Array.IndexOf(customers, "Hiya");
            Console.WriteLine(x);

            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();

            int[] numbers2 = { 2334,63,42,56765,2321,315,345354,4324,3221,42,56,4236,3};
            Console.WriteLine("Dizinin en büyük elemanı: "+ numbers2.Max()+"    Dizinin en küçük elmanı: "+numbers2.Min());

            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();







            #endregion

            #region Kullanıcıdan değer alarak dizi oluşturma
            string[] city2 = new string[5];
            for (int i = 0; i < city2.Length; i++)
            {
                Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
                city2[i]= Console.ReadLine();
               
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine();

            for (int i = 0; i < city2.Length; i++)
            {
                Console.WriteLine(city2[i]);
            }


            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();


            int[] numara = { 432, 32, 654, 13, 67, 43, 734, 35, 5, 4 };
            int sum = 0;
            for (int i = 0; i < numara.Length; i++)
            {
                sum+= numara[i];


            }
            Console.WriteLine(sum);


            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();


            int[]numaralar = { 24, 234, 346, 675, 31, 7, 43, 3, 765, 12344, 556, 421134 };
            Console.WriteLine("Çift Sayılar: ");
            Console.WriteLine();

            for (int i=0; i < numaralar.Length; i++)
            {
                if (numaralar[i] % 2 == 0)
                {
                    Console.WriteLine(numaralar[i]);    

                }
               
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Tek Sayılar");
            Console.WriteLine();

            for (int i = 0; i < numaralar.Length; i++)
            {
                if (numaralar[i] % 2 == 1)
                {
                    Console.WriteLine(numaralar[i]);

                }

            }

            #endregion



            Console.Read();

        }
    }
}
