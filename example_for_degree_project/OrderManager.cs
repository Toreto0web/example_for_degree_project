using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_for_degree_project
{
    class OrderManager
    {
        private Logger _logger;

        public OrderManager(Logger logger)
        {
            _logger = logger;
        }

        public void CreateOrder(int orderId)
        {
            // Simulate order creation
            Console.WriteLine($"Order '{orderId}' created.");
            _logger.Log($"Order '{orderId}' created.");
        }
    }
}
