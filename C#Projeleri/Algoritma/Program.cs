class Program{


    static void Main()
    {
        Console.WriteLine("String bir değer ve silinmesi istediğiniz indexi arada virgül kullanarak giriniz:  ");

        string giris = Console.ReadLine();

        string[] parca = giris.Split(",");

        string metin = parca[0];
        int index = int.Parse(parca[1]);

        metin = metin.Remove(index,1);
        Console.WriteLine( );
        Console.WriteLine($"silinmiş metin güncel hali {metin}");


    }
}