//Console.WriteLine("Hello, World!");
//Topla(2,6);
//KisiBilgiYazdir("Göktuğ", "Yamak", 25);
//KisiBilgiYazdir(surname: "Doğan", age: 25, name: "Ahmet");
////Methodlar

//void Topla(int sayi1, int sayi2)
//{

//Console.WriteLine(sayi1+sayi2);
//}

//void KisiBilgiYazdir(string name,string surname, int age)
//{
//Console.WriteLine($"Kişinin adı {name}, Kişinin soyadı: {surname}, Kişinin Yaşı: {age}");
//}


#region Switch-Case ile hesap makinesi uygulaması
//Bir hesap makinesi uygulaması yapalım switch-case kullanarak
//Kullanıcıdan ilk başta 1.sayıyı sonrasında operatörlerden birini almak(string), sonrasında 2.sayıyı alıp sonucu yazdırmak
//Toplama(a,b), Cikarma(a,b), Carpma(a,b), Bolme(a,b)


//Console.WriteLine("1.sayı giriniz");
//double sayi1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("işlem giriniz:");
//string islem = Console.ReadLine();
//Console.WriteLine("2.Sayıyı giriniz");
//double sayi2 = Convert.ToDouble(Console.ReadLine());

//switch (islem)
//{
//	case "+":
//		Topla(sayi1,sayi2);
//        break;
//    case "-":
//        Cikarma(sayi1,sayi2);
//        break;
//    case "*":
//        Carpma(sayi1 ,sayi2);
//        break;
//    case "/":
//        Bolme(sayi1 ,sayi2);
//        break;
//	default:
//        Console.WriteLine("Yanlış işlem yaptınız");
//		break;
//}


//void Topla(double sayi1,double sayi2)
//{
//    Console.WriteLine(sayi1+sayi2);
//}

//void Carpma(double sayi1,double sayi2)
//{
//    Console.WriteLine(sayi1*sayi2);
//}

//void Cikarma(double sayi1,double sayi2)
//{
//    Console.WriteLine(sayi1-sayi2);
//}

//void Bolme(double sayi1,double sayi2)
//{
//    Console.WriteLine(sayi1/sayi2);
//}

#endregion

#region İvme ve Kütleyi kullanarak cismin kuvvetini hesaplayan method

//İvmeyi ve kütleyi alarak cismin kuvvetini hesaplayan metodu yazalım

//var sonuc = Kuvvet(m:4, a:5);
//Console.WriteLine(sonuc);
//double Kuvvet(double m,double a)
//{
//    return m * a;
//}

#endregion

#region Girilen parametrenin faktöriyelini alan method

//Girilen parametrenin faktöriyelini alan method yazalım

//var faktoriyelSonuc = Faktoriyel1(5);
//Console.WriteLine(Faktoriyel1(5));


//int Faktoriyel1(int sayi)
//{
//    int sonuc = 1;
//    for (int i = 1;  i <= sayi ;  i++)
//    {
//        sonuc *= i;
//    }
//    return sonuc;
//}

//int Faktoriyel2(int sayi)
//{
//    if (sayi == 1)
//        return 1;

//    return sayi * Faktoriyel2(sayi-1);
//}

#endregion

#region Girilen parametredeki metni ter çeviren method
//girilen parametredeki metni ters çeviren metod

//Console.WriteLine(ReverseMetin("TechCareer Bootcamp 2.gün"));

//int[] sayilar = { 10, 20, 30, 40, 21, 25, 66, 88, 101 };
//Console.WriteLine($"Sayılar dizisinin en büyük sayısı: {EnBuyukSayi(sayilar)}");


//string ReverseMetin(string metin)
//{
//    char[] chars = metin.ToCharArray();
//    Array.Reverse(chars);
//    return new string(chars);
//}

//int EnBuyukSayi(int[] sayilar)
//{
//    int enBuyuk = sayilar[0];
//    for (int i = 0; i < sayilar.Length; i++)
//    {
//        if (sayilar[i] > enBuyuk)
//        {
//            enBuyuk = sayilar[i];
//        }

//    }
//    return enBuyuk;
//}

#endregion

#region Params Keyword


//Console.WriteLine(ToplaCoklu(1,2,3,4,5,6));
//Console.WriteLine(ToplaCoklu(-1, -2, -3, -4));
//Console.WriteLine(EnBuyukSayiCoklu(1,23,21,44,55,162,87,123,66,23));
////Sınırsız sayıda parametre almayı sağlar 
//int ToplaCoklu(params int[] sayilar)
//{
//    int sum = 0;
//    foreach (var sayi in sayilar)
//    {
//        sum += sayi;
//    }
//    return sum;
//}

//int EnBuyukSayiCoklu(params int[] sayilar)
//{
//    int enBuyuk = sayilar[0];
//    for (int i = 0; i < sayilar.Length; i++)
//    {
//        if (sayilar[i] > enBuyuk)
//        {
//            enBuyuk = sayilar[i];
//        }

//    }
//    return enBuyuk;
//}




#endregion

#region out keyword

//out keywordü eğer birden fazla return işlemi yapacaksak eğer out keywordu kullanırız. parametre kısmında başına out koyarız
//ve fonksiyonu çağırırken out yazdığımız parametreleri dışarda oluşturduğumuz değişkenlere atarız
//int bolmeIslemiBolum;
//int bolmeIslemiKalan;

//BolmeIslemi(15, 10, out bolmeIslemiBolum, out bolmeIslemiKalan);
//Console.WriteLine($"Bölme işleminin bölümü : {bolmeIslemiBolum}, Kalanı  : {bolmeIslemiKalan}");
//void BolmeIslemi(int bolunen, int bolen,out int bolum, out int kalan)
//{
//    bolum = bolunen / bolen;
//    kalan = bolunen % bolen;
//}

#endregion

#region Üslü ifadeleri toplamayla hesaplama işlemi
//Console.WriteLine("Taban : ");
//int taban = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Üs = ");
//int us = Convert.ToInt32(Console.ReadLine());
//int toplam = 0;

//if (us == 0)
//{
//    Console.WriteLine("1");
//}
//else if (us == 1)
//{
//    Console.WriteLine(taban);
//} else if (us < 0 || taban < 0)
//{
//    Console.WriteLine("Üs veya Taban negatif değer alamaz");
//}
//else
//{
//    int result = taban;
//    for (int i = 1; i < us; i++)
//    {
//        toplam = 0;
//        for (int j = 0; j < taban; j++)
//        {
//            toplam += result;
//        }


//        result = toplam;
//    }

//    Console.WriteLine(toplam);
//}

#endregion