using System;

namespace UnitConversion
{
    public class lb_kg : SimpleConversions
    {
        public lb_kg(bool toMetric)
        {
            base.conversionFactorMetric = 0.45359231;
            base.conversionFactorImperial = 1 / base.conversionFactorMetric;
            base.SetConvertionFactor(toMetric);
        }
    }
}
