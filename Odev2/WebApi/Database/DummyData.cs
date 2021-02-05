using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Database.Constant;
using WebApi.Database.Dtos;
using WebApi.Extensions.DataExtension;
namespace WebApi.Database
{
    public class DummyData
    {
        private static volatile DummyData _instance = null;
        private static readonly object padlock = new object();

        public List<StudentDto> StudentsDto = new List<StudentDto>();
        public List<HeadMasterDto> HeadMasterDtos = new List<HeadMasterDto>();
        public List<TeacherDto> TeacherDtos = new List<TeacherDto>();

        public static DummyData GetInstances()
        {
            lock (padlock)
            {
                if (_instance==null)
                {
                    _instance = new DummyData();
                }
                return _instance;
            }
        }

        private int studentDataCount=50; // oluşturulacak student data sayısı
        private int teacherDataCount=10;// oluşturulacak teacher data sayısı
        private int headMasterCount = 1; //// oluşturulacak headMaster data sayısı
        private DummyData()
        {
            if (PathInfo.StudentDtoDataPath.FileExist())
            {
                StudentsDto.ReadAllStudentsJson(PathInfo.StudentDtoDataPath);
            }
            else
            {
                StudentsDto.CreateRandomStudenDtoData(studentDataCount);
                PathInfo.StudentDtoDataPath.CreateFile();
                StudentsDto.FileAppendStudentJson(PathInfo.StudentDtoDataPath);
            }
            if (PathInfo.TeacherDtoDataPath.FileExist())
            {
                TeacherDtos.ReadAllTeachersJson(PathInfo.TeacherDtoDataPath);
            }
            else
            {
                TeacherDtos.CreateRandomTeacherDtoData(teacherDataCount);
                PathInfo.TeacherDtoDataPath.CreateFile();
                TeacherDtos.FileAppendTeacherJson(PathInfo.TeacherDtoDataPath);
            }
            if (PathInfo.HeadMasterDtoDataPath.FileExist())
            {
                HeadMasterDtos.ReadAllHeadMasterJson(PathInfo.HeadMasterDtoDataPath);
            }
            else
            {
                HeadMasterDtos.CreateRandomHeadMasterDtoData(teacherDataCount);
                PathInfo.HeadMasterDtoDataPath.CreateFile();
                HeadMasterDtos.FileAppendHeadMasterJson(PathInfo.HeadMasterDtoDataPath);
            }
        }

        static bool FileExist(string path)
        {
            return File.Exists(path);
        }
       

    }
}
