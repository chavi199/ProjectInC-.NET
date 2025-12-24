

using DO;
using System.Data.Common;

namespace DalApi;

public interface ICustomer
{
    int Create(Customer item);
    Customer? Read(int id);
    List<Customer> ReadAll();
    void Update(Customer item);
    void Delete(int id);

}
