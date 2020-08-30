using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Interfaces
{
    interface Quadrangle
    {
        int Width { set; get; }
        int Height { set; get; }
        float Area();

    }

    class Rectangle : Quadrangle
    {
        private Width;
        private Heigth ;
    }

            // Constructor with parametrs : 
             
        public Rectangle(int width, int height)

        {
            this.Width = width;
            this.Height = height;

        }

        public Rectangle ()
          {}
        int Quadrangle.Width
        {
            get { return this.width; }
            set { this.width = Value; }
          
            

        }
        int Quadrangle.Height
        {
            get { return this.height; }
            set { this.height = Value; }
           
         float Quadrangle.Area()
        {
             return this.height * this.width;
        }

        }






    } 
      
    class Program
    {
        static void Main(string[] args)
        {
           Quadrangle Q = new Rectangle(10,20);

        float CalculArea = Q.Area();
        Console.WriteLine(CalculArea);
        Console.ReadKey();

        }
    }

