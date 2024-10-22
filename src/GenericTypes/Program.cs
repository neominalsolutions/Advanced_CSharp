// See https://aka.ms/new-console-template for more information
using GenericTypes.Samples;
using System.Collections;
using System.Collections.ObjectModel;

Console.WriteLine("Hello, World!");

#region GenericClass

Repository<Product> pRepo = new Repository<Product>();
pRepo.Save(new Product { Id = 1, Name = "P-1", Price = 10, Stock = 20 });

Repository<Category> cRepo = new Repository<Category>();
cRepo.Save(new Category { Id = Guid.NewGuid(), Name = "C-1" });

ProductService<Product, Product> productService = new ProductService<Product, Product>();
var response = productService.Handle(new Product { Id = 1, Name = "P-3", Price = 10, Stock = 10 });

#endregion


#region Collections

// FIFO, LIFO

// LIFO, C# ortamında stack üzerindeki değişkenlerin tutulma ve ramden silinme mantığı, (Kirlik Bulaşıklar)
Stack<int> numbers = new Stack<int>();
numbers.Push(3);
numbers.Push(5);

numbers.Pop();


// FIFO -> RabbitMq ve Kafka Gibi Mesaj kuyruk sistemlerinde kullanılan bir koleksiyon mimarisi
Queue<string> names = new Queue<string>();
names.Enqueue("ali");
names.Enqueue("mustafa");

names.Dequeue();


// List,IEnumerable, Collection

List<int> numbers2 = [1, 2, 3, 45];

numbers2.Add(5);
numbers2.Add(10);

Collection<Product> products = new();
List<Category> categories = new List<Category>();
categories.Add(new Category { Id = Guid.NewGuid(), Name = "Elektronik" });
categories.Add(new Category { Id = Guid.NewGuid(), Name = "Mutfak Gereçleri" });
categories.Add(new Category { Id = Guid.NewGuid(), Name = "Elektrikli Ev Aletleri" });

categories.Clear();

// LINQ Lambda Expression
categories.Where(x => x.Name.StartsWith("E")).ToList();
categories.OrderBy(x => x.Name).ThenByDescending(x => x.Name);
categories.Skip(2).Take(1).ToList();
categories.Find(x => x.Name == "Elektrikli Ev Aletleri");
categories.GroupBy(x => x.Name).ToList();

// HashSet => Aynı referansa veya değere sahip olan item koleksiyon içerisinde tanımlama, Değerlerin hem referans type hemde value Type Uniquelenmesini sağlar.
var hs = new HashSet<int>();
hs.Add(1);
hs.Add(1);

var category = new Category() { Id = Guid.NewGuid(), Name = "Kategori1" };
var category2 = new Category() { Id = Guid.NewGuid(), Name = "Kategori2" };
var hs2 = new HashSet<Category>();
hs2.Add(category);
hs2.Add(category2);

// Dictionary : Bir sözlük gibi key value pair olarak unique bir key göre koleksiyonda veri saklamamızı sağlar.
// REDIS gibi Key value pair saklayan sistemler, Dictionary kolleksiyon mantığı ile çalışır. 
var dc = new Dictionary<string, int>();
dc.Add("One", 1);
dc.Add("Two", 2);
// dc.Add("One", 4);

dc.TryGetValue("One", out int value);
Console.WriteLine("value" + value);


foreach (KeyValuePair<string,int> item in dc)
{
    Console.WriteLine($"Key {item.Key}, Value: {item.Value}");
}

Console.ReadKey();

#endregion
