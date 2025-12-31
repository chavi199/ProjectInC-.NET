using Dal;
using DalApi;
using DO;
using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Xml.Linq;

namespace DalTest
{
    internal class Program
    {

        private static IProduct? p_dalProduct = new ProductImplementation();
        //private static ICustomer? c_dalCustomer;
        //private static ISale? s_dalSale;
        private static ICustomer? c_dalCustomer = new CustomerImplementation();
        private static ISale? s_dalSale = new SaleImplementation();

        static void Main(string[] args)
        {
            try
            {
                Initialization.Initialize(p_dalProduct, c_dalCustomer, s_dalSale);
            }
            catch (Exception ex)
            {
                Console.WriteLine("worng" + ex.Message);
            }
            PrintMainMenu();
        }
        private static void SubMenuSales(ISale s)
        {
            int choice = PrintSubMenu("Sale");
            switch (choice)
            {
                case 0: UpdateSale(s); break;
                case 1: DeleteSales(s); break;
                case 2: ReadSales(s); break;
                case 3: ReadAllSales(s); break;
                case 4: AddSale(s); break;

            }
        }
        private static void SubMenuProducts(IProduct p)
        {
            int choice = PrintSubMenu("Product");
            switch (choice)
            {
                case 0: UpdateProduct(p); break;
                case 1: DeleteProducts(p); break;
                case 2: ReadProducts(p); break;
                case 3: ReadAllProducts(p); break;
                case 4: AddProduct(p); break;

            }

        }
        private static void SubMenuCustomers(ICustomer c)
        {
            int choice = PrintSubMenu("Customer");
            switch (choice)
            {
                case 0: UpdateCustomers(c); break;
                case 1: DeleteCustomers(c); break;
                case 2: ReadCustomers(c); break;
                case 3: ReadAllCustomers(c); break;
                case 4: AddClient(c); break;

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
            return new Sale(Id,ProductId,RequiredQuantity,PriceAfterDiscount
                ,IsForClubMemberOnly,StartDate,EndDate);
        }
        private static Customer AskClient(int identity = 0)
        {
            int Id;
            string Name;
            string Addres;
            string Phone;
           
            Console.WriteLine("Enter the ID of the Sale");
            Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Name of the Costumer");
            Name = Console.ReadLine();
            
            Console.WriteLine("Enter the Addres of the Costumer");
            Addres = Console.ReadLine();
           
            Console.WriteLine("Enter the Phone of the Costumer");
            Phone = Console.ReadLine();

            return new Customer(Id,Name,Addres,Phone);

        }
        private static void AddProduct(IProduct p)
        {
            Product pr = AskProduct();
            p.Create(pr);
        }
        private static void AddSale(ISale s)
        {
            Sale pr = AskSale();
            s.Create(pr);
        }
        private static void AddClient(ICustomer c)
        {
            Customer cu = AskClient();
            c.Create(cu); 
            
        }
        private static void UpdateProduct(IProduct p)
        {
            Product pr=AskProduct();
            p.Update(pr);
        }
        private static void UpdateSale(ISale s)
        {
            Sale sa = AskSale();
            s.Update(sa);        
        }
        private static void UpdateCustomers(ICustomer c)
        {
            Customer cu=AskClient();
            c.Update(cu);
        }
        private static void ReadAllCustomers(List<Customer> Customers)
        {
        }
        private static void ReadAllSales(List<Sale> Sales)
        {
        }

        private static void ReadAllProducts(List<Product> Products)
        {
        }
        private static void ReadAllProducts(IProduct p)
        {

        }
        private static void ReadAllSales(ISale s)
        {
        }
        private static void ReadAllCustomers(ICustomer c)
        {
        }

        private static void ReadSales(ISale s)
        {

        }
        private static void ReadCustomers(ICustomer c)
        {
        }
        private static void ReadProducts(IProduct p)
        {
        }

        private static void DeleteProducts(IProduct p)
        {
            Console.WriteLine("choose id to delete");
            int i = int.Parse(Console.ReadLine());
            p.Delete(i);

        }
        private static void DeleteCustomers(ICustomer c)
        {
            Console.WriteLine("choose id to delete");
            int i = int.Parse(Console.ReadLine());
            c.Delete(i);
        }
        private static void DeleteSales(ISale s)
        {
            Console.WriteLine("choose id to delete");
            int i=int.Parse(Console.ReadLine());
            s.Delete(i);
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
                case 1: SubMenuCustomers(c_dalCustomer); break;
                case 2: SubMenuProducts(p_dalProduct); break;
                case 3: SubMenuSales(s_dalSale); break;
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





}
