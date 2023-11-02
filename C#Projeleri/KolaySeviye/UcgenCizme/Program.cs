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
            UcgenCiz(deger);

        }

        static void UcgenCiz(int n)
        {
         int k=2;
         int bosluk=0;
            for(int i=0;i<n;i++)
            {
                Console.Write("\n");
                for(int l=n-1;l>=bosluk;l--)
                {
                    Console.Write(" ");
                }
                for(int j=1;j<k;j++)
                {
                     Console.Write("*");
                }
                k= k+2;
                bosluk++;
            }
        }

        
    }
}