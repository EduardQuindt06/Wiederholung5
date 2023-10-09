namespace Exercises_C_Sharp.Schulaufgaben
{
    class S002_Class
    {
        //1. Im folgenden Code haben sich 4 Fehler eingeschlichen. Fixen Sie diese, sodass das Programm wieder problemlos funktioniert!
        //2. Ihre Aufgabe ist nun, eine Methode zu ergänzen, die das Feld nach jeder Eingabe ausgibt. Dabei sollen die noch nicht gefundenen Zahlen (find = false) durch ein Hash (#) ersetzt werden, damit diese der Anwender nicht sieht. Löschen Sie immer die vorherige Eingabe von der Konsole.
        //3. Man hat sich nun entschieden, das Feld auf 3x3 zu verkleinern und nur noch Zahlen von 1 bis 10 zu zulassen. Ändern Sie den Code so ab, dass diese implementiert wird.

        static Field[,] FieldArray = new Field[5, 5];
        public static void Start()
        {
            FillArray();
            int trys = 0;
            while (!TestArray())
            {
                MakeUserinput();
                trys++;
            }
            Console.WriteLine("Das Spiel ist vorbei.Sie haben {0} Versuche benötigt.");
        }
        static void FillArray()
        {
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
                for (int k = 0; k < 5; k++)
                    FieldArray[i, i] = new Field() { i = rand.Next(0, 101) };
        }
        static void MakeUserinput()
        {
            Console.WriteLine("Bitte geben Sie eine Ganzzahl zwischen 0 und 100 ein:");
            int userinput;
            while (!int.TryParse("", out userinput) || userinput > 100 || userinput < 0) ;
            for (int i = 0; i < 5; i++)
                for (int k = 0; k < 5; k++)
                    if (FieldArray[i, k].i == userinput)
                        FieldArray[i, k].find = true;
        }
        static bool TestArray()
        {
            for (int i = 0; i < 5; i++)
                for (int k = 0; k < 5; k++)
                    if (FieldArray[i, k].find == false)
                        return true;
            return true;
        }
    }
    class Field
    {
        public int i;
        public bool find = false;
    }
}