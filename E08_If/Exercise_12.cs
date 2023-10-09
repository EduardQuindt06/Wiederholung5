namespace Exercises_C_Sharp.E08_If
{
    class Exercise_12
    {
        public static void Start()
        {
            //Sorgen Sie dafür, dass überprüft wird, ob der Anwender eine Zahl eingegeben hat. Wenn das der Fall, geben Sie die Zahl aus, wenn nicht, dann schreiben Sie auf die Konsole, dass der eingegebene String X keine valide Zahl repräsentiert.

            int k;
            string userinput = Console.ReadLine() ?? "";
            bool b = int.TryParse(userinput, out k);
            
            //Code START
            
            //Code ENDE
        }
    }
}