using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Tuple
{
    class Exercise_8
    {
        //Die Methode soll den Nutzer nach Strings fragen. Wenn der nutzer nichts eingibt, dann soll die Methode Start() die Methode Meth() mit den eingegebenen Werten aufrufen.
        public static void Start()
        {
            //Code START
            dynamic element = -1;
            //Code ENDE
            foreach(var item in Meth(element))
            {
                //Geben Sie hier die einzelnen Werte in dieser Form aus:
                //Haus -> 2 Selbstlaute
                //Bauer -> 3 Selbstlaute
                //Er -> 1 Selbstlaut
                //Achten Sie auf die deutsche Grammatik!

                //Code START

                //Code ENDE
            }
            
        }
        //Sorgen Sie dafür, dass die Methode eine Liste der Strings mit deren Anzahl an Selbstlauten zurück gibt:
        static List<Tuple<string,int>> Meth(List<string> stringList)
        {
            //Code START
            dynamic returnList = -1;
            //Code ENDE

            return returnList;
        }
    }
}