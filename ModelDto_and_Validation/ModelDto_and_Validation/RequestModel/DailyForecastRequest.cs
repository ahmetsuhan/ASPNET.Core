using System;
using System.ComponentModel.DataAnnotations;

namespace ModelDto_and_Validation.RequestModel
{
    public class DailyForecastRequest
    {
        [Required(ErrorMessage ="Id boş geçilemez")] // Validation4 için tanımladım
        public int Id { get; set; }

        [StringLength(10,ErrorMessage ="Clien ID maksimum 10 karakter olabilir")]
        public string ClientId { get; set; }

        public DateTime Date { get; set; }
        public int ForecastType { get; set; }

        public int TemperatureC { get; set; }
        public string Summary { get; set; }

    }
}
