using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt Alta 10 tane yıldız oluşturma

            //for (int i = 1; i <=10; i++)
            //{
            //    Console.WriteLine("*");
            //}


            #endregion

            #region Yan Yana 10 tane yıldız oluşturma

            //Console.WriteLine();

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}


            #endregion

            #region Alt Alta 10 tane yıldız oluşturma Her Satırda 10 tane yıldız olsun

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("***********");
            //}


            #endregion

            #region Dik üçgen

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //   Console.WriteLine();
            //}


            #endregion

            #region Ters Dik üçgen

            //for (int i = 10; i>= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Dik ve Ters dik üçgen alt alta

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int k = 9; k >= 1; k--)
            //{
            //    for(int l = 1; l <= k; l++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Baklava Dilimi
            //int n = 5;

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j =n- 1; j >0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = n - 1; i >= 1; i--)
            //{
            //    for(int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k=1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine() ;
            //}


            #endregion

            #region Piramit Baklava Dilimi

            int n = 5;
            for(int i = 1; i <=n; i++)                              //i 1 den başdaıve j döngüsüne geçilidi  j 4 ten başladı 1e kadar yani 4 tane noşluk bıraktı
            {//boşluklar
                for (int j=n-i; j > 0; j--)
                {
                    Console.Write(" ");
                 }

                //yıldızlar
                for(int k = 1; k <= 2 * i - 1; k++)    // k 1den başladı i 1 di ve işelmden bir yıldız yazıldı tekrar döngü döndü j den 3 boşluk kdan bu sefer i 2 oyuzden 5 tane yıldız .....
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                

            }
            for(int l=n-1;l>=1; l--)    //l 4 den başlıcak  m döngüsü 1 tane boşluk ilk döngğde  7 yıldız ikinci döngü 2 boşluk  5 yıldız.......
            
            {
                for(int m=n-l;m>0; m--)
                {
                    Console.Write(" ");
                }

                for(int p =1 ; p <= 2*l-1; p++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion

















            Console.Read();
        }
    }
}
    