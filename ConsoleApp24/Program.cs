using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
           
            TaskClass class1 = new TaskClass();
            Task task1 = new Task(class1.Start);
            try
            {
                task1.Start();
                task1.Wait();
                
            }
            catch (AggregateException exc)
            {
                Console.WriteLine(exc.InnerException);
            }
            finally
            {
                task1.Dispose();
            }

            Console.WriteLine("End of Main");
           
        }
       
    }
}
