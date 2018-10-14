namespace Algorithms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Realize algorithm for inserting 
    /// bits of one number to another
    /// </summary>
    public static class Algorithm
    {
        /// <summary>
        /// Insert one part of number to another
        /// in chosen position 
        /// </summary>
        /// <param name="first">source number</param>
        /// <param name="second">number for inserting</param>
        /// <param name="i">finish position</param>
        /// <param name="j">start position</param>
        /// <returns>new number</returns>
        public static int InsertNumber(int first, int second, int i, int j)
        {
            if (i > j)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (i < 0 || j < 0 || i > 31 || j > 31)
            {
                throw new ArgumentOutOfRangeException();
            }

            int mask = (2 << (i - j)) - 1;
            mask <<= i;
            first = first & ~mask;
            second = (second << i) & mask;
            return first | second;
        }
    }
}
