
using System.Collections.Generic;
namespace BO
{
    public class SaleInProduct
    {
        public int SaleId { get; init; }
        public int QuantityForSale { get; set; }
        public double Price { get; set; }
        public bool IsForAllCustomers { get; set; }

        public SaleInProduct()
        {
        }

        public SaleInProduct(int saleId, int quantityForSale, double price, bool isForAllCustomers)
        {
            SaleId = saleId;
            QuantityForSale = quantityForSale;
            Price = price;
            IsForAllCustomers = isForAllCustomers;
        }
        public override string ToString() => this.ToStringProperty();
    }
}