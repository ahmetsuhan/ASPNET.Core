using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModelDto_and_Validation.Validation
{
    public class Temperature:ValidationAttribute
    {

        private int _maxTemperature;

        public Temperature(int maxTemperature)
        {
            _maxTemperature = maxTemperature;
        }

        public override bool IsValid(object value)
        {

            return ((int)value) < _maxTemperature;

        }


    }
}
