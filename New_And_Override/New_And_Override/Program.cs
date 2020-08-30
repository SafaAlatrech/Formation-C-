using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_And_Override
{
    class Art
    {
        virtual public void Message ()
        {
            Console.WriteLine("Art a main class");
        }
    }

    class Theatre : Art
    {
        new public void Message ()
        {
            Console.WriteLine("Theatre is a derived class");
        }
    }

    class Cinema  : Art
    {
        new public void Message()
        {
            Console.WriteLine("Cinemaderived class");
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Theatre theatre = new Theatre();
            Cinema cinema = new Cinema();

            Art art = new Theatre();
            Console.WriteLine("New Comment");
            art.Message();
            Console.ReadKey();
        }
    }
}
