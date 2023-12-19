

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
          bool sonuc =   YanYanaSessizHarfMi(arr[i]);

            if(sonuc)
            {
                Console.Write("True ");
            }
            else{
                Console.Write("False ");
            }
            
        }

        


    }

    static bool YanYanaSessizHarfMi(string kelime)
    {
        // Kelimenin uzunluğunu kontrol etme
        if (kelime.Length < 2)
        {
            // Kelimenin uzunluğu 2'den küçükse işlem yapma
            return false;
        }

        // Yan yana olan harflerin kontrolü
        for (int i = 0; i < kelime.Length - 1; i++)
        {
            char ilkHarf = char.ToLower(kelime[i]);
            char sonrakiHarf = char.ToLower(kelime[i + 1]);

            if (SessizHarfMi(ilkHarf) && SessizHarfMi(sonrakiHarf))
            {
                // Yan yana olan harfler sessiz harflerse true döndür
                return true;
            }
        }

        // Yan yana olan harfler arasında sessiz harf yoksa false döndür
        return false;
    }

    static bool SessizHarfMi(char harf)
    {
        // Harfin sessiz harf olup olmadığını kontrol etme
        char[] sessizHarfler = {'b','c','ç','d','f','g','ğ','h','j','k','l','m','n','p','r','s','ş','t','v','y','z'};
        return Array.Exists(sessizHarfler, h => h == harf);
    }


    static string[] CumleyiKelimelereAyir(string cumle)
    {
        // Cümleyi boşluklara göre ayırma
        string[] kelimeler = cumle.Split(' ');

        return kelimeler;
    }

    
}