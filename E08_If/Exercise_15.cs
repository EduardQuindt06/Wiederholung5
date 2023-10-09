namespace Exercises_C_Sharp.E08_If
{
    class Exercise_15
    {
        public static void Start()
        {
            //In diser if werden direkt zwei Zahlen vom Nutzer verlangt. Wenn dieser beide richtig eingibt, dann soll die Multiplikation beider Zahlen auf der Konsole ausgegeben werden. Wenn einer der Zahlen nicht korrekt ist, dann soll eine Fehlermeldung ausgegeben werden.

            if(int.TryParse(Console.ReadLine(), out int a) && int.TryParse(Console.ReadLine(), out int b))
            //Code START
                Console.WriteLine();
            //Code ENDE
        }
    }
}