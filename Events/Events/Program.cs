using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void OrderDelegate ()  ;

    class Product
    {
        private string Label;


        private int Quantity;

        // Event defenition : 

        public event OrderDelegate orderEvent;

        // Constructor : 
        public Product(string label, int quantity)
        
        {
            this.Label = label;
            this.Quantity = quantity;
        }

        // Property : 

        public string Label_property
        {
            get { return Label; }
            set { Label = value; }

        }
        public int Quantity_property
        {
            get { return Quantity; }
            set { Quantity = value; }

        }

        public void order  (int Nbr_Products ) 
            {
            if (Nbr_Products > this.Quantity) orderEvent();
            this.Quantity = this.Quantity - Nbr_Products;
            }


        public void MessageEvent()

        {
            Console.WriteLine("The quantiti is not available");
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Product prod = new Product("Keyboard", 20);
            prod.orderEvent += new OrderDelegate(prod.MessageEvent);
            prod.order(100);
            Console.WriteLine(prod.Quantity_property);
            Console.Read();

        }
    }
}

