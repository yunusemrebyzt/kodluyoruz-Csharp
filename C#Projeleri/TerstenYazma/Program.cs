namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cümle giriniz: ");
            string metin = Console.ReadLine();
            char harf;
            string[] kelimeler = metin.Split(" "); 

            for(int i=0;i<kelimeler.Length;i++)
            {
                
                    kelimeler[i] = TersiniAl(kelimeler[i]);

                
            }

            

            foreach (string eleman in kelimeler)
        {
            Console.Write(eleman +" ");
        }
        }

        static string TersiniAl(string kelime)
        {
            char[] harfler = kelime.ToCharArray();
            
            char harf = harfler[0];
            for(int i=0;i<harfler.Length-1;i++)
            {
                
                    
                    harfler[i] = harfler[i+1];
       
            }
            harfler[harfler.Length-1] = harf;

            return new string(harfler);


        }
    }
}