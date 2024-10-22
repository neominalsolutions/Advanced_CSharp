using CommonLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
  public static class CacheExtension
  {
    public static void ClearCache(this ICache cache)
    {
      Console.WriteLine("Cache Clear");
    }
  }
}
