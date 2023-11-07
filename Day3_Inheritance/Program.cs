//Product ve Category diye 2 adet veritabanı tablomuzun olduğunu düşünelim bu tablolar arasında basit crud operasyonları yapalım
//Create - Read - Update - Delete

using Day3_Inheritance;
using Day3_Inheritance.Managers;

//Interfaceler sözleşmedir
//Interfaceler soyut classlardır yani new anahtar sözcülüğü ile nesnesi üretilemez

//Category category = new Category()
//{
//    Id = 1,
//    CategoryName = "Bilgisayar",
//    CreatedBy = "Bülent Korkmaz",
//    CreatedDate = "2023"
//};

//Product product = new Product()
//{
//    Id = 2,
//    CreatedBy = "Bülent Korkmaz",
//    CreatedDate = "2023",
//    Name = "MSI",
//    Price = 1200
//};

//Console.WriteLine(category);
//Console.WriteLine(product);

ICrudService crudService = new ProductService();
crudService.Add();
crudService.Delete();
crudService.Update();
crudService.GetAll();