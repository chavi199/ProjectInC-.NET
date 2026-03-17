using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Dal
{
    internal class SaleImplementation : ISale
    {

        readonly string saleXmlPath = @"..\..\..\..\xml\sales.xml";

        public int Create(Sale item)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
            List<Sale> saleList = new List<Sale>();
            int myId = DalXml.Config.SaleNum;
            var newItem = item with { Id = myId };
            using (StreamReader sr = new StreamReader(saleXmlPath))
            {
                saleList = serializer.Deserialize(sr) as List<Sale>;
            }
            saleList.Add(newItem);
            using (StreamWriter sw = new StreamWriter(saleXmlPath))
            {
                serializer.Serialize(sw, saleList);
            }

            return newItem.Id;
        }


        public void Delete(int id)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
            List<Sale> SaleList = new List<Sale>();
            using (StreamReader sr = new StreamReader(saleXmlPath))
            {

                SaleList = serializer.Deserialize(sr) as List<Sale>;
            }
            Sale sale = SaleList.FirstOrDefault(s => s.Id == id);
            if (sale != null)
            {
                SaleList.Remove(sale);
                using (StreamWriter sw = new StreamWriter(saleXmlPath))
                {
                    serializer.Serialize(sw, SaleList);
                }
            }
            else
            {
                throw new DalIdAlreadyExist($"Sale with id:{id} is not exists");
            }
        }

        public Sale? Read(int id)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
            List<Sale> SaleList = new List<Sale>();
            using (StreamReader sr = new StreamReader(saleXmlPath))
            {

                SaleList = serializer.Deserialize(sr) as List<Sale>;
            }
            Sale sale = SaleList.FirstOrDefault(s => s.Id == id);
            if (sale != null)
                return sale;
            else
                throw new DalIdNotExist($"Sale with id:{id}is not exists");
        }

        public Sale? Read(Func<Sale, bool>? filter)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
            List<Sale> SaleList = new List<Sale>();
            using (StreamReader sr = new StreamReader(saleXmlPath))
            {

                SaleList = serializer.Deserialize(sr) as List<Sale>;
            }
            Sale sale = SaleList.FirstOrDefault(filter);
            if (sale != null)
                return sale;
            else
                throw new DalIdNotExist($"Sale with this filter is not exists");
        }

        public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
            List<Sale> SaleList = new List<Sale>();
            using (StreamReader sr = new StreamReader(saleXmlPath))
            {

                SaleList = serializer.Deserialize(sr) as List<Sale>;
            }

            if (filter != null)
                return SaleList.Where<Sale>(filter).ToList();
            return SaleList;

        }

        public void Update(Sale item)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
            List<Sale> SaleList = new List<Sale>();
            using (StreamReader sr = new StreamReader(saleXmlPath))
            {
                SaleList = serializer.Deserialize(sr) as List<Sale>;
            }
            if (!SaleList.Exists(c => c.Id == item.Id))
            {
                SaleList.Remove(SaleList.Find(c => c.Id == item.Id));
                SaleList.Add(item);
                using (StreamWriter sw = new StreamWriter(saleXmlPath))
                {
                    serializer.Serialize(sw, SaleList);
                }

            }

            else
                throw new DalIdAlreadyExist($"Sale with id:{item.Id} was not found");

        }
    }
}


