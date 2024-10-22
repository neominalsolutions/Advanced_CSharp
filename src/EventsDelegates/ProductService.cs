using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegates
{
  public class ProductService
  {

    public void Save()
    {
      ProductPrice p = new ProductPrice();
      p.PriceChanged += P_PriceChanged;
      p.PriceChange(15);

      // Repo.save();
    }

    private void P_PriceChanged(PriceChangeArgs args)
    {
      Console.WriteLine("Kayıt tamam mail at");
    }
  }
}
