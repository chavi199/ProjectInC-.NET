
using DO;
using DalApi;
using System.Linq;
namespace Dal;

public class SaleImplementation : ISale
{
    public int Create(Sale item)
    {
        if (!DataSource.Sales.Any((s) => s.Id == item.Id))
        {
            Sale sale = item with { Id = DataSource.config.NextIndexSale};
            DataSource.Sales.Add(sale);
            return sale.Id;
        }
        throw new DalIdAlreadyExist("Sale is already");

    }

    public void Delete(int id)
    {
        var c = DataSource.Sales.FirstOrDefault(s => s.Id == id);
        if (c != null)
            DataSource.Sales.Remove(c);
        else
            throw new DalIdNotExist("Sale is not exists");

    }

    public Sale? Read(int id)
    {
        var g = DataSource.Sales.FirstOrDefault((s) => s.Id == id);
        if (g != null)
            return g;
        throw new DalIdNotExist("Sale is not exists");

    }

    public Sale? Read(Func<Sale, bool>? filter)
    {
        Sale sale = DataSource.Sales.FirstOrDefault(s=>filter(s));
        if (sale != null)
            return sale;
        throw new DalIdNotExist("Sale is not exists");
    }

    public List<Sale> ReadAll()
    {
        List<Sale> newSales = new List<Sale>(DataSource.Sales);
        return newSales;

    }

    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        if (filter != null)
            return DataSource.Sales.Where(filter).ToList();
        return new List<Sale?>(DataSource.Sales);
    }

    public void Update(Sale item)
    {
        Delete(item.Id);
        DataSource.Sales.Add(item);
    }
}
