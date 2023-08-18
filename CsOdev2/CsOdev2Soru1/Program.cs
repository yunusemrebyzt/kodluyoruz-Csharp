using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Program
{

    static bool IsPrime(int num)
    {
        int sayac=0;
        for(int i=1;i<=num;i++)
        {
            if(num % i == 0)
            {
                sayac++;
            }
        }

        if(sayac == 2)
        {return true;}
        else    
        {return false;}
    }
    static void Main()
    {
        ArrayList primeList = new ArrayList();
        ArrayList nonprimeList = new ArrayList();

        

        Console.WriteLine("5 adet pozitif sayı giriniz : ");

        for(int i=0;i<5;i++)
        {
           int number = int.Parse(Console.ReadLine());
            if(number > 0 )
            {

                if(IsPrime(number))
                {
                    primeList.Add(number);
                }
                else{
                    nonprimeList.Add(number);
                }
            }
            else{

            } 
        }  
        
        primeList.Sort();
        nonprimeList.Sort();
        
        Console.WriteLine("asal adet : " + primeList.Count  );
        Console.WriteLine("asal olmayan adet : " + nonprimeList.Count );
        Console.Write("Asal olanlar: ");
         foreach (var item in primeList)
        {
            Console.Write(item+" ");
        }
        
        Console.Write("\nAsal olmayanlar: ");
         foreach (var item in nonprimeList)
        {
            Console.Write(item+" ");
        }        
    }

    
}