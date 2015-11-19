using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyNumberCalc.Utils
{
    public class CPoint
    {
        public decimal x { get; set; }
        public decimal y { get; set; }

        public CPoint()
        {
            x = y = 0;
        }

        public CPoint(decimal x, decimal y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
