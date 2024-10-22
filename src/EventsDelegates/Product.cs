using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegates
{
  public class PriceChangeArgs : EventArgs
  {
    public decimal OldPrice { get; set; }
    public decimal NewPrice { get; set; }

  }

  public delegate void PriceChangeHandler(PriceChangeArgs @args);

  public class Product
  {
    public decimal Price { get; set; }

    // public event EventHandler PriceChanged; // event Invoke edersek. bu durumda EventHandler delegate üzerinden ilgili Product_PriceChanged tetiklenecektir.
    public event PriceChangeHandler PriceChanged;
    public Product()
    {
      PriceChanged += Product_PriceChanged; // delegate ettik.
    }



    private void Product_PriceChanged(PriceChangeArgs args)
    {
      Console.WriteLine($"eski Fiyat: {args.OldPrice} \n yeni Fiyat: {args.NewPrice}");
    }

    public void ChangePrice(decimal newPrice)
    {
      decimal oldPrice = Price;
      Price = newPrice;

      var eventArgs = new PriceChangeArgs { OldPrice = oldPrice, NewPrice = newPrice };

      PriceChanged.Invoke(eventArgs);
    }

    public void PriceChange(decimal price)
    {
      throw new NotImplementedException();
    }
  }
}
