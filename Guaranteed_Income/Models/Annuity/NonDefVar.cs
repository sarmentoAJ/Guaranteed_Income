﻿using Guaranteed_Income.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guaranteed_Income.Models.Annuity
{
    public class NonDefVar : Annuities
    {
        public NonDefVar(Person person, Brokerage stock) : base(person)
        {
            NonQualified();
            Deferred();            
            Variable();
            CalculateData();
            yearlyBreakdown = GetYearlyBreakdown(stock);
        }
    }
}
