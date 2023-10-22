// Person adında bir class oluşturulur ve gerekli işlemler yapılır
//Oluşturulan nesnelerin ekrana basılması

//classlar referans tiplidir
//referans tipler oluşturulurken new anahtar sözcüğü ile oluşturulur.

using Day2_OOP;
//1.Yöntem
//Person person = new Person();
//person.name = "Hasan";
//person.age = 25;
//person.surname = "Yılmaz";
//person.phone = "05123124512324";

//Console.WriteLine(person);

////2.Yöntem
//Person person1 = new Person();
//person1.name = "Ahmet";
//person1.age = 17;
//person1.surname = "Şahin";
//person1.phone = " ";

//Person.Add(person1); //Static olunca nesne oluşturmadan direkt class üstünden çağırabiliyoruz

////3.Yöntem
//var person2 = new Person(25,"Evren","Çakar","0534102567894");
//Console.WriteLine(person2);


////Record -> immutable data classlardır. Const ile aynı anlamdadır değiştirilemez anlamını taşır.
////Struct -> yapı olarak karşımıza gelir
//Product product = new Product(Name: "Deneme", Description: "Test", Price: 25);

//Console.WriteLine(product);

Book book;
book.Adi = "Abasıyanık";
book.Yazar = "Sait Faik";
book.SayfaSayisi = 125;

Console.WriteLine(book);

//**************STRUCT*****************
//Struct -> Değer tipindedir,
//bellekte stack hafızada tutulur,
//değer tipinde olduğu için new yapmak gerekmez,
//Büyük veri setleri için değildir
//structlar bir classtan miras alamazlar sadece interfaceden miras alabilirler.

//*************RECORD*******************
//.Net5 ve C# 9 ile gelmiştir.
//Temel amacı veriyi saklamaktır.
//Genellikle veri taşıyıcıları da denir.
// İmmutable classlardır.

//****************