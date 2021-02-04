using System;
using System.Collections.Generic;

namespace ModelDto_and_Validation.RequestModel
{
    public interface IRequestModel
    {
        (bool isValid, List<string> validationError) Validation();
    }
    public class DailyForecastRequestV3:IRequestModel
    {
        public int Id { get; set; }
        public string ClientId { get; set; }

        public DateTime Date { get; set; }
        public int ForecastType { get; set; }

        public int TemperatureC { get; set; }
        public string Summary { get; set; }

        public (bool isValid, List<string> validationError) Validation()
        {
                List<string> validateList = new List<string>();
                if (ClientId.Trim() == string.Empty)
                {
                    validateList.Add("Client Id boş geçilemez");
                }

                if (TemperatureC <= -50)
                {
                    validateList.Add("Geçersiz sıcaklık değeri");
                }

                return (validateList.Count <= 0, validateList);
        }
    }
   
}
