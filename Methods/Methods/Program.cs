using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static int sum (int x , int y)
        {
            return x + y;
        }
       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First number ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter seconde number ");
            int b = Convert.ToInt32(Console.ReadLine());
            int resulat = sum (a, b);
            Console.WriteLine("The result is  " +resulat);

            Console.ReadKey();

        }
    }
}
