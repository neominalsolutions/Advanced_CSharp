using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegates
{
  public class ProductPrice : IPriceChange
  {
    public event PriceChangeHandler2 PriceChanged;



    public void PriceChange(decimal price)
    {
      PriceChanged.Invoke(new PriceChangeArgs { NewPrice = 10, OldPrice = 14});
    }
  }
}
