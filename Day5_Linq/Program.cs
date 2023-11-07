using Day5_Linq.Data;
using Day5_Linq.Models;
using System.Threading.Channels;

var products = Repository.Products;
var categories = Repository.Categories;


#region Tüm ürünlerden categoryId si 1 olan ürünleri listeleyin

//      1.YÖNTEM
//foreach (var product in products)
//{
//    if (product.CategoryId == 1)
//    {
//        Console.WriteLine(product);
//    }
//}


//      2.YÖNTEM
//var prodList = from p in products where p.CategoryId == 1 select p;

//foreach (var p in prodList )
//{
//    Console.WriteLine(p);
//}



//      3.Yöntem
//products.Where(p=> p.CategoryId == 1).ToList().ForEach(p => Console.WriteLine(p));

#endregion

#region Tüm ürünlerden içerisinde app geçen ürünleri listeleyin

//      1.YÖNTEM
//foreach (var p in products)
//{
//    if (p.Name.Contains("App"))
//    {
//        Console.WriteLine(p);
//    }
//}

//      2.YÖNTEM
//var pList = from p in products where p.Name.Contains("App") select p;
//foreach (var p in pList)
//{
//    Console.WriteLine(p);
//}

//      3.YÖNTEM
//products.Where(p => p.Name.Contains("App")).ToList().ForEach(p => Console.Write(p));
#endregion

#region Ürünlerin fiyatlarının toplamı olan kodu yaz


//      1.YÖNTEM
//double total = 0;
//foreach (var p in products)
//{
//    total += p.Price;
//}

//Console.WriteLine("Tüm ürünlerin toplamı : " + total);

//      2.YÖNTEM,

//var total = products.Sum(x=> x.Price);
//Console.WriteLine($"Tüm ürünlerin fiyat toplamı : {total}");

#endregion

//TODO : CategoryID 2 olan ürünlerin Price toplamlarını bulunuz

//var total = products.Where(p => p.CategoryId == 2).Sum(p => p.Price);
//Console.WriteLine("Ürün toplamı = " + total);

//TODO: tüm ürünlerin fiyat ortalamasını alan kodu yazınız

//var average = products.Average(p => p.Price);

//Console.WriteLine($"Tüm ürünlerin fiyat ortalaması :{average}");

// TODO : Category id'si 3 olan ürün var mı

//var productIsPresent = products.Any(x => x.CategoryId == 2);
//Console.WriteLine($"CategoryId'si 3 olan ürün var mı? : {productIsPresent}");

// TODO : Ürünün id'si 1 olan ürünün değerlerini ekrana basın

//var product = products.SingleOrDefault(x => x.Id == 1);
//Console.WriteLine(product);

// TODO : Tüm ürünlerin sadece isimlerini ekrana bastırınız

//products.Select(x => x.Name).ToList().ForEach(p => Console.WriteLine(p));

// TODO : Tüm ürünlerin stok ve price değerlerini ekrana bastıran kodu yazınız

//var list = products.Select(x => new { isim = x.Name, stok = x.Stock, fiyat = x.Price }).ToList();
//foreach (var item in list)
//{
//    Console.WriteLine($"isim : {item.isim}, stok = {item.stok}, price ={item.fiyat}");
//}

//      2.YÖNTEM

//var list = from p in products select new {isim = p.Name, stok = p.Stock, price = p.Price};

//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}

//TODO : Kategori ID'lerine göre ürünleri gruplama

//var grouppedProducts = products.GroupBy(x => x.CategoryId).ToDictionary(g => g.Key, g=> g.ToList());

//foreach (var group in grouppedProducts)
//{
//    Console.WriteLine($"{group.Key} CategoryId'sine sahip ürünler");
//    group.Value.ForEach(x => Console.WriteLine(x));
//}

//TODO : Tüm ürünleri fiyatları artacak şekilde sıralayınız.
//products.OrderBy(x => x.Price).ToList().ForEach(p => Console.WriteLine(p));

