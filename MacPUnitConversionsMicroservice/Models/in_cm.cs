using System;

namespace UnitConversion
{
    public class in_cm : SimpleConversions
    {
        public in_cm(bool toMetric)
        {
            base.conversionFactorMetric = 2.54;
            base.conversionFactorImperial = 1 / base.conversionFactorMetric;
            base.SetConvertionFactor(toMetric);
        }
    }
}
