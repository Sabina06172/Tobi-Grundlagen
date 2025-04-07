int[] cards = [3, 5, 7, 8, 9];
int query = 7;

var result = FindCardLocation(cards, query);
System.Console.WriteLine(value: result);


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
