﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gitold.Application
{
    public class Details
    {
        public List<string> Commiters { get; private set; } = new List<string>();
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}