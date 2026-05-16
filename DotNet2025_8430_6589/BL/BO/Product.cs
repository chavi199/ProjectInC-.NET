
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public List<SaleInProduct> SalesLIst { get; set; }
        public Product()
        {
            
        }

        public Product(int id, string name, Category category, double price, int amount)
        {
            Id = id;
            Name = name;
           Category = category;
            Price = price;
            Amount = amount;
            SalesLIst = new List<SaleInProduct>();
        }
        public override string ToString() => this.ToStringProperty();
    }
}
