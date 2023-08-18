using System;
using System.Collections;
class Program
{
    static void Main()
    {
        Console.Write("Bir kelime girin: ");
        string word = Console.ReadLine();

        char[] wordArr = word.ToCharArray();

        char[] words = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

        
        ArrayList   arrayList = new ArrayList();

       for (int i = 0; i < wordArr.Length; i++)
       {
        for (int j = 0;j<words.Length; j++)
        {
            if(char.ToLower(wordArr[i]) == words[j])
            {
                arrayList.Add(wordArr[i]);
                
            }

        }
       }

       foreach (var item in arrayList)
       {
            Console.Write(item + " ");
       }
    }    
}