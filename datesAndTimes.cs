using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            dates();
        }
        private static void dates()
        {
            // code for messing with dates and times.
            DateTime myValue = DateTime.Now;
            string dateAndTime = myValue.ToString();       // displays the date and time.
            string justDate = myValue.ToShortDateString(); // displays just the date only. 
            string justTime = myValue.ToShortTimeString(); // displays just the time only.
            string dateAndTimeLonger = myValue.ToLongDateString();
            string timeLonger = myValue.ToLongTimeString();
            int justMonth = myValue.Month; // displays just the month.
            int justHour = myValue.Hour; // displays just the hour.
            /* DateTime myBirthday = new DateTime(1988, 8, 18);
            Console.WriteLine(myBirthday.ToLongDateString()); */
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
