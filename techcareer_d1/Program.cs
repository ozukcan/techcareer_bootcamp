#region STRING ISLEMLERI

//Console.WriteLine("Bootcampin ilk günü");
//Console.WriteLine(1+45);

//Console.WriteLine("1.sayıyı giriniz");
//int sayi1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("2.sayıyı giriniz");
//int sayi2 = Convert.ToInt32(Console.ReadLine());
//int toplam = sayi1 + sayi2;

//String interpolation
//Console.WriteLine($"2sayının Toplamı: {sayi1} + {sayi2} = {toplam}");

//string ad = "Hüseyin";
//string soyad = "Özükcan";

//string tamIsim = ad + " " + soyad;

//.ToUpper()  Tüm harfleri büyük harf yapar
//.ToLower()  Tüm harfleri küçük harf yapar
//.Contains() İçinde bulundurma durumuna bakar

//Console.WriteLine(tamIsim.Contains("A"));

#endregion 

#region ONDALIK SAYILAR ve BOOL
//double ondalik1 = 10.5;
//double ondalik2 = 10.7;

//Console.WriteLine(ondalik1 + ondalik2);

//double a = 25;
//double b = 10;

//Console.WriteLine(a/b);

//bool veri tipi
//Karşılaştırma operatörleri
//Console.WriteLine($"{ondalik1} ve {ondalik2} sayıları eşit midir = {ondalik1 == ondalik2}");
//Console.WriteLine($"{ondalik1} ve {ondalik2} sayıları eşit değil midir = {ondalik1 != ondalik2}");
//Console.WriteLine($"{ondalik1} , {ondalik2} sayısından büyük müdür = {ondalik1 > ondalik2}");
//Console.WriteLine($"{ondalik1} , {ondalik2} sayısından küçük müdür = {ondalik1 < ondalik2}");
//Console.WriteLine($"{ondalik1} , {ondalik2} sayısından büyük eşit midir = {ondalik1 >= ondalik2}");
//Console.WriteLine($"{ondalik1} , {ondalik2} sayısından  midir = {ondalik1 <= ondalik2}");

#endregion


#region Konsoldan girdi alınarak ehliyet alınabilirlik durumu kontrolünün yapılması
//Konsoldan girdi alınacak ve girilen yaş 18'in altındaysa ehliyet alamaz 18 yaşından büyük eşit ise ehliyet alabilir

//Console.WriteLine("Lütfen yaşınızı giriniz");
//int age = Convert.ToInt32(Console.ReadLine());

//if (age >= 18)
//{
//    Console.WriteLine("Ehliyet alabilir");
//}
//else
//{
//    Console.WriteLine("Ehliyet alamaz");
//}

//#endregion

//#region if else ile not harflendirmesi
////if else ile not harflendirmesi

//Console.WriteLine("Notunuzu giriniz");
//double not = Convert.ToDouble(Console.ReadLine());
//if (not >= 50 && not < 60)
//{
//    Console.WriteLine("Not Harfiniz : D");
//}
//else if (not >= 60 && not < 70)
//{
//    Console.WriteLine("Not Harfiniz : C");
//}
//else if (not >= 70 && not < 80)
//{
//    Console.WriteLine("Not Harfiniz : B");
//}
//else if (not >=80 && not <= 90)
//{
//    Console.WriteLine("Not Harfiniz : A");
//}
//else if (not > 90 && not <= 100)
//{
//    Console.WriteLine("Not Harfiniz : S+");
//}
//else
//{
//    Console.WriteLine("Yanlış not girdiniz");
//}
#endregion


#region Switch-Case yapısı

//Kullanıcıdan 1-7'ye kadar sayı alınır ve hangi güne denk geliyorsa o günün adı ekrana bastırılır

//Console.WriteLine("1-7 arası bir sayı giriniz");
//int dayOfWeek = Convert.ToInt32(Console.ReadLine());

//switch (dayOfWeek)
//{
//    case 1:
//        Console.WriteLine("Pazartesi");
//        break;
//    case 2:
//        Console.WriteLine("Salı");
//        break;
//    case 3:
//        Console.WriteLine("Çarşamba");
//        break;
//    case 4:
//        Console.WriteLine("Perşembe");
//        break;
//    case 5:
//        Console.WriteLine("Cuma");
//        break;
//    case 6:
//        Console.WriteLine("Cumartesi");
//        break;
//    case 7:
//        Console.WriteLine("Pazar");
//        break;
//    default:
//        Console.WriteLine("Yazdığınız sayı 1-7 arasında değildir");
//        break;
//}
#endregion

#region Switch Case 2.yöntem

//string name = dayOfWeek switch
//{
//    1 => "Pazartesi",
//    2 => "Salı",
//    3 => "Çarşamba",
//    4 => "Perşembe",
//    5 => "Cuma",
//    6 => "Cumartesi",
//    7 => "Pazar",
//    _=> "Geçersiz karakter girildi."
//};

//Console.WriteLine(name);
#endregion

#region Döngüler

//Döngüler
//ilk 9 sayıyı ekrana bastıran kod
// 1 2 3 4 5 6 7 8 9
//for (int i=1; i<=9; i+=2)
//{
//    Console.WriteLine(i);
//}

// 1'den 20'ye kadar olan tüm çift sayıları yazdır
//for (int i = 1; i <= 20; i ++)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}

////2.yöntem
//for (int i = 2; i <= 20; i+=2)
//{
//    Console.WriteLine(i);
//}

#endregion

#region Arrayler ve Foreach
//Arrayler

string[] sehirler = { "Ankara", "İzmir", "Aydın", "Bursa", "İstanbul","Elazığ"};

//for (int i = 0; i < sehirler.Length; i++)
//{
//    Console.WriteLine(sehirler[i]);
//}

//Şehirler dizisinden ismi içerisinde "r" olan şehirleri ekrana yazdırsın
//Şehirler dizisinden A ile başlayan şehirleri ekrana bastırın
//Sonu a ile biten şehirleri ekrana bastırın

//Console.WriteLine("Şehirler dizisinden ismi içerisinde 'r' olan şehirleri ekrana yazdırsın");
//foreach (string sehir in sehirler)
//{
//    if (sehir.Contains("r"))
//    {
//        Console.WriteLine(sehir);
//    }
//}

//Console.WriteLine("Şehirler dizisinden A ile başlayan şehirleri ekrana bastırın");
//foreach (string sehir in sehirler)
//{
//    if (sehir.StartsWith("A"))
//    {
//        Console.WriteLine(sehir);
//    } 
//}

//Console.WriteLine("Sonu a ile biten şehirleri ekrana bastırın");
//foreach (var sehir in sehirler)
//{
//    if (sehir.EndsWith("a") )
//    {
//        Console.WriteLine(sehir);
//    }
//}


//foreach (string sehir in sehirler)
//{
//    Console.WriteLine(sehir);
//}
#endregion

#region While Döngüsü

Console.WriteLine("Şehirleri while döngüsü ile bastırma");
int i = 0;
while (i < sehirler.Length)
{
    Console.WriteLine(sehirler[i]);
    i++;
}

#endregion 