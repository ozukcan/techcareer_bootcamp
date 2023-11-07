namespace Day2_OOP;

internal class Person
{

    //Constructor ilk çalışmasını istediğimiz kod bloğudur.
    //cotr kısayolu ile oluşturulur
    //iki tane oluşturma sebebimiz aldığımız kayıtların zorunlulukları varsa 
    public Person(/* Email,şifre */) // iki adet  
    {
        
    }
    public Person(int age,string name, string surname, string phone)
    {   //this ile burdaki parametreleri classta tanımladığımız değerlere eşitliyoruz
        this.age = age;
        this.name = name;
        this.surname = surname;
        this.phone = phone;
    }

    public int age;
    public string name;
    public string surname;
    internal string phone; //internal bu proje içinde kullanılmasına izin verir, protected sadece miras alanların kullanmasına izin verir


    public override string ToString() //override ile ToString metodunu ezerek adres yerine bizim verdiğimiz değerleri getirmesini sağlıyoruz
    {
        return $"Kişi adı: {name}, kişi soyadı: {surname}, kişi yaşı: {age}, kişinin telefonu: {phone}";
    }

    //Kişinin adı minimum 2 karakterli olmalıdır
    //Kişinin yaşı 18'den küçük olmamalıdır.
    //Kişinin telefon numarası boş olmamalıdır.
    public static void Add(Person person) //Static olunca nesne oluşturmadan direkt class üstünden çağırabiliyoruz
    {
        if (person.name.Length < 2)
        {
            Console.WriteLine("Kişinin adı minimum 2 karakterli olmalıdır");
        }
        if (person.age < 18)
        {
            Console.WriteLine("Kişinin yaşı 18'den küçük olmamalıdır.");
        }
        if (string.IsNullOrWhiteSpace(person.phone))
        {
            Console.WriteLine("Kişinin telefon numarası boş olmamalıdır");
        }
        else if(person.name.Length > 2 && person.age > 18 && person.phone != null)
        {
            Console.WriteLine("Kişi başarıyla oluşturuldu");
        }

    }


}
