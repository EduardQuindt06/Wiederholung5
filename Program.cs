using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp
{
    class Program
    {
        static List<ExerciseGroup> OptionList = new List<ExerciseGroup>();

        public static void Main()
        {
            //Zuerst schauen, ob der Speicherordner existiert
            if(!Directory.Exists("saveFolder"))
                Directory.CreateDirectory("saveFolder");


            //************************
            //*******Einleitung*******
            //************************
            ExerciseGroup beginnerElements = new ExerciseGroup()
            {
                Name = "1. Einleitung",
                ElementList = new List<ExerciseElement>()
                {
                    new ExerciseElement(){Name = "Übung 1", Method = Exercises_C_Sharp.E01_Einleitung.Exercise_1.Start},
                    new ExerciseElement(){Name = "Übung 2", Method = Exercises_C_Sharp.E01_Einleitung.Exercise_2.Start},
                    new ExerciseElement(){Name = "Übung 3", Method = Exercises_C_Sharp.E01_Einleitung.Exercise_3.Start},
                    new ExerciseElement(){Name = "Übung 4", Method = Exercises_C_Sharp.E01_Einleitung.Exercise_4.Start},
                    new ExerciseElement(){Name = "Übung 5", Method = Exercises_C_Sharp.E01_Einleitung.Exercise_5.Start}
                }
            };
            //************************
            //*******Variablen********
            //************************
            ExerciseGroup variableElements = new ExerciseGroup()
            {
                Name = "2. Variablen",
                ElementList = new List<ExerciseElement>()
                {
                    new ExerciseElement(){Name = "Übung 1", Method = Exercises_C_Sharp.E02_Variablen.Exercise_1.Start},
                    new ExerciseElement(){Name = "Übung 2", Method = Exercises_C_Sharp.E02_Variablen.Exercise_2.Start},
                    new ExerciseElement(){Name = "Übung 3", Method = Exercises_C_Sharp.E02_Variablen.Exercise_3.Start},
                    new ExerciseElement(){Name = "Übung 4", Method = Exercises_C_Sharp.E02_Variablen.Exercise_4.Start},
                    new ExerciseElement(){Name = "Übung 5", Method = Exercises_C_Sharp.E02_Variablen.Exercise_5.Start},
                    new ExerciseElement(){Name = "Übung 6", Method = Exercises_C_Sharp.E02_Variablen.Exercise_6.Start},
                    new ExerciseElement(){Name = "Übung 7", Method = Exercises_C_Sharp.E02_Variablen.Exercise_7.Start},
                    new ExerciseElement(){Name = "Übung 8", Method = Exercises_C_Sharp.E02_Variablen.Exercise_8.Start},
                    new ExerciseElement(){Name = "Übung 9", Method = Exercises_C_Sharp.E02_Variablen.Exercise_9.Start}
                }
            };
            //************************
            //********Strings*********
            //************************
            ExerciseGroup stringElements = new ExerciseGroup()
            {
                Name = "3. Strings",
                ElementList = new List<ExerciseElement>()
                {
                    new ExerciseElement(){Name = "Übung 1", Method = Exercises_C_Sharp.E03_Strings.Exercise_1.Start},
                    new ExerciseElement(){Name = "Übung 2", Method = Exercises_C_Sharp.E03_Strings.Exercise_2.Start},
                    new ExerciseElement(){Name = "Übung 3", Method = Exercises_C_Sharp.E03_Strings.Exercise_3.Start},
                    new ExerciseElement(){Name = "Übung 4", Method = Exercises_C_Sharp.E03_Strings.Exercise_4.Start},
                    new ExerciseElement(){Name = "Übung 5", Method = Exercises_C_Sharp.E03_Strings.Exercise_5.Start},
                    new ExerciseElement(){Name = "Übung 6", Method = Exercises_C_Sharp.E03_Strings.Exercise_6.Start},
                    new ExerciseElement(){Name = "Übung 7", Method = Exercises_C_Sharp.E03_Strings.Exercise_7.Start},
                    new ExerciseElement(){Name = "Übung 8", Method = Exercises_C_Sharp.E03_Strings.Exercise_8.Start},
                    new ExerciseElement(){Name = "Übung 9", Method = Exercises_C_Sharp.E03_Strings.Exercise_9.Start},
                    new ExerciseElement(){Name = "Übung 10", Method = Exercises_C_Sharp.E03_Strings.Exercise_10.Start},
                    new ExerciseElement(){Name = "Übung 11", Method = Exercises_C_Sharp.E03_Strings.Exercise_11.Start}
                }
            };
            //************************
            //********Konsole*********
            //************************
            ExerciseGroup terminalElements = new ExerciseGroup()
            {
                Name = "4. Konsole",
                ElementList = new List<ExerciseElement>()
                {
                    new ExerciseElement(){Name = "Übung 1", Method = Exercises_C_Sharp.E04_Konsole.Exercise_1.Start},
                    new ExerciseElement(){Name = "Übung 2", Method = Exercises_C_Sharp.E04_Konsole.Exercise_2.Start},
                    new ExerciseElement(){Name = "Übung 3", Method = Exercises_C_Sharp.E04_Konsole.Exercise_3.Start},
                    new ExerciseElement(){Name = "Übung 4", Method = Exercises_C_Sharp.E04_Konsole.Exercise_4.Start},
                    new ExerciseElement(){Name = "Übung 5", Method = Exercises_C_Sharp.E04_Konsole.Exercise_5.Start},
                    new ExerciseElement(){Name = "Übung 6", Method = Exercises_C_Sharp.E04_Konsole.Exercise_6.Start}
                }
            };
            //************************
            //********Arrays*********
            //************************
            ExerciseGroup arrayElements = new ExerciseGroup()
            {
                Name = "5. Arrays",
                ElementList = new List<ExerciseElement>()
                {
                    new ExerciseElement(){Name = "Übung 1", Method = Exercises_C_Sharp.E05_Arrays.Exercise_1.Start},
                    new ExerciseElement(){Name = "Übung 2", Method = Exercises_C_Sharp.E05_Arrays.Exercise_2.Start},
                    new ExerciseElement(){Name = "Übung 3", Method = Exercises_C_Sharp.E05_Arrays.Exercise_3.Start},
                    new ExerciseElement(){Name = "Übung 4", Method = Exercises_C_Sharp.E05_Arrays.Exercise_4.Start},
                    new ExerciseElement(){Name = "Übung 5", Method = Exercises_C_Sharp.E05_Arrays.Exercise_5.Start},
                    new ExerciseElement(){Name = "Übung 6", Method = Exercises_C_Sharp.E05_Arrays.Exercise_6.Start},
                    new ExerciseElement(){Name = "Übung 7", Method = Exercises_C_Sharp.E05_Arrays.Exercise_7.Start},
                    new ExerciseElement(){Name = "Übung 8", Method = Exercises_C_Sharp.E05_Arrays.Exercise_8.Start},
                    new ExerciseElement(){Name = "Übung 9", Method = Exercises_C_Sharp.E05_Arrays.Exercise_9.Start},
                    new ExerciseElement(){Name = "Übung 10", Method = Exercises_C_Sharp.E05_Arrays.Exercise_10.Start},
                    new ExerciseElement(){Name = "Übung 11", Method = Exercises_C_Sharp.E05_Arrays.Exercise_11.Start},
                    new ExerciseElement(){Name = "Übung 12", Method = Exercises_C_Sharp.E05_Arrays.Exercise_12.Start}
                }
            };
            
            

            //************************
            //*******Methoden*******
            //************************
            ExerciseGroup methodsElements = new ExerciseGroup()
            {
                Name = "Methoden",
                ElementList = new List<ExerciseElement>()
                {
                    new ExerciseElement(){Name = "Übung 1", Method = XX_Methods.Exercise_1.Start},
                    new ExerciseElement(){Name = "Übung 2", Method = XX_Methods.Exercise_2.Start},
                    new ExerciseElement(){Name = "Übung 3", Method = XX_Methods.Exercise_3.Start},
                    new ExerciseElement(){Name = "Übung 4", Method = XX_Methods.Exercise_4.Start},
                    new ExerciseElement(){Name = "Übung 5", Method = XX_Methods.Exercise_5.Start},
                    new ExerciseElement(){Name = "Übung 6", Method = XX_Methods.Exercise_6.Start}
                }
            };
            
            //************************
            //*******Überladung*******
            //************************
            ExerciseGroup ueberladungElements = new ExerciseGroup()
            {
                Name = "Überladung",
                ElementList = new List<ExerciseElement>()
                {
                    new ExerciseElement(){Name = "Übung 1", Method = XX_Überladung.Exercise_1.Start},
                    new ExerciseElement(){Name = "Übung 2", Method = XX_Überladung.Exercise_2.Start},
                    new ExerciseElement(){Name = "Übung 3", Method = XX_Überladung.Exercise_3.Start},
                    new ExerciseElement(){Name = "Übung 4", Method = XX_Überladung.Exercise_4.Start},
                    new ExerciseElement(){Name = "Übung 5", Method = XX_Überladung.Exercise_5.Start}
                }
            };


            //************************
            //********LISTEN**********
            //************************
            ExerciseGroup listElements = new ExerciseGroup()
            {
                Name = "Listen",
                ElementList = new List<ExerciseElement>()
                {
                    new ExerciseElement(){Name = "Übung 1", Method = XX_Lists.Exercise_1.Start},
                    new ExerciseElement(){Name = "Übung 2", Method = XX_Lists.Exercise_2.Start},
                    new ExerciseElement(){Name = "Übung 3", Method = XX_Lists.Exercise_3.Start},
                    new ExerciseElement(){Name = "Übung 4", Method = XX_Lists.Exercise_4.Start},
                    new ExerciseElement(){Name = "Übung 5", Method = XX_Lists.Exercise_5.Start},
                    new ExerciseElement(){Name = "Übung 6", Method = XX_Lists.Exercise_6.Start},
                    new ExerciseElement(){Name = "Übung 7", Method = XX_Lists.Exercise_7.Start},
                    new ExerciseElement(){Name = "Übung 8", Method = XX_Lists.Exercise_8.Start},
                    new ExerciseElement(){Name = "Übung 9", Method = XX_Lists.Exercise_9.Start},
                    new ExerciseElement(){Name = "Übung 10", Method = XX_Lists.Exercise_10.Start},
                    new ExerciseElement(){Name = "Übung 11", Method = XX_Lists.Exercise_11.Start},
                    new ExerciseElement(){Name = "Übung 12", Method = XX_Lists.Exercise_12.Start},
                    new ExerciseElement(){Name = "Übung 13", Method = XX_Lists.Exercise_13.Start}
                }
            };


            //************************
            //*********Enums**********
            //************************
            ExerciseGroup enumElements = new ExerciseGroup()
            {
                Name = "Enums",
                ElementList = new List<ExerciseElement>()
                {
                    new ExerciseElement(){Name = "Übung 1", Method = XX_Enumns.Exercise_1.Start},
                    new ExerciseElement(){Name = "Übung 2", Method = XX_Enumns.Exercise_2.Start},
                    new ExerciseElement(){Name = "Übung 3", Method = XX_Enumns.Exercise_3.Start},
                    new ExerciseElement(){Name = "Übung 4", Method = XX_Enumns.Exercise_4.Start},
                    new ExerciseElement(){Name = "Übung 5", Method = XX_Enumns.Exercise_5.Start},
                    new ExerciseElement(){Name = "Übung 6", Method = XX_Enumns.Exercise_6.Start},
                    new ExerciseElement(){Name = "Übung 7", Method = XX_Enumns.Exercise_7.Start},
                    new ExerciseElement(){Name = "Übung 8", Method = XX_Enumns.Exercise_8.Start},
                    new ExerciseElement(){Name = "Übung 9", Method = XX_Enumns.Exercise_9.Start},
                    new ExerciseElement(){Name = "Übung 10", Method = XX_Enumns.Exercise_10.Start},
                    new ExerciseElement(){Name = "Übung 11", Method = XX_Enumns.Exercise_11.Start},
                    new ExerciseElement(){Name = "Übung 12", Method = XX_Enumns.Exercise_12.Start},
                    new ExerciseElement(){Name = "Übung 13", Method = XX_Enumns.Exercise_13.Start}
                }
            };

            //************************
            //*********Tuple**********
            //************************
            ExerciseGroup tupleElements = new ExerciseGroup()
            {
                Name = "Tuple",
                ElementList = new List<ExerciseElement>()
                {
                    new ExerciseElement(){Name = "Übung 1", Method = XX_Tuple.Exercise_1.Start},
                    new ExerciseElement(){Name = "Übung 2", Method = XX_Tuple.Exercise_2.Start},
                    new ExerciseElement(){Name = "Übung 3", Method = XX_Tuple.Exercise_3.Start},
                    new ExerciseElement(){Name = "Übung 4", Method = XX_Tuple.Exercise_4.Start},
                    new ExerciseElement(){Name = "Übung 5", Method = XX_Tuple.Exercise_5.Start},
                    new ExerciseElement(){Name = "Übung 6", Method = XX_Tuple.Exercise_6.Start},
                    new ExerciseElement(){Name = "Übung 7", Method = XX_Tuple.Exercise_7.Start},
                    new ExerciseElement(){Name = "Übung 8", Method = XX_Tuple.Exercise_8.Start},
                    new ExerciseElement(){Name = "Übung 9", Method = XX_Tuple.Exercise_9.Start}
                }
            };

            //************************
            //*Mehrdimensinale Arrays*
            //************************
            ExerciseGroup moredimensionalArrayElements = new ExerciseGroup()
            {
                Name = "Mehrdimensinale Arrays",
                ElementList = new List<ExerciseElement>()
                {
                    new ExerciseElement(){Name = "Übung 1", Method = XX_Mehrdimensionale_Arrays.Exercise_1.Start},
                    new ExerciseElement(){Name = "Übung 2", Method = XX_Mehrdimensionale_Arrays.Exercise_2.Start},
                    new ExerciseElement(){Name = "Übung 3", Method = XX_Mehrdimensionale_Arrays.Exercise_3.Start},
                    new ExerciseElement(){Name = "Übung 4", Method = XX_Mehrdimensionale_Arrays.Exercise_4.Start},
                    new ExerciseElement(){Name = "Übung 5", Method = XX_Mehrdimensionale_Arrays.Exercise_5.Start},
                    new ExerciseElement(){Name = "Übung 6", Method = XX_Mehrdimensionale_Arrays.Exercise_6.Start},
                    new ExerciseElement(){Name = "Übung 7", Method = XX_Mehrdimensionale_Arrays.Exercise_7.Start}
                }
            };

            //************************
            //******Jagged Arrays*****
            //************************
            ExerciseGroup jaggedArrayElements = new ExerciseGroup()
            {
                Name = "Jagged Arrays",
                ElementList = new List<ExerciseElement>()
                {
                    new ExerciseElement(){Name = "Übung 1", Method = XX_Jagged_Arrays.Exercise_1.Start},
                    new ExerciseElement(){Name = "Übung 2", Method = XX_Jagged_Arrays.Exercise_2.Start},
                    new ExerciseElement(){Name = "Übung 3", Method = XX_Jagged_Arrays.Exercise_3.Start},
                    new ExerciseElement(){Name = "Übung 4", Method = XX_Jagged_Arrays.Exercise_4.Start}
                }
            };

            //************************
            //********Klassen*********
            //************************
            ExerciseGroup classElements = new ExerciseGroup()
            {
                Name = "Klassen",
                ElementList = new List<ExerciseElement>()
                {
                    new ExerciseElement(){Name = "Übung 1", Method = Exercises_C_Sharp.XX_Classes.Exercise_1.Start},
                    new ExerciseElement(){Name = "Übung 2", Method = Exercises_C_Sharp.XX_Classes.Exercise_2.Start},
                    new ExerciseElement(){Name = "Übung 3", Method = Exercises_C_Sharp.XX_Classes.Exercise_3.Start},
                    new ExerciseElement(){Name = "Übung 4", Method = Exercises_C_Sharp.XX_Classes.Exercise_4.Start},
                    new ExerciseElement(){Name = "Übung 5", Method = Exercises_C_Sharp.XX_Classes.Exercise_5.Start},
                    new ExerciseElement(){Name = "Übung 6", Method = Exercises_C_Sharp.XX_Classes.Exercise_6.Start},
                    new ExerciseElement(){Name = "Übung 7", Method = Exercises_C_Sharp.XX_Classes.Exercise_7.Start}
                }
            };

            //************************
            //****Konstruktoren*******
            //************************
            ExerciseGroup constructorElements = new ExerciseGroup()
            {
                Name = "Konstruktoren",
                ElementList = new List<ExerciseElement>()
                {
                    new ExerciseElement(){Name = "Übung 1", Method = Exercises_C_Sharp.XX_Konstruktoren.Exercise_1.Start},
                    new ExerciseElement(){Name = "Übung 2", Method = Exercises_C_Sharp.XX_Konstruktoren.Exercise_2.Start},
                    new ExerciseElement(){Name = "Übung 3", Method = Exercises_C_Sharp.XX_Konstruktoren.Exercise_3.Start},
                    new ExerciseElement(){Name = "Übung 4", Method = Exercises_C_Sharp.XX_Konstruktoren.Exercise_4.Start},
                    new ExerciseElement(){Name = "Übung 5", Method = Exercises_C_Sharp.XX_Konstruktoren.Exercise_5.Start},
                    new ExerciseElement(){Name = "Übung 6", Method = Exercises_C_Sharp.XX_Konstruktoren.Exercise_6.Start},
                    new ExerciseElement(){Name = "Übung 7", Method = Exercises_C_Sharp.XX_Konstruktoren.Exercise_7.Start}
                }
            };

            //************************
            //******Exceptions********
            //************************
            ExerciseGroup exceptionElements = new ExerciseGroup()
            {
                Name = "Exceptions",
                ElementList = new List<ExerciseElement>()
                {
                    new ExerciseElement(){Name = "Übung 1", Method = Exercises_C_Sharp.XX_Exceptions.Exercise_1.Start},
                    new ExerciseElement(){Name = "Übung 2", Method = Exercises_C_Sharp.XX_Exceptions.Exercise_2.Start},
                    new ExerciseElement(){Name = "Übung 3", Method = Exercises_C_Sharp.XX_Exceptions.Exercise_3.Start},
                    new ExerciseElement(){Name = "Übung 4", Method = Exercises_C_Sharp.XX_Exceptions.Exercise_4.Start},
                    new ExerciseElement(){Name = "Übung 5", Method = Exercises_C_Sharp.XX_Exceptions.Exercise_5.Start},
                    new ExerciseElement(){Name = "Übung 6", Method = Exercises_C_Sharp.XX_Exceptions.Exercise_6.Start},
                    new ExerciseElement(){Name = "Übung 7", Method = Exercises_C_Sharp.XX_Exceptions.Exercise_7.Start},
                    new ExerciseElement(){Name = "Übung 8", Method = Exercises_C_Sharp.XX_Exceptions.Exercise_8.Start},
                    new ExerciseElement(){Name = "Übung 9", Method = Exercises_C_Sharp.XX_Exceptions.Exercise_9.Start}
                }
            };
            

            //************************
            //****Sonderaufgaben******
            //************************
            ExerciseGroup specialElements = new ExerciseGroup()
            {
                Name = "Sonderaufgaben",
                ElementList = new List<ExerciseElement>()
                {
                    new ExerciseElement(){Name = "Schere Stein Papier Echse Spock", Method = Exercises_C_Sharp.Sonderaufgaben.Exercise_1.Start},
                    new ExerciseElement(){Name = "Schiffe versenken", Method = Exercises_C_Sharp.Sonderaufgaben.Exercise_2.Start},
                    new ExerciseElement(){Name = "Memory", Method = Exercises_C_Sharp.Sonderaufgaben.Exercise_3.Start}
                }
            };
            
            //************************
            //*Entwicklungsaufgaben***
            //************************
            ExerciseGroup developElements = new ExerciseGroup()
            {
                Name = "Entwicklungsaufgaben",
                ElementList = new List<ExerciseElement>()
                {
                    new ExerciseElement(){Name = "Dynamische Eingaben in Echtzeit", Method = Exercises_C_Sharp.Entwicklungsaufgaben.Minispiele.Step_1.Start}
                }
            };

            //************************
            //***Dateizugriffe********
            //************************
            ExerciseGroup filesystemElements = new ExerciseGroup()
            {
                Name = "Dateizugriffe",
                ElementList = new List<ExerciseElement>()
                {
                    new ExerciseElement(){Name = "Aufgabe 1", Method = Exercises_C_Sharp.XX_Dateizugriffe.Exercise_1.Start},
                    new ExerciseElement(){Name = "Aufgabe 2", Method = Exercises_C_Sharp.XX_Dateizugriffe.Exercise_2.Start},
                    new ExerciseElement(){Name = "Aufgabe 3", Method = Exercises_C_Sharp.XX_Dateizugriffe.Exercise_3.Start},
                    new ExerciseElement(){Name = "Aufgabe 4", Method = Exercises_C_Sharp.XX_Dateizugriffe.Exercise_4.Start},
                    new ExerciseElement(){Name = "Aufgabe 5", Method = Exercises_C_Sharp.XX_Dateizugriffe.Exercise_5.Start},
                    new ExerciseElement(){Name = "Aufgabe 6", Method = Exercises_C_Sharp.XX_Dateizugriffe.Exercise_6.Start},
                    new ExerciseElement(){Name = "Aufgabe 7", Method = Exercises_C_Sharp.XX_Dateizugriffe.Exercise_7.Start},
                    new ExerciseElement(){Name = "Aufgabe 8", Method = Exercises_C_Sharp.XX_Dateizugriffe.Exercise_8.Start},
                    new ExerciseElement(){Name = "Aufgabe 8b", Method = Exercises_C_Sharp.XX_Dateizugriffe.Exercise_8b.Start}
                }
            };

            //************************
            //***********MySQL********
            //************************
            ExerciseGroup mysqlElements = new ExerciseGroup()
            {
                Name = "MySQL",
                ElementList = new List<ExerciseElement>()
                {
                    new ExerciseElement(){Name = "Aufgabe 1", Method = Exercises_C_Sharp.XX_MySQL.Exercise_1.Start},
                    new ExerciseElement(){Name = "Aufgabe 2", Method = Exercises_C_Sharp.XX_MySQL.Exercise_2.Start}
                }
            };

            //************************
            //*****Serialisierung*****
            //************************
            ExerciseGroup serializeElements = new ExerciseGroup()
            {
                Name = "Serialisierung",
                ElementList = new List<ExerciseElement>()
                {
                    new ExerciseElement(){Name = "Aufgabe 1", Method = Exercises_C_Sharp.XX_Serialisierung.Exercise_1.Start},
                    new ExerciseElement(){Name = "Aufgabe 2", Method = Exercises_C_Sharp.XX_Serialisierung.Exercise_2.Start}
                }
            };

            //Zusammenführung
            OptionList = new List<ExerciseGroup>(){
                beginnerElements,
                variableElements,
                stringElements,
                terminalElements,
                arrayElements,
                listElements,
                enumElements,
                methodsElements,
                ueberladungElements,
                moredimensionalArrayElements,
                jaggedArrayElements,
                tupleElements,
                specialElements,
                developElements,
                classElements,
                constructorElements,
                exceptionElements,
                filesystemElements,
                mysqlElements
            };

            Menu();
        }
    
        //ToDo: Einzelne Lektionen nebeneinander anzeigen
        //ToDo: Senden, um zu überprüfen, ob alles richtig ist
        //ToDo: Element als erledigt markieren
        static void Menu()
        {
            Console.Clear();
            Console.SetCursorPosition(0,0);
            LoadMarkedExercises();
            var pos = LoadCurrentElementAndCurrentList();
            int currentElement = pos.Item1;
            int currentList = pos.Item2;

            while(true)
            {
                Console.Clear();
                for(int k = 0; k < OptionList.Count; k++)
                {
                    var element = OptionList[k];
                    Console.WriteLine("**********************");
                    Console.WriteLine(element.Name);
                    Console.WriteLine("**********************");
                    //Console.ReadKey();
                    if(currentList == k)
                    {
                        for(int i = 0; i < element.ElementList.Count; i++)
                        {
                            //Der erste Wert vorne ist dafür gedacht, dass markiert wird, wenn die Aufgabe abgegeben und korregiert wurde --> ToDo
                            Console.WriteLine("{2}{1}[{0}] " + element.ElementList[i].Name, currentElement == i && currentList == k ? "X" : " ", !element.ElementList[i].IsMarked ? " " : "#", element.ElementList[i].FinishState == false ? "NO" : element.ElementList[i].FinishState == false == true ? "OK" : "  ");
                        }
                    }
                }
                var key = Console.ReadKey();
                if(key.Key == ConsoleKey.UpArrow)
                {
                    Console.Clear();
                    if(currentElement == 0 && currentList == 0)
                    {
                        currentList = OptionList.Count -1;
                        currentElement = OptionList[OptionList.Count -1].ElementList.Count -1;
                    }
                    else if(currentElement == 0 && currentList > 0)
                    {
                        currentList--;
                        currentElement = OptionList[currentList].ElementList.Count -1;
                    }
                    else
                        currentElement--;
                }
                else if(key.Key == ConsoleKey.DownArrow)
                {
                    Console.Clear();
                    if(currentElement == OptionList[currentList].ElementList.Count - 1 && currentList == OptionList.Count -1)
                    {
                        currentList = 0;
                        currentElement = 0;
                    }
                    else if(currentElement == OptionList[currentList].ElementList.Count - 1 && currentList < OptionList.Count -1)
                    {
                        currentList++;
                        currentElement = 0;
                    }
                    else
                    {
                        currentElement++;
                    }
                }
                else if(key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    try
                    {
                        SaveCurrentElementAndCurrentList(currentElement, currentList);
                        OptionList[currentList].ElementList[currentElement].Method();
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("******************");
                        Console.WriteLine("***** Fehler *****");
                        Console.WriteLine("******************");
                        Console.WriteLine("Bei der Aufgabe ist folgender Fehler aufgetreten:");
                        Console.WriteLine(ex.ToString());
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Aufgabe beendet. Zum Weitermachen Taste  drücken...");
                    Console.ReadKey();
                }
                else if(key.Key == ConsoleKey.X)
                {
                    Console.Clear();
                    var el = OptionList[currentList].ElementList[currentElement];
                    if(el.IsMarked == false)
                        OptionList[currentList].ElementList[currentElement].IsMarked = true;
                    else
                        OptionList[currentList].ElementList[currentElement].IsMarked = false;

                    SaveMarkedExercises();
                }
                else if(key.Key == ConsoleKey.RightArrow)
                {
                    //ToDo: Absenden und überprüfen

                }
                else if(key.Key == ConsoleKey.V)
                {
                    //Zum Videomenu
                    OpenLinkToVideo.ShowVideoMenu(OptionList[currentList], OptionList[currentList].ElementList[currentElement]);
                }
                Console.Clear();
            }
        }

        
    
        //Speichert das zuletzt ausgewählte Element
        static void SaveCurrentElementAndCurrentList(int currentElement, int currentList)
        {
            try
            {
                if(File.Exists("lastPoint"))
                    File.Delete("lastPoint");
                
                File.WriteAllLines("lastPoint", new List<string>(){currentElement.ToString(), currentList.ToString()});
            }
            catch(Exception ex)
            {
                Console.WriteLine("Sorry, habe anscheindend einen Fehler reinprogrammiert. Ihre Aufgabe ist nun, den Fehler in der Program.cs zu finden und zu fixen. Hierfür bekommen Sie folgenden Hinweis:");
                Console.WriteLine(ex.ToString());
            }
        }
        static Tuple<int,int> LoadCurrentElementAndCurrentList()
        {
            try
            {
                if(!File.Exists("lastPoint"))
                    return new Tuple<int,int>(0,0);
                
                var el = File.ReadAllLines("lastPoint");
                return new Tuple<int,int>(Convert.ToInt32(el[0]), Convert.ToInt32(el[1]));
            }
            catch(Exception ex)
            {
                Console.WriteLine("Sorry, habe anscheindend einen Fehler reinprogrammiert. Ihre Aufgabe ist nun, den Fehler in der Program.cs zu finden und zu fixen. Hierfür bekommen Sie folgenden Hinweis:");
                Console.WriteLine(ex.ToString());
            }
            return new Tuple<int,int>(0,0);
        }
    
        //ToDo: Richtiges Abspeichern implementieren!!!
        //Speichert die markierten Aufgaben ab
        static void SaveMarkedExercises()
        {
            List<string> saveList = new List<string>();
            foreach(var element in OptionList)
            {
                foreach(var item in element.ElementList)
                {
                    if(item.IsMarked == true)
                    {
                        saveList.Add(string.Format("{0}{1} {2}", element.Name, item.Name, item.IsMarked.ToString()));
                    }
                }
            }
            File.WriteAllLines("markingSave", saveList);
        }
        static void LoadMarkedExercises()
        {
            if(!File.Exists("markingSave"))
                return;
            var el = File.ReadAllLines("markingSave");
            Dictionary<string, bool> dic = new Dictionary<string, bool>();
            foreach(var element in el)
            {
                string str = element.Substring(0, element.LastIndexOf(" "));
                bool b = Convert.ToBoolean(element.Substring(element.LastIndexOf(" ") + 1));
                dic.Add(str, b);
            }


            foreach(var element in OptionList)
            {
                for(int i = 0; i < element.ElementList.Count; i++)
                {
                    var key = string.Format("{0}{1}", element.Name, element.ElementList[i].Name);
                    if(dic.ContainsKey(key))
                    {
                        element.ElementList[i].IsMarked = dic[key];
                    }
                }
            }
        }
    }
}
