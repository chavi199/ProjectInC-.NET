using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi
{
    public interface IOrder
    {
        List<SaleInProduct> AddProductToOrder(Order order, int productId, int quantity);
        void CalcTotalPriceForProduct(ProductInOrder product);
        void CalcTotalPrice(Order order);
        void DoOrder(Order order);
        void SearchSaleForProduct(ProductInOrder product, bool isPreferredCustomer);

    }
}
