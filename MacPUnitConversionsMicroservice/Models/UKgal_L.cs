using System;

namespace UnitConversion
{
    public class UKgal_L : SimpleConversions
    {
        public UKgal_L(bool toMetric)
        {
            base.conversionFactorMetric = 4.5460879;
            base.conversionFactorImperial = 1 / base.conversionFactorMetric;
            base.SetConvertionFactor(toMetric);
        }
    }
}
