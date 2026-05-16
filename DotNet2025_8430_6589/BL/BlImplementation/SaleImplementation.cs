using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BO.Tools;
namespace BlImplementation
{
    internal class SaleImplementation : BlApi.ISale
    {
        private IDal _dal = DalApi.Factory.Get;
        public int Create(BO.Sale sale)
        {
            try
            {
                return _dal.Sale.Create(sale.ConverBOSaleToDOSale());
            }
            catch (DO.DalIdAlreadyExist dae)
            {
                throw new BO.BLIdAlreadyExist($"Sale with ID {sale.Id} already exists.", dae);
            }

        }

        public void Delete(int id)
        {
            try
            {
                _dal.Sale.Delete(id);

            }
            catch (DO.DalIdNotExist dne)
            {
                throw new BO.BLIdNotExist($"Sale with ID {id} was not found.", dne);
            }
        }

        public BO.Sale? Read(int id)
        {
            try
            {
                return _dal.Sale.Read(id).ConverDOSaleToBOSale();
            }
            catch (DO.DalIdNotExist dne)
            {
                throw new BO.BLIdNotExist($"Sale with ID {id} was not found.", dne);
            }
        }
        public BO.Sale? Read(Func<BO.Sale, bool>? filter)
        {
            try
            {
                return _dal.Sale.Read(s => filter(s.ConverDOSaleToBOSale())).ConverDOSaleToBOSale();

            }
            catch (DO.DalIdNotExist dne)
            {
                throw new BO.BLIdNotExist($"Sale matching the filter was not found", dne);
            }
        }

        public List<BO.Sale?> ReadAll(Func<BO.Sale, bool>? filter = null)
        {
            if (filter == null)
            try
            {
                return _dal.Sale.ReadAll().Select(s => s.ConverDOSaleToBOSale()).ToList();
            }
            catch (DO.DalIdNotExist dne)
            {
                throw new BO.BLIdNotExist($"Sale matching the filter was not found", dne);
            }
            try
            {
                return _dal.Sale.ReadAll(s => filter(s.ConverDOSaleToBOSale())).Select(s => s.ConverDOSaleToBOSale()).ToList(); ;

            }
            catch (DO.DalIdNotExist dne)
            {
                throw new BO.BLIdNotExist($"Sale matching the filter was not found", dne);
            }
        }

        public void Update(BO.Sale sale)
        {
            try
            {      
                _dal.Sale.Update(sale.ConverBOSaleToDOSale());
            }
            catch(DO.DalIdNotExist dne)
            {
                throw new BO.BLIdNotExist($"Sale with ID {sale.Id} was not found.", dne);
            }
        }
    }
}
