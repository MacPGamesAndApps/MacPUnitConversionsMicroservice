using System;

namespace UnitConversion
{
    public class USgal_L : SimpleConversions
    {
        public USgal_L(bool toMetric)
        {
            base.conversionFactorMetric = 3.7854118;
            base.conversionFactorImperial = 1 / base.conversionFactorMetric;
            base.SetConvertionFactor(toMetric);
        }
    }
}
