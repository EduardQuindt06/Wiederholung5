namespace Exercises_C_Sharp.XX_Methods
{
    //In dieser Aufgabe wurde eine Art Hangman programmiert. Leider handelt es sich hierbei um sogenannten "Spaghetti-Code". Ihre Aufgabe ist nun, alle Elemente in dieser Aufgabe, um die "Code START/ENDE" steht, in Methoden auszulagern. Rufen Sie dann anstelle des Codes die Methode auf.
    class Exercise_6
    {
        static List<string> StringList = new List<string>(){ "ELTERN", "BAUM", "HAUSDACH", "GELÄNDEWAGEN"};
        static List<char> InputList = new List<char>();
        public static void Start()
        {
            Random rand = new Random();
            //Wählen eines zufälligen Elements
            string word = StringList[rand.Next(0, StringList.Count)];
            int tries = 0;

            while(true)
            {
                //Ausgabe der Anzeige für den User
                //Code START
                Console.Clear();
                foreach(var element in word)
                {
                    if(InputList.Contains(element))
                        Console.Write(element);
                    else
                        Console.Write("_");
                }
                Console.WriteLine();
                //Code ENDE

                //Fragen nach der Eingabe
                //Code START
                Console.WriteLine("Bitte geben Sie einen Buchstaben ein:");
                while(true)
                {
                    string userinput = (Console.ReadLine() ?? "").ToUpper();
                    if(userinput == null || userinput.Length == 0 || InputList.Contains(userinput[0]))
                        continue;
                    InputList.Add(userinput[0]);
                    break;
                }
                //Code ENDE
                tries++;

                //Kontrolle, ob alle Elemente gefunden wurden
                //Code START
                bool allFound = true;
                foreach(var element in word)
                {
                    if(!InputList.Contains(element))
                    {
                        allFound = false;
                        break;
                    }
                }
                //Code ENDE
                if(allFound)
                    break;
            }

            //Ausgaben der Spielstatistiken
            Console.WriteLine("Herzlichen Glückwunsch! Sie haben gewonnen!");
            Console.WriteLine("Das Wort war: " + word);
            Console.WriteLine("Ihre Versuche: " + tries);
        }

        //Hier kommen die Methoden hin:
        //Code START
        
        //Code ENDE

    }
}