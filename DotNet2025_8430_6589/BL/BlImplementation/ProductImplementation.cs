using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BO.Tools;

namespace BlImplementation
{
    internal class ProductImplementation : BlApi.IProduct
    {
        private IDal _dal = DalApi.Factory.Get;
        public int Create(BO.Product product)
        {
            try
            {
                return _dal.Product.Create(product.ConverBOProductToDOProduct());
            }
            catch (DO.DalIdAlreadyExist dae)
            {
                throw new BO.BLIdAlreadyExist($"Product with ID {product.Id} already exists.");
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while creating the product.", ex);
            }


        }

        public void Delete(int id)
        {
            try
            {
                _dal.Product.Delete(id);

            }
            catch (DO.DalIdNotExist dne)
            {
                throw new BO.BLIdNotExist($"Product with ID {id} was not found.", dne);
            }
        }

        public BO.Product? Read(int id)
        {
            try
            {
                return _dal.Product.Read(id).ConverDOProductToBOProduct();

            }
            catch (DO.DalIdNotExist dne)
            {
                throw new BO.BLIdNotExist($"Product with ID {id} was not found.", dne);
            }
        }

        public BO.Product? Read(Func<BO.Product, bool>? filter)
        {
            try
            {
                return _dal.Product.Read(s => filter(s.ConverDOProductToBOProduct())).ConverDOProductToBOProduct();

            }
            catch (DO.DalIdNotExist dne)
            {
                throw new BO.BLIdNotExist($"Product matching the filter was not found", dne);
            }
        }

        public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null)
        {
            if (filter == null)
                try
                {
                    return _dal.Product.ReadAll().Select(s => s.ConverDOProductToBOProduct()).ToList();
                }
                catch (DO.DalIdNotExist dne)
                {
                    throw new BO.BLIdNotExist($"Product matching the filter was not found", dne);
                }
            try
            {
                return _dal.Product.ReadAll(s => filter(s.ConverDOProductToBOProduct())).Select(s => s.ConverDOProductToBOProduct()).ToList();
            }
            catch (DO.DalIdNotExist dne)
            {
                throw new BO.BLIdNotExist($"Product matching the filter was not found", dne);
            }
        }
        /// void??????
        //public List<BO.Sale> GetAllSales(BO.ProductInOrder product, bool isPreferredCustomer)
        //{
        //    return _dal.Product.ReadAll().Select(x => x.ConverDOProductToBOProduct()).Where(p => p.SalesLIst != null && p(p => p.SaleId == id && favorite)).ToList();
        //}

        public void Update(BO.Product product)
        {
            try
            {
                _dal.Product.Update(product.ConverBOProductToDOProduct());

            }
            catch (DO.DalIdNotExist dne)
            {
                throw new BO.BLIdNotExist($"Product with ID {product.Id} was not found.", dne);
            }
        }
    }
}
