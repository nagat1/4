﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.enumms
{
    [Flags]
    public enum permissions:byte

    {
        Read=1, 
        write=2,
        Delete=4,
        Execute=8

    }
}
