// See https://aka.ms/new-console-template for more information
using CommonLayer;
using StaticClass;
using System.Numerics;
using System.Text.Json;


#region StaticClass


Console.WriteLine("Hello, World!");

// Uygulama ayağa kalktığı süre boyunca tek bir instance ile çalışır
// Uygulama çokça kullanılan methodları yada const değerleri kapsüllemek amaçlı kullanıyoruz.

Logger.LogError("Error");
Logger.LogInfo("Info");
//Logger.minimumLogLevel = 5;

string completed = OrderStatusTypes.Completed;


// Session gibi kullanıcı bazlı, oturum bazlı bir veri tutma işleminde static sınıflar sorun çıkartabilir.

// Application State, yani uygulama genelini ilgilendiren bir durum söz konusu ise böyle bir durum için kullanılabilir.

var test = new TestService();
test.DisplayGuestCount();

GuestCounter.ActiveGuestCount += 1;
GuestCounter.ActiveGuestCount += 1;
GuestCounter.ActiveGuestCount += 1;

GuestCounter.ActiveGuestCount -= 1;

test.DisplayGuestCount();



//Console.WriteLine("Ziyaretçi Sayısını Oku");
//ConsoleKeyInfo info = Console.ReadKey();

//if(info.Key == ConsoleKey.Y)
//{
//  test.DisplayGuestCount();
//}



#endregion


#region ExtensionClass


Person p = new Person();
p.FirstName = "Ali";
p.LastName = "Tan";

Console.WriteLine(p.GetFullName());
// memCache 
// Bir interfaceden implemente olan tüm sınıflara bir extension method ile bir davranış kazandırdık.

var memCache = new MemCache();
memCache.ClearCache();

var redisCache = new RedisCache();
redisCache.ClearCache();




#endregion


#region Serialization

var p2 = new Person();
p2.FirstName = "Ahmet";
p2.LastName = "Can";


var serializeOptions = new JsonSerializerOptions
{
  WriteIndented = true,
  IncludeFields = true,
  IgnoreReadOnlyFields = false,
  NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.WriteAsString,
  DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
  PropertyNameCaseInsensitive = true,
  PropertyNamingPolicy = JsonNamingPolicy.CamelCase
};


var jsonString = JsonSerializer.Serialize(p2, serializeOptions);
// jsonString

// deserize ederken serialize ederken ki ayarları uygulamayı unutmalayalım.
var p3 = JsonSerializer.Deserialize<Person>(jsonString, serializeOptions);




#endregion


Console.ReadKey();