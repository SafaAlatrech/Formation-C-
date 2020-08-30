using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            Double Div;

            Console.WriteLine("Enter the First Number");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second Number");
            number2 = int.Parse(Console.ReadLine());

            switch ( number2 )
            {
                case 0: 
                Console.WriteLine("Cannot devide by zero ! ");
                break;

                default:
                Div = number1 / number2;
                Console.WriteLine("The result of division is : "  + Div);
                    break;
            }
            Console.ReadKey();
                
                    
        }
    }
}
