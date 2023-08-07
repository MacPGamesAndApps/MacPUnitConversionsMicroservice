
using MacPUnitConversionsMicroservice.Helpers;
using MacPUnitConversionsMicroservice.Models;
using MacPUnitConversionsMicroservice.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using UnitConversion;

namespace MacPUnitConversionsMicroservice.Services
{
    public class UnitConversionService : IUnitConversionService
    {
        private const bool TO_METRIC = true;
        private const bool TO_IMPERIAL = false;
        public double? ConvertValue(double valueFrom, ConversionTypes conversionType)
        {
            double? convertedValue = null;
            Conversions? conversion = null;


            switch (conversionType)
            {
                case ConversionTypes.in_to_cm:
                    {
                        conversion = new in_cm(TO_METRIC);
                        break;
                    }
                case ConversionTypes.ft_to_m:
                    {
                        conversion = new ft_m(TO_METRIC);
                        break;
                    }
                case ConversionTypes.yd_to_m:
                    {
                        conversion = new yd_m(TO_METRIC);
                        break;
                    }
                case ConversionTypes.mi_to_km:
                    {
                        conversion = new mi_km(TO_METRIC);
                        break;
                    }
                case ConversionTypes.lb_to_kg:
                    {
                        conversion = new lb_kg(TO_METRIC);
                        break;
                    }
                case ConversionTypes.USoz_to_ml:
                    {
                        conversion = new USoz_mL(TO_METRIC);
                        break;
                    }
                case ConversionTypes.USgal_to_L:
                    {
                        conversion = new USgal_L(TO_METRIC);
                        break;
                    }
                case ConversionTypes.UKgal_to_L:
                    {
                        conversion = new UKgal_L(TO_METRIC);
                        break;
                    }
                case ConversionTypes.F_to_C:
                    {
                        conversion = new F_C(TO_METRIC);
                        break;
                    }
                case ConversionTypes.cm_to_in:
                    {
                        conversion = new in_cm(TO_IMPERIAL);
                        break;
                    }
                case ConversionTypes.m_to_ft:
                    {
                        conversion = new ft_m(TO_IMPERIAL);
                        break;
                    }
                case ConversionTypes.m_to_yd:
                    {
                        conversion = new yd_m(TO_IMPERIAL);
                        break;
                    }
                case ConversionTypes.km_to_mi:
                    {
                        conversion = new mi_km(TO_IMPERIAL);
                        break;
                    }
                case ConversionTypes.kg_to_lb:
                    {
                        conversion = new lb_kg(TO_IMPERIAL);
                        break;
                    }
                case ConversionTypes.Ml_to_USoz:
                    {
                        conversion = new USoz_mL(TO_IMPERIAL);
                        break;
                    }
                case ConversionTypes.L_to_USgal:
                    {
                        conversion = new USgal_L(TO_IMPERIAL);
                        break;
                    }
                case ConversionTypes.L_to_UKgal:
                    {
                        conversion = new UKgal_L(TO_IMPERIAL);
                        break;
                    }
                case ConversionTypes.C_to_F:
                    {
                        conversion = new F_C(TO_IMPERIAL);
                        break;
                    }
            }

            if (conversion != null)
            {
                convertedValue = conversion.ConvertValue(valueFrom);
            }

            return convertedValue;
        }

        public IEnumerable<ConversionTypeNamed> GetTypes()
        {
            List<ConversionTypeNamed> types = new List<ConversionTypeNamed>();

            foreach (ConversionTypes type in Enum.GetValues(typeof(ConversionTypes)))
            {
                types.Add(new ConversionTypeNamed { ConversionName = EnumHelper.GetEnumDisplayName(type), ConversionType = type });
            }

            return types;
        }
    }
}
