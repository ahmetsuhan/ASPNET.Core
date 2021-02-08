using Abstract_Interface.Abstract.Sample3.Factory;
using Abstract_Interface.Interface.Sample3.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Interface.Interface.Sample3.Factory
{
    public class CreateLoggerFactory : ICreateLoggerFactory
    {
        public LogType logType { get; set; }

        public CreateLoggerFactory(LogType logType)
        {
            this.logType = logType;
        }

        public ILog CreateLogger()
        {
            ILog logFactory = null;
            switch (logType)
            {
                case LogType.None:

                    break;
                case LogType.Sql:
                    logFactory = new SqlLog();
                    break;
                case LogType.File:
                    logFactory = new FileLog();
                    break;
                default:
                    break;
            }
            return logFactory;
        }
    }
    public interface ICreateLoggerFactory
    {
        LogType logType { get; set; }
        ILog CreateLogger();
       
    }
}
