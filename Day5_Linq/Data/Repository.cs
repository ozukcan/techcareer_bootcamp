using Day5_Linq.Models;


namespace Day5_Linq.Data;

internal class Repository
{
    public static List<Product> Products { get; set; } = new List<Product>()
    {
        new Product { Id = 1,CategoryId=1,Name ="MSI Laptop", Price=35000,Stock=2000},
        new Product { Id = 2,CategoryId=1,Name ="Monster Laptop", Price=25000,Stock=2500},
        new Product { Id = 3,CategoryId=1,Name ="Asus Laptop", Price=55000,Stock=1000},
        new Product { Id = 4,CategoryId=2,Name ="Samsung Telefon", Price=22000,Stock=6500},
        new Product { Id = 5,CategoryId=2,Name ="Apple Telefon", Price=75000,Stock=200},
        new Product { Id = 6,CategoryId=2,Name ="Oppo Telefon", Price=15000,Stock=1000},

    };

    public static List<Category> Categories { get; set; } = new List<Category>
    {
        new Category { Id = 1,Name="Bilgisayar"},
        new Category { Id = 2,Name="Telefon"}
    };
}
