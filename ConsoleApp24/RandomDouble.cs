using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
  static  internal class RandomDouble
    {
    static Random randObj = new Random();
      static  public double[] RandomDouble_(double[] mas,int a)
        {
           


            for (int i = 0; i < a; i++)
            {

                mas[i] = Convert.ToDouble(randObj.Next(110) / 10.0);

            }

            return mas;
        }

        
    }
}
