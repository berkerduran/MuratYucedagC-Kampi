using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakinhDesicion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region IF
            //Console.WriteLine("lütfen şifreyi giriniz: ");
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

            //Console.WriteLine("başkenti giriniz giriniz:");

            //capital = Console.ReadLine();
            //Console.WriteLine("lütfen ülkeyi giriniz");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("veriler doğrulandı");

            //}
            //else
            //{
            //    Console.WriteLine("veriler yanlış ");
            //}

            //int number;
            //Console.WriteLine("Sayıyı giriniz :");
            //number =int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı:");
            //}
            //Console.WriteLine(number);

            double exam1, exam2,exam3,average;
          
            Console.WriteLine("Lütfen İlk Sınavınızı Giriniz:");
            exam1 =int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen Ara Sınavınızı Giriniz:");
            exam2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen Son Sınavınızı Giriniz:");
            exam3 = int.Parse(Console.ReadLine());

            average = (exam1 + exam2 + exam3)/3;
            if (average >= 65)
            {
                Console.WriteLine("Sınavınız Başarılı ortalamanız  :" + average);
            }
            else
            {
                Console.WriteLine("sınavınız başarısız ortalamanız : " + average);
            }







            #endregion

            Console.Read();
        }
    }
}
