using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Customer(
        int Id,
        string Name,
        string Addres,
        string Phone)
    {
        public Customer():this(1,"dan","bb","098765432")
        {
            
        }

    }
}
