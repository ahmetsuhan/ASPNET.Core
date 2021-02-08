using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Interface.Abstract.Sample2
{
    public abstract class Basephone
    {
        public Basephone()
        {
            ShowInfo();
            Test();
        }
        public virtual void ShowInfo()
        {
            Console.Write("BasePhone ShowInfo()");
        }
        public void Test()
        {
            Console.WriteLine("I'm Test");
        }
    }

    public class IPhone:Basephone
    {
        public IPhone()
        {
           
        }
        public override void ShowInfo()
        {
            Console.WriteLine("IPhone 12");
        }
    }

    public class Android : Basephone
    {
        public Android()
        {
         
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Android Oreo");
        }
    }
}
