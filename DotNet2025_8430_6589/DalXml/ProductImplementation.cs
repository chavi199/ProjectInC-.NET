using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dal
{
    internal class ProductImplementation : IProduct
    {
        readonly string productXmlPath = @"..\xml\products.xml";

        public int Create(Product item)
        {
            int myId = DalXml.Config.ProductNum;
            XElement productsList = XElement.Load(productXmlPath);
            productsList.Add(new XElement("Product",
                new XElement("Id", myId),
                 new XElement("Name", item.Name),
                  new XElement("category", item.category),
                  new XElement("Price", item.Price),
                   new XElement("Amount", item.Amount)));

            productsList.Save(productXmlPath);

            return myId;
        }

        public void Delete(int id)
        {
            XElement productsList = XElement.Load(productXmlPath);
            XElement product = productsList.Descendants("Id").FirstOrDefault(i => int.Parse(i.Value) == id);
            if (product != null)
            {
                product.Parent.Remove();
                productsList.Save(productXmlPath);
            }
            else
                throw new DalIdNotExist("product is not exists");
        }

        public Product? Read(int id)
        {
            XElement productsList = XElement.Load(productXmlPath);
            XElement? product = productsList.Elements("Product")
            .FirstOrDefault(p => (int?)p.Element("Id") == id);
            if (product != null)
            {
                return new Product(int.Parse(product.Element("Id").Value)
                    , product.Element("Name").Value,
                     (Category)Enum.Parse(typeof(Category), (string)product.Element("category")!)
                    , double.Parse(product.Element("Price").Value)
                    , int.Parse(product.Element("Amount").Value));

            }
            else
                throw new DalIdNotExist($"Product with id:{id} is not exists");
        }

        public Product? Read(Func<Product, bool>? filter)
        {
            List<Product> products = ReadAll();
            Product product = products.FirstOrDefault(p => filter(p));
            if (product != null)
                return product;
            else throw new DalIdNotExist("Product is not exists");
        }

        public List<Product> ReadAll(Func<Product, bool>? filter = null)
        {
            XElement productsList = XElement.Load(productXmlPath);
            List<Product> products = productsList.Elements().Select(product =>
                                      new Product(int.Parse(product.Element("Id").Value)
                                                        , product.Element("Name").Value
                                                         , (Category)Enum.Parse(typeof(Category), (string)product.Element("category")!)
                                                         , double.Parse(product.Element("Price").Value)
                                                         , int.Parse(product.Element("Amount").Value))).ToList();
            if (filter != null)
            {
                return products.Where(filter).ToList();
            }
            return products;
        }

        public void Update(Product item)
        {
            XElement productsList = XElement.Load(productXmlPath);
            XElement product = productsList.Descendants("Id").FirstOrDefault(i => int.Parse(i.Value) == item.Id);
            if (product != null)
            {
                product.Element("Id").SetValue(item.Id);
                product.Element("Name").SetValue(item.Name);
                product.Element("category").SetValue(item.category);
                product.Element("Price").SetValue(item.Price);
                product.Element("Amount").SetValue(item.Amount);
                productsList.Save(productXmlPath);

            }
            else
                throw new DalIdNotExist($"Product with id:{item.Id} is not exists");
        }
    }
}