using BlApi;
using BO;
using DalTest;

namespace BlTest
{
    internal class Program
    {
        //    private static readonly IBl s_bl = BlApi.Factory.Get();

        //    private static void Main(string[] args)
        //    {
        //        try
        //        {
        //            DalTest.Initialization.Initialize();

        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine("wrong " + ex.Message);
        //        }
        //        PrintMainMenu();
        //    }

        //    // ------------------- MENUS -------------------

        //    private static void SubMenuCustomers()
        //    {
        //        int choice = PrintSubMenu("Customer");
        //        switch (choice)
        //        {
        //            case 0: AddCustomer(); PrintMainMenu(); break;///האם לשלוח את כולן לתפריט הראשי????
        //            case 1: DeleteCustomer(); SubMenuCustomers(); break;
        //            case 2: UpdateCustomer(); SubMenuCustomers(); break;
        //            case 3: ReadCustomer(); SubMenuCustomers(); break;
        //            case 4: ReadAllCustomers(); SubMenuCustomers(); break;
        //        }
        //    }

        //    private static void SubMenuProducts()
        //    {
        //        int choice = PrintSubMenu("Product");
        //        switch (choice)
        //        {
        //            case 0: AddProduct(); PrintMainMenu(); break;///////
        //            case 1: DeleteProduct(); SubMenuProducts(); break;
        //            case 2: UpdateProduct(); SubMenuProducts(); break;
        //            case 3: ReadProduct(); SubMenuProducts(); break;
        //            case 4: ReadAllProducts(); SubMenuProducts(); break;
        //        }
        //    }

        //    private static void SubMenuSales()
        //    {
        //        int choice = PrintSubMenu("Sale");
        //        switch (choice)
        //        {
        //            case 0: AddSale(); SubMenuSales(); break;
        //            case 1: DeleteSale(); SubMenuSales(); break;
        //            case 2: UpdateSale(); SubMenuSales(); break;
        //            case 3: ReadSale(); SubMenuSales(); break;
        //            case 4: ReadAllSales(); SubMenuSales(); break;
        //        }
        //    }

        //    // ------------------- ASK OBJECTS -------------------

        //    private static BO.Customer AskCustomer(int id = 0)
        //    {
        //        Console.WriteLine("Enter ID");
        //        int Id = int.Parse(Console.ReadLine());

        //        Console.WriteLine("Enter Name");
        //        string name = Console.ReadLine();

        //        Console.WriteLine("Enter Address");
        //        string address = Console.ReadLine();

        //        Console.WriteLine("Enter Phone");
        //        string phone = Console.ReadLine();

        //        return new BO.Customer(Id, name, address, phone);
        //    }

        //    private static BO.Product AskProduct(int code = 0)
        //    {
        //        Console.WriteLine("Enter name");
        //        string name = Console.ReadLine();

        //        Console.WriteLine("Enter category");
        //        BO.Category category = (BO.Category)int.Parse(Console.ReadLine());

        //        Console.WriteLine("Enter price");
        //        double price = double.Parse(Console.ReadLine());

        //        Console.WriteLine("Enter amount");
        //        int amount = int.Parse(Console.ReadLine());

        //        return new BO.Product(code, name, category, price, amount);
        //    }

        //    private static BO.Sale AskSale(int code = 0)
        //    {
        //        Console.WriteLine("Enter ID");
        //        int id = int.Parse(Console.ReadLine());

        //        Console.WriteLine("Enter ProductId");
        //        int productId = int.Parse(Console.ReadLine());

        //        Console.WriteLine("Enter RequiredQuantity");
        //        int req = int.Parse(Console.ReadLine());

        //        Console.WriteLine("Enter PriceAfterDiscount");
        //        int price = int.Parse(Console.ReadLine());

        //        Console.WriteLine("Is for club?");
        //        bool club = bool.Parse(Console.ReadLine());

        //        Console.WriteLine("StartDate");
        //        DateTime start = DateTime.Parse(Console.ReadLine());

        //        Console.WriteLine("EndDate");
        //        DateTime end = DateTime.Parse(Console.ReadLine());

        //        return new BO.Sale(id, productId, req, price, club, start, end);
        //    }

        //    // ------------------- CUSTOMER -------------------

        //    private static void AddCustomer()
        //    {
        //        var c = AskCustomer();
        //        s_bl.Customer.Create(c);
        //    }

        //    private static void ReadCustomer()
        //    {
        //        Console.WriteLine("Enter id");
        //        if (!int.TryParse(Console.ReadLine(), out int id)) return;
        //        Console.WriteLine(s_bl.Customer.Read(id));
        //    }

        //    private static void ReadAllCustomers()
        //    {
        //        foreach (var item in s_bl.Customer.ReadAll())
        //            Console.WriteLine(item);
        //    }

        //    private static void UpdateCustomer()
        //    {
        //        Console.WriteLine("Enter id");
        //        if (!int.TryParse(Console.ReadLine(), out int id)) return;
        //        var c = AskCustomer(id);
        //        s_bl.Customer.Update(c);
        //    }

        //    private static void DeleteCustomer()
        //    {
        //        Console.WriteLine("Enter id");
        //        if (!int.TryParse(Console.ReadLine(), out int id)) return;
        //        s_bl.Customer.Delete(id);
        //    }

        //    // ------------------- PRODUCT -------------------

        //    private static void AddProduct()
        //    {
        //        var p = AskProduct();
        //        s_bl.Product.Create(p);
        //    }

        //    private static void ReadProduct()
        //    {
        //        Console.WriteLine("Enter id");
        //        if (!int.TryParse(Console.ReadLine(), out int id)) return;
        //        Console.WriteLine(s_bl.Product.Read(id));
        //    }

