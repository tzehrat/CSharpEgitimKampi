using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            string[] cities = { "milano", "roma", "istanbul", "adana", "prag", "venedik" };

            foreach (string city in cities)
            {
                Console.WriteLine(city);

            
            
            }
            int[] numbers = { 23, 5, 2, 47, 123, 87, 453 };

            foreach (var item in numbers)
            {
                Console.WriteLine(item);

            }

            int[] numbers2 = { 423, 7675, 234, 793190, 3210, 423, 4537, 23, 135, 4564, 24, 377, 4125457, 74535, 7843, 6, 65, 4, 34, 23, 2, 62, 67, 623 };


            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine();
            Console.Write("çift sayılar: ");
            foreach (var cift in numbers2)
            {

                if (cift % 2 == 0) {
                    Console.Write($"{cift,-5}");

                }

            }



          
            int[] numbers3 = { 423, 7675, 234, 793190, 3210, 423, 4537, 23, 135, 4564, 24, 377, 4125457, 74535, 7843, 6, 65, 4, 34, 23, 2, 62, 67, 623 };
            int total = 0;
            
            foreach (var i in numbers3)
            {

             
                total= total + i;

            }
            Console.WriteLine();
            Console.WriteLine("elemanlar toplamı : "+total);

            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine();

            List<int> numbers4 = new List<int>()
            {
                1,23,43,74,12,523,87453,54,658,42,242
            };

            foreach (var i in numbers4)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine();

            string word = "Merhaba";

            foreach (char i in word)
            {
                Console.WriteLine(i);
            }













            #endregion


            #region Örnek Sınav Sistemi

            Console.WriteLine("********** C# Eğitim Kampı Uygulaması************");
            Console.WriteLine() ;
            Console.WriteLine() ;
            Console.WriteLine() ;
            Console.WriteLine() ;
            Console.WriteLine("-----------------------------") ;
            //Sınıftaki öğrenci syaısını kullanıcdan almak
            Console.Write("Sınıfınızda kaç öğrenci var : ") ;
            var ogrenciSayisi=int.Parse(Console.ReadLine());
            Console.WriteLine($"Sınıfınızdaki öğrenci sayısı {ogrenciSayisi} kadardır.");
            Console.WriteLine("----------------------------");
            Console.WriteLine();


            //Öğrenci isimlerini ve ortalamalarını saklayacak diziler
            string[] studentNames = new string[ogrenciSayisi];
            double[] studentExamAvg = new double[ogrenciSayisi];

            for (int i = 0; i < ogrenciSayisi; i++)
            {
                Console.WriteLine();

                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();
                double totalExamResult = 0;

                //Her öğrenci için 3 sınav notu girişi
                Console.WriteLine();
                for (int j = 0; j < 3; j++)
                {
                

                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;

                }


                studentExamAvg[i] = totalExamResult/3;





            }

            //öğrenci ortalamsı ve geçip kalma durumu
            Console.WriteLine();

            //for (int i = 0; i < ogrenciSayisi; i++)
            //{
  

            //    Console.WriteLine();

            //    Console.WriteLine($"{studentNames[i]} " +
            //        $"adlı öğrencinin ortalaması: {studentExamAvg[i]}");
              
            //}


            //öğrencini geçip kalma durumu

            for (int i = 0; i < ogrenciSayisi; i++)
            {

                Console.WriteLine();
                Console.WriteLine("-----------------------------");

                Console.WriteLine($"{studentNames[i]} " +
                    $"adlı öğrencinin ortalaması: {studentExamAvg[i]}");

                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti..") ;
                }

                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı...");
                }
                Console.WriteLine("-----------------------------");

            }





            #endregion












            Console.Read();


        }
    }
}
