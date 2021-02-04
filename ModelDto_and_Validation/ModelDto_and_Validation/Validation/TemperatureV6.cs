using ModelDto_and_Validation.Enums;
using ModelDto_and_Validation.RequestModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModelDto_and_Validation.Validation
{
    public class TemperatureV6:ValidationAttribute
    {

        private int _maxTemperature;

        public TemperatureV6(int maxTemperature)
        {
            _maxTemperature = maxTemperature;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            DailyForecastRequestV6 forecastModel = (DailyForecastRequestV6)validationContext.ObjectInstance;

            if (forecastModel.ForecastType == (int)ForecastType.Weather && forecastModel.Summary=="Snowy")
            {
                if (forecastModel.TemperatureC > _maxTemperature)
                {
                    return new ValidationResult(FormatErrorMessage(validationContext.MemberName));
                }
            }
            return ValidationResult.Success;

        }


    }
}
