using Dal;
using DalApi;
using DO;
using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Xml.Linq;

namespace DalTest;
internal class Program
{

    private static IDal s_dal = new Dal.DalList();
    //private static ICustomer? c_dalCustomer;
    //private static ISale? s_dalSale;


    static void Main(string[] args)
    {
        try
        {
            Initialization.Initialize();
        }
        catch (Exception ex)
        {
            Console.WriteLine("worng" + ex.Message);
        }
        PrintMainMenu();
    }
    private static void SubMenuSales()
    {
        int choice = PrintSubMenu("Sale");
        switch (choice)
        {
            case 0: UpdateSale(); SubMenuSales(); break;
            case 1: Delete<Sale>(s_dal.Sale); SubMenuSales(); break;
            case 2: Read<Sale>(s_dal.Sale); SubMenuSales(); break;
            case 3: ReadAll<Sale>(s_dal.Sale); SubMenuSales(); break;
            case 4: AddSale(); SubMenuSales(); break;

        }
    }
    private static void SubMenuProducts()
    {
        int choice = PrintSubMenu("Product");
        switch (choice)
        {
            case 0: UpdateProduct(); SubMenuProducts(); break;
            case 1: Delete<Product>(s_dal.Product); SubMenuProducts(); break;
            case 2: Read<Product>(s_dal.Product); SubMenuProducts(); break;
            case 3: ReadAll<Product>(s_dal.Product); SubMenuProducts(); break;
            case 4: AddProduct(); SubMenuProducts(); break;

        }

    }
    private static void SubMenuCustomers()
    {
        int choice = PrintSubMenu("Customer");
        switch (choice)
        {
            case 0: UpdateCustomers(); SubMenuCustomers(); break;
            case 1: Delete<Customer>(s_dal.Customer); SubMenuCustomers(); break;
            case 2: Read<Customer>(s_dal.Customer); SubMenuCustomers(); break;
            case 3: ReadAll<Customer>(s_dal.Customer); SubMenuCustomers(); break;
            case 4: AddClient(); SubMenuCustomers(); break;
        }

    }
    //private static void ProductMenu()??
    //{
    //}
    private static Product AskProduct(int code = 0)
    {

        string name;
        Category category;
        double price;
        int count;

        Console.WriteLine("Enter the Name of the product");
        name = Console.ReadLine();

        Console.WriteLine("Enter the category: between 0 to 3 ");
        int cat;
        if (!int.TryParse(Console.ReadLine(), out cat))
            category = 0;
        else
            category = (Category)cat;

        Console.WriteLine("Enter Price");
        if (!double.TryParse(Console.ReadLine(), out price))
            price = 10;

        Console.WriteLine("Enter count in stock");
        if (!int.TryParse(Console.ReadLine(), out count))
            count = 0;

        return new Product(code, name, category, price, count);
    }
    private static Sale AskSale(int code = 0)
    {
        int Id;
        int ProductId;
        int RequiredQuantity;
        int PriceAfterDiscount;
        bool IsForClubMemberOnly;
        DateTime StartDate;
        DateTime EndDate;

        Console.WriteLine("Enter the ID of the Sale");
        Id = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the ProductId ");
        int cat;
        if (!int.TryParse(Console.ReadLine(), out cat))
            ProductId = 0;
        else
            ProductId = cat;

        Console.WriteLine("Enter RequiredQuantity");
        if (!int.TryParse(Console.ReadLine(), out RequiredQuantity))
            RequiredQuantity = 10;

        Console.WriteLine("Enter PriceAfterDiscount");
        if (!int.TryParse(Console.ReadLine(), out PriceAfterDiscount))
            PriceAfterDiscount = 0;

        Console.WriteLine("Enter IsForClubMemberOnly");
        if (!bool.TryParse(Console.ReadLine(), out IsForClubMemberOnly))
            IsForClubMemberOnly = false;

        Console.WriteLine("Enter StartDate");
        if (!DateTime.TryParse(Console.ReadLine(), out StartDate))
            StartDate = DateTime.Now;
        Console.WriteLine("Enter EndDate");
        if (!DateTime.TryParse(Console.ReadLine(), out EndDate))
            EndDate = DateTime.Now;
        return new Sale(Id, ProductId, RequiredQuantity, PriceAfterDiscount
            , IsForClubMemberOnly, StartDate, EndDate);
    }
    private static Customer AskClient(int identity = 0)
    {
        int Id;
        string Name;
        string Addres;
        string Phone;

        Console.WriteLine("Enter the ID of the Customer");
        Id = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Name of the Customer");
        Name = Console.ReadLine();

        Console.WriteLine("Enter the Addres of the Customer");
        Addres = Console.ReadLine();

        Console.WriteLine("Enter the Phone of the Customer");
        Phone = Console.ReadLine();

        return new Customer(Id, Name, Addres, Phone);

    }
    private static void AddProduct()
    {
        Product pr = AskProduct();
        s_dal.Product.Create(pr);
    }
    private static void AddSale()
    {
        Sale pr = AskSale();
        s_dal.Sale.Create(pr);
    }
    private static void AddClient()
    {
        Customer cu = AskClient();
        s_dal.Customer.Create(cu);

    }
    private static void UpdateProduct()
    {
        Console.WriteLine("insert code");
        if (!int.TryParse(Console.ReadLine(), out int id)) return;
        Product pr = AskProduct(id);
        s_dal.Product.Update(pr);
    }
   private static void UpdateSale()
    {
        Console.WriteLine("insert code");
        if (!int.TryParse(Console.ReadLine(), out int id)) return;
        Sale sa = AskSale(id);
        s_dal.Sale.Update(sa);
    }
   private static void UpdateCustomers()
    {
        Console.WriteLine("insert id");
        if (!int.TryParse(Console.ReadLine(), out int id)) return;
        Customer cu = AskClient(id);
        s_dal.Customer.Update(cu);
    }

    private static void ReadAll<T>(ICrud<T> icrud)
    {
        List<T> list = icrud.ReadAll();
        foreach (T item in list)
        {
            Console.WriteLine(item);
        }

    }

    private static void Read<T>(ICrud<T> icrud)
    {
        Console.WriteLine("insert id");
        if (!int.TryParse(Console.ReadLine(), out int id)) return;
        Console.WriteLine(icrud.Read(id));

    }


    private static void Delete<T>(ICrud<T> icrud)
    {
        Console.WriteLine("insert id");
        if (!int.TryParse(Console.ReadLine(), out int id)) return;
        icrud.Delete(id);
    }

    public static void PrintMainMenu()
    {
        Console.WriteLine("menu");
        Console.WriteLine("For customer press 1");
        Console.WriteLine("For product press 2");
        Console.WriteLine("For sale press 3");
        Console.WriteLine("To exit press 0");
        int select = int.Parse(Console.ReadLine());
        while (select < 0 || select > 4)
        {
            Console.WriteLine("You have mistake, press again");
            select = int.Parse(Console.ReadLine());
        }
        switch (select)
        {
            case 1: SubMenuCustomers(); break;
            case 2: SubMenuProducts(); break;
            case 3: SubMenuSales(); break;
            case 0: break; ;
        }
    }
    public static int PrintSubMenu(string item)
    {
        Console.WriteLine($"To update {item}, press 0 ");
        Console.WriteLine($"To delete {item}, press 1 ");
        Console.WriteLine($"To read {item}, press 2 ");
        Console.WriteLine($"To readAll {item}, press 3 ");
        Console.WriteLine($"To add {item}, press 4 ");
        int select;
        int.TryParse(Console.ReadLine(), out select);
        return select;

    }

}
