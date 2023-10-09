namespace Exercises_C_Sharp.E08_If
{
    class Exercise_17
    {
        public static void Start()
        {
            //Geben Sie auf der Konsole den Wert von der Eingabe i aus und lassen mit Hilfe vom String s dazuschreiben, ob die Zahl größer/gleich/kleiner 12 ist.
            
            int i = Convert.ToInt32(Console.ReadLine());
            string s = i > 12 ? "größer 12" : i == 12 ? "gleich 12" : "kleiner 12";

            //Code START
            
            //Code ENDE
        }
    }
}