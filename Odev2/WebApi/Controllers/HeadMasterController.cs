using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Database;
using WebApi.RequestModels;
using WebApi.Extensions.Mapper;
using WebApi.Database.Dtos;
using System.ComponentModel.DataAnnotations;
using WebApi.Valdiation;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HeadMasterController : ControllerBase
    {

        private readonly DummyData _dummyData;
        public HeadMasterController()
        {
            _dummyData = DummyData.GetInstances();
        }

        [HttpGet]
        public List<HeadMasterRequestModel> Get()
        {
            List<HeadMasterRequestModel> list = new List<HeadMasterRequestModel>();
            list = _dummyData.HeadMasterDtos.ToHeadMasterRequestModel();
            return list;
        }
        [HttpGet("get/{id}")]
        public HeadMasterDto GetById(int id)
        {
            var data = _dummyData.HeadMasterDtos.FirstOrDefault(x => x.Id == id);
            return data;
        }


        [HttpPost]
        public IActionResult Post([FromBody] HeadMasterRequestModel headMasterRequestModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var data = headMasterRequestModel.ToHeadMasterDto2();
            _dummyData.HeadMasterDtos.Add(data);
            return Ok();
        }


        [HttpPost("post")]
        public IActionResult Post2([FromBody] HeadMasterRequestModel headMasterRequestModel)
        {
            var context = new ValidationContext(headMasterRequestModel);
            var validationResult = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(headMasterRequestModel,context
                ,validationResult,true);

            if (!isValid)
            {
                return BadRequest(validationResult);
            }
            var data = headMasterRequestModel.ToHeadMasterDto2();
            _dummyData.HeadMasterDtos.Add(data);

            return Ok();
        }


        [HttpPost("post3")]
        public IActionResult Post3([FromBody] HeadMasterRequestModel headMasterRequestModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var data = headMasterRequestModel.ToHeadMasterDto2();
            _dummyData.HeadMasterDtos.Add(data);

            return Ok();
        }

        [HttpPost("post4")]
        public IActionResult Post4([FromBody] HeadMasterRequestModel headMasterRequestModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var data = headMasterRequestModel.ToHeadMasterDto2();
            _dummyData.HeadMasterDtos.Add(data);

            return Ok();
        }

        [HttpPost("post5")]
        public IActionResult Post5([FromBody] HeadMasterRequestModel headMasterRequestModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var data = headMasterRequestModel.ToHeadMasterDto2();
            _dummyData.HeadMasterDtos.Add(data);

            return Ok();
        }



        [HttpPost("post6")]
        [ValidationActionModel]
        public IActionResult Post6([FromBody] HeadMasterRequestModel headMasterRequestModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var data = headMasterRequestModel.ToHeadMasterDto2();
            _dummyData.HeadMasterDtos.Add(data);

            return Ok();
        }

    }
}
