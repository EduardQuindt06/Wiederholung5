namespace Exercises_C_Sharp.Schulaufgaben
{
    //Sie sind ITler bei den Wasserwerken
    class S008_Enum
    {
        public static void Start()
        {
            Console.WriteLine("Wir testen heute die besten Wasseraufbereiter! Unser mega toller Algorithmus wurde extra von einem sehr gut ausgebildeten ITler von den Wasserwerken programmiert!");
            var listOfBestProducts = GetBestOnes();
            Console.WriteLine();
            Console.WriteLine("Hier kommen die besten drei Produkte:");
            //Geben Sie hier die Liste der besten Produkte mit deren Platzierungen aus. Benutzen Sie dafür die Methode GetBestOnes.
            //Code START

            //Code ENDE
            Console.WriteLine();
            Console.WriteLine("Aber was heißen die Klassen eigentlich? Hier die Übersicht darüber:");
            //Geben Sie hier alle WaterQuality-Elemente aus und geben Sie mit Hilfe der Methode WaterUseful die dazugehörige Beschreibung aus:
            //Code START

            //Code ENDE
            Console.WriteLine();
            Console.WriteLine("Vielen Dank für die Nutzung unseres tollen Vergleichtools!");
            Console.WriteLine("Wir wünschen Ihnen eine schöne Restwoche! Bleiben Sie uns treu!");


        }

        //Dieser Methode kann man eine WaterQuality und ein WaterAdd übergeben. Die Methode berechnet dann die neue Wasserqualität, nachdem das Mittel hinzugefügt wurde und gibt diese zurück.
        static WaterQuality MakeBetterWater(WaterQuality wq, WaterAdd wa)
        {
            return (WaterQuality)(((int)wq * (int)wa) % 9);

        }

        //Diese Methode bewertet die Wasserqualität und gibt diese als String zurück.
        static string WaterUseful(WaterQuality wq)
        {
            if(wq == WaterQuality.AAA)
                return "Für jeden uneingeschränkt trinkbar und für Babynahrung geeignet";
            if(wq == WaterQuality.AA)
                return "Für jeden uneingeschränkt trinkbar";
            if(wq == WaterQuality.A)
                return "Grundlegend für jeden trinkbar, Menschen mit Vorerkrankungen sollten aufpassen";
            if(wq == WaterQuality.B)
                return "Für anfällige Menschen mit Vorerkrankungen ungeeignet, in geringen Dosen für normale Menschen geeignet";
            if(wq == WaterQuality.C)
                return "Vorsichtiger Genuss von minimalen Mengen, abgekocht (mindestens 60 Sekunden) noch genießbar";
            if(wq == WaterQuality.D)
                return "Leicht verunreinigt, nur im äußersten Notfall (Gefahr für Leib und LEben) trinken und Menge minimal halten";
            if(wq == WaterQuality.E)
                return "Nicht trinkbar, ab höheren Dosen tötlich";
            if(wq == WaterQuality.F)
                return "Nicht trinkbar, ab mittleren Dosen tötlich";
            if(wq == WaterQuality.X)
                return "Nicht trinkbar, schon in kleinen Dosen tötlich";

            return string.Empty;
        }
    
        //Sie sollen nun die Methode "GetBestOnes" schreiben. In dieser Methode sollen sie die Top 3 der besten WaterAdd-Produkte als Liste zurück geben. Dabei ist der Sieger der, der es schafft, aus der schlechtestens Qualität die beste Qualität zu machen. (Also X -> AAA, X -> AA usw.). Bei einem eventuellen Gleichstand nehmen sie die nächste Qualitätsstufe (also F -> AAA, F -> AA usw.)
        static List<WaterAdd> GetBestOnes()
        {
            //Code START
            return new List<WaterAdd>();
            //Code ENDE
        }

        enum WaterQuality {AAA, AA, A, B, C, D, E, F, X }
        enum WaterAdd { Micropur, Reents, Yachticon, Tankline }
    }

}