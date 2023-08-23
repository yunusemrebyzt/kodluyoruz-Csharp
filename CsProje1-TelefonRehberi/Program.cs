using System;
using System.Collections.Generic;

class Person
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? PhoneNumber { get; set; }

    public override string ToString()
    {
        return $"Kişi: {Name} {Surname}, Telefon: {PhoneNumber}";
    }
}

class Program
{
    static List<Person> phoneBook = new List<Person>()
    {
        new Person { Name = "Yunus Emre", Surname = "Bayazit", PhoneNumber = "555-123" },
        new Person { Name = "Mehmet Ali", Surname = "Karabulut", PhoneNumber = "555-456" },
        new Person { Name = "Deniz", Surname = "Vural", PhoneNumber = "555-789" },
        new Person { Name = "Sefa", Surname = "DD", PhoneNumber = "555-147" },
        new Person { Name = "Furkan", Surname = "Bayazit", PhoneNumber = "555-258" },
    };
    static void Main()
    {
         

       

        
        while(true)
        {

        
        Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
        Console.WriteLine("(1) Yeni Numara Kaydetmek \n(2) Varolan Numarayı Silmek \n(3) Varolan Numarayı Güncelleme \n(4) Rehberi Listelemek \n(5) Rehberde Arama Yapmak ?");

        int choice = int.Parse(Console.ReadLine());

        if(choice == 1)
        {
            
            SavePhone();
            

        }

        else if(choice == 2)
        {
            
            RemovePhone();
        }
        else if(choice == 3)
        {
            UpdatePhone();
        }
        
        else if(choice == 4)
        {
            Console.WriteLine("******************************** \nTelefon Rehberi: ");
            foreach (var p in phoneBook)
            {
                Console.WriteLine($"--- {p} \n");
            }
        }
        else if(choice == 5)
        {
            SearchPhone();
        }
        else
        {
            break;
        }

        }
    }

    static void SavePhone()
    {
        Console.WriteLine("Lütfen isim giriniz             :");
           string? name = Console.ReadLine();

            Console.WriteLine("Lütfen soyisim giriniz          :");
            string? surName = Console.ReadLine();

            Console.WriteLine("Lütfen Telefon numarasını giriniz      :");
            string? phoneNumber = Console.ReadLine();

            Person person  = new Person
            {
                Name = name,
                Surname = surName,
                PhoneNumber = phoneNumber
            };

            phoneBook.Add(person);

            Console.WriteLine("Kişi kaydedildi! \n********************************");
    }

    static void RemovePhone()
    {
        Console.WriteLine("********************** \nLütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz :  ");
            string? search = Console.ReadLine();
            
           int removedCount = phoneBook.RemoveAll(person => person.Name == search || person.Surname == search);

           if(removedCount > 0)
           {
            Console.WriteLine($"********************************\n {search} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
            string? delete = Console.ReadLine();
            if(delete == "y")
            {
            Console.WriteLine($"{search} kişisi silindi! \n********************************");

            }
            else{
                
            }

           }
           else
           {
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız. * Silmeyi sonlandırmak için : (1)       * Yeniden denemek için      : (2) ");
           }
    }

    static void UpdatePhone()
    {
        Console.WriteLine("******************************** \nLütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz :  ");
            string? updateName = Console.ReadLine();

            Person personToUpdate = phoneBook.Find(person => person.Name == updateName || person.Surname == updateName);

            if(personToUpdate != null)
            {
                Console.WriteLine("Yeni telefon numarasını giriniz : ");
                string? updatePhone = Console.ReadLine();

                personToUpdate.PhoneNumber = updatePhone;
            }
            else{
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. \nLütfen bir seçim yapınız. \nGüncellemeyi sonlandırmak için    : (1)     * Yeniden denemek için              : (2)");

                int num = int.Parse(Console.ReadLine());

                if(num == 1)
                {
                    
                }

            }
    }

    static void SearchPhone()
    {
        Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("*** İsim veya soyisime göre arama yapmak için: (1) \n*** Telefon numarasına göre arama yapmak için: (2)");
            int searchNum = int.Parse(Console.ReadLine());

            if(searchNum == 1)
            {
                Console.WriteLine("Arama yapmak istediğiniz kişinin isim veya soyismini yazınız");
                string search = Console.ReadLine();
                Person personToSearch = phoneBook.Find(person => person.Name == search || person.Surname == search);

                if(personToSearch != null)
                {
                    Console.WriteLine($"isim : {personToSearch.Name} soyisim:  {personToSearch.Surname} telefon numarası:  {personToSearch.PhoneNumber}");
                }
                else{
                    Console.WriteLine("Aradığınız kişiye ait bilgi bulunamadı!! \n********************************");
                }
            }
            else if(searchNum == 2)
            {
                Console.WriteLine("Arama yapmak istediğiniz kişinin telefon numarasını yazınız");
                string search = Console.ReadLine();
                Person personToSearch = phoneBook.Find(person => person.PhoneNumber == search);

                if(personToSearch != null)
                {
                    Console.WriteLine($"isim : {personToSearch.Name} soyisim:  {personToSearch.Surname} telefon numarası:  {personToSearch.PhoneNumber} \n ");
                }
                else{
                    Console.WriteLine("Aradığınız kişiye ait bilgi bulunamadı!! \n********************************");
                }

            }
    }
}