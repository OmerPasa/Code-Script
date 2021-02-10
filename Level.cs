using System;
using System.Collections.Generic;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int levels = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Points(levels));
        }

        
        static int Points(int levels)
        {
            int x =0;
            for(int i=1;i<=levels;i++)
            {
            x+=i;//i yi her döngüde sayaca ekler 1+2+3+  tek tek sayıları ekler çünkü zaten iyi normal bir şekilde sayıyoruz tek eksik onu düzenli olarak toplamak bu bu işi çözüyor.
            }
            levels =x;
            return levels;
        }

    }

}