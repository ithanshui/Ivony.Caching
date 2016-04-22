﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivony.Caching
{


  public interface ICachePolicyProvider
  {

    CachePolicy CreateCachePolicy( string cacheKey, object cacheValue );

  }
}