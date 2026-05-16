using BO;

namespace BO
{
    public class Order
    {
        public bool IsPreferredCustomer { get; set; }
        public List<ProductInOrder> Products { get; set; }
        public double FinalPrice { get; set; }
        public Order()
        {
        }

        public Order(bool isPreferredCustomer, List<ProductInOrder> products, double finalPrice)
        {
            IsPreferredCustomer = isPreferredCustomer;
            Products = products;
            FinalPrice = finalPrice;
        }
        public override string ToString() => this.ToStringProperty();
    }
}