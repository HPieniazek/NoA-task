using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoA_task
{
    public class DateRange
    {
        private DateTime _start { get; init; }
        private DateTime _end { get; init; }
        public string separator { get; set; }
        public CultureInfo culture { get; set; }
        public DateRange(DateTime start, DateTime end )
        {
            if (start > end)
            {
                Console.WriteLine("Start date must be before end date");
            }
            _start = start;
            _end = end;
            culture = new CultureInfo(CultureInfo.CurrentCulture.Name);
        }

        
        public string DateFormating()
        {
            string retult = "";
            if (_start.Month == _end.Month && _start.Year == _end.Year)
            {
                retult = string.Format("{0} - {1} -1", _start.ToString("dd", culture), _end.ToString("d", culture));
            }
            else if ( _start.Year == _end.Year)
            {
                retult = string.Format("{0} - {1} -2", _start.ToString("dd/MM", culture), _end.ToString("d", culture));
            }
            else
            {
                retult = string.Format("{0} - {1} -3", _start.ToString("g", culture), _end.ToString("d", culture));
            }
            return retult;
        }
    }

}
