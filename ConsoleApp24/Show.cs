using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
   static internal class Show 
    {
        
       static public void ShowMas(IEnumerable<double> mas)
        {

            foreach (var value in mas)
            {
                Console.WriteLine(value);
            }
        }
    }
}
