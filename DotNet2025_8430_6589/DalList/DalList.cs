//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

using DalApi;

namespace Dal;

public class DalList : IDal
{
    public ICustomer Customer => new CustomerImplementation();

    public ISale Sale =>  new SaleImplementation();

    public IProduct Product { get => new ProductImplementation(); }
}
