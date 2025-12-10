

using DO;

namespace DalApi;

public interface IProduct
{
    int Create(Product item);
    Product? Read(int id);
    List<Product> ReadAll();
    void Update(Product item);


}
