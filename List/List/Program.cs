using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            myList.Add(2);
            myList.Add(2);
            myList.Add(2);
            myList.Add(2);

            foreach (int n in myList)
            {
                Console.WriteLine(n);

            }
            Console.WriteLine(myList.Count);
            Console.ReadKey();

        }
}
}
