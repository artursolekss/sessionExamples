using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExceptions
{
    class MyOwnException2 : Exception
    { 

        public void PrintError()
        {
            Console.WriteLine("Therere is the error occured");
        }

    }
}
