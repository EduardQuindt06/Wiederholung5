using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.E06_Random
{
    class Exercise_3
    {
        public static void Start()
        {
            //Sorgen Sie dafür, dass eine Zufallszahl zwischen 0 und 45 ausgegeben wird.
            Random rand = new Random();
            int k;

            //Code START
            k = -1;
            //Code ENDE
            
            Console.WriteLine(rand.Next() % k);
        }
    }
}