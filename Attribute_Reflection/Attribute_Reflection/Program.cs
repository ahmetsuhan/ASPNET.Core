using Attribute_Reflection.Business;
using Attribute_Reflection.CustomSql;
using Attribute_Reflection.Models;
using System;
using System.Collections.Generic;

namespace Attribute_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {

            Master master = new Master() { Id = 1, FirstName = "MasterName", LastName = "masterLastName" };
            Admin admin = new Admin() { Id=2,FirstName="adminName",LastName="adminLastName"};
            Student student = new Student() { Id = 3, FirstName = "studentName", LastName = "studentLastName" };


            List<Lesson> lessons = new List<Lesson>();
            lessons.Add(new Lesson(10, "kimya", master));
            lessons.Add(new Lesson(3, "fizik", admin));
            //lessons.Add(new Lesson(8, "Math", student));



            List<Customer> customers = new List<Customer>()
            {
                new Customer{ Id=1,Name="Ahmet Suhan",Age=24,Birthdate=new DateTime(1997,1,8)},
                new Customer{ Id=2,Name="Ahmet Suhan1",Age=21,Birthdate=new DateTime(1992,5,8)},
                new Customer{ Id=3,Name="Ahmet Suhan2",Age=22,Birthdate=new DateTime(1991,6,12)},
                new Customer{ Id=4,Name="Ahmet Suhan3",Age=25,Birthdate=new DateTime(1990,2,12)},
                new Customer{ Id=5,Name="Ahmet Suhan4",Age=264,Birthdate=new DateTime(1998,4,1)},


            };

            SqlGenerator sqlGenerator = new SqlGenerator();
            var insertScript = sqlGenerator.BuidInsertScript(customers,"Customers");




            Console.ReadKey();
        }
    }
}
