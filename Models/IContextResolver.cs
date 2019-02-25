﻿using System.Collections.Generic;
using System;

namespace UsedCarsComp.Models
{
    public interface IContextResolver : IDisposable
    {
        List<T> RetrieveData<T>();

        bool SaveData<T>(List<T> items);
    }
}