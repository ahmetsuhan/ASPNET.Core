using ModelDto_and_Validation.Data.Entity;
using ModelDto_and_Validation.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelDto_and_Validation.Mapping
{
    public static  class MappingExtension
    {


        public static List<DailyForecastModel> ToDailyForecastModelResponse(this List<DailyForecast> dailyForecast)
        {
            List<DailyForecastModel> dailyForecastModels = new List<DailyForecastModel>();

            for (int i = 0; i < dailyForecast.Count; i++)
            {
                dailyForecastModels[i].Id = dailyForecast[i].Id;
                dailyForecastModels[i].Date = dailyForecast[i].Date;
                dailyForecastModels[i].TemperatureC = dailyForecast[i].TemperatureC;
                dailyForecastModels[i].Summary = dailyForecast[i].Summary;
                dailyForecastModels[i].ForecastType = (ForecastType)dailyForecast[i].ForecastType;
            }
            return dailyForecastModels;

        }

        /*Different way with using nested foreach and for */
        public static List<DailyForecastModel> ToDailyForecastModelResponse2(this List<DailyForecast> dailyForecast)
        {

            List<DailyForecastModel> result = new List<DailyForecastModel>();

            for (int i = 0; i < dailyForecast.Count; i++)
            {
                result.Add(new DailyForecastModel
                {
                    Id = dailyForecast[i].Id,
                    Date = dailyForecast[i].Date,
                    ForecastType = (ForecastType)dailyForecast[i].ForecastType,
                    Summary = dailyForecast[i].Summary,
                    TemperatureC = dailyForecast[i].TemperatureC,
                    TemperatureF = dailyForecast[i].TemperatureC * 3
                });
            }
            return result;

        }

    }
}






