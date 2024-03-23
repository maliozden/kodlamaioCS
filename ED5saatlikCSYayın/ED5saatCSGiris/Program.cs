using Businness.Concrete;
using ED5saatCSGiris;
using Entities.Concrete;


public class Program
{
    private static void Main(string[] args)
    {
        Citizen human1 = new Citizen();

        human1.Name = "Muhammed";
        human1.Surname = "Ali";
        human1.birthyear = 2000;


        /*
        SayHello("ahmet");

        SayHello("mehmet");


        SayHello();


        static void SayHello(string Name="Noname")
        {
            Console.WriteLine($"Hello, {Name}!");
        }
        */


        string[] sehirler1 = new[] { "Ankara", "İstanbul ", "İzmir" };

        string[] sehirler2 = new[] { "Adana", "Bursa ", "Antalya " };

        sehirler2 = sehirler1;
        //sehirler1 ve sehirler2 nin aynı adresi referans etmesini sağladık

        sehirler1[0] = "Bolu";
        Console.WriteLine(sehirler2[0]);
        //Array,Class,Abstarct gibi yapılar referans tipi değişkenlerdir.
        //Bu yüzden heapde aynı adresi gösteren referanslar aynı adresteki değerleri alır veya günceller


        List<string> sehirler3 = new List<string>() { "Isparta", "Konya", "Aydın" };
        sehirler3.Add("Antalya");
        Person person1 = new Person();
        PttManager pttManager = new PttManager(new PersonManager());
        person1.Name = "Mali";
        person1.Surname = "Gosling";
        person1.Id = 123;
        person1.BirthYear = 2000;

        pttManager.GiveMask(person1);
    }
}