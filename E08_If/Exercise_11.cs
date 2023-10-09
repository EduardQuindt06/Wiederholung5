namespace Exercises_C_Sharp.E08_If
{
    class Exercise_11
    {
        public static void Start()
        {
            //Die vom Nutzer eingegebene Zahl soll zwischen 10 und 100 liegen. Sollte die Zahl über 100 oder unter 10 liegen, geben Sie die unten stehende Fehlermeldung aus.

            int userinput = Convert.ToInt32(Console.ReadLine());
            //Code START
            
            //Code ENDE
                Console.WriteLine("Die Zahl liegt leider außerhalb des Bereichs von 10 bis 100 und ist somit nicht valide...");
        }
    }
}