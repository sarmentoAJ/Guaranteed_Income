﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guaranteed_Income.Interfaces
{
    public abstract class IRider
    {
        public double annualIncome { get; set; }
        public double benifitBase { get; set; }
    }
}
