using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordTupples
{
  public record Location
  {
    public int X { get; set; }
    public int Y { get; set; }

    public int Z { get; init; }

    public Location(int z)
    {
      Z = z;
    }


  }
}
