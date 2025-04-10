// int[] cards = [3, 5, 7, 8, 9]; //Gehört zu Linear Search
// int query = 7;


// int[] cards2 = new int[50000000];
// for (int i = 0; i < cards2.Length; i++)
// {
//     cards2[i] = i +1;
// }


// var result = Algorithms.FindCardLocation(cards, query);
// System.Console.WriteLine(value:"Index vom gesuchtem Element in cards:" + result); //Gehört zu Linear Search

// // System.Console.WriteLine(cards2[10]);
// var result2 = Algorithms.FindCardLocationBinarySearch(cards2, query: 40_942_069);
// System.Console.WriteLine("Index vom gesuchtem Element in cards2:" + result2);  //40_942_068 wird erwartet/erraten

// using BenchmarkDotNet.Running;

// var summary = BenchmarkRunner.Run<Algorithms>();

// test insertion sort with small array
var unsortedArray = new int[] { 5, 3, 8, 6, 2 };
Console.WriteLine("Unsortiertes Array: " + string.Join(", ", unsortedArray));
var sortedArray = Algorithms.InsertionSort(unsortedArray);

Console.WriteLine("Sortiertes Array: " + string.Join(", ", sortedArray));
