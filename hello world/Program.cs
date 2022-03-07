using hello_world;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {/*
          //ondan küçük mü 1 den büyük mü?
            Console.WriteLine("Please enter a number 1-10:");
            var Value = Console.ReadLine();
            Int64.Parse(Value);
            Console.WriteLine(Value);
            if (int.Parse(Value) >= 1 && int.Parse(Value) <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }*/
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Write a program to count how many numbers between 1 and 100 are "divisible by 3" with no remainder.
            //Display the count on the console

            /*
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)Console.WriteLine(i);
            }
            */
            //////////////////////////////////////////////////////////////////////////////////////////////
            //Write a program and continuously ask the user to enter a number or "ok" to exit.
            //Calculate the sum of all the previously entered numbers and display it on the console.
            // check ok or not.
            //
            /*
            bool isAsking = true;
            int Total = 0;
            var ok = "ok";
            while(isAsking)
            {
                Console.WriteLine("Please insert numbers. to sum up write (ok)");
                var input = Console.ReadLine();

                if (input == "Ok" || input == "OK"  || input == "ok")
                {
                    isAsking = false;
                    Console.WriteLine("Your total Expenses: " + Total);
                    break;
                }
                Total += Int32.Parse(input);
                Console.WriteLine("This is total:" + Total);
                Console.WriteLine("This is input:" + input);
                */
            //////////////////////////////////////////////////////////////////////////////////////
            ///
            //Write a program and ask the user to enter a number.
            //Compute the factorial of the number and print it on the console.
            //For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and
            //display it as 5! = 120
            /*
            Console.Write("Enter a number: ");
            var factorial = Convert.ToInt32(Console.ReadLine());
            var fctrl = factorial--;
            var sum = fctrl;
            for (int i = factorial; i >= 1; i--)
            {
                fctrl *= i;
                Console.WriteLine("debug:"+i);
                if (i == 1)
                {
                    Console.WriteLine("factorial sum : " + sum +"! = " + fctrl);
                }
            }*/
            /////////////////////////////////////////////////////////////////////////////////////
            //Write a program that picks a random number between 1 and 10.
            //Give the user 4 chances to guess the number.
            //If the user guesses the number, display “You won"; otherwise, display “You lost".
            //(To make sure the program is behaving correctly,
            //you can display the secret number on the console first.)
            /*
            var rand = new Random();
            var solution = rand.Next(0, 10);
            for (int i = 0; i < 4; i++)
            {
                var bet = Convert.ToInt32(Console.ReadLine());
                if (bet == solution)
                {
                    Console.WriteLine("You  Won !! " + solution);
                    break;
                }
                else Console.WriteLine("You lost, please try again. ");
            }
            */
            ///////////////////////////////////////////////////////////////////////////////////////
            //Write a program and ask the user to enter a series of numbers separated by comma.
            //Find the maximum of the numbers and display it on the console.
            //For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
            /*
            var numbers = new char[5];
            var charsToRemove = new string[] { "@", ",", ".", ";", "'" };
            Console.WriteLine("Please enter 4 numbers separeted with (,)");
            var list = Console.ReadLine();
            foreach (var c in charsToRemove)// these will remove ","
            {
                list = list.Replace(c, string.Empty);
            }

            var maxNumber = list.Max();//string to bigeset number

            Console.WriteLine("Max number is: " + maxNumber);
            */
            ///////////////////////////////////////////////////////////////////////////////////////
            // A person already posted so he will upload names that liked his post 
            //If no one likes your post, it doesn't display anything.
            //If only one person likes your post, it displays: [Friend's Name] likes your post.
            //If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
            //If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.








        }
    }
}
 