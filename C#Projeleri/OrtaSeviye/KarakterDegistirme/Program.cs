

class Program
{
    static void Main(string[] args)
    {
        
        
        Console.WriteLine("İşlem yapmak istediğiniz cümleyi giriniz :  ");
        string cumle = Console.ReadLine();
      

        int boslukSayisi = cumle.Count(c => c == ' ');
        string[] arr = new string[boslukSayisi+1];

        arr = CumleyiKelimelereAyir(cumle);
        
        for(int i=0;i<boslukSayisi+1;i++)
        {
            string kelime = arr[i];

            if (kelime.Length >= 2)
            {

            char ilkHarf = kelime[0];

            // Kelimenin son harfi
            char sonHarf = kelime[kelime.Length - 1];

            // İlk ve son harfleri yer değiştirilmiş kelime oluşturma
            string yeniKelime = sonHarf + kelime.Substring(1, kelime.Length - 2) + ilkHarf;

            arr[i] = yeniKelime;

            
            }
        }

        foreach (var item in arr)
        {
            Console.Write($"{item} ");
        }


    }

    static string[] CumleyiKelimelereAyir(string cumle)
    {
        // Cümleyi boşluklara göre ayırma
        string[] kelimeler = cumle.Split(' ');

        return kelimeler;
    }
}