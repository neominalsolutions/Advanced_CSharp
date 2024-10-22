using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordTupples
{
  public class MoneyClass(int y)
  {
    public string Currency { get; set; }
    public decimal Amount { get; set; }
    public int Y { get; set; }


    // Nesnenin referansını olduğu gibi kopyala
    public MoneyClass Copy()
    {
      return (MoneyClass)MemberwiseClone();
    }

    //public override bool Equals(object? obj)
    //{
    //  var instance = (MoneyClass)obj;

    //  return instance.Amount == this.Amount && instance.Currency == this.Currency;
    //}

  }
}
