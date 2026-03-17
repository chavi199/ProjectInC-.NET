
using DO;
using DalApi;
using System.Security.AccessControl;
//using  DO

namespace Dal;
public class CustomerImplementation : ICustomer
{

    //public int Create(Customer item)
    //{
    //    if (!DataSource.Customers.Exists((p) => p.Id == item.Id))
    //    {
    //        DataSource.Customers.Add(item);//TODO
    //        return item.Id;
    //    }
    //    throw new DalIdAlreadyExist("customers is already");
    //}
    public int Create(Customer item)
    {
        if (!DataSource.Customers.Any((p) => p.Id == item.Id))
        {
            DataSource.Customers.Add(item);
            return item.Id;
        }
        throw new DalIdAlreadyExist("customers is already");
    }

    //public void Delete(int id)
    //{
    //    if (DataSource.Customers.Exists((p) => p.Id == id))
    //        DataSource.Customers.Remove(DataSource.Customers.Find((p) => p.Id == id));
    //    throw new DalIdNotExsist("customers is not exists");
    //}
    public void Delete(int id)
    {
        var c = DataSource.Customers.FirstOrDefault(x => x.Id == id);
        if (c != null)
            DataSource.Customers.Remove(c);
        else
            throw new DalIdNotExist("customers is not exists");

    }
    public Customer? Read(int id)
    {
        var g = DataSource.Customers.FirstOrDefault((p) => p.Id == id);
        if (g != null)
            return g;
        throw new DalIdNotExist("customers is not exists");
    }

    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        if (filter != null)
            return DataSource.Customers.Where(filter).ToList();
        return new List<Customer?>(DataSource.Customers);
    }
   
    public void Update(Customer item)
    {
        Delete(item.Id);
        DataSource.Customers.Add(item);
    }
    public Customer? Read(Func<Customer, bool>? filter)
    {
        var g = DataSource.Customers.FirstOrDefault(filter);
        if (g != null)
            return g;
        throw new Exception("");////////לזכור לשאול מה לעשות עם השגיאה פה
    }

}

