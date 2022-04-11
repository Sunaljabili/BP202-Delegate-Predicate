using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Exceptions
{
    class MedicineAlreadyExistsException:Exception
    {
        public MedicineAlreadyExistsException(string message):base(message)
        {

        }
    }
}
