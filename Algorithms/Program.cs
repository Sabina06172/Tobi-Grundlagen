int[] cards = [3, 5, 7, 8, 9];


int[] cards2 = new int[50000000];
for (int i = 0; i < cards2.Length; i++)
{
    cards2[i] = i +1;
}

int query = 7;

var result = FindCardLocation(cards, query);
System.Console.WriteLine(value:"Index vom gesuchtem Element in cards:" + result);

System.Console.WriteLine(cards2[10]);
var result2 = FindCardLocationBinarySearch(cards2, query: 40_942_069);
System.Console.WriteLine("Index vom gesuchtem Element in cards2:" + result2);  //40_942_068 wird erwartet/erraten


//Binary Search: => O(log(n))
int FindCardLocationBinarySearch(int[] cards, int query)
{
    int low = 0;
    int high = cards2.Length -1;
    while(low <= high)
    {
        int mid = (low + high) / 2;

        if(cards2[mid] == query)
        {
            return mid;
        }
        else if(cards2[mid] < query)
        {
            low = mid +1;
        }
        else
        {
            high = -1;
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
