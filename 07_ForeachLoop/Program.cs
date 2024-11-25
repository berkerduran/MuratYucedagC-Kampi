using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Foreach döngüsü 
            //int[] numbers = { 45, 78, 895, 635, 11, 74, 22, 33, 41, 205, 6578, 10394 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);

            //}
            // int[] numbers = { 45, 78, 895, 635, 11, 74, 22, 33, 41, 205, 6578, 10394 };
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}
            //int[] numbers = { 45, 78, 895, 635, 11, 74, 22, 33, 41, 205, 6578, 10394 };

            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}




            #endregion

            #region Örnek Sınav 

            Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Sınıfındızda Kaç Öğrenci Var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------");


            string[] studentNames = new string[studentCount];

            double[] studentExamAverage = new double[studentCount];

            for (int i = 0; i < studentCount; i++) {

                Console.WriteLine($"{i + 1}. öğrencinin ismini giriniz ");
                studentNames [i]= Console.ReadLine();
                double totalExamResult = 0;

                for (int j = 0; j < 3; j++) {

                    Console.WriteLine($"{studentNames[i]} adlı öğrencinin sınav {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;
                }

                studentExamAverage[i] = totalExamResult / 3;
            }
            for (int i = 0; i < studentCount; i++)
            {

                Console.WriteLine("---------------------------------");
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalamsı: {studentExamAverage[i]}");
                if (studentExamAverage[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten geçti.");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
                }
                Console.WriteLine("---------------------------------");
            }

            #endregion

            Console.Read();
        }
    }
}
