using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Project01
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        // Constructor
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        // Override ToString to provide a formatted string representation
        public override string ToString()
        {
            return $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}";
        }

        // Override Equals to compare Duration objects
        public override bool Equals(object obj)
        {
            if (obj is Duration other)
            {
                return Hours == other.Hours &&
                       Minutes == other.Minutes &&
                       Seconds == other.Seconds;
            }
            return false;
        }

        // Override GetHashCode to provide a hash code based on all attributes
        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
    }
}
