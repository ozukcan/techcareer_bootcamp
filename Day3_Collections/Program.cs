

//List yapısı
//Listeler referans tiplidir

using System.Threading.Channels;

//List<int> numbers = new List<int>() {1,2,3,4,5,6,7,8,9,10};
//numbers.Add(11);
//numbers.Add(10);
//numbers.AddRange(new int[] {25,27,26,30});

////Listeleri göstermenin ilk yöntemi
////foreach (var number in numbers)
////{
////    Console.WriteLine(number);
////}

////2.yöntem
////numbers.ForEach(number => Console.WriteLine(number));
//Console.WriteLine($"numbers listesi içerisinde 30 varmı? : {numbers.Contains(30)}");
//Console.WriteLine($"numbers listesi içinde 30'un indexi nedir? : {numbers.IndexOf(30)}");
//Console.WriteLine($"numbers listesi kaç elemanlıdır? : {numbers.Count}");

//// iki tane listemiz olacak, numbers listesi içindeki tek ve çift sayıları ayıracak ve bunları ekrana yazacak

//List<int> evenNumbers = new List<int>(); //çift
//List<int> oddNumbers = new List<int>(); //tek

////foreach (var x in numbers)
////{
////    if (x % 2 == 0)
////    {
////        evenNumbers.Add(x);
////    }
////    else
////    {
////        oddNumbers.Add(x);
////    }
////}

////2.yöntem
//evenNumbers = numbers.FindAll(x => x % 2 == 0);
//oddNumbers = numbers.FindAll(x=>x % 2 == 1);

////3.yöntem
////evenNumbers = numbers.Where(x => x % 2 == 0).ToList();
////oddNumbers = numbers.Where(x => x % 2 == 1).ToList();

//Console.WriteLine("Çift sayılar : ");
//evenNumbers.ForEach(number => Console.WriteLine(number));
//Console.WriteLine("Tek sayılar : ");
//oddNumbers.ForEach(number => Console.WriteLine(number));

//HashSet<int> hashNumbers = new HashSet<int>() { 1,2,3,4,4,4,5,5,5,6,5,6,2,1};
//foreach (var x in hashNumbers)
//{
//    Console.WriteLine(x);
//}

//hashNumbers.Clear();

//Dictionary Key -> Value
Dictionary<string,int> meyveler = new Dictionary<string,int>();

meyveler.Add("Elma",12);
meyveler.Add("Armut", 15);
meyveler.Add("Üzüm", 25);
meyveler.Add("Karpuz", 30);

meyveler["Üzüm"] = 20;
Console.WriteLine($"Üzüm fiyatı : {meyveler["Üzüm"]}");
//Eleman kontrolü Contains

if (meyveler.ContainsKey("Karpuz"))
{
    Console.WriteLine($"Karpuz fiyatı : {meyveler["Karpuz"]}");
}
else
{
    Console.WriteLine("Karpuz mevcut değil");
}


//Her bir elemanı gezmek için keyvaluepair veya var türünde bir değişkenle gezmemiz gerekiyor.
foreach (KeyValuePair<string,int> meyve in meyveler)
{
    Console.WriteLine($"Meyve adı : {meyve.Key}, Fiyatı : {meyve.Value}");
}

//Eleman silme işlemi

meyveler.Remove("Karpuz");

foreach (var meyve in meyveler)
{
    Console.WriteLine($"Meyve adı : {meyve.Key}, Fiyatı : {meyve.Value}");
}

var Keys = meyveler.Keys;
foreach (var key in Keys)
{
    Console.WriteLine(key);
}

var Values = meyveler.Values;
foreach (var value in Values)
{
    Console.WriteLine(value);
}

//Stack nedir Queue nedir