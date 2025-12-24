using DO;
using DalApi;
using System.Data.Common;

namespace DalTest;



public static class Initialization
{
    private static IProduct?  p_dalProduct = new ProductImplementation(new Product());
    private static ICustomer? c_dalCustomer = new CustomerImplementation(new Customer());
    private static ISale? s_dalSale = new SaleImplementation(new Sale());

    public static void CreateCustomers()
    {
        c_dalCustomer.Create(new Customer(2163, "Shira","Shamgar","02568479"));
        c_dalCustomer.Create(new Customer(2983, "Chava", "Minchat Yitschak", "02566579"));
        c_dalCustomer.Create(new Customer(3563, "Chaya Sara", "Jeremiah", "02568379"));
        c_dalCustomer.Create(new Customer(2547, "Faigi", "Mea shearim", ""));
        c_dalCustomer.Create(new Customer(4125, "Odaya", "Avi Ezri", "0556762688"));
    }
    public static void CreateProducts()
    {
        p_dalProduct.Create(new Product(0, "Link bracelet", Category.bracelet, 500.5, 30));
        p_dalProduct.Create(new Product(0, "Pearl earrings", Category.earrings, 800, 20));
        p_dalProduct.Create(new Product(0, "Diamond ring", Category.ring, 1200, 10));
        p_dalProduct.Create(new Product(0, "MK watch", Category.watch, 420, 36));
        p_dalProduct.Create(new Product(0, "Pearl necklace", Category.necklace, 800, 20));

    }
    public static void CreateSales()
    {
        s_dalSale.Create(new Sale(0, 100, 2, 300, true, DateTime.Now, new DateTime(2026, 1, 30)));
        s_dalSale.Create(new Sale(0, 101, 3, 470, true, DateTime.Now, new DateTime(2026, 2, 12)));
        s_dalSale.Create(new Sale(0, 102, 3, 560, true, DateTime.Now, new DateTime(2026, 3, 26)));
        s_dalSale.Create(new Sale(0, 103, 2, 790, false, DateTime.Now, new DateTime(2026, 1, 30)));
        s_dalSale.Create(new Sale(0, 104, 4, 860, true, DateTime.Now, new DateTime(2026, 4, 09)));

    }

    public static void Initialize()
    {
        CreateCustomers();
        CreateProducts();
        CreateSales();
    }
}
