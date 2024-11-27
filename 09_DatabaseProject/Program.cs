using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net

            Console.WriteLine("***** C# Ürün kategori Bilgi sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("1- Kategoriler");
            Console.WriteLine("2- Ürünlerr");
            Console.WriteLine("3- Siparişler");
            Console.WriteLine("4- Çıkış yap");
            Console.WriteLine("Lütfen Getirmek istediğiniz tablo numarasını giriniz: ");
            string tableNumber=Console.ReadLine();
            Console.WriteLine("-------------------------------------------");
            SqlConnection connection = new SqlConnection("Data Source =  ...........;initial Catalog = EgitimKampiDb; integrated security = true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory",connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();
            foreach (DataRow row in dataTable.Rows) 
            { 
               foreach(var item in row.ItemArray)
                {
                    Console.WriteLine(item.ToString());
                }
                    
            
            }

            Console.Read();
        }
    }
}
