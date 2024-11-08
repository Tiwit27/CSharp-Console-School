using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    internal class MyException: Exception
    {
        public MyException(string message)
        {
            Console.WriteLine(message);
        }
    }
}
