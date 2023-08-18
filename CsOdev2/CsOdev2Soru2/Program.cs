using System;
using System.Collections;

class Program
{
    static void Main()
    {
        int[] numbers = new int[8];
        int[] firstNumbers = new int[3];
        int[] lastNumbers = new int[3];
        double count1=0;
        double count2=0;
      Console.WriteLine("20 adet sayı giriniz : ");

      for(int i=0;i<8;i++)
      {
        int sayi = int.Parse(Console.ReadLine());

        numbers[i] = sayi;
      }
        Array.Sort(numbers);
         foreach (var number in numbers)
        {
            Console.Write($"{number} ");
        }
        for(int i=0;i<3;i++)
        {
            
            firstNumbers[i] = numbers[i];
            count1 += firstNumbers[i];
        }
        Array.Reverse(numbers);
        for(int i=0;i<3;i++)
        {
            lastNumbers[i] = numbers[i];
            count2 += lastNumbers[i];
        }
        
        double ort1 = count1/3;
        double ort2 = count2/3;
        double ortTop = ort1 + ort2;

        Console.WriteLine("ilk üç ortalama: " + ort1 );
        Console.WriteLine("son üç ortalama: " + ort2 );
        Console.WriteLine("ortalamalar toplamı: " + ortTop  );
    }
}