
using DO;
using DalApi;
namespace Dal;
internal static class DataSource
{
 internal static  List<Sale?> Sales=new List<Sale?>();
 internal static List<Customer?> Customers = new List<Customer?>();
 internal static List<Product?> Products = new List<Product?>();

    internal static class config
    {
        internal const int SaleMinCode = 0;
        internal const int  ProductMinCode = 100;
        private static int SaleIndex = SaleMinCode;
        private static int ProductIndex = ProductMinCode;
        public static int NextIndexSale { get {return SaleIndex++;} }
        public static int NextIndexProduct => ProductIndex++;

    }

}
