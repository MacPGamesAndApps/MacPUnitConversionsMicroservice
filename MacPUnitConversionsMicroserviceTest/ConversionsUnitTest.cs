using MacPUnitConversionsMicroservice.Services.Interfaces;
using MacPUnitConversionsMicroservice.Services;
using MacPUnitConversionsMicroservice.Models;

namespace MacPUnitConversionsMicroserviceTest;

[TestClass]
public class ConversionsUnitTest
{
    [TestMethod]
    [DataRow(1, ConversionTypes.in_to_cm)]
    [DataRow(1, ConversionTypes.ft_to_m)]
    [DataRow(1, ConversionTypes.yd_to_m)]
    [DataRow(1, ConversionTypes.mi_to_km)]
    [DataRow(1, ConversionTypes.lb_to_kg)]
    [DataRow(1, ConversionTypes.USoz_to_ml)]
    [DataRow(1, ConversionTypes.USgal_to_L)]
    [DataRow(1, ConversionTypes.UKgal_to_L)]
    [DataRow(1, ConversionTypes.F_to_C)]
    [DataRow(1, ConversionTypes.cm_to_in)]
    [DataRow(1, ConversionTypes.m_to_ft)]
    [DataRow(1, ConversionTypes.m_to_yd)]
    [DataRow(1, ConversionTypes.km_to_mi)]
    [DataRow(1, ConversionTypes.kg_to_lb)]
    [DataRow(1, ConversionTypes.Ml_to_USoz)]
    [DataRow(1, ConversionTypes.L_to_USgal)]
    [DataRow(1, ConversionTypes.L_to_UKgal)]
    [DataRow(1, ConversionTypes.C_to_F)]
    public void ConvertWithValidData(double fromValue, ConversionTypes conversionType)
    {
        IUnitConversionService _unitConversionService = new UnitConversionService();
        double? test = _unitConversionService.ConvertValue(fromValue, conversionType);
        Assert.IsNotNull(test);
    }

    [TestMethod]
    public void ConvertWithInvalidType()
    {
        IUnitConversionService _unitConversionService = new UnitConversionService();
        double? test = _unitConversionService.ConvertValue(1, (ConversionTypes)125);
        Assert.IsNull(test);
    }
}