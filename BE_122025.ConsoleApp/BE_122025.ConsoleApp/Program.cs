using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE_122025.ConsoleApp
{
    using System;
    using System.Threading.Tasks;
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            await Task.Delay(1000); // Simulate some async work
            Console.WriteLine("Goodbye, World!");
        }
    }
}