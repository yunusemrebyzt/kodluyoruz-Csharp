

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("kaç adet deger gireceksiniz? ");
        int deger = int.Parse(Console.ReadLine());

         List<int> degerler = new List<int>();
         
         int farkToplam =0;
         int mutlakToplam =0;

         for(int i=1;i<=deger;i++)
         {
           Console.Write($" {i}. değeri girin: ");
           int input = int.Parse(Console.ReadLine());

           degerler.Add(input);
           
           
         }


         for(int i=0 ;i<deger; i++)
         {
            
            if(degerler[i] < 67)
            {
                farkToplam += 67 - degerler[i];
            }
            else if(degerler[i] > 67)
            {
                int fark = degerler[i] -67;
                mutlakToplam += fark * fark;
            }
         }

         Console.Write($"farklarının toplamı: {farkToplam},farklarının mutlak karelerinin toplamı:  {mutlakToplam}");
    }
}