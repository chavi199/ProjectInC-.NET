using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    internal class DalExceptions:Exception
    {

        public class DalIdNotExsist: Exception
        {
            public DalIdNotExsist(string? message):base(message) { }

            public DalIdNotExsist(string? message, Exception? innerException) : base(message, innerException) { }

        }
        public class DalIdAlreadyExsist : Exception 
        {
            public DalIdAlreadyExsist(string? message) : base(message) { }

            public DalIdAlreadyExsist(string? message, Exception? innerException) : base(message, innerException) { }

        }


    }
}
