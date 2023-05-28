using System;

namespace UnitConversion
{
    public class F_C : Conversions
    {
        private bool toCelsius;

        public F_C(bool toMetric)
        {
            toCelsius = toMetric;
        }

        public override double ConvertValue(double fromValue)
        {
            if (toCelsius)
            {
                return (FahrenheitToCelsius(fromValue));
            }
            else
            {
                return (CelsiusToFahrenheit(fromValue));
            }
        }

        private Double CelsiusToFahrenheit(double fromValue)
        {
            return ((fromValue * 9 / 5) + 32);
        }

        private Double FahrenheitToCelsius(double fromValue)
        {
            return ((fromValue - 32) * 5 / 9);
        }
    }
}
