using System;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir deger giriniz: ");
            int deger = int.Parse(Console.ReadLine());
            Fibonacci(deger);

        }

        static void Fibonacci(int num)
        {
            float a=0;
            float b=1;
            float c=0;
            float sum = 1;
            float ort=0;
            
            for(int i=2;i<=num;i++)
            {
                c = a+b;
                a = b;
                b = c;
                sum+=c;

               
            }
            Console.WriteLine(sum);
            Console.WriteLine($"ortalama degeri = {sum/num}");
        }
    }
}