

using DalApi;

namespace Dal;

internal  sealed class DalList : IDal
{
    private DalList()
    {
        
    }
    private static readonly DalList instance  = new DalList();
    public static  DalList Instance { get { return instance; } }//?? readonly

    public ICustomer Customer => new CustomerImplementation();

    public ISale Sale =>  new SaleImplementation();

    public IProduct Product { get => new ProductImplementation(); }
}
