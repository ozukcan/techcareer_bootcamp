using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Inheritance.Managers;

internal class ProductService : ICrudService
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
