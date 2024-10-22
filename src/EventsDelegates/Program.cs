
using EventsDelegates;

delegate void SendMessageHandler(string message);
public class Program
{

  public static void Main(string[] args)
  {
    // 1.Örnek Kullanım
    var del = new SendMessageHandler(SendSms);
    del += SendEmail; // Multi cast delegate
    del("Mesaj Gönderilidi");

    // 2. Örnek Kullanım
    // Lambda Expression Action delegate
    // Void bir işlem yapmak için Action tipi kullanılabilir.
    Action<string> lambdaDelegate = message =>
    {
      Console.WriteLine(message);

    };

    lambdaDelegate("Mesaj");
    ActionDelegateSample("mesaj1", lambdaDelegate);

    // Lambda Func delegate
    List<int> numbers = [10, 12, 13, 24, 45, 38];
    //List<int> evenNums = new();
    //numbers.ForEach(item =>
    //{
    //  if(item % 2 == 0)
    //  {
    //    evenNums.Add(item);
    //  }

    //});

    // 3.Örnek Kullanım

    // result döndürme işlemlerinde ise Func tipini kullanırız.
    Func<int, bool> isEven = n =>
    {
      return n % 2 == 0;
    }; // koleskiyon içerisindeki çift sayıları function delegate ile bulma.

    List<int> evenNumbers = numbers.FindAll(new Predicate<int>(isEven));


    // 4.Örnek Nesne içindeki eventi tetikleme

    Product p = new Product();
    p.Price = 15;
    p.ChangePrice(newPrice:25); // eylem action 


    // 5. Örnek

    ProductService ps = new();
    ps.Save();

  }

  private static void P2_PriceChanged(PriceChangeArgs args)
  {
    Console.WriteLine(args.NewPrice);
  }

  public static void ActionDelegateSample(string message, Action<string> action)
  {
    Console.WriteLine(message);
    action(message); // Invoke işlemi
  }

  public static void SendSms(string message)
  {
    Console.WriteLine(message);
  }

  public static void SendEmail(string message)
  {
    Console.WriteLine(message);
  }

}








