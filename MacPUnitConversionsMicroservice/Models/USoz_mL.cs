using UnitConversion;

namespace MacPUnitConversionsMicroservice.Models
{
    public class USoz_mL : SimpleConversions
    {
        public USoz_mL(bool toMetric)
        {
            base.conversionFactorMetric = 29.5735;
            base.conversionFactorImperial = 1 / base.conversionFactorMetric;
            base.SetConvertionFactor(toMetric);
        }
    }
}
