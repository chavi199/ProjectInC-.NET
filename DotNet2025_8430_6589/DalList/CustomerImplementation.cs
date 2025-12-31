
using DO;
using DalApi;
using static Dal.DalExceptions;

namespace Dal;


public class CustomerImplementation : ICustomer
{

    public int Create(Customer item)
    {
        if (!DataSource.Customers.Exists((p) => p.Id == item.Id))
        {
            DataSource.Customers.Add(item);//TODO
            return item.Id;
        }
        throw new DalIdAlreadyExsist("customers is already");
    }

    public void Delete(int id)
    {
        if (DataSource.Customers.Exists((p) => p.Id == id))
            DataSource.Customers.Remove(DataSource.Customers.Find((p) => p.Id == id));
        throw new DalIdNotExsist("customers is not exsist");
    }

    public Customer? Read(int id)
    {
        if (DataSource.Customers.Exists((p) => p.Id == id))
            return DataSource.Customers.Find((p) => p.Id == id);
        throw new DalIdNotExsist("customers is not exsist");
    }

    public List<Customer> ReadAll()
    {
        List<Customer> newCustomers = new List<Customer>(DataSource.Customers);
        return newCustomers;
        
    }

    public void Update(Customer item)
    {
        if (DataSource.Customers.Exists((p) => p.Id == item.Id))//TODO//לא צריך לחפש כי הDELETE כבר עושה...
        {
            Delete(item.Id);
            DataSource.Customers.Add(item);
        }
       
    }
}

