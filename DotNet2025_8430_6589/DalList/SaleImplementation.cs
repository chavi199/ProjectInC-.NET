
using DO;
using DalApi;
using static Dal.DalExceptions;
namespace Dal;

internal class SaleImplementation : ISale
{
    public int Create(Sale item)
    {
        int myId = DataSource.config.NextIndexSale;
        Sale sale = item with { Id = myId };
        DataSource.Sales.Add(sale);
        return myId;

       
    }

    public void Delete(int id)
    {
        if (DataSource.Sales.Exists((p) => p.Id == id))
            DataSource.Sales.Remove(DataSource.Sales.Find((p) => p.Id == id));
        throw new DalIdNotExsist("sale is not exsist");

    }

    public Sale? Read(int id)
    {
        if (DataSource.Sales.Exists((p) => p.Id == id))
            return DataSource.Sales.Find((p) => p.Id == id);
        throw new DalIdNotExsist("sale is not exsist");
       
    }

    public List<Sale> ReadAll()
    {
        List<Sale> newSales = new List<Sale>(DataSource.Sales);
        return newSales;

    }

    public void Update(Sale item)
    {
        if (DataSource.Sales.Exists((p) => p.Id == item.Id))
        {
            Delete(item.Id);
            DataSource.Sales.Add(item);
        }
    }
}
