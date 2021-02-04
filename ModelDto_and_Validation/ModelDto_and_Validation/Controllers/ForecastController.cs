using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModelDto_and_Validation.Data.Context;
using ModelDto_and_Validation.Filters;
using ModelDto_and_Validation.Mapping;
using ModelDto_and_Validation.RequestModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModelDto_and_Validation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ForecastController : ControllerBase
    {

        private DbContextOptions<DatabaseContext> option;

        public ForecastController()
        {
            option = new DbContextOptionsBuilder<DatabaseContext>().UseInMemoryDatabase(databaseName: "TestDatabase").Options;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<DailyForecastModel> result = new List<DailyForecastModel>();
            using (DatabaseContext dbContext = new DatabaseContext(option))
            {
                var entityList = dbContext.DailyForeCasts.ToList();

                result = entityList.ToDailyForecastModelResponse();
            }
            return Ok(result);
        }

        [HttpPost]
        [ValidationActionModel]
        public IActionResult Post([FromBody] DailyForecastRequest request)
        {
            #region Validation1

            List<string> validations = new List<string>();
            if (request.ClientId == string.Empty)
            {
                validations.Add("Client Id boş geçilemez");
            }
            if (request.TemperatureC<=-50)
            {
                validations.Add("Geçersiz Sıcaklık değeri");
            }
            if (validations.Any())
            {
                return BadRequest(validations);
            }

            #endregion Validation1


            #region Validation2

            var request2 = JsonConvert.DeserializeObject<DailyForecastRequestV2>(JsonConvert.SerializeObject(request));

            var validate2_0 = request2.Validate();
            if (validate2_0.Item1)
            {
                return BadRequest(validate2_0.Item2);
            }

            var validate2_1 = request2.Validate2();

            if (validate2_1.Isvalid)
            {
                return BadRequest(validate2_1.validationErrors);
            }

            #endregion Validation2


            #region Validation3

            var request3 = JsonConvert.DeserializeObject<DailyForecastRequestV3>(JsonConvert.SerializeObject(request));
            var validation3 = request3.Validation();
            if (!validation3.isValid)
            {
                return BadRequest(validation3.validationError);
            }

            #endregion Validation3

            #region Validation4
            //annotations
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            #endregion Validation4


            #region Validation5

            var request5 = JsonConvert.DeserializeObject<DailyForecastRequestV5>(JsonConvert.SerializeObject(request));

            var context5 = new ValidationContext(request5);
            var validation5Result = new List<ValidationResult>();

            bool isValid5 = Validator.TryValidateObject(request5,context5,validation5Result,true);
            if (!isValid5)
            {
                return BadRequest(validation5Result);
            }

            #endregion Validation5


            #region Validation6

            var request6 = JsonConvert.DeserializeObject<DailyForecastRequestV6>(JsonConvert.SerializeObject(request));

            var context6 = new ValidationContext(request6);
            var validation6Result = new List<ValidationResult>();

            bool isValid6 = Validator.TryValidateObject(request6, context6, validation6Result, true);
            if (!isValid6)
            {
                return BadRequest(validation6Result);
            }

            #endregion Validation6
            return Ok();

        }

    }
}
