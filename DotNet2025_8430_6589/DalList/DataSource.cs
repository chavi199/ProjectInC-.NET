

using DO;

namespace Dal;

internal static class DataSource
{
 internal static  List<Sale> Sales=new List<Sale>();
 internal static List<Customer> Customers = new List<Customer>();
 internal static List<Product> Products = new List<Product>();

    internal static class config
    {
        internal const int runNum = 0;
        private static int number = runNum;
        public static int nextNum { get {return number++;} }

    }









}
