using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegates
{
  public delegate void PriceChangeHandler2(PriceChangeArgs @args);

  public interface IPriceChange
  {
    public event PriceChangeHandler2 PriceChanged;
    public void PriceChange(decimal price);
  }
}
