﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomSpawns.ModIntegration
{
    public class SubMod
    {

        public string SubModuleName { get; private set; }

        public SubMod(string subModuleName)
        {
            SubModuleName = subModuleName;
        }
    }
}
