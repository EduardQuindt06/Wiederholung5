namespace Exercises_C_Sharp.Schulaufgaben
{
    //Sie sind ITler bei einer Softwarefirma. Ihre Abteilung hat Ihnen vorgefertigten Code gegeben, den Sie vervollständigen bzw. erweitern sollen. Folgende Aufgaben sollen Sie ausführen:
    // - Schreiben Sie eine Methode "NormRow", die dafür sorgt, dass in keiner Zeile die selbe Zahl darin steht. Addieren Sie hierfür solange eine 1, bis ein nicht vorhandener Wert in dem Feld steht.
    // - Erstellen Sie ein neues 5x5 int-Array in der Start-Methode.
    // - Nutzen Sie die Methode "FillList" um Werte in das int-Array hinein zu schreiben.
    // - Vertauschen Sie zufällig zwei Werte. Machen Sie den Tausch mit der Methode "ChangeFields".
    
    class S006_Multidimensionale_Arrays
    {
        public static void Start()
        {
            //Code START
            
            //Code ENDE
        }

        //Hier werden die Werte des Arrays mit den Standardwerten befüllt. Die Standardwerte sind die Multiplikation der Indezes.
        static int[,] FillList(int[,] field)
        {
            for(int i = 0; i < field.GetLength(0); i++)
                for(int k = 0; k < field.GetLength(1); k++)
                    field[i,k] = i * k;
            
            return field;
        }
        //Hier kann ein User zwei Werte im Array tauschen lassen. Dabei muss das Array und die beiden Koordinaten übergeben werden, die getauscht werden sollen.
        static int[,] ChangeFields(int[,] arr, (int x, int y) co1, (int x, int y) co2)
        {
            if(arr.GetLength(0) > co1.x && arr.GetLength(0) > co2.x && arr.GetLength(1) > co1.y && arr.GetLength(1) > co2.y)
            {
                var tem = arr[co1.x, co2.y];
                arr[co1.x, co1.y] = arr[co2.x, co2.y];
                arr[co2.x, co2.y] = tem;
            }
            return arr;
        }

        static int[,] SetField(int[,] arr, (int x, int y) field, int value)
        {
            if(arr.GetLength(0) > field.x && arr.GetLength(0) > field.x)
                arr[field.x, field.y] = value;
            return arr;
        }

        //Code START



        //Code ENDE
    }

}