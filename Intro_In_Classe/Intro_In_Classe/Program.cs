using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_In_Classe
{
    class Car
    {
        // Filed :  
           private int ID;
           private string Color;
           private string Model;

        // Properties : 

            public int ID_Property
        {
             get { return ID; }
             set { this.ID = value; }
        }

        public string Color_Property
        {
            get { return Color; }
            set { this.Color = value; }
        }
        public string Model_Property
        {
            get { return Model; }
            set { this.Model = value; }
        }




        // Constructor : 
        public Car(int id, string color, string model)
        {
            this.ID = id;
            this.Color = color;
            this.Model = model;
        }

        public Car ()
            {}

        // Methods :
        public void Intialize (int id, string color, string model)
        {

            int ID = id;
            string Color = color;
            string Model = model;

        }
            public void sowMessage ()
            {
                Console.WriteLine("ID is {0} \n Color is {1} \n Model is {2}", ID , Color, Model );
            }

      
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(123, "Blue", "Mercdes");
            Console.WriteLine(myCar.Color_Property);
            Console.ReadKey();
          


            Console.ReadKey();

        }
    }

}
