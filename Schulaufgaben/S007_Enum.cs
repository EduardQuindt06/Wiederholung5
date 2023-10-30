namespace Exercises_C_Sharp.Schulaufgaben
{
    //Sie sind ITler in der Finanzbranche. 
    class S007_Enum
    {
        //Schreiben Sie hier eine Liste von MachineOutput. Achten Sie auf das Keyword static.
        //Code START
        static dynamic MachineOutputList = -1;
        //Code ENDE

        public static void Start()
        {
            Console.WriteLine("Programmtestung Start");
            //Füllen der Liste mit Zufallswerten
            FillMachineListWithRandomValues(90);
            //Wie viele Fehler sind passiert?
            Console.WriteLine("Die Anzahl der Fehler lag bei " + GetPercentsOfMachineValue(MachineOutput.Error).ToString("0.00") + " %.");
            //Ausgabe der Gesamtübersicht
            ShowListData();
        }

        //Diese Methode füllt die obere Liste mit zufälligen Maschinendaten.
        static void FillMachineListWithRandomValues(int amount)
        {
            for(int i = 0; i < amount; i++)
                MachineOutputList.Add(GetRandomMachineData());
        }

        //Diese Methode soll zufällig Maschinendaten erzeugen. Sorgen Sie dafür, dass die Methode immer einen der zufälligen Werte vom Type MachineOutput zurück gibt.
        static MachineOutput GetRandomMachineData()
        {
            //Code START
            return MachineOutput.Error;
            //Code ENDE
        }
    
        //Dieser Methode kann man ein MachineOutput-Element geben. Wenn man das gemacht hat, dann berechnet diese Methode das prozentuale Erscheinen dieses Werts in der Liste. ((Anzahl des Vorkommens / Gesamtanzahl von Elementen in der Liste) * 100) Implementieren Sie diese Funktion.
        static decimal GetPercentsOfMachineValue(MachineOutput mo)
        {
            //Code START
            return -1;
            //Code ENDE
        }
    
        //Diese Methode soll das Vorkommen aller Elemente wie folgt ausgeben:
        //  3x Perfect
        // 12x Good
        //  2x Okay
        //... usw
        //Achten Sie dabei darauf, dass das x immer in der selben Zeile steht, egal ob die Zahl eine oder zwei Stellen hat. Wir gehen nicht davon aus, dass es mehr als zwei Stellen werden.
        static void ShowListData()
        {
            //Code START

            //Code ENDE
        }

        enum MachineOutput { Perfect, Good, Okay, Bad, Dreadfull, Error}
    }

}