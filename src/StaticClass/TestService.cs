using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
  public class TestService
  {

    public void DisplayGuestCount()
    {
      Console.WriteLine("\n"  + GuestCounter.ActiveGuestCount);
    }
  }
}
