using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyNumberCalc.Utils
{
    public class TrapezoidFuzzyNumber
    {
        public decimal BottomLeft { get; set; }
        public decimal BottomRight { get; set; }
        public decimal TopLeft { get; set; }
        public decimal TopRight { get; set; }


        public TrapezoidFuzzyNumber()
        {
            this.BottomLeft = this.BottomRight = this.TopLeft = this.TopRight = 0;
        }

        public bool IsValid()
        {
            if (this.BottomLeft > this.TopLeft) return false;
            if (this.TopLeft > this.TopRight) return false;
            if (this.TopRight > this.BottomRight) return false;

            return true;
        }

        public bool IsZero()
        {
            return ((this.BottomLeft * this.BottomRight <= 0));
        }

        public decimal Probability(decimal x)
        {
            if (!this.IsValid()) return -1;

            if (x <= this.BottomLeft || this.BottomRight <= x) return 0;
            if (this.TopLeft <= x && x <= this.TopRight) return 1;

            if (x < this.TopLeft)
            {
                return (x - this.BottomLeft) / (this.TopLeft - this.BottomLeft);
            }

            if (x > this.TopRight)
            {
                return (x - this.BottomRight) / (this.TopRight - this.BottomRight);
            }

            return 0;
        }

        public Interval AlphaCut(decimal y)
        {
            Interval result = new Interval();
            if (y < 0 || y > 1) return null;

            if (y == 0)
            {
                result.LowerBound = BottomLeft;
                result.UpperBound = BottomRight;
            }
            else if (y == 1)
            {
                result.LowerBound = TopLeft;
                result.UpperBound = TopRight;
            }
            else //if (0 < y && y < 1)
            {
                result.LowerBound = y * (TopLeft - BottomLeft) + BottomLeft;
                result.UpperBound = y * (TopRight - BottomRight) + BottomRight;
            }

            return result;
        }
    }
}
