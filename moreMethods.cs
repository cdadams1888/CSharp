using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moreMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            testMethod(firstName);
        }

        private static void testMethod(string firstName)
        {
            Console.Write("Hello {0}! This is inside of the method.", firstName);
            Console.ReadLine();
        }
    }
}
