using MacPUnitConversionsMicroservice.Models;
using MacPUnitConversionsMicroservice.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MacPUnitConversionsMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitConversionsController : ControllerBase
    {
        private readonly IUnitConversionService _unitConversionService;

        public UnitConversionsController(IUnitConversionService unitConversionService)
        {
            _unitConversionService = unitConversionService;
        }

        [HttpPost("convert")]
        public double? Convert(ConversionRequestData conversionRequestData)
        {
            return _unitConversionService.ConvertValue(conversionRequestData.ValueFrom, conversionRequestData.ConversionType);
        }

        [HttpGet("gettypes")]
        public IEnumerable<ConversionTypeNamed> GetTypes()
        {
            return _unitConversionService.GetTypes();
        }
    }
}
