using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            string returnedItem = addToCart();
            Console.WriteLine("You have added an {0} to the cart!", returnedItem);
            Console.ReadLine();

        }
        static string addToCart()
        {
            Console.Write("Name of the first item that you would like to add: ");
            string itemName = Console.ReadLine();
            return itemName;
        }
    }
}
