using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Tuple
{
    class Exercise_9
    {
        //Sie sollen ein Kochbuch in einer Liste implementieren. In diesem Kochbuch steht zuerst das Produkt, dann folgt eine Liste mit Zutaten und deren Mengen. Sie sollen auch noch zusätzlich zwei weitere Methoden schreiben, dem Nutzer ein Element löschen und dem Nutzer ein Element hinzufügen lassen.
        static List<Tuple<string, List<Tuple<string,double>>>> Kochbuch = new List<Tuple<string, List<Tuple<string,double>>>>();
        public static void Start()
        {
            //Starten Sie hier und füllen Sie die Liste 'Kochbuch' mit mindesten drei Rezepten
            //Code START

            //Code ENDE
            
            Console.WriteLine("------ Gefülltes Kochbuch -----");
            ShowKochbuch();
            AddNewToKochbuch();
            Console.WriteLine("------ Zusätzliches Rezept -----");
            ShowKochbuch();
            DeleteElementFromKochbuch();
            Console.WriteLine("------ Rezept gelöscht -----");
            ShowKochbuch();
        }
        //Hier werden alle Rezepte ausgegeben
        static void ShowKochbuch()
        {
            foreach(var recipes in Kochbuch)
            {
                Console.WriteLine("*****************");
                Console.WriteLine("*** {0}", recipes.Item1);
                Console.WriteLine("*****************");
                foreach(var element in recipes.Item2)
                {
                    Console.WriteLine("- {0}: {1}", element.Item1, element.Item2);
                }
                Console.WriteLine();
            }
        }
        //In dieser Methode kann der Anwender ein Element aus dem Kochbuch löschen lassen
        static void DeleteElementFromKochbuch()
        {
            //Code START

            //Code ENDE
        }
        //In dieser Methode soll der Anwender ein Rezept hinzufügen können
        static void AddNewToKochbuch()
        {
            //Code START

            //Code ENDE
        }
    }
}