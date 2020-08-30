using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Text_manipulation
    {
        public static string TextCase(string Text)
        {
            if (Text == Text.ToUpper())
            {
                return "l'ecriture est majiscule";
            }
            else if (Text == Text.ToLower())
            {
                return "l'ecriture est miniscule";
            } else
                { 
                
                    return " Your text is mixed";
                }

            }

        public string TextLength (string Text) 
            {

            return string.Format("your text Length is : {0} ", Text.Length);

            }
}


        class Program
    {
        public delegate string myDelagte(string Text);
        static void Main(string[] args)
        {
            Text_manipulation tm = new Text_manipulation();
            myDelagte firstDelegate = new myDelagte(tm.TextLength);
            myDelagte secondDelegate = Text_manipulation.TextCase;

            Console.WriteLine("Enter a string value ");
            string text = Console.ReadLine();
            Console.WriteLine(firstDelegate(text));
            Console.WriteLine(secondDelegate(text));
            Console.Read();
        }
    }
}
