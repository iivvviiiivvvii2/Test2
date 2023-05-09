using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class TaskClass
    {
        public void Start()
        {
           const int masSize = 10;
           
            EnumerableType enumerableType = new EnumerableType();
            
            ResaltSum resaltSum = new ResaltSum();
          
                MasClass<double> masClass = new MasClass<double>(masSize);
                double[] mas = RandomDouble.RandomDouble_(masClass.values, masSize);
                Show.ShowMas(mas);

              
                IEnumerable<double> resaltDoubles = enumerableType.EnumerableDouble(mas);
              
                IEnumerable<double> resalt = resaltSum.GetRowSums(resaltDoubles);
                Console.WriteLine(new String('-', 100));

                Show.ShowMas(resalt);

        }
    }
}
