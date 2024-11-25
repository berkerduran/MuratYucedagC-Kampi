using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel dizi örnekleri 
            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "mavi";
            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "izmir";
            //cities[1] = "istanbul";
            //cities[2] = "lyon";
            //cities[3] = "kahire";
            //cities[4] = "muğla";
            //cities[5] = "balıkesir";

            //Console.WriteLine(cities[5]);

            #endregion

            #region Dizideki tüm elemanları listeleme 

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Turuncu", "Pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);

            //}


            //int[] numbers = { 1, 20, 36, 48, 556, 678, 7464, 8, 9, 10, 11, 12, 13, 14, 15 };
            //for (int i = 0; i <numbers.Length; i++)
            //{
            //    if (numbers[i]%3==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            //char[] symbol = { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
            //for (int i = 0; i < symbol.Length; i++)
            //{
            //    Console.WriteLine(symbol[i]);
            //}

            //int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //int maxNumber = myArray[0];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i]>maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }

            //}
            //Console.WriteLine(maxNumber);

            //string[] person = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };

            //Console.WriteLine(person.Length);




            #endregion

            #region Dizi Metotları
            //string[] customers = { "ali", "mehmet", "merve", "buse", "ayşegül", "çınar", "kaya" };
            //int index = Array.IndexOf(customers ,"merve");
            //Console.WriteLine(index);



            #endregion

            #region Kullanıcıdan Değer Alma 

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"litfen {i + 1}. şehri giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();

            //Console.WriteLine("----------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            int[] numbers = new int[10];
            Console.WriteLine("lütfen toplmak istediğiniz elemanları girin");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

            }
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("Sonuç:" + sum);

            #endregion
            Console.Read();
        }
    }
}