//TODO : Tüm ürünlerin fiyatını azalan bir şekilde sıralayınız
//products.OrderByDescending(x => x.Price).ToList().ForEach(p => Console.WriteLine(p));

//Productları gez eğer categoryId'si c'nin id'sine eşitse joinle
//var details = from p in products // p products tablosunda bir değişken, c ise categoriesdeki bir değişken
//              join c in categories on p.CategoryId equals c.Id
//              select new ProductDetailDto //bize bir prodDetail nesnesi oluştur ve yakaladığın nesneleri bunlara dönüştür.
//              {
//                  CategoryName = c.Name,
//                  Price = p.Price,
//                  ProductName = p.Name,
//                  Stock = p.Stock
//              };

//foreach (var item in details)
//{
//    Console.WriteLine(item);
//}

//      2.YÖNTEM

//var lambdaJoin = products.Join(categories,
//    p => p.CategoryId,
//    c => c.Id,
//    (product,category) => new ProductDetailDto
//    {
//        CategoryName = category.Name,
//        Price = product.Price,
//        ProductId = product.Id,
//        ProductName = product.Name,
//        Stock = product.Stock,
//    }).ToList();
//lambdaJoin.ForEach(p => Console.WriteLine(p));

// TODO: öyle bir sistem dizayn edin ki product detail listesi dönsün ama Category Id'si 2 olan ürünlerin detay listesi olsun

//var filterLambdaJoin = products
//    .Where(x=> x.CategoryId == 2)
//    .Join(categories, 
//    p => p.CategoryId,
//    c => c.Id,
//    (p,c) => new ProductDetailDto
//    {
//        CategoryName = c.Name,
//        Price = p.Price,
//        ProductId = p.Id,
//        ProductName = p.Name,
//        Stock = p.Stock,
//    }).ToList();

//filterLambdaJoin.ForEach(x => Console.WriteLine(x));

List<int> numbers1 = new List<int>() { 1,2,3,4,5};
List<int> numbers2 = new List<int>() { 4,5,6,7,8 };
List<int> numbers3 = new List<int>() { 1,1,2,2,3,3,10,4,5};

//TODO : iki sayı listesinde ortak sayıları tek liste halinde listeleyelim
//numbers1.Intersect(numbers2).ToList().ForEach(X => Console.WriteLine(X));

// TODO : 1.sayı listesinde bulunup 2.sayı listesinde BULUNMAYAN sayıların listesini yazdıran kod
//numbers1.Except(numbers2).ToList().ForEach(x => Console.WriteLine(x));

// TODO : 1.sayı listesinde bulunup 2.sayı listesinde BULUNMAYAN sayıların üstüne ekleyip yazdır
//numbers1.Except(numbers2).ToList().ForEach(x => numbers2.Add(x));
//numbers2.ForEach(x => Console.WriteLine(x));

// TODO : 1.sayı listesinde bulunan sayıların çarpımını yapınız
//Console.WriteLine(numbers1.Aggregate((a, b) => a * b));

// TODO : Benzersiz sayıların listesini yazınız
//numbers3.Distinct().ToList().ForEach(x => Console.WriteLine(x));

// TODO : 3 sayı listesini tek liste haline getimre
//numbers1.Concat(numbers2).Concat(numbers3).ToList().ForEach(x => Console.Write($"{x}, "));

// TODO : Sayı 2 listesinde en büyük ve en küçük değeri ekrana yazın
//Console.WriteLine($"numbers2 listesinde en küçük sayı : {numbers2.Min()}, en büyük sayı ise {numbers2.Max()}");

// TODO : Sayı 2 listesinde 2'den büyük 3 tane sayı alan yeni liste yazdırınız
//numbers2.Where(x => x > 2).Take(3).ToList().ForEach(x => Console.WriteLine(x));
