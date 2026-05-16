using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Product(
       int Id,
       string Name,
       Category  Category ,
       double Price,
       int Amount
        )

    {

        public Product() : this(0, "", Category.bracelet, 200.0, 100)
        {

        }
    }
}
