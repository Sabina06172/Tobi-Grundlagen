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


// int[] unsortedArray = [3, 7, 1, 9, 4, 2];
// public static int[] InsertionSort(int[] unsortedArray)
// {
//     //toDo 
//     for (int i = 0; i < unsortedArray.Length; i++)
//     {
//         int sortedArray = unsortedArray[i];
//         int j = i -1;
//         while(j >= 0 && unsortedArray[j] > sortedArray)
//         {
//             unsortedArray[j +1] = unsortedArray[j];
//             j--;
//         }
//         unsortedArray[j +1] = sortedArray;
//     }
//     return unsortedArray;


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


// int[] unsortedArray = [3, 7, 1, 9, 4, 2];
// int[] sortedArray = [];
public static int[] InsertionSort(int[] unsortedArray)
{
    //toDo 
    // for (int i = 0; i < unsortedArray.Length; i++)
    int i = 1;
    // int sortedArray = unsortedArray[i];
    while(i < unsortedArray.Length)
    {
        int j = i -1;
        int sortedArray = unsortedArray[i];
        while(j >= 0 && sortedArray < unsortedArray[j]) //Wird nach links verschoben
        {
            unsortedArray[j +1] = unsortedArray[j];
            j--;
        }
        unsortedArray[j +1] = sortedArray;
        i++;
    }
    return unsortedArray;
}
}

