//19.03.2024 derse başlangıç
//basic intro
using kodlamaio1.ders.Businnes;
using kodlamaio1.ders.Entities;

Console.WriteLine("Hello, World!");
//veri tipleri

//conditions 
if (true)
{
    //.şarta uygun durumlar..//
}
//arrays
string[] books = { "Anna Karanina", "Anna karanina 2 ", "Anna Karanina 3 " };

for (int i = 0; i < books.Length; i++)
{

    Console.WriteLine(books[i]);
}
//oop giriş



CourseManager courseManager1 = new CourseManager();
Course[] courses= courseManager1.GetAll();

for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine($"Name:{courses[i].Name} \n Price:{courses[i].Price}");
}







