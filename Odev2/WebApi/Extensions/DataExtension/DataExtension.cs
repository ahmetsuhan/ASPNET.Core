using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using WebApi.Database.Dtos;

namespace WebApi.Extensions.DataExtension
{
    public static class DataExtension
    {
        #region File append operations
        public static void FileAppendStudentJson(this List<StudentDto> studentDtos, string path)
        {
            string jsonString = JsonSerializer.Serialize(studentDtos);
            File.WriteAllText(path, jsonString);
        }

        public static void FileAppendTeacherJson(this List<TeacherDto> teacherDtos, string path)
        {
            string jsonString = JsonSerializer.Serialize(teacherDtos);
            File.WriteAllText(path, jsonString);
        }

        public static void FileAppendHeadMasterJson(this List<HeadMasterDto> headMasterDtos, string path)
        {
            string jsonString = JsonSerializer.Serialize(headMasterDtos);
            File.WriteAllText(path, jsonString);
        }

        #endregion File append operations

      
        #region Read All JSon operations
        public static void ReadAllStudentsJson(this List<StudentDto> studentDtos, string path)
        {
            string jsonString = File.ReadAllText(path);
            List<StudentDto> data = JsonSerializer.Deserialize<List<StudentDto>>(jsonString);
            studentDtos.SetStudentDto(data);
        }

        public static void ReadAllTeachersJson(this List<TeacherDto> teacherDtos, string path)
        {
            string jsonString = File.ReadAllText(path);
            List<TeacherDto> data = JsonSerializer.Deserialize<List<TeacherDto>>(jsonString);
            teacherDtos.SetTeacherDto(data);
        }

        public static void ReadAllHeadMasterJson(this List<HeadMasterDto> headMasterDtos, string path)
        {
            string jsonString = File.ReadAllText(path);
            List<HeadMasterDto> data = JsonSerializer.Deserialize<List<HeadMasterDto>>(jsonString);
            headMasterDtos.SetHeadMasterDto(data);
        }

        #endregion Read All JSon operations

        #region RandomNumberGenerator

        public static Random random = new Random();
        public static int RandomNumberGenerator(int start, int end)
        {
            return random.Next(start, end);
        }
        #endregion


        #region Create Dummy datas
        public static void CreateRandomStudenDtoData(this List<StudentDto> studentDtos, int dataCount)
        {
            for (int i = 0; i <= dataCount; i++)
            {
                studentDtos.Add(new StudentDto
                {
                    Id = i,
                    FirstName = "StudentFirstname_" + RandomNumberGenerator(0, 10000),
                    LastName = "StudentLastName_" + RandomNumberGenerator(0, 10000),
                    Address = "StudentAddress_" + RandomNumberGenerator(0, 10000),
                    //CarColor = "StudentCarColor_" + RandomNumberGenerator(0, 10000),
                   // HouseColor = "StudentHouseColor_" + RandomNumberGenerator(0, 10000),
                    //HouseRoomCount = RandomNumberGenerator(0, 10),
                    //Income = (decimal)RandomNumberGenerator(1000, 10000),
                    Country = "StudentCounter_" + RandomNumberGenerator(0, 1000),
                    City = "StudentCity_" + RandomNumberGenerator(0, 1000),
                    BirthDate = DateTime.Today
                });
            }
        }

    
        
        public static void CreateRandomTeacherDtoData(this List<TeacherDto> teacherDtos, int dataCount)
        {
            for (int i = 0; i <= dataCount; i++)
            {
                teacherDtos.Add(new TeacherDto { 
                
                    Id=i,
                    FirstName = "TeacherFirstname_" + RandomNumberGenerator(0, 10000),
                    LastName = "TeacherLastName_" + RandomNumberGenerator(0, 10000),
                    Address = "TeacherAddress_" + RandomNumberGenerator(0, 10000),
                    BirthDate = DateTime.Today,
                    City = "TeacherCity_" + RandomNumberGenerator(0, 1000),
                    Country = "StudentCounter_" + RandomNumberGenerator(0, 1000),
                    //ExperienceYear=RandomNumberGenerator(0,15),
                    //Specialty="TeacherSpeciality_"+RandomNumberGenerator(0,10)

                });
            }
        }


        public static void CreateRandomHeadMasterDtoData(this List<HeadMasterDto> headMasterDtos, int dataCount)
        {
            bool isMarried = true;
            int num;
            for (int i = 0; i <= dataCount; i++)
            {
                num = RandomNumberGenerator(0, 1);
                if (num%2==0)
                {
                    isMarried = true;
                }
                else
                {
                    isMarried = false;
                }

                headMasterDtos.Add(new HeadMasterDto { 
                
                Id=i,
                    FirstName = "HeadMasterFirstname_" + RandomNumberGenerator(0, 10000),
                    LastName = "HeadMasterLastName_" + RandomNumberGenerator(0, 10000),
                    BirthDate = DateTime.Today,
                    Address = "HeadMasterAddress_" + RandomNumberGenerator(0, 10000),
                    Country = "HeadMasterCounter_" + RandomNumberGenerator(0, 1000),
                    City = "HeadMasterCity_" + RandomNumberGenerator(0, 1000),
                    Maried=isMarried,
                    Bank="HeadMasterbank_"+RandomNumberGenerator(0,100),
                    BankAccountMoney=(decimal)RandomNumberGenerator(0,100000),
                    IBAN=RandomNumberGenerator(100000,1000000),
                    Company="HeadMasterCompany_"+RandomNumberGenerator(0,505)
                });
            }
        }
        #endregion Create Dummy datas

        #region Set operations

        private static void SetStudentDto(this List<StudentDto> studentDtos , List<StudentDto> datas)
        {
            for (int i = 0; i < datas.Count; i++)
            {
                studentDtos.Add(datas[i]);
            }
        }
        private static void SetTeacherDto(this List<TeacherDto> teacherDtos, List<TeacherDto> datas)
        {
            for (int i = 0; i < datas.Count; i++)
            {
                teacherDtos.Add(datas[i]);
            }
        }
        private static void SetHeadMasterDto(this List<HeadMasterDto> headMasterDtos, List<HeadMasterDto> datas)
        {
            for (int i = 0; i < datas.Count; i++)
            {
                headMasterDtos.Add(datas[i]);
            }
        }

        #endregion Set operations

        public static void CreateFile(this string path)
        {
            FileStream fileStream = File.Create(path);
            fileStream.Close();
        }
        public static bool FileExist(this string path)
        {
            return File.Exists(path);
        }

    }


}
