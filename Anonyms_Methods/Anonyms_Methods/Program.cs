using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonyms_Methods
{
    public delegate void Mydelegate();
    class Absance
        {
        public event Mydelegate AbsanceEvent;
        private int Absanted_hours;

           // Properties : 
        
        public int Absanted_hours_Property
          {
             get { return Absanted_hours;  }
             set { Absanted_hours = value;}

          }
        public Absance ( int Hours)
            {
           this.Absanted_hours = Hours;
            }

        public void VerifyAbsance (int Max_Hours)
        {
            if (Absanted_hours>Max_Hours)
            {
                // Rise event 
                AbsanceEvent();
          
            }
        }
        public void alertEvent()
        {

            Console.WriteLine("Warning!");
        }

        }


    class Program
    {
        static void Main(string[] args)
        {
            Absance Abs = new Absance(10);
            Abs.AbsanceEvent += new Mydelegate(Abs.alertEvent);
            Abs.VerifyAbsance(8);
            Console.ReadKey();
        }
    }
}
