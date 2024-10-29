using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Metots
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region Metotlar

            //()
            //geriye değer döndürmeyen metodlar olarak 2 ye ayrılır.
            //Customer--> Listele,ekle,sil,güncelle

            //Void mertotlar geriye deeğer döndürmeyen metot.
            void CustomerList()
            {
                Console.WriteLine("Ali yıldız");
                Console.WriteLine("Hakan Öztğrk");
                Console.WriteLine("Merve yıldırım");
                Console.WriteLine("ayşe yıldız");


            }

            CustomerList();
            Console.WriteLine();
            Console.WriteLine("-----------------");
            Console.WriteLine();

            void Sum()
            {
                int x = 1;
                int y = 2;
                int z = y + x;
                Console.WriteLine("Toplam: "+z);
            }
            Sum();

            Console.WriteLine();
            Console.WriteLine("-----------------");
            Console.WriteLine();





            #endregion


            #region Geriye değer döndürmeyen parametreli metotlar
            void Write(String customerName)
            {
                Console.WriteLine(customerName);
            }
            Write("Mehmet");
            Console.WriteLine();
            Console.WriteLine("-----------------");
            Console.WriteLine();

            void CustomerCard(string name,string surname){
                Console.WriteLine("Müşteri: " + name + " " + surname);

            }

            CustomerCard("ali","ahmet");
            Console.WriteLine();
            Console.WriteLine("-----------------");
            Console.WriteLine();


            #endregion

            #region Geriye Değer Döndürmeyen Int parametreli Metotlar

            void Summ(int number1,int number2,int number3)
            {
                int result = number1 + number2 + number3;
                Console.WriteLine(result);
            }
            Summ(12,134,235);
            Console.WriteLine();
            Console.WriteLine("-----------------");
            Console.WriteLine();
            #endregion

            #region Geriye değer döndüren metotlar
            string CustomerName()
            {
                return "buse yıldız";

            }//ekrenad akarşılığı yok

            string Student()
            {
                string name = "ali";
                string surname = "ali";
                return name + " " + surname;
                

            }
            Console.WriteLine(Student());
            Console.WriteLine();
            Console.WriteLine("-----------------");
            Console.WriteLine();
            CustomerName();

            Console.WriteLine();
            Console.WriteLine("-----------------");
            Console.WriteLine();


            #endregion

            #region Geriye değer Döndüren Parametreli metotlar

            string CountryCard(string countryNAme,string capital,string flagColor) {
            
            string cardInfo="Ülke : "+countryNAme +" - Başkent:  "+ capital +" - Bayrak Rengi: "+ flagColor;
            
            return cardInfo;

            }
            Console.Write("Ülke adını giriniz: ");
            string a, b, c;
            a = Console.ReadLine();
            Console.Write("Ülke Başkentini giriniz: ");

            b = Console.ReadLine();
            Console.Write("Ülke Bayrak rengini giriniz giriniz: ");

            c = Console.ReadLine();

            Console.WriteLine(CountryCard(a, b, c)) ;
                CountryCard(a,b,c);
            Console.WriteLine();
            Console.WriteLine("-----------------");
            Console.WriteLine();
            #endregion

            #region Geriye Değer Döndüren Int parametreli Metotlar


            int Summm(int number,int number4,int number5)
            {
                int result2 = number + number4 + number5;
                return result2;


            }
            Console.WriteLine(Summm(3,432,45) );
            Console.WriteLine(Summm(323,43432,4245) );
            Console.WriteLine(Summm(3,4,5) );
            Console.WriteLine();
            Console.WriteLine("-----------------");
            Console.WriteLine();

            //string ExamResult() {

            //    Console.Write("Öğrenci adını giriniz: ");
            //   string student=Console.ReadLine();
            //    Console.Write("Öğrencinin 1. sınav notunu giriniz: ");
            // int   exam1 = int.Parse(Console.ReadLine());
            //    Console.Write("Öğrencinin 2. sınav notunu giriniz: ");
            //  int  exam2 = int.Parse(Console.ReadLine());

            //    Console.Write("Öğrencinin 3.sınav notunu giriniz: ");
            //  int  exam3 = int.Parse(Console.ReadLine());

            //    int studenResult =(exam1 + exam2+exam3)/3;

            //    if (studenResult >= 50)
            //    {
            //        return "Öğrenci başarılı olmuştur";
            //    }
            //    else
            //    {
            //        return "Öğrenci başarısız olmuştur.";
            //    }

            //}


            #endregion

            #region Örnek Uygulama
            string ExamResult(string student, int exam1, int exam2, int exam3)
            {



                int studenResult = (exam1 + exam2 + exam3) / 3;

                if (studenResult >= 50)
                {
                    return student + " isimli öğrenci BAŞARILI olmuştur. " + "Ortalama: " + studenResult;
                }
                else
                {
                    return student + " isimli öğrenci BAŞARISIZ olmuştur. " + "Ortalama: " + studenResult;
                }

            }
            Console.Write("Öğrenci adını giriniz: ");
            string studentName = Console.ReadLine();
            Console.Write("Öğrencinin 1. sınav notunu giriniz: ");
            int t = int.Parse(Console.ReadLine());
            Console.Write("Öğrencinin 2. sınav notunu giriniz: ");
            int v = int.Parse(Console.ReadLine());

            Console.Write("Öğrencinin 3.sınav notunu giriniz: ");
            int w = int.Parse(Console.ReadLine());

            Console.WriteLine(ExamResult(studentName, t, v, w));
            Console.WriteLine();
            Console.WriteLine("-----------------");
            Console.WriteLine();
            Console.WriteLine(ExamResult("zehra", 100, 100, 100));

            #endregion
            Console.Read();
        }
    }
}
