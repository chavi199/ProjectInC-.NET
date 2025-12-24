using System.Linq.Expressions;

namespace DalTest
{
    internal class Program
    {
        static void Main(string[] args)
        { in
           
        }
        public static int printMainMenu()
        {
            Console.WriteLine("For customer press 1");
            Console.WriteLine("For product press 2");
            Console.WriteLine("For sale press 3");
            Console.WriteLine("To exit press 0");
            int select= Console.ReadLine();
            return select;
                

        }
    }
}
