using System;
using System.IO;
using System.Collections.Generic;
using System.Data.Common;

namespace Exercises_C_Sharp.E08_If
{
    class Exercise_
    {
        public static void Start()
        {
            //Sorgen Sie dafür, dass unten "Hello World!" ausgegeben wird.

            //Code START
            dynamic b = -1;
            
            //Code ENDE
            if(b)
                Console.Write("He");

            //Code START

            //Code ENDE
            if(!b)
                Console.Write("llo");


            //Code START

            //Code ENDE
            if(b == true)
                Console.Write(" Worl");

            //Code START

            //Code ENDE
            if(b == false)
                Console.WriteLine("d!");
        }
    }
}