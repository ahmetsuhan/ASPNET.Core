using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Database.Dtos;
using WebApi.RequestModels;

namespace WebApi.Extensions.Mapper
{
    public static class MappingExtension
    {

        public static List<StudentRequestModel> ToStudentRequestModel(this List<StudentDto> studentDtos)
        {
            List<StudentRequestModel> studentRequestModels = new List<StudentRequestModel>();
            foreach (var item in studentDtos)
            {
                studentRequestModels.Add(
                    new StudentRequestModel
                    {
                        Id = item.Id,
                        FirstName = item.FirstName,
                        City = item.City,
                        Country = item.Country,
                        Address = item.Address,
                        BirthDate = item.BirthDate,
                        LastName = item.LastName
                    }
                    );
            }
            return studentRequestModels;
        }




        public static StudentRequestModel ToStudentRequestModel2(this StudentDto studentDtos)
        {
            StudentRequestModel studentRequestModel = new StudentRequestModel();

            studentRequestModel.Id = studentDtos.Id;
            studentRequestModel.FirstName = studentDtos.FirstName;
            studentRequestModel.LastName = studentDtos.LastName;
            studentRequestModel.Address = studentDtos.Address;
            studentRequestModel.BirthDate = studentDtos.BirthDate;
            studentRequestModel.City = studentDtos.City;
            studentRequestModel.Country = studentDtos.Country;

            return studentRequestModel;
        }




        public static List<StudentDto> ToStudentDto(this List<StudentRequestModel> studentRequestModels)
        {
            List<StudentDto> studentDtos = new List<StudentDto>();
            foreach (var item in studentRequestModels)
            {
                studentDtos.Add(new StudentDto
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    City = item.City,
                    Country = item.Country,
                    Address = item.Address,
                    BirthDate = item.BirthDate,
                    LastName = item.LastName
                });
            }
            return studentDtos;
        }


        public static StudentDto ToStudentDto2(this StudentRequestModel studentRequestModel)
        {
            StudentDto studentDto = new StudentDto();

            studentDto.Id = studentRequestModel.Id;
            studentDto.FirstName = studentDto.FirstName;
            studentDto.LastName = studentDto.LastName;
            studentDto.BirthDate = studentDto.BirthDate;
            studentDto.Country = studentDto.Country;
            studentDto.City = studentDto.City;
            studentDto.Address = studentDto.Address;

            return studentDto;
        }


        public static List<TeacherRequestModel> ToTeacherRequestModel(this List<TeacherDto> teacherDtos)
        {
            List<TeacherRequestModel> teacherRequestModels = new List<TeacherRequestModel>();
            foreach (var item in teacherDtos)
            {
                teacherRequestModels.Add(new TeacherRequestModel
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    City = item.City,
                    Country = item.Country,
                    Address = item.Address,
                    BirthDate = item.BirthDate,
                    LastName = item.LastName,

                });
            }
            return teacherRequestModels;
        }



        public static TeacherRequestModel ToTeacherRequestModel2(this TeacherDto teacherDtos)
        {
            TeacherRequestModel teacherRequestModel = new TeacherRequestModel();

            teacherRequestModel.Id = teacherDtos.Id;
            teacherRequestModel.FirstName = teacherDtos.FirstName;
            teacherRequestModel.City = teacherDtos.City;
            teacherRequestModel.Country = teacherDtos.Country;
            teacherRequestModel.Address = teacherDtos.Address;
            teacherRequestModel.BirthDate = teacherDtos.BirthDate;
            teacherRequestModel.LastName = teacherDtos.LastName;

            return teacherRequestModel;
        }


        public static List<TeacherDto> ToTeacherDto(this List<TeacherRequestModel> teacherRequestModels)
        {
            List<TeacherDto> teacherDtos = new List<TeacherDto>();
            foreach (var item in teacherRequestModels)
            {
                teacherDtos.Add(new TeacherDto
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    City = item.City,
                    Country = item.Country,
                    Address = item.Address,
                    BirthDate = item.BirthDate,
                    LastName = item.LastName
                });
            }
            return teacherDtos;
        }


        public static TeacherDto ToTeacherDto(this TeacherRequestModel teacherRequestModel)
        {
            TeacherDto teacherDto = new TeacherDto();

            teacherDto.Id = teacherRequestModel.Id;
            teacherDto.FirstName = teacherRequestModel.FirstName;
            teacherDto.City = teacherRequestModel.City;
            teacherDto.Country = teacherRequestModel.Country;
            teacherDto.Address = teacherRequestModel.Address;
            teacherDto.BirthDate = teacherRequestModel.BirthDate;
            teacherDto.LastName = teacherRequestModel.LastName;

            return teacherDto;
        }



        public static List<HeadMasterRequestModel> ToHeadMasterRequestModel(this List<HeadMasterDto> headMasterDtos)
        {
            List<HeadMasterRequestModel> headMasterRequestModels = new List<HeadMasterRequestModel>();
            foreach (var item in headMasterDtos)
            {
                headMasterRequestModels.Add(new HeadMasterRequestModel
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    City = item.City,
                    Country = item.Country,
                    Address = item.Address,
                    BirthDate = item.BirthDate,
                    LastName = item.LastName,
                });
            }
            return headMasterRequestModels;
        }


        public static HeadMasterRequestModel ToHeadMasterRequestModel2(this HeadMasterDto headMasterDto)
        {
            HeadMasterRequestModel headMasterRequestModel = new HeadMasterRequestModel();

            headMasterRequestModel.Id = headMasterDto.Id;
            headMasterRequestModel.FirstName = headMasterDto.FirstName;
            headMasterRequestModel.City = headMasterDto.City;
            headMasterRequestModel.Country = headMasterDto.Country;
            headMasterRequestModel.Address = headMasterDto.Address;
            headMasterRequestModel.BirthDate = headMasterDto.BirthDate;
            headMasterRequestModel.LastName = headMasterDto.LastName;

            return headMasterRequestModel;
        }
        public static List<HeadMasterDto> ToHeadMasterDto(this List<HeadMasterRequestModel> headMasterRequestModels)
        {
            List<HeadMasterDto> headMasterDtos = new List<HeadMasterDto>();
            foreach (var item in headMasterRequestModels)
            {
                headMasterDtos.Add(new HeadMasterDto
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    City = item.City,
                    Country = item.Country,
                    Address = item.Address,
                    BirthDate = item.BirthDate,
                    LastName = item.LastName,
                });
            }
            return headMasterDtos;
        }

        public static HeadMasterDto ToHeadMasterDto2(this HeadMasterRequestModel headMasterRequestModel)
        {
            HeadMasterDto headMasterDto = new HeadMasterDto();


            headMasterDto.Id = headMasterRequestModel.Id;
            headMasterDto.FirstName = headMasterRequestModel.FirstName;
            headMasterDto.City = headMasterRequestModel.City;
            headMasterDto.Country = headMasterRequestModel.Country;
            headMasterDto.Address = headMasterRequestModel.Address;
            headMasterDto.BirthDate = headMasterRequestModel.BirthDate;
            headMasterDto.LastName = headMasterRequestModel.LastName;
               
            return headMasterDto;
        }
    }
}
