using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyNumberCalc.Utils
{
    public class Interval
    {
        public decimal LowerBound { get; set; }
        public decimal UpperBound { get; set; }


        public Interval()
        {
            LowerBound = 0;
            UpperBound = 0;
        }
    }
}
