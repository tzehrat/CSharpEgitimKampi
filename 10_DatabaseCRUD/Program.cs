using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CRUD operations

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek istediğiniz Kategori Adı: ");
            //string categoryName=Console.ReadLine();
            //SqlConnection connection = 
            //    new SqlConnection("Data Source=DESKTOP-H1UMG5K\\ASAR;initial catalog=EgitimKampiDB;integrated security=true");
            //connection.Open();//bağlantıyı aç
            ////Sorgu
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)",connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery(); //koşulsuz çalıştır
            //connection.Close();
            //Console.Write("Katogori başarıyla eklendi");
            #endregion

            #region Ürün ekleme işlemi
            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write("Eklemek istediğiniz ürün adı: ");
            //productName=Console.ReadLine();
            //Console.Write("Eklediğiniz ürünü fıyatı: ");
            //productPrice=decimal.Parse(Console.ReadLine());
            //SqlConnection sqlConnection = new SqlConnection("Data source=DESKTOP-H1UMG5K\\ASAR;initial catalog=EgitimKampiDB;integrated security=true");

            //sqlConnection.Open();
            //SqlCommand cmd = new SqlCommand("insert into" +
            //    " TblProduct(ProductName,ProductPrice,ProductStatus) values (@p1,@p2,@p3)", sqlConnection);
            //cmd.Parameters.AddWithValue("@p1", productName);
            //cmd.Parameters.AddWithValue("@p2", productPrice);
            //cmd.Parameters.AddWithValue("@p3", true);
            //cmd.ExecuteNonQuery();//çalıştır değişikleri kaydet
            //sqlConnection.Close();
            //Console.WriteLine("Ürün eklendi");










            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection conn = new SqlConnection("Data source=DESKTOP-H1UMG5K\\ASAR;" +
            //    "initial catalog=EgitimKampiDB;integrated security=true");
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("Select * From TblProduct",conn);
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd); // köprü veritabanı ve c# projesi arasında
            //DataTable   dt = new DataTable();//verileri geçici belleğe alabilmek için

            //adapter.Fill(dt);//belleğe adapter kodunu ekle

            //foreach (DataRow dr in dt.Rows)
            //{ 
            //foreach(var item in dr.ItemArray)
            //    {
            //        Console.Write(item.ToString()+" ");
            //    }
            //Console.WriteLine();
            //}
            //conn.Close();
            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün Id: ");
            //int productId=int.Parse(Console.ReadLine());

            //SqlConnection conn = new SqlConnection("Data source=DESKTOP-H1UMG5K\\ASAR;" +
            //   "initial catalog=EgitimKampiDB;integrated security=true");

            //conn.Open();
            //SqlCommand cmd = new SqlCommand("Delete From TblProduct Where ProductId=@productId",conn);
            //cmd.Parameters.AddWithValue("@productId", productId);
            //cmd.ExecuteNonQuery();
            //Console.WriteLine("Silme İşlemi Yapıldı");





            //conn.Close();
            #endregion

            #region Ürün Güncelleme İşlemi
            Console.Write("Güncellenecek Ürün Id: ");
            int productId=int.Parse(Console.ReadLine());

            Console.Write("Güncellenecek Ürün Adı: ");

            string productName =Console.ReadLine();

            Console.Write("Güncellenecek Ürün Fiyatı: ");

            decimal productPrice =decimal.Parse(Console.ReadLine());

            Console.Write("Güncellenecek Ürün Stokta mı? : ");

            bool productStatus =bool.Parse(Console.ReadLine());

           SqlConnection conn = new SqlConnection("Data source=DESKTOP-H1UMG5K\\ASAR;" +
               "initial catalog=EgitimKampiDB;integrated security=true");
            conn.Open();
            SqlCommand  cmd= new SqlCommand("Update TblProduct Set ProductName=@productName,ProductPrice=@productPrice,ProductStatus=@productStatus Where ProductId=@productId",conn);
            cmd.Parameters.AddWithValue("@productName", productName);
            cmd.Parameters.AddWithValue("@productId", productId);
            cmd.Parameters.AddWithValue("@productPrice", productPrice);
            cmd.Parameters.AddWithValue("@productStatus", productStatus);
            cmd.ExecuteNonQuery();

            conn.Close();
            Console.WriteLine("Güncelleme Başarılı");
            
            
            
            #endregion

            Console.Read();
        }
    }
}
