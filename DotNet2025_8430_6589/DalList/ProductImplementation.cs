
using DO;
using DalApi;
using static Dal.DalExceptions;

namespace Dal;

public class ProductImplementation : IProduct
{
    public int Create(Product item)
    {
        int myId = DataSource.config.NextIndexProduct;
        Product product=item with { Id = myId };
        DataSource.Products.Add(product);
        return myId;
        
    }

    public void Delete(int id)
    {
        if (DataSource.Products.Exists((p) => p.Id == id))
            DataSource.Products.Remove(DataSource.Products.Find((p) => p.Id == id));
        throw new DalIdNotExsist("product id is not exsist");
    }

    public Product? Read(int id)
    {
        if(DataSource.Products.Exists((p)=>p.Id == id))
            return DataSource.Products.Find((p)=>p.Id == id);
        throw new DalIdNotExsist("product is not exsist");
    }

    public List<Product> ReadAll()
    {
        List<Product> newProducts = new List<Product>(DataSource.Products);
        return newProducts;

    }

    public void Update(Product item)
    {
        if (DataSource.Products.Exists((p) => p.Id ==item.Id )) { 
            Delete(item.Id);
            DataSource.Products.Add(item);
        }
    }



}

