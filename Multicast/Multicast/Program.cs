using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi
{
    class Multiple
    {
        public static void sinus (int number)
        {
            Console.WriteLine(" sinus is : " + Math.Sin(number));
        }

        public static void cosinus(int number)
        {
            Console.WriteLine(" cosinus is : " + Math.Cos(number));
        }

    }
    public delegate void Mydelegate(int number);
    class Program
    {
        static void Main(string[] args)
        {
            Mydelegate D1 = Multicast.sinus;
            Mydelegate D2 = Multicast .cosinus;

            Console.WriteLine("Simple delegate";
            D1.Invoke(70);
            D2(100);

            Console.ReadLine();

        }
    }
}
