using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parametrs
{
    

    class Program
  
    {
        static void myProc(ref int Number)
        {
            Number = 10;
            Console.WriteLine("The value during passing is :  "  + Number);
        }
        static void Main(string[] args)
        {
            int Num = 20;
            Console.WriteLine("The value Before passing" + Num);
            myProc ( ref Num);
           Console.WriteLine("The value After passing" + Num);
            Console.ReadKey();

        }
    }
}
