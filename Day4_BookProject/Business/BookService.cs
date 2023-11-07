using Day4_BookProject.Data;
using Day4_BookProject.Exceptions;
using Day4_BookProject.Models;

namespace Day4_BookProject.Business;

//BookService içinde BookRepository kullanıcağımız için şu yöntemi kullanıcaz
//Dependency Injection (Constructor args Injection,Setter injection,method injection)
// AddScopeed, AddSingleton, AddTransient

//Single Responsibility
//Open Closed
//Liskov subs.
//Interface segre.
//Dependency Inversion = Bağımlılıklar arasındaki konfor.

public class BookService : IBookService
{

    private readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }
    
    //Ekleme işi yaparken kitap adı minimum 2 karakterli olmalıdır
    //Price ve stock propertyleri - değer alamaz


    public void Add(Book book)
    {
        //Validasyon kurallarından geçmeyen kitabı listeye eklemicez.
        try
        {
            AddRules(book);
            _bookRepository.Add(book);
            GetList();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        


    }

    public void Delete(int id)
    {
        try
        {
            _bookRepository.Delete(id);
            GetList();
        }
        catch (BookNotFoundException ex)
        {

            Console.WriteLine(ex.Message);
        }


    }

    public void GetById(int id)
    {
        try
        {
            Book? book = _bookRepository.GetById(id);
            Console.WriteLine(book);
        }
        catch (BookNotFoundException ex)
        {

            Console.WriteLine(ex.Message);
        }


    }

    public void GetList()
    {
        List<Book> books = _bookRepository.GetAll();
        books.ForEach(book => Console.WriteLine(book));
    }

    private void AddRules(Book book)
    {
        if (book.Title.Length < 2)
        {
            throw new BookTitleException(book.Title);
        }

        if (book.Price < 0 || book.Stock < 0)
        {
            throw new BookPriceAndStockException(book.Price, book.Stock);
        }
    }


}
