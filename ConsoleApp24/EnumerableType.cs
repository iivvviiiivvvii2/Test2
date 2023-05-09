using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class EnumerableType
    {
        public IEnumerable<double> EnumerableDouble(double[] row2)
        {

            return from p in row2
                   select p; ;
        }
    }
}
