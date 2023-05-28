using System;

namespace UnitConversion
{
    public class mi_km : SimpleConversions
    {
        public mi_km(bool toMetric)
        {
            base.conversionFactorMetric = 1.609344;
            base.conversionFactorImperial = 1 / base.conversionFactorMetric;
            base.SetConvertionFactor(toMetric);
        }
    }
}
