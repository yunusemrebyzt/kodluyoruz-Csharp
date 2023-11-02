namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cümle giriniz: ");
            string metin = Console.ReadLine();

            char[] harfler = metin.ToCharArray();

            Array.Reverse(harfler);

            string tersMetin = new string(harfler);

            Console.WriteLine(tersMetin);
        }
    }
}