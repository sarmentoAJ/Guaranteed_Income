﻿using Guaranteed_Income.Interfaces;
using System.Collections.Generic;

namespace Guaranteed_Income.Models
{
    public class Qualified
    {
        public List<List<double>> fixedIm;
        public List<List<double>> fixedDef;
        public List<List<double>> varIm;
        public List<List<double>> varDef;
        public double fixedImYearly;
        public double fixedDefYearly;
        public double varImYearly;
        public double varDefYearly;
        public double fixedImAsset;
        public double fixedDefAsset;
        public double varImAsset;
        public double varDefAsset;
        private AnnuityFactory qualDefFix;
        private AnnuityFactory qualDefVar;
        private AnnuityFactory qualImFix;
        private AnnuityFactory qualImVar;

        public Qualified(Brokerage stock, Person person)
        {
            qualDefFix = new AnnuityFactory(AnnuityTax.Qualified, AnnuityTime.Deferred, AnnuityRate.Fixed, person, stock);
            qualDefVar = new AnnuityFactory(AnnuityTax.Qualified, AnnuityTime.Deferred, AnnuityRate.Variable, person, stock);
            qualImFix = new AnnuityFactory(AnnuityTax.Qualified, AnnuityTime.Immediate, AnnuityRate.Fixed, person, stock);
            qualImVar = new AnnuityFactory(AnnuityTax.Qualified, AnnuityTime.Immediate, AnnuityRate.Variable, person, stock);

            fixedIm = qualImFix.yearlyBreakdown;
            fixedDef = qualDefFix.yearlyBreakdown;
            varIm = qualImVar.yearlyBreakdown;
            varDef = qualDefVar.yearlyBreakdown;

            fixedImYearly = qualImFix.afterTaxIncome;
            fixedDefYearly = qualDefFix.afterTaxIncome;
            varImYearly = qualImVar.afterTaxIncome;
            varDefYearly = qualDefVar.afterTaxIncome;

            fixedDefAsset = qualDefFix.assetValue;
            fixedImAsset = qualImFix.assetValue;
            varDefAsset = qualDefVar.assetValue;
            varImAsset = qualImVar.assetValue;

            Annuities.FinishStock(stock);
        }
    }
}