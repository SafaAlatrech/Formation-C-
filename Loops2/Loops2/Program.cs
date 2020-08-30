using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do .. while : 
            //int number = 0;
            //do
            //{
            // Console.WriteLine("Hello");
            // number++;
            // } while (number>0 && number<5);
            // Console.ReadKey();

            //while : 

            ask:   Console.WriteLine("Whi is The first Name Alatrech ?");
            string name = Console.ReadLine();
   
            while (name != "Safa")
            {
                Console.WriteLine("false ");
                goto ask;
            }
            Console.WriteLine("True");
            Console.ReadKey();


        }

    }
}
