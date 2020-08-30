using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_And_Enum
{


    class Program
    {
        enum Status_Marital
        {
            single,married
        }


        //struct Person
      //  {
       //     public string FullName;
         //   public int Age;
       // }

        static void Main(string[] args)
        {
            Console.WriteLine("Are you married ?" );
            string reponse = Console.ReadLine();
               
            switch(reponse)
            {
                case "yes":
                    Console.WriteLine("yes Iam  : " + Status_Marital.married);
                break;

                case "no":
                    Console.WriteLine("yes Iam  : " + Status_Marital.single);
                    break;
            }

            Console.ReadKey();

           // Person p = new Person();
           // Console.WriteLine("Enter your FullName");
           // p.FullName = Console.ReadLine();
           // Console.WriteLine("Enter your Age");
           // p.Age =int.Parse (Console.ReadLine());
           // Console.WriteLine("Your name is :  " + p.FullName + "And your age is : " + p.Age);
           // Console.ReadKey();

        }
    }
}
