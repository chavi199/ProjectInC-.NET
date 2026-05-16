using BlApi;
using BO;
using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    internal class OrderImplementation : IOrder
    {
        private IDal _dal = DalApi.Factory.Get;

        public void CalcTotalPriceForProduct(ProductInOrder product)
        {
            int count = product.Quantity;
            double finalPrice = 0;
            List<SaleInProduct> usedSales = new();

            foreach (var sale in product.Sales)
            {
                if (count < sale.QuantityForSale) continue;

                int timesToApply = count / sale.QuantityForSale;
                finalPrice += timesToApply * sale.Price * sale.QuantityForSale;
                count %= sale.QuantityForSale;

                usedSales.Add(sale);

                if (count == 0) break;
            }

            finalPrice += count * product.BasePrice;
            product.Sales = usedSales;
            product.FinalPrice = finalPrice;
        }

        public void CalcTotalPrice(Order order)
        {
            order.FinalPrice = order.Products.Sum(p => p.FinalPrice);
        }

        public List<SaleInProduct> AddProductToOrder(Order order, int productId, int quantity)
        {
            var doProduct = _dal.Product.Read(productId) ?? throw new Exception("Product not found");

            var productInOrder = order.Products.FirstOrDefault(p => p.ProductId == productId);

            if (productInOrder != null)
            {
                if (doProduct.Amount < productInOrder.Quantity + quantity)
                    throw new Exception("Not enough in stock");

                productInOrder.Quantity += quantity;
            }
            else
            {
                if (doProduct.Amount < quantity)
                    throw new Exception("Not enough in stock");

                productInOrder = new ProductInOrder
                {
                    ProductId = productId,
                    ProductName = doProduct.Name,
                    BasePrice = doProduct.Price,
                    Quantity = quantity,
                    Sales = new List<SaleInProduct>()
                };
                order.Products.Add(productInOrder);
            }

            SearchSaleForProduct(productInOrder, order.IsPreferredCustomer);
            CalcTotalPriceForProduct(productInOrder);
            CalcTotalPrice(order);

            return productInOrder.Sales;
        }

        public void DoOrder(Order order)
        {
            var dal = DalApi.Factory.Get;

            foreach (var product in order.Products)
            {
                var doProduct = dal.Product.Read(product.ProductId);
                if (doProduct != null)
                {
                    var updatedProduct = doProduct with { Amount = doProduct.Amount - product.Quantity };
                   dal.Product.Update(updatedProduct);
                }
            }
        }
        public void SearchSaleForProduct(ProductInOrder product, bool isPreferredCustomer)
        {
          
            product.Sales = _dal.Sale.ReadAll(s =>
                                s.ProductId == product.ProductId &&
                                s.StartDate <= DateTime.Now &&
                                s.EndDate >= DateTime.Now &&
                                product.Quantity >= s.RequiredQuantity &&
                                (!s.IsForClubMemberOnly || isPreferredCustomer))
                                .Select(s => new SaleInProduct
                                {
                                    SaleId = s.Id,
                                    QuantityForSale = s.RequiredQuantity,
                                    IsForAllCustomers = !s.IsForClubMemberOnly,
                                    Price = s.PriceAfterDiscount
                                })
                                .OrderBy(s => s.Price)
                                .ToList();
        }
    }
}
