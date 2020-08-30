using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] name = new string[2,3];
            name[0,0] = "Safa0";
            name[0,1] = "Safa1";
            name[0, 2] = "Safa2";
           
            name[1, 0] = "Safa3";
            name[1, 1] = "Safa4";
            name[1, 2] = "Safa5";
          


            foreach (string n in name)
            {
                Console.WriteLine("Hello" + n.ToUpper());
            }
            Console.ReadKey();
        }
    }
}
