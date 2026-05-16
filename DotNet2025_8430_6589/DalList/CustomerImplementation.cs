
using DO;
using DalApi;
using System.Security.AccessControl;

namespace Dal;
public class CustomerImplementation : ICustomer
{
    public int Create(Customer item)
    {
        if (!DataSource.Customers.Any((p) => p.Id == item.Id))
        {
            DataSource.Customers.Add(item);
            return item.Id;
        }
        throw new DalIdAlreadyExist("Customers is already");
    }
    public void Delete(int id)
    {
         Customer customer = DataSource.Customers.FirstOrDefault(x => x.Id == id);
        if (customer != null)
            DataSource.Customers.Remove(customer);
        else
            throw new DalIdNotExist("Customers is not exists");
    }
    public Customer? Read(int id)
    {
        //Customer customer = DataSource.Customers.FirstOrDefault(p => p.Id == id);
        Customer customer = DataSource.Customers.FirstOrDefault(p => p.Id == id);
        if (customer != null)
            return customer;
        throw new DalIdNotExist("Customers is not exists");
    }

    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        if (filter != null)
            return DataSource.Customers.Where(filter).ToList();////
        return new List<Customer?>(DataSource.Customers);
    }
   
    public void Update(Customer item)
    {
        Delete(item.Id);
        DataSource.Customers.Add(item);
    }
    public Customer? Read(Func<Customer, bool>? filter)
    {
        Customer customer = DataSource.Customers.FirstOrDefault(c=> filter(c));
        if (customer != null)
            return customer;
        throw new DalIdNotExist("Customers is not exists");
    }

}

