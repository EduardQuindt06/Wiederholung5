//WS2324 -> ITFA_2

namespace Exercises_C_Sharp.Schulaufgaben
{
    class S001_Class
    {
       static List<Garbage> GarbageList = new List<Garbage>();

		public static void Start()
		{
			while (true)
			{
				//Bauen Sie ein kleines Menü, in dem der Anwender aus den unteren drei Methoden auswählen kann
				//CODE START

				//CODE ENDE
			}
		}
		//Sorgen Sie dafür, dass der Anwender bei dieser Methode ein neues Garbage-Element erstellen kann. Dieses soll dann der Liste hinzugefügt werden.
		public static void AddNewGarbage()
		{
			//CODE START

			//CODE ENDE
		}
		//Sorgen Sie hier dafür, dass der Anwender bei einem beliebigen Garbage-Objekt das RemoveDate setzen kann. Sorgen Sie auch dafür, dass ein auf der Konsole falsch eingegebenes Datum nicht zu einem Prorammasturz führt, sondern dass der Benutzer es nochmal eingeben kann.
		public static void SetRemoveDate(Garbage garbage)
		{
			//CODE START

			//CODE ENDE
		}
		//Sorgen Sie dafür, dass hier alle Garbage-Objekte angezeigt werden. Wird true übergeben, dann werden auch alle Garbage-Objekte angezeigt, bei denen das RemoveDate nicht null ist. Bei Übergabewert false werden nur Garbage-Elemente ausgegeben, bei denen das RemoveDate null ist.
		public static void ShowAllGarbage(bool removed = false)
		{
			//CODE START

			//CODE ENDE
		}
	}
    class Garbage
    {
        public string? Name;
        public decimal Weight;
        public GarbageKind Kind;
        public DateTime? RemoveDate = null;
    }

    enum GarbageKind { Papiermüll, Restmüll, Sondermüll, Recyclingmüll }
}