using Day3_Static;

//Calculator calculator = new Calculator();


//Console.WriteLine("1.Sayıyı giriniz");
//int sayi1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("2.Sayıyı giriniz");
//int sayi2 = Convert.ToInt32(Console.ReadLine());

//calculator.Toplama(sayi1, sayi2);
//calculator.Carpma(sayi1, sayi2);
//calculator.Cikarma(sayi1, sayi2);
//calculator.Bolme(sayi1, sayi2);

//Statik metodlar newlemeden çalışırlar ancak proje çalıştığı anda bellekte yer tutacağı için her yerde kullanmak mantıklı değildir

//CalculatorStatik.Toplama(sayi1, sayi2);
//CalculatorStatik.Carpma(sayi1, sayi2);
//CalculatorStatik.Cikarma(sayi1, sayi2);
//CalculatorStatik.Bolme(sayi1, sayi2);

//Bir sisteme kayıt olduğumuzda veri tabanında parolalarımız nasıl görünür

byte[] passwordHash;
byte[] passwordSalt;
Console.WriteLine("Lütfen şifre giriniz.");
string password = Console.ReadLine();

SecurityHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
Console.WriteLine($"Şifreniz : {password}");
Console.WriteLine("Şifrenizin hashi :");

foreach (var hash in passwordHash)
{
    Console.Write(hash);
}

Console.WriteLine();

Console.WriteLine("Şifreniz : ");

foreach (var hash in passwordSalt)
{
    Console.Write(hash);
}