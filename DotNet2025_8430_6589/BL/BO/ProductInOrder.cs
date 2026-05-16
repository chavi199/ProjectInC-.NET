
using System.Collections.Generic;
namespace BO
{
    public class ProductInOrder
    {
        public int ProductId { get; init; }
        public string ProductName { get; set; }
        public double BasePrice { get; set; }
        public int Quantity { get; set; }
        public List<SaleInProduct> Sales { get; set; }
        public double FinalPrice { get; set; }

        public ProductInOrder()
        {
        }

        public ProductInOrder(int productId, string productName, double basePrice,
                              int quantity, List<SaleInProduct> sales, double finalPrice)
        {
            ProductId = productId;
            ProductName = productName;
            BasePrice = basePrice;
            Quantity = quantity;
            Sales = sales;
            FinalPrice = finalPrice;
        }
        public override string ToString() => this.ToStringProperty();
    }
}