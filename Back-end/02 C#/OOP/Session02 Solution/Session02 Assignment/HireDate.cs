using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Session02_Assignment
{
 
    internal class HireDate
    {
        public int Day {  get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HireDate(int _day, int _month, int _year)
        {
            if (_day < 1 || _day > 30)

                throw new ArgumentOutOfRangeException(nameof(_day), "Day must be between 1 and 31.");

            if (_month < 1 || _month > 12)
                throw new ArgumentOutOfRangeException(nameof(_month), "Month must be between 1 and 12.");

            if (_year < 1900 || _year > DateTime.Now.Year)
                throw new ArgumentOutOfRangeException(nameof(_year), "Year must be realistic.");

            Day = _day;
            Month = _month;
            Year = _year;
        }
        public override string ToString()
        {
            return $"Day: {Day}, Month:{Month}, Year:{Year}\n";
        }
    }
}
