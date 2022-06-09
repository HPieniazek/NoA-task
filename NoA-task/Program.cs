using System;
using System.Globalization;

namespace NoA_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            DateTime date1 = new DateTime();
            DateTime date2 = new DateTime();
            
            string date = Console.ReadLine();
            string delimiter = " ";
            string[] dateParts = date.Split(delimiter);

            /*DateTime date11 = Convert.ToDateTime(dateParts[0]);
            Console.WriteLine(date11);*/
            date1 = DateTime.Parse(dateParts[0]);
            date2 = DateTime.Parse(dateParts[1]);

            
            DateRange range = new(date1, date2);
            Console.WriteLine(range.DateFormating());

        }

    }
}
