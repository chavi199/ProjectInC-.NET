using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    internal record Product(
       int Id,
       string Name,
       Category Categor,
       double Price,
       int Amount
        )

    {

        public Product():this(1,"",Category.bracelet,200.0,100)
        {
            
        }
    }
}
