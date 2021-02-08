using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Interface.Abstract.Sample1
{
    public abstract class BaseNoteBook
    {
        public BaseNoteBook()
        {
            Console.WriteLine("Baseclass says ; Hello, I'm base");
        }
    }

    public class MacBook:BaseNoteBook
    {
        public MacBook()
        {
            Console.WriteLine("Drived class says ; Hi I'm MacBook drived class");
        }
    }

    public class MicrosoftNoteBook:BaseNoteBook
    {
        public MicrosoftNoteBook()
        {
            Console.WriteLine("Drived class says ; Hi I'm Microsoft drived class");

        }
    }
}
