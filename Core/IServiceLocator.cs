﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPFTemplate.Core
{
    public interface IServiceLocator<TKey, TValue> : IDictionary<TKey, TValue>
    {
        T Get<T>();
        T Get<T>(string key);
    }
}
