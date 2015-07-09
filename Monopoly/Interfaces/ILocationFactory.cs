﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Interfaces
{
    public interface ILocationFactory
    {
        Dictionary<int, ILocation> GetLocations();
    }
}