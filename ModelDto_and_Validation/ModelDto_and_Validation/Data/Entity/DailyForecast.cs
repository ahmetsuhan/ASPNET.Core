using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelDto_and_Validation.Data.Entity
{
    public class DailyForecast
    {
        public int Id { get; set; }
        public int ForecastType { get; set; }
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public string Summary { get; set; }
    }
}
