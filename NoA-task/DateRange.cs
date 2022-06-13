using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NoA_task
{
    public class DateRange
    {
        private DateTime _start { get; init; }
        private DateTime _end { get; init; }
        public CultureInfo culture { get; init; }
        public DateRange(DateTime start, DateTime end )
        {
            if (start > end)
            {
                _start = end;
                _end = start;
            }
            else
            {
                _start = start;
                _end = end;
            }
            
            culture = new CultureInfo(CultureInfo.CurrentCulture.Name);
        }

        
        public string DateFormating()
        {
            string retult = "";
            if (_start.Month == _end.Month && _start.Year == _end.Year)
            {
                retult = string.Format("{0} - {1}", _start.ToString("dd", culture), _end.ToString("d", culture));
            }
            else if ( _start.Year == _end.Year)
            {
                retult = string.Format("{0} - {1}", _start.ToString("dd/MM", culture), _end.ToString("d", culture));
            }
            else
            {
                retult = string.Format("{0} - {1}", _start.ToString("d", culture), _end.ToString("d", culture));
            }
            return retult;
        }
        
        public string DateFormatingYearFirst()
        {
            string retult = string.Format("{0} - {1}", _start.ToString("yyyy/MM/dd", culture), _end.ToString("yyyy/MM/dd", culture));
            return retult;
        }
        






    }

}
