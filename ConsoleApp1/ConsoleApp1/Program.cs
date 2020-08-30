using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "MY new Application";
            Console.Write("Enter your Name :");
            string name = Console.ReadLine();

            // First Way : 
            int age = int.Parse(Console.ReadLine());
            Console.Write("Hello Mm:"  + name +  "Your age :" + age );

            Console.ReadKey();

           



        }
    }
}
