using System;
using Christlin.Utils;

namespace Christlin.Utils.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test 90 seconds ago.
            Console.WriteLine(PrettyDate.From(DateTime.Now.AddSeconds(-90)));
            // Test 25 minutes ago.
            Console.WriteLine(PrettyDate.From(DateTime.Now.AddMinutes(-25)));
            // Test 45 minutes ago.
            Console.WriteLine(PrettyDate.From(DateTime.Now.AddMinutes(-45)));
            // Test 4 hours ago.
            Console.WriteLine(PrettyDate.From(DateTime.Now.AddHours(-4)));
            // Test 15 days ago.
            Console.WriteLine(PrettyDate.From(DateTime.Now.AddDays(-7))); 
            // Test 150 days ago.
            Console.WriteLine(PrettyDate.From(DateTime.Now.AddDays(-150))); 
            // Test 715 days ago.
            Console.WriteLine(PrettyDate.From(DateTime.Now.AddDays(-715)));

            Console.ReadLine();
        }
    }
}
