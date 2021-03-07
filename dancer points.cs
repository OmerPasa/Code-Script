using System;
using System.Collections.Generic;
// just posted questinon
namespace Code_Coach_Challenge
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            int points1 = Convert.ToInt32(Console.ReadLine());
            string name2 = Console.ReadLine();
            int points2 = Convert.ToInt32(Console.ReadLine());

            DancerPoints dancer1 = new DancerPoints(name1, points1);
            DancerPoints dancer2 = new DancerPoints(name2, points2);

            DancerPoints total = dancer1 + dancer2;
            Console.WriteLine(total.name);
            Console.WriteLine(total.points);
        }
    }

    class DancerPoints
    {
        public string name;// you can change name and point to something else :D 
        public int points;
        public DancerPoints(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        //overload the + operator
        public static DancerPoints operator+ (DancerPoints n, DancerPoints p)
        {

            string name = n.name + " & " + p.name;
            int points = n.points + p.points;
            DancerPoints res = new DancerPoints(name, points);

            return res;
            
            //DancerPoints( name1 + "&" + name2 = name , points1 + points2 = points);
        }
    }
}

/*

public static DancerPoints operator+ (DancerPoints a, DancerPoints b)
        {
            string name = a.name + "&" + b.name;
            int points = a.points + b.points;

            DancerPoints res = new DancerPoints(name, points)

            return res;
        }

public static Box operator+ (Box b, Box c)
{
   Box box = new Box();
   
   box.length = b.length + c.length;
   
   box.breadth = b.breadth + c.breadth;
  
   return box;
}



input 

Dave
8
Jessica
7

output
Dave & Jessica
15
*/