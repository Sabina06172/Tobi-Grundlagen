System.Console.WriteLine("Wilkommen beim Todoinator");
var TodoList = new List<TodoItem>();
while (true)
{
    for (int i = 0; i < TodoList.Count; i++)
    {
        System.Console.WriteLine($"Index {i + 1}: {TodoList[i]}");
    }
    System.Console.WriteLine("""
    1. Neues ToDo
    2. ToDo abhaken
    """); //Mit den 6 " wird ein Menü angezeigt mit nur 1 Console.WriteLine
    var userMenuChoice = Console.ReadLine();
    switch(userMenuChoice)
    {
        case "1":
             //ToDo erstellen
             System.Console.WriteLine("Was ist das ToDo?");
             var todoDescription = Console.ReadLine();
             System.Console.WriteLine("""
             Wie wichtig? 
             1 => Hohe Prio
             2 => Normale Prio
             3 => Niedrige Prio
             """);
             var todoPrio = Console.ReadLine();
             var newToDo = new TodoItem();
             newToDo.Description = todoDescription;
             newToDo.Prio = Convert.ToInt32(todoPrio);
             TodoList.Add(newToDo);
             break;
        case "2":
             //ToDo abhaken
             System.Console.WriteLine("Welches ToDo möchtest du Löschen?");
             var indexToDelete = Convert.ToInt32(Console.ReadLine());
             TodoList.RemoveAt(indexToDelete - 1);
             break;
        default:
             //Nicht definierter Input (Anderes Antwort als was angegeben)
             break;
    }
    Console.Clear();
}