        //    private static void ReadAllProducts()
        //    {
        //        foreach (var item in s_bl.Product.ReadAll())
        //            Console.WriteLine(item);
        //    }

        //    private static void UpdateProduct()
        //    {
        //        Console.WriteLine("Enter id");
        //        if (!int.TryParse(Console.ReadLine(), out int id)) return;
        //        var p = AskProduct(id);
        //        s_bl.Product.Update(p);
        //    }

        //    private static void DeleteProduct()
        //    {
        //        Console.WriteLine("Enter id");
        //        if (!int.TryParse(Console.ReadLine(), out int id)) return;
        //        s_bl.Product.Delete(id);
        //    }

        //    // ------------------- SALE -------------------

        //    private static void AddSale()
        //    {
        //        var s = AskSale();
        //        s_bl.Sale.Create(s);
        //    }

        //    private static void ReadSale()
        //    {
        //        Console.WriteLine("Enter id");
        //        if (!int.TryParse(Console.ReadLine(), out int id)) return;
        //        Console.WriteLine(s_bl.Sale.Read(id));
        //    }

        //    private static void ReadAllSales()
        //    {
        //        foreach (var item in s_bl.Sale.ReadAll())
        //            Console.WriteLine(item);
        //    }

        //    private static void UpdateSale()
        //    {
        //        Console.WriteLine("Enter id");
        //        if (!int.TryParse(Console.ReadLine(), out int id)) return;
        //        var s = AskSale(id);
        //        s_bl.Sale.Update(s);
        //    }

        //    private static void DeleteSale()
        //    {
        //        Console.WriteLine("Enter id");
        //        if (!int.TryParse(Console.ReadLine(), out int id)) return;
        //        s_bl.Sale.Delete(id);
        //    }

        //    // ------------------- MAIN MENU -------------------

        //    public static void PrintMainMenu()
        //    {
        //        Console.WriteLine("menu");
        //        Console.WriteLine("Customer 1");
        //        Console.WriteLine("Product 2");
        //        Console.WriteLine("Sale 3");
        //        Console.WriteLine("Exit 0");

        //        int select = int.Parse(Console.ReadLine());

        //        switch (select)
        //        {
        //            case 1: SubMenuCustomers(); break;
        //            case 2: SubMenuProducts(); break;
        //            case 3: SubMenuSales(); break;
        //            case 0: break;
        //        }
        //    }

        //    public static int PrintSubMenu(string item)
        //    {
        //        Console.WriteLine($"Add {item} - 0");
        //        Console.WriteLine($"Delete {item} - 1");
        //        Console.WriteLine($"Update {item} - 2");
        //        Console.WriteLine($"Read {item} - 3");
        //        Console.WriteLine($"ReadAll {item} - 4");


        //        int.TryParse(Console.ReadLine(), out int select);
        //        return select;
        //    }
        //}
        static readonly IBl s_bl = Factory.Get();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello customer!");

            Console.WriteLine("Insert customer ID:");
            int customerId = int.Parse(Console.ReadLine());

            if (!s_bl.Customer.IsCustomerExists(customerId))
            {
                Console.WriteLine("The customer does not exist.");
                return;
            }

            Console.WriteLine("Are you a club member?");
            Console.WriteLine("1 - Yes");
            Console.WriteLine("0 - No");

            bool club = Console.ReadLine() == "1";

            Order order = new Order()
            {
                IsPreferredCustomer = club,
                Products = new List<ProductInOrder>(),
                FinalPrice = 0
            };

            int choice;

            do
            {
                Console.WriteLine();
                Console.WriteLine("===== Order Menu =====");
                Console.WriteLine("1 - Adding a product to an order");
                Console.WriteLine("2 - Show order");
                Console.WriteLine("3 - Final price");
                Console.WriteLine("4 - Placing an order");
                Console.WriteLine("0 - Exit");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("Insert productId:");
                            int productId = int.Parse(Console.ReadLine());

                            Console.WriteLine("Insert amount:");
                            int amount = int.Parse(Console.ReadLine());

                            var sales = s_bl.Order.AddProductToOrder(order, productId, amount);

                            Console.WriteLine("The product has been added to the order.");

                            if (sales != null && sales.Count > 0)
                            {
                                Console.WriteLine("Deals found:");

                                foreach (var sale in sales)
                                {
                                    Console.WriteLine($"Sale ID: {sale.SaleId}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("There are no promotions for this product.");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 2:
                        Console.WriteLine("===== Order =====");

                        if (order.Products == null || order.Products.Count == 0)
                        {
                            Console.WriteLine("No products in the order");
                            break;
                        }

                        foreach (var item in order.Products)
                        {
                            Console.WriteLine($"Product ID: {item.ProductId}");
                            Console.WriteLine($"Product Name: {item.ProductName}");
                            Console.WriteLine($"Quantity: {item.Quantity}");
                            Console.WriteLine($"BasePrice: {item.BasePrice}");
                            Console.WriteLine($"FinalPrice: {item.FinalPrice}");

                            Console.WriteLine("Sales:");

                            if (item.Sales != null)
                            {
                                foreach (var sale in item.Sales)
                                {
                                    Console.WriteLine($"Sale ID: {sale.SaleId}");
                                }
                            }

                            Console.WriteLine();
                        }
                        break;

                    case 3:
                        Console.WriteLine($"Final price for the order: {order.FinalPrice}");
                        break;

                    case 4:
                        try
                        {
                            s_bl.Order.DoOrder(order);
                            Console.WriteLine("The order was placed successfully.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 0:
                        Console.WriteLine("Exit");
                        break;

                    default:
                        Console.WriteLine("Incorrect choice");
                        break;
                }

            } while (choice != 0);
        }
    }


}

