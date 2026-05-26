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
            int myId = Config.ProductNum;
            XElement productsList = XElement.Load(productXmlPath);
            productsList.Add(new XElement("Product",
                new XElement("Id", myId),
                 new XElement("Name", item.Name),
                  new XElement("category", item.Category),
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

            // המקור שלך חיפש את ה-Id הפנימי. כאן שינינו לחיפוש אלמנט ה-Product השלם:
            XElement product = productsList.Elements("Product").FirstOrDefault(p => (int?)p.Element("Id") == item.Id);

            if (product != null)
            {
                // מחקנו את השורה שעדכנה את ה-Id של עצמו (שגרמה ל-NullReferenceException)
                product.Element("Name").SetValue(item.Name);
                product.Element("category").SetValue(item.Category);
                product.Element("Price").SetValue(item.Price);
                product.Element("Amount").SetValue(item.Amount);
                productsList.Save(productXmlPath);

            }
            else
                throw new DalIdNotExist($"Product with id:{item.Id} is not exists");
        }
    }
}
//using DalApi;
//using DO;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace Dal
//{
//    internal class ProductImplementation : IProduct
//    {
//        readonly string productXmlPath = @"..\xml\products.xml";


//        public int Create(Product item)
//        {
//            int myId = Config.ProductNum;
//            XElement productsList = XElement.Load(productXmlPath);
//            productsList.Add(new XElement("Product",
//                new XElement("Id", myId),
//                 new XElement("Name", item.Name),
//                  new XElement("category", item.Category),
//                  new XElement("Price", item.Price),
//                   new XElement("Amount", item.Amount)));

//            productsList.Save(productXmlPath);

//            return myId;
//        }

//        public void Delete(int id)
//        {
//            XElement productsList = XElement.Load(productXmlPath);
//            XElement? product = productsList.Elements("Product")
//                .FirstOrDefault(p => (int?)p.Element("Id") == id);
//            if (product != null)
//            {
//                product.Remove();
//                productsList.Save(productXmlPath);
//            }
//            else
//                throw new DalIdNotExist("product is not exists");
//        }

//        public Product? Read(int id)
//        {
//            XElement productsList = XElement.Load(productXmlPath);
//            XElement? product = productsList.Elements("Product")
//            .FirstOrDefault(p => (int?)p.Element("Id") == id);
//            if (product != null)
//            {
//                return new Product(int.Parse(product.Element("Id").Value)
//                    , product.Element("Name").Value,
//                     (Category)Enum.Parse(typeof(Category), (string)product.Element("category")!)
//                    , double.Parse(product.Element("Price").Value)
//                    , int.Parse(product.Element("Amount").Value));

//            }
//            else
//                throw new DalIdNotExist($"Product with id:{id} is not exists");
//        }

//        public Product? Read(Func<Product, bool>? filter)
//        {
//            List<Product> products = ReadAll();
//            Product product = products.FirstOrDefault(p => filter(p));
//            if (product != null)
//                return product;
//            else throw new DalIdNotExist("Product is not exists");
//        }

//        public List<Product> ReadAll(Func<Product, bool>? filter = null)
//        {
//            XElement productsList = XElement.Load(productXmlPath);
//            // make sure we enumerate only "Product" elements
//            List<Product> products = productsList.Elements("Product")
//                .Select(product =>
//                {
//                    var idElem = product.Element("Id");
//                    var nameElem = product.Element("Name");
//                    var categoryElem = product.Element("category");
//                    var priceElem = product.Element("Price");
//                    var amountElem = product.Element("Amount");

//                    // skip invalid entries
//                    if (idElem == null || nameElem == null || categoryElem == null || priceElem == null || amountElem == null)
//                        return null;

//                    return new Product(int.Parse(idElem.Value)
//                                      , nameElem.Value
//                                       , (Category)Enum.Parse(typeof(Category), (string)categoryElem.Value)
//                                       , double.Parse(priceElem.Value)
//                                       , int.Parse(amountElem.Value));
//                })
//                .Where(p => p != null)
//                .Select(p => p!)
//                .ToList();

//            if (filter != null)
//            {
//                return products.Where(filter).ToList();
//            }
//            return products;
//        }

//        public void Update(Product item)
//        {
//            XElement productsList = XElement.Load(productXmlPath);
//            // find the enclosing <Product> element (not the <Id> element)
//            XElement? productElem = productsList.Elements("Product")
//                .FirstOrDefault(p => (int?)p.Element("Id") == item.Id);

//            if (productElem != null)
//            {
//                // ensure elements exist or add them, then set values
//                var idElem = productElem.Element("Id");
//                if (idElem == null) { productElem.Add(new XElement("Id", item.Id)); }
//                else idElem.SetValue(item.Id);

//                var nameElem = productElem.Element("Name");
//                if (nameElem == null) { productElem.Add(new XElement("Name", item.Name)); }
//                else nameElem.SetValue(item.Name);

//                var catElem = productElem.Element("category");
//                if (catElem == null) { productElem.Add(new XElement("category", item.Category)); }
//                else catElem.SetValue(item.Category);

//                var priceElem = productElem.Element("Price");
//                if (priceElem == null) { productElem.Add(new XElement("Price", item.Price)); }
//                else priceElem.SetValue(item.Price);

//                var amountElem = productElem.Element("Amount");
//                if (amountElem == null) { productElem.Add(new XElement("Amount", item.Amount)); }
//                else amountElem.SetValue(item.Amount);

//                productsList.Save(productXmlPath);
//            }
//            else
//                throw new DalIdNotExist($"Product with id:{item.Id} is not exists");
//        }
//    }
//}