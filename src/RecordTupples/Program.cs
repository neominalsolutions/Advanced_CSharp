// See https://aka.ms/new-console-template for more information
using RecordTupples;



#region Records


Console.WriteLine("Hello, World!");

// Class dışında DTO için yada ValueObject tipleri yaygın kullanılan, bir referance type. Record, DTO olan tüm Request Nesneleri API uygulamalarında Record ile tanımlanıyor.

// Class tipler Mutable çalışır
// Record tipleri Immutable çalışır.

// Değer eşitlik durumlarda da tercih ediliyor.

var money1 = new Money(amount: 1000, currency: "TL");
money1.Y = "Y";

var money2 = new Money(amount: 1000, currency: "$");
var money3 = new Money(amount: 1000, currency: "TL");


var location = new Location(z:34);
// location.Z = 45;
location.X = 45;
location.Y = 85;


Console.WriteLine("senaryo1" + money1.Equals(money2)); // Değer olarak eşit mi false

Console.WriteLine("senaryo2" + money1.Equals(money3));

// Immutable çalıştığı için değer set edilemez.
// money3.currency = "$";

// MoneyClass üzerinden equals operatör kullanımı

var money4 = new MoneyClass(y:58); // Heap
money4.Amount = 500;
money4.Currency = "TL";



var money5Copy = money4.Copy(); // Memberwise Clone ile oluşturulduğundan heap deki referansı koparır ama değer kaybına yol açmaz.
//var money5Copy = money4;

money4.Amount = 600;

Console.WriteLine(money5Copy.Amount);


Console.WriteLine("Copy" + money4.Equals(money5Copy)); // False


var money5 = new MoneyClass(y:58); // Heap
money5.Amount = 500;
money5.Currency = "TL";

Console.WriteLine("Test" + money4.Equals(money5)); // False

#endregion

#region Tupples

// veri demeti, anlık bir veri tipine ihtiyaç olursa, Tupple içerisine konulan nesneler program tarafında tekrar kullanılmayacak ise mantıklı.

// MVC de view birden fazla model göndermek için mantıklı

// 1.Yöntem

var t1 = Tuple.Create<int, string, bool>(1,"a",true);
var t2 = Tuple.Create<Money, Location>(new Money(100,"TL"),new Location(z:500));

// 2. Yöntem

var person = ("Ali", "Tan", 27); // contruct işlemi

string firstname = person.Item1;

// 3. Yöntem

var p3 = GetPerson("Ali", "Can", 78);

Console.WriteLine(p3.firstname);

static (string firstname,string lastname,int age) GetPerson(string firstname, string lastname, int age)
{
  return (firstname, lastname, age);
}


#endregion

