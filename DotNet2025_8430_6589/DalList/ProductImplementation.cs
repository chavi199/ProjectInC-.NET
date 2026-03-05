
using DO;
using DalApi;
using static Dal.Exceptions;

namespace Dal;

public class ProductImplementation : IProduct
{
    //לשנות את הפונקציות פה כמו CustomerImplementation

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
        throw new DalIdNotExist("product id is not exist");
    }

    public Product? Read(int id)
    {
        if(DataSource.Products.Exists((p)=>p.Id == id))
            return DataSource.Products.Find((p)=>p.Id == id);
        throw new DalIdNotExsit("product is not exist");
    }

    public Product? Read(Func<Product, bool>? filter)///אם הפונקציה בcustomerImplemention טובה אז להעתיק לפה
    {
        throw new NotImplementedException();
    }

    public List<Product> ReadAll()
    {
        List<Product> newProducts = new List<Product>(DataSource.Products);
        return newProducts;

    }

    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        throw new NotImplementedException();
    }

    public void Update(Product item)
    {
        if (DataSource.Products.Exists((p) => p.Id ==item.Id )) { 
            Delete(item.Id);
            DataSource.Products.Add(item);
        }
    }



}

