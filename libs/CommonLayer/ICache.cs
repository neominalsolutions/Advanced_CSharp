﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer
{
  public interface ICache
  {
    void SetCache(string key, string value);
  }
}
