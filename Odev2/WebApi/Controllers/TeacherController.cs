using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApi.Database;
using WebApi.RequestModels;
using WebApi.Extensions.Mapper;
using WebApi.Database.Dtos;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherController:ControllerBase
    {


        private readonly DummyData _dummyData;

        public TeacherController()
        {
            _dummyData = DummyData.GetInstances();
        }

        [HttpGet]
        public List<TeacherRequestModel> Get()
        {
            List<TeacherRequestModel> list = new List<TeacherRequestModel>();
            list = _dummyData.TeacherDtos.ToTeacherRequestModel();
            return list;
        }
        [HttpGet("get/{id}")]
        public TeacherDto GetById(int id)
        {
            var data = _dummyData.TeacherDtos.FirstOrDefault(x=>x.Id==id);
            return data;
        }
        [HttpPost]
        public IActionResult Post([FromBody] TeacherRequestModel teacherRequestModel)
        {
            var validate = teacherRequestModel.Validate1();
            if (validate.Item1)
            {
                return BadRequest(validate.Item2);
            }

            #region Validation2
            var validate2 = teacherRequestModel.Validate2();
            if (validate2.isValid)
            {
                return BadRequest(validate2.validationErrors);
            }

            #endregion

            var data = teacherRequestModel.ToTeacherDto();
            _dummyData.TeacherDtos.Add(data);
            return Ok();
        }

    }
}
