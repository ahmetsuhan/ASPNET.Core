using Abstract_Interface.Abstract.Sample3.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Interface.Abstract.Sample3
{
    public class SqlLog : LogBase
    {
        public override void ReadLog()
        {
            Console.WriteLine("SQL : read some log");
        }

        public override void WriteErrorLog()
        {
            Console.WriteLine("SQL : write error log");

        }

        public override void WriteLog()
        {
            Console.WriteLine("SQL : Write info log");

        }
    }
}
