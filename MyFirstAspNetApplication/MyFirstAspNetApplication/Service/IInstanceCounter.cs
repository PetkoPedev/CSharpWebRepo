﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstAspNetApplication.Service
{
    public interface IInstanceCounter
    {
        int Instances { get; }
    }
}
