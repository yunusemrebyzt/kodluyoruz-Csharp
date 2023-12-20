

class Program
{
        
    static void Main(string[] args)
    {
        List<string> kullanıcılar = new List<string> {"Ali", "Deniz"};

        Dictionary<string, int> oyunlar = new Dictionary<string, int>{
            {"RDR2", 0},
            {"GTA V", 0},
            {"MİNECRAFT", 0}
        };

        Dictionary<string, int> filmler = new Dictionary<string, int>{
            {"MATRİX", 0},
            {"THE DARK KNİGHT", 0},
            {"FORREST GUMP", 0}
        };

        Dictionary<string, int> futbolcular = new Dictionary<string, int>{
            {"RONALDO", 0},
            {"MESSİ", 0},
            {"NEYMAR", 0}
        };

        bool devam = true;
        while (devam)
        {
        Console.WriteLine("Merhaba oy vermek istediğiniz kategoriyi seçiniz : ");
        Console.WriteLine(" 1-> Filmler \n 2-> Futbolcular \n 3-> Oyunlar \n 4-> ÇIKIŞ ");
        string secim= Console.ReadLine();
        
            if(secim == "1")
            {
                
                if(Kayıtlımı(kullanıcılar))
                {
                    Filmler(filmler);

                }
                else
                {
                    KayıtOl(kullanıcılar);
                }
            }  
            else if(secim == "2")
            {
                if(Kayıtlımı(kullanıcılar))
                {
                    Futbolcular(futbolcular);

                }
                else
                {
                    KayıtOl(kullanıcılar);
                }
            }  
            else if(secim == "3")
            {
                if(Kayıtlımı(kullanıcılar))
                {
                    Oyunlar(oyunlar);

                }
                else
                {
                    KayıtOl(kullanıcılar);
                }
            }
            
            else if(secim == "4")
            {
                foreach (var film in filmler)
                {
                    Console.WriteLine($"\n {film.Key} filminin oyu ---->>>>> {film.Value} -->> oy yüzdesi : {film.Value*100/kullanıcılar.Count}");
                }

                foreach (var futbolcu in futbolcular)
                {
                    Console.WriteLine($"\n {futbolcu.Key} futbolcusunun oyu ---->>>>> {futbolcu.Value} -->> oy yüzdesi : {futbolcu.Value*100/kullanıcılar.Count}");
                }

                foreach (var oyun in oyunlar)
                {
                    Console.WriteLine($"\n {oyun.Key} oyununun oyu ---->>>>> {oyun.Value} -->> oy yüzdesi : {oyun.Value*100/kullanıcılar.Count}");
                }
        
                 devam =  false;
            }
            else{
                Console.WriteLine(" Hatalı tuşlama yeniden deneyiniz: ");
            }
        }
    }

    static void Filmler(Dictionary<string, int> filmler)
    {
        foreach(var film in filmler)
        {
            Console.Write($"\n{film.Key} ");
            
        }
        Console.WriteLine("\nYılın filmi ödülünde kime oy vermek istiyorsunuz yazınız : ");
        string filmSecim = Console.ReadLine();
        filmSecim = filmSecim.ToUpper();

        if(filmler.ContainsKey(filmSecim))
        {
            filmler[filmSecim]++;
            Console.WriteLine(" \nfilm başarılı bir şekilde seçildi :) \n");
        }
        else{
            Console.WriteLine(" \nSeçtiğiniz film listede bulunmuyor\n ");
        }



    }

    static void Futbolcular(Dictionary<string, int> futbolcular)
    {
        foreach(var futbolcu in futbolcular)
        {
            Console.Write($"\n{futbolcu.Key} ");
            
        }
        Console.WriteLine("\nYılın futbolcusu ödülünde kime oy vermek istiyorsunuz yazınız : ");
        string futbolcuSecim = Console.ReadLine();
        futbolcuSecim =  futbolcuSecim.ToUpper();

        if(futbolcular.ContainsKey(futbolcuSecim))
        {
            futbolcular[futbolcuSecim]++;
            Console.WriteLine(" \nfutbolcu başarılı bir şekilde seçildi :) \n");
        }
        else{
            Console.WriteLine(" \nSeçtiğiniz futbolcu listede bulunmuyor\n ");
        }
    }

    static void Oyunlar(Dictionary<string, int> oyunlar)
    {
        foreach(var oyun in oyunlar)
        {
            Console.Write($"\n{oyun.Key} ");
            
        }
        Console.WriteLine("\nYılın oyunu ödülünde kime oy vermek istiyorsunuz yazınız : ");
        string oyunSecim = Console.ReadLine();
        oyunSecim =  oyunSecim.ToUpper();

        if(oyunlar.ContainsKey(oyunSecim))
        {
            oyunlar[oyunSecim]++;
            Console.WriteLine(" \noyun başarılı bir şekilde seçildi :) \n");
        }
        else{
            Console.WriteLine(" \nSeçtiğiniz oyun listede bulunmuyor \n");
        }
    }

    static bool Kayıtlımı( List<string> liste)
    {
        Console.WriteLine(" Kullanıcı adınızı giriniz : ");
        string isim = Console.ReadLine();
        if(liste.Contains(isim))
        {
            return true;
        }
        else
        {
            
            Console.WriteLine(" Adınıza bir kayıt bulunmuyor kayıt ol menüsüne yönlendiriliyorsunuz : ");
            return false;
        }
    }

    static void KayıtOl(List<string> liste)
    {
        Console.WriteLine(" Kayıt olmak istediğiniz kullanıcı adını giriniz: ");
        string isim = Console.ReadLine();

        if(liste.Contains(isim))
        {
            Console.WriteLine("Kullanıcı adı zaten kullanılmakta başka bir kullanıcı adı giriniz : ");
            KayıtOl(liste);
        }
        else{
            Console.WriteLine($"Tebrikler başarıyla kayıt oldunuz {isim} :) ");
            liste.Add(isim);
        }
    }

    
}