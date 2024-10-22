using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordTupples
{
  // Request ve DTO nesneleri için mantıklı, DDD ValueObject tipi için mantıklı bir çözüm.
  // public record Money(decimal amount, string currency); Default
  public record Money(decimal amount, string currency)
  {
    public string Y { get; set; }
  }

}
