using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Sale(
        int Id,
        int ProductId, 
        int RequiredQuantity,
        int PriceAfterDiscount,
        bool IsForClubMemberOnly,
        DateTime StartDate,
        DateTime EndDate
        )
    {
        public Sale():this(0,0,1,0,true,DateTime.Now, DateTime.Now)//TODO
        {
            
        }
    }
}
