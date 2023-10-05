using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Tuple
{
    class Exercise_7
    {
        //Sorgen Sie dafür, dass "Elementarelement" ausgegeben wird.

        public static void Start()
        {
            //Code START
            dynamic element = -1;
            //Code ENDE
            Meth(element);
            
        }

        static void Meth(dynamic tup)
        {
            int temp = tup.Item2;
            while(tup.Item1.Length <= temp || temp < 0)
            {
                if(temp < 0)
                {
                    temp *= -1;
                    continue;
                }
                temp /= 2;
            }
            for(int i = temp; i >= 0; i--)
                Console.Write(tup.Item1[i]);
            for(int i = tup.Item1.Length - 1; i > temp; i--)
                Console.Write(tup.Item1[i]);
        }
    }
}