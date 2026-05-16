using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi;
public interface ICustomer 
{
    int Create(Customer item);
    Customer? Read(int id);
    List<Customer?> ReadAll(Func<Customer, bool>? filter = null);
    void Update(Customer item);
    void Delete(int id);
    Customer? Read(Func<Customer, bool>? filter);
    bool IsCustomerExists(int customertId);

}
