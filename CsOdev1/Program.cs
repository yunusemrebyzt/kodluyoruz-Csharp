using System;

namespace CsOdev1
{
    class Program
    {
        static void Main(string[] args)
        {
            // /* ****** SORU-1 ******  */
            Console.WriteLine("Pozitif bir sayı giriniz: ");
            int n  = int.Parse(Console.ReadLine());
            int[] dizi = new int[n];
            Console.WriteLine(n+" adet pozitif sayı giriniz");

            for(int i=0; i<n; i++)
            {
            dizi[i] = int.Parse(Console.ReadLine());

            }
             Console.WriteLine("Girdiğiniz sayılardan pozitif olanlar: ");
            for(int j=0;j<n;j++)
            {
                if(dizi[j] % 2 == 0 )
                {
                   
                Console.WriteLine(dizi[j]);

                }
            }


            /*  ******* SORU-2  ******** */

            // Console.WriteLine("Pozitif iki sayı giriniz: ");
            // int a = int.Parse(Console.ReadLine());
            // int b = int.Parse(Console.ReadLine());
            
            // Console.WriteLine(a + " Adet pozitif sayı giriniz: "); 
            // int[] dizi = new int[a];
            // for (int i = 0;i<a;i++)
            // {
            //       dizi[i] = int.Parse(Console.ReadLine());

            // }
            // Console.WriteLine("Girmiş olduğunuz sayılardan m'e eşit yada tam bölünenler: ");
            // for(int j=0;j<a;j++)
            // {
            //     if(dizi[j] == b || dizi[j]%b == 0){
            //         Console.WriteLine(dizi[j]);
            //     }
            // }


            /*  ******* SORU-3  ******** */

            //   Console.WriteLine("Pozitif bir sayı giriniz: "); 
            //   int n  = int.Parse(Console.ReadLine());
            //   Console.WriteLine(n + " adet kelime giriniz: ");
            //   string[] dizi = new string[n];

            //   for(int i=0;i<n;i++)
            //   {
            //     dizi[i] = Console.ReadLine();

            //   } 
            //     Console.WriteLine("Girdiğiniz keimelerin sondan başa doğrı sıralanmış hali: ");
            //   for(int i =n-1;i>=0;i--)
            //   {
            //     Console.WriteLine(dizi[i]);
            //   }
            

             /*  ******* SORU-4  ******** */


            //  Console.WriteLine("Bir cümle yazınız: ");

            //  string veri = Console.ReadLine();
            //  string[] words = veri.Split(" ");
             
            //  string letter = veri.Replace(" ", "");
            //  Console.WriteLine("Cümledeki toplam kelime sayısı : " + words.Length);

            //  char[] charArr = letter.ToCharArray();
            //  int letterCount = charArr.Count(char.IsLetter);
            
            //  Console.WriteLine("Cümledeki toplam harf sayısı : " + letterCount);




        }
    }
}