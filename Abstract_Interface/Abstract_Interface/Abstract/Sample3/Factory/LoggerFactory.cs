using Abstract_Interface.Abstract.Sample3.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Interface.Abstract.Sample3.Factory
{
    public enum LogType
    {
        None, 
        Sql,
        File
    }
    public class LoggerFactory
    {
        public LoggerFactory()
        {
           
           
        }

        public LogBase CreateLogger(LogType logType)
        {
            LogBase log;
            switch (logType)
            {
                case LogType.None:
                    throw new NotImplementedException();

                case LogType.Sql:
                    log = new SqlLog();
                    break;
                case LogType.File:
                    log = new FileLog();
                    break;
                default:
                    log = new SqlLog();
                    break;
            }
            return log;
        }
    }
}
