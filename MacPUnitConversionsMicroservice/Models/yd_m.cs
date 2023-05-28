using System;

namespace UnitConversion
{
    public class yd_m : SimpleConversions
    {
        public yd_m(bool toMetric)
        {
            base.conversionFactorMetric = 0.9144;
            base.conversionFactorImperial = 1 / base.conversionFactorMetric;
            base.SetConvertionFactor(toMetric);
        }
    }
}
