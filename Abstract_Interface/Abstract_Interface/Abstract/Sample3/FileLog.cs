using Abstract_Interface.Abstract.Sample3.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Interface.Abstract.Sample3
{
    public class FileLog : LogBase
    {
        public override void ReadLog()
        {
            Console.WriteLine("File : read some log");
        }

        public override void WriteErrorLog()
        {
            Console.WriteLine("File : write error log");

        }

        public override void WriteLog()
        {
            Console.WriteLine("File : Write info log");

        }
    }
}
