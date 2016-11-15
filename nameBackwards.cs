using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace messin
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName     = "Christopher";
            int lengthCounter    = firstName.Length;
            var backwardsName    = "";
            int[] backwardsArray = new int[] { };
            for (int i = 0; i < firstName.Length; i++)
            {
                lengthCounter--;
                backwardsName += firstName[lengthCounter];
                
            }
            Console.Write(backwardsName);
            Console.ReadLine();
        }
    }
}


