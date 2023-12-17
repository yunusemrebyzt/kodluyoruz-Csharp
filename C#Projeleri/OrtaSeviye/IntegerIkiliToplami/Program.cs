

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("kaç adet ikili deger gireceksiniz? ");
        int deger = int.Parse(Console.ReadLine());

         List<Tuple<int, int>> ikiliDegerler = new List<Tuple<int, int>>();
         int[] arr = new int[deger];

         for(int i=1;i<=deger;i++)
         {
           Console.Write($"İkili değeri {i}. çifti girin (örnek: 2,3): ");
           string input = Console.ReadLine();

           string[] splitValues = input.Split(",");

           if(splitValues.Length == 2 && int.TryParse(splitValues[0], out int firstnum) && int.TryParse(splitValues[1], out int secondnum) )
           {
                ikiliDegerler.Add(new Tuple<int, int>(firstnum,secondnum));
           }
           else{
            Console.WriteLine("hatalı giriş lütfen sayıları ',' ile ayırarak giriniz !!! ");
            i--;
           }
         }

        for(int i=0;i<deger;i++ )
        {
            int sum = ikiliDegerler[i].Item1 + ikiliDegerler[i].Item2;
            if(ikiliDegerler[i].Item1 != ikiliDegerler[i].Item2)
            {
                arr[i] = sum;
            }
            else if(ikiliDegerler[i].Item1 == ikiliDegerler[i].Item2)
            {
                arr[i] = sum*sum;
            }
        }


        foreach (var item in arr)
        {
            Console.Write($"{item} ");
        }

    }
}