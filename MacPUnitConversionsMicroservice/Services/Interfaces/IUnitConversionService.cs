using MacPUnitConversionsMicroservice.Models;
using System.Collections.Generic;

namespace MacPUnitConversionsMicroservice.Services.Interfaces
{
    public interface IUnitConversionService
    {
        double? ConvertValue(double valueFrom, ConversionTypes conversionType);
        IEnumerable<ConversionTypeNamed> GetTypes();
    }
}
