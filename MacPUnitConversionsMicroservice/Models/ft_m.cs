using System;

namespace UnitConversion
{
    public class ft_m : SimpleConversions
    {
        public ft_m(bool toMetric)
        {
            base.conversionFactorMetric = 0.3048;
            base.conversionFactorImperial = 1 / base.conversionFactorMetric;
            base.SetConvertionFactor(toMetric);
        }
    }
}
