using System;
using System.Collections.Generic;

enum SizeEnum
{
    XS = 1,
    S = 2,
    M = 3,
    L = 4,
    XL = 5
    
}
class Card
{
    

    public string Title { get; set; }
    public string Contents { get; set; }

    public string PersonId { get; set; }
    public string Size { get; set; }

    public int CardId { get; set; }

}

class Program
{
    static Dictionary<int,string> person = new Dictionary<int,  string>()
    {
        { 1, "yunus" },
        { 2, "Deniz" },
        { 3,"Sefa"}
    };

    
    static List<Card> phoneBook = new List<Card>
    {
        new Card { Title = "Ali", Contents = "Yılmaz", PersonId = $"{person[1]}",Size = $"{(SizeEnum)1}",CardId=1},
        new Card { Title = "Mehmet", Contents = "Yılmaz", PersonId = $"{person[2]}",Size = $"{(SizeEnum)2}",CardId=1},
        new Card { Title = "Deniz", Contents = "Yılmaz", PersonId = $"{person[3]}",Size = $"{(SizeEnum)2}",CardId=2},
    };

    
    static void Main(string[] args)
    {
        while(true)
        {

        Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
        Console.WriteLine("\n(1) Board Listelemek \n(2) Board'a Kart Eklemek \n(3) Board'dan Kart Silmek \n(4) Kart Taşımak");

        int choice = int.Parse(Console.ReadLine());

        if(choice == 1)
        {
            
            BoardList();
        }
        else if(choice == 2)
        {
            AddCard();
        }
        else if(choice == 3)
        {
            DeleteCard();
        }
        else if(choice == 4)
        {
            MoveCard();
        }
        else{
            break;
        }
    }

    static void BoardList()
    {
        Console.WriteLine("TODO Line \n ************************* \n");
        
                foreach(Card card in phoneBook)
                 {
                    if(card.CardId == 1)
                    {
                    Console.WriteLine($"Başlık: {card.Title}\n İçerik: {card.Contents}\n Atanan Kişi: {card.PersonId}\n Büyüklük: {card.Size}\n");

                    }

            
                }
        Console.WriteLine("IN PROGRESS Line \n ************************* \n");

                foreach(Card card in phoneBook)
                 {
                    if(card.CardId == 2)
                    {
                    Console.WriteLine($"Başlık: {card.Title}\n İçerik: {card.Contents}\n Atanan Kişi: {card.PersonId}\n Büyüklük: {card.Size}\n");

                    }

            
                }        

        Console.WriteLine("DONE Line \n ************************* \n");

                foreach(Card card in phoneBook)
                 {
                    if(card.CardId == 3)
                    {
                    Console.WriteLine($"Başlık: {card.Title}\n İçerik: {card.Contents}\n Atanan Kişi: {card.PersonId}\n Büyüklük: {card.Size}\n");

                    }

            
                }           
        
        
    }
        
    }

    static void AddCard()
    {
        Console.WriteLine("Başlık Giriniz                                  : ");
        string title = Console.ReadLine();

        Console.WriteLine("İçerik Giriniz                                  : ");
        string contents = Console.ReadLine();

        Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  : ");
        int size = int.Parse(Console.ReadLine());

        Console.WriteLine("Kişi id Giriniz                                  : ");
        int id = int.Parse(Console.ReadLine());

        if(person.ContainsKey(id))
        {
        Card newCard = new Card { Title = title, Contents = contents, PersonId = $"{person[id]}",Size = $"{(SizeEnum)size}",CardId=0};

        phoneBook.Add(newCard);

        }
    }

    static void DeleteCard()
    {
        Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
        Console.WriteLine("Lütfen kart başlıgını yazınız. ");

        string search  = Console.ReadLine();
        List<Card> cardsToDelete = phoneBook.Where(card => card.Title == search).ToList();

        if(cardsToDelete.Count > 0)
        {

            foreach (Card card in cardsToDelete)
            {
                
                
                phoneBook.Remove(card);
                Console.WriteLine($"{search} bulundu ve silindi!!  ");  
                
                
            }
        }
        else{
            Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Silmeyi sonlandırmak için : (1) ");
            Console.WriteLine("* Yeniden denemek için : (2) ");
            int num = int.Parse(Console.ReadLine());

            if(num == 2){
                DeleteCard();
            }
            else{}
        }
    }

    static void MoveCard()
    {
        Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
        Console.WriteLine("Lütfen kart başlıgını yazınız. ");
        string? move = Console.ReadLine();

        List<Card> cardsToMove = phoneBook.Where(card => card.Title == move).ToList();


        if(cardsToMove.Count > 0)
        {

            foreach (Card card in cardsToMove)
            {
                
                
               
                Console.WriteLine(" bulunan card bilgileri:  ");
                Console.WriteLine($"Başlık: {card.Title}\n İçerik: {card.Contents}\n Atanan Kişi: {card.PersonId}\n Büyüklük: {card.Size}\n");  
                Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: (1) TODO (2) IN PROGRESS (3) DONE");
                int num = int.Parse(Console.ReadLine());

                if(num == 1 || num ==2 || num==3)
                {

                card.CardId = num;
                Console.WriteLine("Card taşındı! ");
                }
                else{
                    Console.WriteLine("Hatalı bir seçim yaptınız!! ");
                    
                }
                
            }
        }
        else{
            Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Taşımayı sonlandırmak için : (1) ");
            Console.WriteLine("* Yeniden denemek için : (2) ");
            int num = int.Parse(Console.ReadLine());

            if(num == 2){
                MoveCard();
            }
            else{}
        }
    }
}