using System.Data;

class Program
{
    static void Main()
    {
        Console.WriteLine("Alanın hesaplanmasını istediğiniz geometrik seçmi giriniz : (1-2-3-4) ");
        Console.WriteLine(" 1- Kare \n 2- Dikdörtgen \n 3- Üçgen  \n 4-Daire  Çıkmak için ---> (5)");
        int secim = int.Parse(Console.ReadLine());

        if(secim == 1)
        {
            Kare();
        }
        else if(secim == 2)
        {
            Dikdortgen();
        }
        else if(secim == 3)
        {
            Ucgen();
        }
        else if(secim == 4)
        {
            Daire();
        }
        else if(secim == 5)
        {
            
        }
        else{
            Console.WriteLine("Hatalı tuşlama yaptınız ... ");
        }
    }


    static void Kare()
    {
        Console.WriteLine("Hesaplanmasını istediğiniz karenin kenar uzunluğunu giriniz : ");
        int kenar = int.Parse(Console.ReadLine());
        int alan = kenar * kenar;
        int çevre = kenar * 4;
        Console.WriteLine($"\n Kenar uzunluğu {kenar} olan karenin alanı = {alan}  Çevresi =  {çevre} \n");
        Main();
    }

    static void Dikdortgen()
    {
        Console.WriteLine("Hesaplanmasını istediğiniz dikdörtgenin kısa kenar uzunluğunu giriniz : ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Hesaplanmasını istediğiniz dikdörtgenin uzun kenar uzunluğunu giriniz : ");
        int b = int.Parse(Console.ReadLine());
        int alan = a * b;
        int çevre = (a * 2) + (b*2);
        Console.WriteLine($"\n Verilen bilgilere göre dikdörtgenin alanı = {alan}  Çevresi =  {çevre} \n");
        Main();
    }

    static void Ucgen()
    {
        Console.WriteLine("Üçgenin alanını(1) mı çevresini(2) mi hesaplamak istersiniz : ");
        int secim = int.Parse(Console.ReadLine());

        if(secim == 1)
        {
            Console.WriteLine("Üçgenin taban alanını giriniz :  ");
            int taban = int.Parse(Console.ReadLine());
            Console.WriteLine("Üçgenin yüksekliğini giriniz : ");
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n üçgenin alanı = {taban*h/2} \n");
            Main();
        }
        else if(secim == 2)
        {
            Console.WriteLine("Üçgenin 1. kenar uzunluğunu giriniz: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Üçgenin 2. kenar uzunluğunu giriniz: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Üçgenin 3. kenar uzunluğunu giriniz: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n üçgenin çevresi = {a+b+c} \n");
            Main();
        }
       
    }

    static void Daire()
    {
        Console.WriteLine("Hesaplanmasını istediğiniz dairenin yarıçap uzunluğunu giriniz : ");
        int r = int.Parse(Console.ReadLine());
        int pi = 3;
        int alan = pi * r * r;
        int çevre = 2 * pi * r;
        Console.WriteLine($"\n Verilen bilgilere göre dairenin alanı = {alan}  Çevresi = {çevre} \n");

        Main();
    }
}