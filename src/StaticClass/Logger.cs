using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
  public static class Logger
  {
    public const int minimumLogLevel = 1;

    static Logger()
    {

    }

    public static void LogInfo(string message)
    {
      Console.WriteLine(message);
    }

    public static void LogError(string message)
    {
      Console.WriteLine(message);
    }
  }
}
