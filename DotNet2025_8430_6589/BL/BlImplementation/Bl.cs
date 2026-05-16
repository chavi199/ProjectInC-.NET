using BlApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    internal class Bl : IBl
    {
        //public IProduct Product => throw new NotImplementedException();

        //public IOrder Order => throw new NotImplementedException();

        //public ISale Sale => throw new NotImplementedException();

        //public ICustomer Customer => throw new NotImplementedException();

        public IProduct Product => new ProductImplementation();
        public IOrder Order => new OrderImplementation();
        public ISale Sale => new SaleImplementation();
        public ICustomer Customer => new CustomerImplementation();
    }
}
