using CommonLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
  // Extension sınıflarımızda static tanımlanıyor ve ilgili kod içerden müdehale etmeden kodda yeni özellikler kazandırmamızı sağlıyorlar.
  public static class PersonExtension
  {

    // Extension Method yöntemi
    public static string GetFullName(this Person person)
    {
      return $"{person.FirstName} {person.LastName.ToUpper()}";
    }

  }
}
