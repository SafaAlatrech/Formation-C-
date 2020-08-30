using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        { 
            try
            {
                int a = 89; int b = 0; Double div = a / b;

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadKey();
        }

    }
}
