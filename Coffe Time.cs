using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int discount = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, int> coffee = new Dictionary<string, int>();
            coffee.Add("Americano", 50);
            coffee.Add("Latte", 70);
            coffee.Add("Flat White", 60);
            coffee.Add("Espresso", 60);
            coffee.Add("Cappuccino", 80);
            coffee.Add("Mocha", 90);

            foreach (string cf in coffee.Keys.ToArray())  
            {
                coffee[cf] -= (coffee[cf]*discount)/100;
                Console.WriteLine(cf+": "+coffee[cf]); 
                
            }

            foreach (string cf in coffee.Keys.ToArray()) 
            {
                a = coffee[cf] * discount;
                a = a / 100;
                coffee[cf] -= a;
                Console.WriteLine("Value; {0}", coffee[cf]);
                
            }
            // because of complier limitations attempt down below unsuccesful. :(
            Dictionary<string, int>.ValueCollection values = coffee.Values;  
            foreach (int val in values)  
            {
                a = val * discount;
                a = a / 100;
                val -= a;
                Console.WriteLine("Value; {0}", val);
                
            }










        }
    }
}