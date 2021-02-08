using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Interface.Interface.Sample1
{
    public class Computer : IComputer
    {
        public void Compile()
        {
            throw new NotImplementedException();
        }
    }
    public class PersonelComputer : IPersonelComputer,IComputer
    {
        public void SayHello()
        {
            Console.WriteLine("Hi I'm PersonelComputer class");
        }
        public void Compile()
        {
            throw new NotImplementedException();
        }
    }

    public interface IPersonelComputer
    {
        //string Name; field cannot be assigned in interface 
        void SayHello();
    }

    public interface IComputer
    {
        void Compile();
    }
}
