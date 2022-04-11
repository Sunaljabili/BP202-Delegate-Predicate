using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Exceptions
{
    class CapacityLimitException:Exception
    {
        public CapacityLimitException(string message):base(message)
        {

        }
    }
}
