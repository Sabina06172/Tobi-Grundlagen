using BenchmarkDotNet.Attributes;

public class Algorithms //Klasse
{
    int[] cards; //Deklaration
    public Algorithms() //Konstruktor
    {
        cards = new int[50_000_000]; //Initialisierung
        for (int i = 0; i < cards.Length; i++)
        {
            cards[i] = i + 1;
        }
    }
    //Binary Search: => O(log(n))
    [Benchmark]
    public void TestBinarySearch()
    {
        FindCardLocationBinarySearch(cards, query: 40_942_069); //40_942_068
    }
    public static int FindCardLocationBinarySearch(int[] cards, int query)
    {

        // Pseudo-Code: Binär Search

        //     Setze low auf 0
        //     Setze high auf Länge des Arrays - 1
        //     Solange low <= high
        //         Setze mid auf (low + high) / 2
        //         Wenn array[mid] == zielwert(query)
        //             Gib mid zurück // Ziel gefunden an Position mid
        //         Sonst wenn array[mid] < zielwert(query)
        //                Ziel liegt rechts → links abschneiden
        //             Setze low auf mid + 1
        //         Sonst
        //                Ziel liegt links → rechts abschneiden
        //             Setze high auf mid - 1
        //     Ende Solange
        //     Gib -1 zurück // Zielwert(query) nicht im Array gefunden 

        int low = 0;
        int high = cards.Length - 1;
        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (cards[mid] == query)
            {
                return mid;
            }
            else if (cards[mid] < query)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }

        }
        return -1;

    }



    //Linear Search: => O(n)
       [Benchmark]
    public void TestLinearSearch()
    {
        FindCardLocationLinearSearch(cards, query: 40_942_069); //40_942_068
    }
    public static int FindCardLocationLinearSearch(int[] cards, int query)
    {
        /* 
     Definiere Variable "index" und initialisiere mit Wert 0
     Wiederhole bis "index" gleich "cards" length:
         Wenn "cards" an "index" gleich "query", dann:
             Gebe "index" zurück
             Inkrementiere "index" um 1
       */
        int i = 0;
        while (i < cards.Length)
        {
            if (cards[i] == query)
                return i;
            i++;   //index = index + 1;
        }
        return -1;
    }
}
