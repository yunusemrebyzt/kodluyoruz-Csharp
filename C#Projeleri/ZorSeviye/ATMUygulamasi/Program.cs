

using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        int hak=3;
        string[] aktifKullanici = new string[1];
        List<string> hatalı = new List<string>();
        List<string> islemler = new List<string>();
        bool devam = true;
        Dictionary<string,string> kullanıcılar = new Dictionary<string, string>{
            {"Deniz","1234"},
            {"Mehmet","7899"}
        };

        Dictionary<string,int> paralar = new Dictionary<string, int>{
            {"Deniz",500},
            {"Mehmet",200}
        };


        Console.WriteLine("ATM'de işlem yapmak için lütfen giriş yapınız : \n ");
        
        while(hak>0)
        {

        
        if(KayıtlıMı(kullanıcılar,hatalı,aktifKullanici))
        {
            
            while(devam)
            {
            
                Console.WriteLine("Yapmak istediğiniz işlemi seçiniz : ");
                Console.WriteLine("1->Para Çekme \n2->Para Yatırma \n3->Ödeme Yapma \n4->Gün sonu al");
                int secim = int.Parse(Console.ReadLine());
                
                if(secim == 1)
                {
                    ParaCek(paralar,aktifKullanici,islemler);
                }
                else if(secim == 2)
                {
                    ParaYatır(paralar,aktifKullanici,islemler);
                }
                else if(secim == 3)
                {
                    OdemeYap(paralar,aktifKullanici,islemler);
                }
                else if(secim == 4)
                {
                    GunAl(hatalı,islemler,aktifKullanici);
                    devam = false;
                    hak = 0;
                }
            
            
            }
        }
        else{
            hak--;
            Console.WriteLine($"kalan hak {hak} ");
        }
        }
    }

    static void ParaCek(Dictionary<string,int> paralar,string[] aktifKullanici,List<string> islemler)
    {
        int aktifPara = paralar[aktifKullanici[0]];
        Console.WriteLine($"Hesabınızda bulunan para miktari {aktifPara}");
        Console.WriteLine("Ne kadar para çekmek istiyorsunuz ? ");
        int cekilenPara = int.Parse(Console.ReadLine());

        if(aktifPara<cekilenPara)
        {
            Console.WriteLine("Yeteri kadar paranız yok :( ");
        }
        else{

            islemler.Add($"{cekilenPara.ToString()} tl para çekildi !");
            aktifPara = aktifPara - cekilenPara;

            paralar[aktifKullanici[0]] = aktifPara;

            Console.WriteLine("İşlem başarılı bir şekilde yapıldı :) ");
        }
    }

    static void ParaYatır(Dictionary<string,int> paralar,string[] aktifKullanici,List<string> islemler)
    {
        int aktifPara = paralar[aktifKullanici[0]];
        Console.WriteLine($"Hesabınızda bulunan para miktari {aktifPara}");
        Console.WriteLine("Ne kadar para yatırmak istiyorsunuz ? ");
        int yatirilanPara = int.Parse(Console.ReadLine());
        islemler.Add($"{yatirilanPara.ToString()} tl para yatırıldı !");
        aktifPara = aktifPara + yatirilanPara;

        paralar[aktifKullanici[0]] = aktifPara;

        Console.WriteLine("İşlem başarılı bir şekilde yapıldı :) ");
    }

    static void OdemeYap(Dictionary<string,int> paralar,string[] aktifKullanici,List<string> islemler)
    {
        int aktifPara = paralar[aktifKullanici[0]];
        Console.WriteLine($"Hesabınızda bulunan para miktari {aktifPara}");
        Console.WriteLine("Ne kadar ödeme yapmak istiyorsunuz ? ");
        int cekilenPara = int.Parse(Console.ReadLine());

        if(aktifPara<cekilenPara)
        {
            Console.WriteLine("Ödeme yapacak kadar paranız yok :( ");
        }
        else{

            islemler.Add($"{cekilenPara.ToString()} tl Ödeme yapıldı!");
            aktifPara = aktifPara - cekilenPara;

            paralar[aktifKullanici[0]] = aktifPara;

            Console.WriteLine("İşlem başarılı bir şekilde yapıldı :) ");
        }
    }

    static void GunAl(List<string> hatalı,List<string> islemler,string[] aktifKullanici)
    {
        int hatalıCount = hatalı.Count;
        Console.WriteLine($"\nHatalı giriş denemesi {hatalıCount} ");

        foreach (var hata in hatalı)
        {
            Console.WriteLine(hata);
        }

        Console.WriteLine("\nYapılan işlemler : ");

        foreach (var islem in islemler)
        {
            Console.WriteLine(islem);
        }

        string masaustuDizin = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string dosyaYolu = Path.Combine(masaustuDizin, $"{aktifKullanici[0]}{DateTime.Now.ToShortDateString()}.txt");

        using (StreamWriter sw = new StreamWriter(dosyaYolu))
        {
            sw.WriteLine("HATALI GİRİŞ DENEMELERİ : ");
            foreach (string item in hatalı)
            {
                sw.WriteLine(item);
            }
            sw.WriteLine("YAPILAN İŞLEMLER : ");
            foreach (string item1 in islemler)
            {
                sw.WriteLine(item1);
            }
        }

        Console.WriteLine("\nListe başarıyla masaüstüne yazıldı.");
    }

    static bool KayıtlıMı( Dictionary<string, string> kullanıcılar,List<string> hatalı,string[] aktifKullanici)
    {
        Console.WriteLine("Kullanıcı adınızı giriniz : ");
        string userName = Console.ReadLine();

        Console.WriteLine("Şifrenizi giriniz : ");
        string password = Console.ReadLine();
        if(kullanıcılar.ContainsKey(userName) && kullanıcılar.ContainsValue(password))
        {
            Console.WriteLine("Sisteme başarılı bir şekilde giriş yapıldı :) ");
            aktifKullanici[0] = userName;
            return true;
        }
        else{
            Console.WriteLine("Kullanıcı adı veya şifre hatalı tekrar deneyiniz !!! ");
            DateTime saat = DateTime.Now;
            Console.WriteLine($"{saat}");
            hatalı.Add(saat.ToString()); 
            return false;
        }
    }
}