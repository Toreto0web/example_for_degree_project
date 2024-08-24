using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_for_degree_project
{
    class UserManager
    {
        private Logger _logger;

        public UserManager(Logger logger)
        {
            _logger = logger;
        }

        public void CreateUser(string username)
        {
            // Simulate user creation
            Console.WriteLine($"User '{username}' created.");
            _logger.Log($"User '{username}' created.");
        }
    }
}
