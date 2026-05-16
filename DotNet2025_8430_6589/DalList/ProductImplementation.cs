namespace Dal;
using DalApi;
using DO;



public class ProductImplementation : IProduct
{
    public int Create(Product item)
    {
        if (!DataSource.Products.Any((p) => p.Id == item.Id))
        {
            Product product = item with { Id = DataSource.config.NextIndexProduct };
            DataSource.Products.Add(product);
            return product.Id;
        }
        throw new DalIdAlreadyExist("Products is already");       
    }

    public void Delete(int id)
    {
        Product product = DataSource.Products.FirstOrDefault(x => x.Id == id);
        if (product != null)
            DataSource.Products.Remove(product);
        else
            throw new DalIdNotExist("Products is not exists");
    }

    public Product? Read(int id)
    {
        Product product = DataSource.Products.FirstOrDefault((p) => p.Id == id);
        if (product != null)
            return product;
        throw new DalIdNotExist("Products is not exists");
           }

    public Product? Read(Func<Product, bool>? filter)
    {
        Product product = DataSource.Products.FirstOrDefault(p => filter(p));
        if (product != null)
            return product;
        throw new DalIdNotExist("Products is not exists");
    }
   
    public List<Product?> ReadAll(Func<Product, bool>? filter = null)//////
    {

        if (filter != null)
            return DataSource.Products.Where(filter).ToList();
        return new List<Product?>(DataSource.Products);
    }

    public void Update(Product item)
    {

        Delete(item.Id);
        DataSource.Products.Add(item);
        
    }



}

