using Abstract_Interface.Interface.Sample3.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Interface.Interface.Sample3
{
    public class SqlLog : ILog
    {
        public void ReadLog()
        {
            throw new NotImplementedException();
        }

        public void WriteErrorLog()
        {
            throw new NotImplementedException();
        }

        public void WriteLog()
        {
            throw new NotImplementedException();
        }
    }
}
