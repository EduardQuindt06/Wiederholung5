using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.E07_DateTime
{
    class Exercise_4
    {
        public static void Start()
        {
            //Sorgen Sie dafür, dass auf der Konsole die Zahl 101 ausgegeben wird.
            DateTime dt = new DateTime(1,2,3,4,5,6);
            //Code START
            
            //Code ENDE
            Console.WriteLine(dt.Day + dt.Hour);
        }
    }
}