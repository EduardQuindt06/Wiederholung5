namespace Exercises_C_Sharp.Schulaufgaben
{
    class S005_Tuple
    {
         static List<Tuple<string,Vals>> ProductList = new();
        public static void Start()
        {
            Console.WriteLine("Willkommen!");
            //Bauen Sie hier ein kleines Menü Ihrer Wahl ein, indem der User
            // - Ein neues Produkt hinzufügen kann (-> Methode AddNewProduct)
            // - Sich die Anzahl der benötigten Trucks anzeigen lassen kann (-> Methode GetAmountOfTrucks)
            // - Sich unsere Kosten anzeigen lassen kann (-> Methode GetCosts)
            // - Sich die Kosten für die Kunden anzeigen lassen kann (-> Methode GetCosts)
            // - Die Liste senden kann (-> Methode SendList)
            //Das Programm soll in einer Endlosschleife laufen.
            //Code START

            //Code ENDE
        }


        //In dieser Methode soll der User ein neues Produkt zum Transport anmelden können. Dieser muss den Namen des Transports als String und die Größe als Integer angeben. Dann soll das Element in die ProductList gespeichert werden. Der Integer soll dann wie folgt umgewandelt werden:
        // <10 -> Tiny
        // 10 - 50 -> Small
        // 50 - 100 -> Medium
        //100 - 1000 -> Big
        // >1000  -> Oversize
        static void AddNewProduct()
        {
            //Code START

            //Code ENDE
        }

        //Geben Sie hier die Anzahl der Trucks zurück, welche für die obrige Liste an Produkten verwendet werden muss. Ein Truck kann entweder eine Oversize-Lieferung, vier Big-Lieferungen, fünfzehn Medium-Lieferungen, vierunddreißig Small-Lieferungen oder achtzig Tiny-Lieferung beinhalten. Ein Vermischen ist nicht möglich.
        static int GetAmountOfTrucks()
        {
            //Code START
            return -1;
            //Code ENDE
        }

        //Hier sollen die Gesamtkosten für die Trucks UND die Kosten für den einzelnen Kunden zurück gegeben werden. 
        //Ein Truck kostet durchschnittlich mit Fahrer, Anschaffung, Unterhalt und Benzin 3.485,23 pro Fahrt. 
        //Rechnen Sie die Kosten pro Produkt aus. Es wird kein Unterschied zwischen der Größe gemacht, jedes Produkt kostet gleich viel. Addieren Sie zusätzlich 25% auf diesen Preis drauf. Dabei handelt es sich um unseren Gewinn.
        static dynamic GetCosts(int amountTrucks)
        {
            //Code START
            return -1;
            //Code ENDE
        }

        //Hier wird die Liste geleert und die einzelnen Trucks beauftragt.
        static void SendList()
        {
            //Leeren Sie die Liste ProductList
            //Code START

            //Code ENDE

            //Hier wird später die Schnittstelle aufgerufen, um die Trucks los zu schicken. Hier müssen Sie nichts mehr programmieren, das übernehmen Ihre Kollegen.
            //TrucksAPI.SendTrucks();
        }


        //Dieses Enum bezeichnet die Größe der Ladung
        enum Vals {Tiny, Small, Medium, Big, Oversize}
    }

}