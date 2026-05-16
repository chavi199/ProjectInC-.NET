
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Sale
    {
        public int Id { get; init; }
        public int ProductId { get; set; }
        public int RequiredQuantity { get; set; }
        public double PriceAfterDiscount { get; set; }
        public bool IsForClubMemberOnly { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Sale()
        {
        }

        public Sale(int id, int productId, int requiredQuantity, double priceAfterDiscount,
             bool isForClubMemberOnly, DateTime startDate, DateTime  endDate)
        {
            Id = id;
            ProductId = productId;
            RequiredQuantity = requiredQuantity;
            PriceAfterDiscount = priceAfterDiscount;
            IsForClubMemberOnly = isForClubMemberOnly;
            StartDate = startDate;
            EndDate = endDate;
        }
        public override string ToString() => this.ToStringProperty();
    }
}
