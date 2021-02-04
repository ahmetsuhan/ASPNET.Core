using ModelDto_and_Validation.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelDto_and_Validation
{
    public class DailyForecastModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public ForecastType ForecastType { get; set; }

        public int TemperatureC { get; set; }
        public int TemperatureF { get; set; }
        public string Summary { get; set; }

    }
}
