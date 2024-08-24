using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_for_degree_project
{
    class Logger
    {
        private List<string> _logEntries;

        public Logger()
        {
            _logEntries = new List<string>();
            Console.WriteLine("Logger initialized.");
        }

        public void Log(string message)
        {
            _logEntries.Add($"{DateTime.Now}: {message}");
        }

        public void ShowLog()
        {
            foreach (var entry in _logEntries)
            {
                Console.WriteLine(entry);
            }
        }
    }
}
