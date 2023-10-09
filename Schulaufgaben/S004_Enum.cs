namespace Exercises_C_Sharp.Schulaufgaben
{
    class S004_Enum
    {
         //1. Ein anderer Programmierer hat den folgenden Code geschrieben. Leider haben sich in dem Code 4 Fehler eingeschlichen. Finden und fixen Sie diese!
        //2. Sie sollen nun diesen Code so erweitern, dass wieder Werte gelöscht werden können. Entscheiden Sie selbst, wie der Anwender einzelne Listenelemente löschen kann und implementieren Sie dies.
        //3. Jetzt soll der Code so erweitert werden, dass bei 10-maligen Vorkommen von dem Status "Failed" das Programm beendet wird. Implementieren Sie diese Funktion!
        static List<States> StateList = new List<States>();

        static void Start()
        {
            Console.WriteLine("Programmstart");
            FirstFill();
            while (!true)
            {
                #pragma warning disable CS0162
                Console.WriteLine("A -> Werte anzeigen, E -> Neuen Wert erzeugen");
                if (Console.ReadLine() == "A")
                {
                    ShowValues();
                }
                else if (Console.ReadLine() == "E")
                {
                    StateList.Add(GetMachineState());
                }
            }
        }
        static void FirstFill()
        {
            for(int i = 0; i < 12; i++)
            {
                StateList.Add(GetMachineState());
            }
        }
        static void ShowValues()
        {
            int[] countArray = new int[5];
            foreach (var state in StateList)
                countArray[(int)state] += 1;
        }

        static States GetMachineState()
        {
            //Zugriff auf die Machine
            //Hier werden testweise die Werte zufällig erzeugt
            Random rand = new Random();
            return (States)rand.Next(0, 5);

        }

        enum States { Super, Good, Okay, Acceptable, Dreadful, Failed}
    }

}