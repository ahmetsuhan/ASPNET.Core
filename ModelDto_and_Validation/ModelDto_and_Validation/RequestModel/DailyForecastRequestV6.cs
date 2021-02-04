using ModelDto_and_Validation.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ModelDto_and_Validation.RequestModel
{
  
    public class DailyForecastRequestV6
    {
        public int Id { get; set; }
        public string ClientId { get; set; }

        public DateTime Date { get; set; }

        public int ForecastType { get; set; }

        [Temperature(-5,ErrorMessage ="Sıcaklık maksimum -5 olabilir")]
        public int TemperatureC { get; set; }
        public string Summary { get; set; }

       
    }
   
}
