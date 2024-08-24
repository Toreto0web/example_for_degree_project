using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_for_degree_project
{
    class Program
    {
        public static void Main()
        {
            // Instance 1 of Logger used by UserManager
            Logger logger1 = new Logger();
            UserManager userManager = new UserManager(logger1);
            userManager.CreateUser("Alice");

            // Instance 2 of Logger used by OrderManager
            Logger logger2 = new Logger();
            OrderManager orderManager = new OrderManager(logger2);
            orderManager.CreateOrder(1234);

            // Show logs from both loggers
            Console.WriteLine("\nLogger 1 Entries:");
            logger1.ShowLog();  // Only shows logs related to UserManager

            Console.WriteLine("\nLogger 2 Entries:");
            logger2.ShowLog();  // Only shows logs related to OrderManager
        }
    }
}
