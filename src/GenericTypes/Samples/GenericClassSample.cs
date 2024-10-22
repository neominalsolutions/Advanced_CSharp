using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes.Samples
{
  public class ProductService<TRequest,TResponse>
    where TRequest:class
    where TResponse:class
  {
    public TResponse Handle(TRequest request)
    {
      return default(TResponse);
    }
  }

  public abstract class Entity<TKey>
  {
    public TKey Id { get; set; }

  }

  // Generic Class : İlgili nesneleri farklı tiplerde yönetmek için kullanılan bir kod geliştirme yakalşımı.
  public class Product:Entity<int>
  {
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
  }
  public class Category:Entity<Guid>
  {
    public string Name { get; set; }
  }

  // Hizmet
  public class Repository<T> where T : class
  {
    public void Save(T item)
    {
      Console.WriteLine($"{typeof(T)} kaydedildi");
    }
  }


}
