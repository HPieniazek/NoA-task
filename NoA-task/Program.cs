using System;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

namespace NoA_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Date range formating");
            Console.WriteLine("Enter a date range. (To exit enter 'x')");
           
            while (true)
            {
                var userInput = Console.ReadLine();
                string delimiter = " ";
                string[] dateParts = userInput.Split(delimiter);

                switch (userInput)
                {
                    case "x":
                        return;
                    default:
                        if (Regex.IsMatch(dateParts[0], @"^\d{4}([/.-])(\d{1,2})([/.-])(\d{1,2})") && Regex.IsMatch(dateParts[1], @"^\d{4}([/.-])(\d{1,2})([/.-])(\d{1,2})"))
                        {
                            DateTime start = DateTime.Parse(dateParts[0]);
                            DateTime end = DateTime.Parse(dateParts[1]);
                            DateRange range = new(start, end);
                            Console.WriteLine(range.DateFormatingYearFirst());
                        }
                        else if(Regex.IsMatch(dateParts[0], @"^(\d{1,2})([/.-])(\d{1,2})([/.-])\d{4}") && Regex.IsMatch(dateParts[1], @"^(\d{1,2})([/.-])(\d{1,2})([/.-])\d{4}"))    
                        {
                            DateTime start = DateTime.Parse(dateParts[0]);
                            DateTime end = DateTime.Parse(dateParts[1]);
                            DateRange range = new(start, end);
                            Console.WriteLine(range.DateFormating());
                        }
                        else
                        {
                            Console.WriteLine("Wrong date rate");
                        }
                     break;
                }
                Console.WriteLine("Enter a date or date range. (To exit enter 'x')");
                
            }


            
 
        }
    }
}
