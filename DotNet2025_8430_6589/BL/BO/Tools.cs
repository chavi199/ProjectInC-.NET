using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    internal static class Tools
    {
        public static string ToStringProperty<T>(this T obj)
        {
            string str = "";    
            foreach(PropertyInfo prop in obj.GetType().GetProperties())
            {
                if (prop.PropertyType.IsPrimitive 
                    || prop.PropertyType == typeof(DateTime)
                    || prop.PropertyType == typeof(string))
                    str += prop.Name + " : " + prop.GetValue(obj) + " , ";
                else
                { 
                  str += prop.Name + ": "; 
                  str += prop.GetValue(obj).ToStringProperty();
                }

            }
            return str;
        }
        public static DO.Customer ConverBOCustomerToDOCustomer(this BO.Customer customer)
        {
            return new DO.Customer(customer.Id, customer.Name, customer.Address, customer.Phone);
        }
        public static BO.Customer ConverDOCustomerToBOCustomer(this DO.Customer customer)
        {
            return new BO.Customer(customer.Id, customer.Name, customer.Address, customer.Phone);
        }
        public static DO.Product ConverBOProductToDOProduct(this BO.Product product)
        {
            return new DO.Product(product.Id, product.Name, (DO.Category)product.Category, product.Price, product.Amount);
        }

        public static BO.Product ConverDOProductToBOProduct(this DO.Product product)
        {
            return new BO.Product(product.Id, product.Name, (BO.Category)product.Category, product.Price, product.Amount);
        }


        public static DO.Sale ConverBOSaleToDOSale(this BO.Sale sale)
        {
            return new DO.Sale(sale.Id, sale.ProductId, sale.RequiredQuantity, sale.PriceAfterDiscount, sale.IsForClubMemberOnly, sale.StartDate,sale.EndDate);
        }

        public static BO.Sale ConverDOSaleToBOSale(this DO.Sale sale)
        {
            return new BO.Sale(sale.Id, sale.ProductId, sale.RequiredQuantity, sale.PriceAfterDiscount, sale.IsForClubMemberOnly, sale.StartDate, sale.EndDate);
        }





    }
}
