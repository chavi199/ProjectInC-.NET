using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using static BO.Tools;


namespace BlImplementation
{
    internal class CustomerImplementation : BlApi.ICustomer
    {
        private IDal _dal = DalApi.Factory.Get;

        public int Create(BO.Customer customer)
        {
            try
            {
                return _dal.Customer.Create(customer.ConverBOCustomerToDOCustomer());
            }
            catch (DO.DalIdAlreadyExist dae)
            {
                throw new BO.BLIdAlreadyExist($"Customer with ID {customer.Id} already exists.", dae);
            }
        }

        public void Delete(int id)
        {
            try
            {
                _dal.Customer.Delete(id);
            }
            catch (DO.DalIdNotExist dae)
            {
                throw new BO.BLIdNotExist($"Customer with ID {id} was not found.", dae);
            }
        }

        public bool IsCustomerExists(int customertId)
        {
            var customer = _dal.Customer.Read(customertId);
            return customer != null;
        }

        public BO.Customer? Read(int id)
        {
            try
            {
                return _dal.Customer.Read(id).ConverDOCustomerToBOCustomer();
            }
            catch (DO.DalIdNotExist dne)
            {
                throw new BO.BLIdAlreadyExist($"Customer with ID {id} was not found.", dne);
            }

        }

        public BO.Customer? Read(Func<BO.Customer, bool>? filter)
        {
            try
            {
                return _dal.Customer.Read(s => filter(BO.Tools.ConverDOCustomerToBOCustomer(s))).ConverDOCustomerToBOCustomer(); ;
            }
            catch (DO.DalIdNotExist dne)
            {
                throw new BO.BLIdNotExist($"Customer matching the filter was not found.", dne);
            }

        }

        public List<BO.Customer?> ReadAll(Func<BO.Customer, bool>? filter = null)
        {
            if (filter == null)
            try
            {
                return _dal.Customer.ReadAll().Select(s => s.ConverDOCustomerToBOCustomer()).ToList();
            }
            catch (DO.DalIdNotExist dne)
            {
                throw new BO.BLIdNotExist($"Customer matching the filter was not found.", dne);
            }
            else 
                try
                {
                    return _dal.Customer.ReadAll(s => filter(s.ConverDOCustomerToBOCustomer())).Select(s => s.ConverDOCustomerToBOCustomer()).ToList();
                }
                catch (DO.DalIdNotExist dne)
                {
                    throw new BO.BLIdNotExist($"Customer matching the filter was not found.", dne);
                }
        }

        public void Update(BO.Customer customer)
        {
            try
            {
                _dal.Customer.Update(customer.ConverBOCustomerToDOCustomer());
            }
            catch (DO.DalIdNotExist dne)
            {
                throw new BO.BLIdNotExist($"Customer with ID {customer.Id} was not found.", dne);
            }
        }
    }
}

