namespace Exercises_C_Sharp.Schulaufgaben
{
    class S003_Tuple
    {
        public static void Start()
        {
            while(true)
            {
                var el = EditNumber(EditString(AskForUserinput()));
                Console.Clear();
                Console.WriteLine("Verwandelter String: " + el.Item1);
                Console.WriteLine("Verwandelter Integer: " + el.Item2);
                Console.WriteLine();
            }
        }

        //Diese Methode soll den Integer im Tuple verdoppeln, wenn diese ungerade ist und halbieren, wenn diese gerade ist.
        public static Tuple<string,int> EditNumber(Tuple<string, int> element)
        {
            //Code START
            return element;
            //Code ENDE
        }
        //Diese Methode soll alle Leerzeichen in dem String durch einen Unterstrich ersetzen. 
        public static Tuple<string, int> EditString(Tuple<string, int> element)
        {
            //Code START
            return element;
            //Code ENDE
        }
        //Diese Methode soll dem Nutzer die Möglichkeit geben, einen String und einen Integer einzugeben. Sorgen Sie dafür, dass beide Werte valide sind, also dass der String nicht null und nicht leer ist und dass der Integer wirklich so einer ist.
        public static Tuple<string, int> AskForUserinput()
        {
            //Code START
            return new Tuple<string, int>("", 0);
            //Code ENDE
        }
    }
}