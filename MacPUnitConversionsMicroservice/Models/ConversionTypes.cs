using System;
using System.ComponentModel.DataAnnotations;

namespace MacPUnitConversionsMicroservice.Models
{
    public enum ConversionTypes : Byte
    {
        [Display(Name = "Inches to centimeters")]
        in_to_cm = 0,
        [Display(Name = "Feet to meters")]
        ft_to_m = 1,
        [Display(Name = "Yards to meters")]
        yd_to_m = 2,
        [Display(Name = "Miles to kilometers")]
        mi_to_km = 3,
        [Display(Name = "Pounds to kilograms")]
        lb_to_kg = 4,
        [Display(Name = "US Ounces to millimeters")]
        USoz_to_ml = 5,
        [Display(Name = "US Gallons to liters")]
        USgal_to_L = 6,
        [Display(Name = "UK Gallons to liters")]
        UKgal_to_L = 7,
        [Display(Name = "Fahrenheit to celcius")]
        F_to_C = 8,
        [Display(Name = "Centimeters to inches")]
        cm_to_in = 9,
        [Display(Name = "Meters to feet")]
        m_to_ft = 10,
        [Display(Name = "Meters to yards")]
        m_to_yd = 11,
        [Display(Name = "Kilometers to miles")]
        km_to_mi = 12,
        [Display(Name = "Kilograms to pounds")]
        kg_to_lb = 13,
        [Display(Name = "Milliliters to US ounces")]
        Ml_to_USoz = 14,
        [Display(Name = "Liters to US gallons")]
        L_to_USgal = 15,
        [Display(Name = "Liters to UK gallons")]
        L_to_UKgal = 16,
        [Display(Name = "Celcius to fahrenheit")]
        C_to_F = 17
    }
}
