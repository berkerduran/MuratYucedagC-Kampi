using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Methods

            //void Customerlist()
            //{
            //    Console.WriteLine("Ali yıldız ");
            //    Console.WriteLine("Ayşeyıldız ");
            //    Console.WriteLine("Veli yıldız ");
            //    Console.WriteLine("Merve yıldız ");
            //}
            //Customerlist();

            //void Sum()
            //{ 
            //    int x = 0;
            //    int y = 2;
            //    int z = x+y;
            //    Console.WriteLine(z);


            //}
            //Sum();
            #endregion

            #region Gerideğer dödürmeyen parametreli methodlar 


            //void WriteMethod(string customerName) 
            //{
            //    Console.WriteLine(customerName);            
            //}
            //WriteMethod("customerName");


            //void CustomerCard(string name,string surName)
            //{
            //    Console.WriteLine("Müşteri:"+name +surName);
            //}
            //CustomerCard("Mehmet","Yıldız");
            //CustomerCard("Ayşegül", "Kaya");


            //void Sum(int number1, int number2,int number3)
            //{
            //    int result = number1 + number2+ number3;
            //    Console.WriteLine(result);
            //}

            //Sum(4, 5, 6);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "buse Yıldız";
            //}
            //CustomerName();


            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surName = "Kaya";

            //    return name + " " + surName;

            //}
            //StudentCard();

            #endregion

            #region Geriye değer dondüren parametreli metotlar


            //string CountryCard(string countryName, string capital,string flagColor)
            //{

            //    string cardInfo = "Ülke: "+countryName+" - Başkent: "+ capital+" - Bayrak Rengi: " +flagColor;
            //    return cardInfo;

            //}
            //string x, y, z;

            //Console.Write("Ülkenin adını giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("lütfen bayrak rengini giriniz ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x,y,z));

            //Console.WriteLine(CountryCard("türkiye ", "Ankara", "Kırmızı Beyaz"));

            #endregion

            #region Geriye Değer Döndüren İnt Paramaetreli Metodlar 

            //int Sum(int number1,int number2)
            //{ 
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(55,52));
            //Console.WriteLine(Sum(45, 52));
            //Console.WriteLine(Sum(59, 15));
            //Console.WriteLine(Sum(33, 98));
            #endregion
            #region Örnek Uygulama
            string ExamResult(string student, int exam1, int exam2,int exam3)
            { 
                int result = (exam1+exam2+exam3)/3;
                if (result>=50)
                {
                    return student + "Adlı öğrenci Başaralı" + "Ortalama:"+result;

                }else
                {
                    return student + "Adlı öğrenci Başarısız"+"Ortalama:" + result;
                }
              
            }
            Console.WriteLine(ExamResult("Ali", 25, 45, 26));
            Console.WriteLine(ExamResult("Ayşe", 29, 80,66));
            #endregion
        }
    }
}
