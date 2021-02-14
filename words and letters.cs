using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };

            string letter = Console.ReadLine();

            int count = 0;

            var bools = Array.Exists(words, word => word.Contains(letter));

            if(bools == true)
            {
                var result = Array.FindAll(words, word => word.Contains(letter));

                foreach (var word in result)
                {
                    Console.WriteLine(word);
                }
            }
            else
            {
                Console.Write("No match");
            }
            
        }
    }
}