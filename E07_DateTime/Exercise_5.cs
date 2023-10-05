using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.E07_DateTime
{
    class Exercise_5
    {
        public static void Start()
        {
            //Ziehen Sie von dem angegeben Datum eine Stunde ab und addieren Sie drei Tage drauf.
            DateTime dt = DateTime.Now;
            //Code START
            
            //Code ENDE
            Console.WriteLine(dt.ToString("dd.MM.yyyy hh:mm:ss"));
        }
    }
}