using Day4_BookProject.Exceptions;
using Day4_BookProject.Models;
namespace Day4_BookProject.Data;


public class BookRepository : IBookRepository
{
    private readonly List<Book> _bookData; //readonly - const farkı const 1 kez tanımlanır, readonly sadece constructor içinde tanımlanır.

    public BookRepository() //constructor
    {
        _bookData = new List<Book>()
        {
            new Book{Id= 1, Description = "Güzel bir kitap", Price = 250, Stock = 2500, Title="Sherlock Holmes" },
            new Book{Id= 2, Description = "Güzel bir kitap", Price = 120, Stock = 500, Title="Arsen Lüpen" },
            new Book{Id= 3, Description = "Güzel bir kitap", Price = 300, Stock = 100, Title="Nutuk"}
        };
    }

    public void Add(Book book)
    {
        _bookData.Add(book);
    }

    public void Delete(int id)
    {
        Book? book = _bookData.Where(x=>x.Id == id).SingleOrDefault(); //IEnumerable = sıralanabilir koleksiyon,
        if (book is null)
        {
            throw new BookNotFoundException(id);
        }

        _bookData.Remove(book);

    }

    public List<Book> GetAll()
    {
        return _bookData;
    }

    public Book GetById(int id)
    {
        var book = _bookData.SingleOrDefault(x => x.Id == id);

        if (book == null)
        {
            throw new BookNotFoundException(id);
        }

        return book;
    }
}
