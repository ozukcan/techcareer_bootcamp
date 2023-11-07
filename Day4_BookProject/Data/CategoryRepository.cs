using Day4_BookProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_BookProject.Data
{
    internal class CategoryRepository : ICategoryRepository
    {
        private readonly List<Category> _categories;
        public void Add(Category category)
        {
            _categories = new List<Category>() 
            {
            new Category { Id = "A", Name = "Polisiye" },
            new Category { Id = "B", Name = "Tarih" },
            new Category { Id = "C", Name = "Dram" }


            };
        }

        public void Delete(string id)
        {
            Category? category = _categories.SingleOrDefault(c => c.Id == id);
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category? GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
