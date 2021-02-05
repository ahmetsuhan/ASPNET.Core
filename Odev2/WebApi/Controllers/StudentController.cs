using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Database;
using WebApi.RequestModels;
using WebApi.Extensions.Mapper;
using WebApi.Database.Dtos;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {

        private readonly DummyData _dummyData;

        public StudentController()
        {
            _dummyData = DummyData.GetInstances();
        }

        [HttpGet]
        public List<StudentRequestModel> Get()
        {
            List<StudentRequestModel> list = new List<StudentRequestModel>();
            list = _dummyData.StudentsDto.ToStudentRequestModel();
            return list;
        }

        [HttpGet("get/{id}")]
        public StudentDto GetById(int id)
        {
            var data = _dummyData.StudentsDto.FirstOrDefault(s => s.Id == id);
            return data;
        }

        [HttpPost]
        public IActionResult Post([FromBody] StudentRequestModel studentRequestModel)
        {
            List<string> validations = new List<string>();
            if (_dummyData.StudentsDto.Exists(x => x.Id == studentRequestModel.Id))
            {
                validations.Add("Gönderilen ID zaten mevcut");
            }
            if (validations.Any())
            {
                return BadRequest(validations);
            }
            var data = studentRequestModel.ToStudentDto2();
            _dummyData.StudentsDto.Add(data);
            return Ok();
        }

        [HttpPut]
        public void Put([FromBody] StudentRequestModel studentRequestModel)
        {
            var edited = _dummyData.StudentsDto.FirstOrDefault(x => x.Id == studentRequestModel.Id);
            edited.FirstName = studentRequestModel.FirstName;
            edited.LastName = studentRequestModel.LastName;
            edited.City = studentRequestModel.City;
            edited.Country = studentRequestModel.Country;
            edited.Address = studentRequestModel.Address;
            edited.BirthDate = studentRequestModel.BirthDate;

        }






    }
}
