using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class ResaltSum
    {
       public IEnumerable<double> GetRowSums( IEnumerable<double> row)
        {
            var tempSum = 0.0;

            foreach (var item in row)
            {
                yield return (tempSum += item);
            }

        }
    }
}
