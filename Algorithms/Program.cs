int[] cards = [3, 5, 7, 8, 9]; //Gehört zu Linear Search
int query = 7;


int[] cards2 = new int[50000000];
for (int i = 0; i < cards2.Length; i++)
{
    cards2[i] = i +1;
}


var result = FindCardLocation(cards, query);
System.Console.WriteLine(value:"Index vom gesuchtem Element in cards:" + result); //Gehört zu Linear Search

// System.Console.WriteLine(cards2[10]);
var result2 = FindCardLocationBinarySearch(cards2, query: 40_942_069);
System.Console.WriteLine("Index vom gesuchtem Element in cards2:" + result2);  //40_942_068 wird erwartet/erraten


//Binary Search: => O(log(n))
int FindCardLocationBinarySearch(int[] cards, int query)
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
    int high = cards.Length -1;
    while(low <= high)
    {
        int mid = (low + high) / 2;

        if(cards[mid] == query)
        {
            return mid;
        }
        else if(cards[mid] < query)
        {
            low = mid +1;
        }
        else
        {
            high = mid -1;
        }
        
    }
    return -1;
    
}




//Linear Search: => O(n)
int FindCardLocation(int[] cards, int query)
{
       /* 
    Definiere Variable "index" und initialisiere mit Wert 0
    Wiederhole bis "index" gleich "cards" length:
        Wenn "cards" an "index" gleich "query", dann:
            Gebe "index" zurück
            Inkrementiere "index" um 1
      */
      int i = 0;
      while(i < cards.Length)
      {
           if(cards[i] == query)
              return i;
           i++;   //index = index + 1;
      }
      return -1;
}
