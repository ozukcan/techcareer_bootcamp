using System;

namespace Day3_Inheritance.Managers;

public class CategoryService : ICrudService
{
    public void Add()
    {
        Console.WriteLine("Kategori Eklendi");
    }

    public void Delete()
    {
        Console.WriteLine("Kategori Silindi");
    }

    public void GetAll()
    {
        Console.WriteLine("Kategoriler Listelendi");
    }

    public void Update()
    {
        Console.WriteLine("Kategori Güncellendi");
    }
}
