using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer
{
  public class MemCache : ICache
  {
    public void SetCache(string key, string value)
    {
      Console.WriteLine("MemCache");
    }
  }
}
