using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class MasClass<T>
    {
        public T[] values;

        public int A { get; set; }

     
        public MasClass(int a)
        {
            A = a;
            values = new T[A];
           
        }
    }
}
