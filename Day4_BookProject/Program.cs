//Kitap ekleme listeleme ve silme operasyonları simüle edicez
//Veri tabanı gibi çalışan bir liste kullanıcaz

//Klasörler : models en temel yapımız olcak temel classlarımızı buraya eklicez
//Data : listenin içinde datalarımızın olduğu ve çeşitli dataları burda tutcaz
//Exceptions : kendi yolladığımız exceptions burda buluncak
//Business : Aranan data bulunamadı tarzı şeyler burda buluncak
//Entity Framework Core kullanılır sektörde
//Dapper > EFC

using Day4_BookProject.Business;
using Day4_BookProject.Data;
using Day4_BookProject.Models;

IBookService bookService = new BookService(new BookRepository());

bookService.GetList();

Book book = new Book()
{
    Id = 5,
    Description = "Test",
    Price = -1,
    Stock = -1,
    Title = "T",
};

Console.WriteLine("Kayıt ekleme : ");
bookService.Add(book);

