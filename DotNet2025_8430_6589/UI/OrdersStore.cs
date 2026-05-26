using System.Collections.Generic;
using System.Linq;

namespace UI
{
    internal static class OrdersStore
    {
        private static readonly object _lock = new();
        private static readonly List<BO.Order> _orders = new();

        // Add order (a clone is stored to avoid later mutation by UI)
        public static void Add(BO.Order order)
        {
            if (order == null) return;
            lock (_lock)
            {
                _orders.Add(CloneOrder(order));
            }
        }

        // Read all stored orders (returns clones)
        public static List<BO.Order> ReadAll()
        {
            lock (_lock)
            {
                return _orders.Select(CloneOrder).ToList();
            }
        }

        private static BO.Order CloneOrder(BO.Order src)
        {
            if (src == null) return null!;
            return new BO.Order
            {
                IsPreferredCustomer = src.IsPreferredCustomer,
                FinalPrice = src.FinalPrice,
                Products = src.Products?.Select(p => new BO.ProductInOrder
                {
                    ProductId = p.ProductId,
                    ProductName = p.ProductName,
                    BasePrice = p.BasePrice,
                    Quantity = p.Quantity,
                    Sales = p.Sales?.Select(s => new BO.SaleInProduct
                    {
                        SaleId = s.SaleId,
                        QuantityForSale = s.QuantityForSale,
                        IsForAllCustomers = s.IsForAllCustomers,
                        Price = s.Price
                    }).ToList() ?? new List<BO.SaleInProduct>(),
                    FinalPrice = p.FinalPrice
                }).ToList() ?? new List<BO.ProductInOrder>()
            };
        }
    }
}