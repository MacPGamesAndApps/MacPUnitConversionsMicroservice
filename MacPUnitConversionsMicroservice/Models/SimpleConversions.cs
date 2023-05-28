using System;

namespace UnitConversion
{
    public class SimpleConversions : Conversions
    {
        private double conversionFactor;
        protected double conversionFactorMetric { get; set; }
        protected double conversionFactorImperial { get; set; }

        public SimpleConversions()
        {
            //logic implemented in derived classes
        }

        protected void SetConvertionFactor(bool toMetric)
        {
            if (toMetric)
            {
                conversionFactor = conversionFactorMetric;
            }
            else
            {
                conversionFactor = conversionFactorImperial;
            }
        }

        public override double ConvertValue(double fromValue)
        {
            return (fromValue * conversionFactor);
        }
    }
}
