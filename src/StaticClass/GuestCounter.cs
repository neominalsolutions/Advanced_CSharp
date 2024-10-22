using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
  public static class GuestCounter
  {
    public static int ActiveGuestCount { get; set; } = 0;
  }
}
