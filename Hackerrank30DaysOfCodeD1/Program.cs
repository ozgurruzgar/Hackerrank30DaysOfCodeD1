using System;

namespace Hackerrank30DaysOfCodeD1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            // Declare second integer, double, and String variables. İkinci integer,double ve string değişkenleri tanımlayın.
            int i1;
            double d1;
            string s1;

            // Read and save an integer, double, and String to your variables. Değerleri Değişkene Kaydet.
            i1 = int.Parse(Console.ReadLine());
            d1 = double.Parse(Console.ReadLine());
            s1 = Console.ReadLine();
            // Print the sum of both integer variables on a new line. integer Değerlerin Toplamını Yeni Satırda Yaz.
            Console.WriteLine(i + i1);
            // Print the sum of the double variables on a new line. Double Değerlerin Toplamını Yeni Satırda Yaz.
            Console.WriteLine((d + d1).ToString("F1"));
            // Concatenate and print the String variables on a new line. String Değerleri Yeni Satırda Yaz.
            Console.WriteLine(s + s1);
            // The 's' variable above should be printed first. s değişkeni, yani "Hackerrank" başta yazsın diyor. string değerlerin yazımında

        }
    }
}
