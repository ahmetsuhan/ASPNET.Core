using Abstract_Interface.Abstract.Sample1;
using Abstract_Interface.Abstract.Sample2;
using Abstract_Interface.Abstract.Sample3;
using Abstract_Interface.Abstract.Sample3.Abstract;
using Abstract_Interface.Abstract.Sample3.Factory;
using Abstract_Interface.Interface.Sample3.Factory;
using Abstract_Interface.Interface.Sample3.Interface;
using System;

namespace Abstract_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Sample1
            BaseNoteBook macBook = new MacBook();
            BaseNoteBook microsoftBook = new MicrosoftNoteBook();

            //wrong using, not permitted
            //BaseNoteBook baseNoteBook = new BaseNoteBook();
            /* 
            When program runs, expected output would be:
                
            Baseclass says ; Hello, I'm base"
            Drived class says ; Hi I'm MacBook drived class
            Drived class says ; Hi I'm Microsoft drived class
            */

            #endregion Sample1

            // Console.Clear();
            Console.WriteLine("***********************************");

            #region Sample2
            Basephone android = new Android();
            Basephone iPhone = new IPhone();

            /* 
           When program runs, expected output would be:

            Android Oreo
            I'm Test
            IPhone 12
            I'm Test
           */
            #endregion Sample2

            Console.WriteLine("***********************************");
            Console.Clear();

            #region Sample3
            LogBase sqlLog1 = new SqlLog();
            //sqlLog1.WriteLog();
            var logType = LogType.File;//Read from Config
            LoggerFactory loggerFactory = new LoggerFactory();
            var logInstance = loggerFactory.CreateLogger(logType);
            logInstance.WriteLog();
            #endregion Sample3


            #region Interface Sample3

            ICreateLoggerFactory IFactory = new CreateLoggerFactory(LogType.Sql);
            ILog logItem = IFactory.CreateLogger();
            logItem.ReadLog();
            logItem.WriteErrorLog();
            logItem.WriteLog();

            #endregion Interface Sample3
        }
    }
}
