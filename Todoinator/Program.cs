System.Console.WriteLine("Wilkommen beim Todoinator");
while (true)
{
    System.Console.WriteLine("""
    1. Neues ToDo
    2. ToDo abhaken
    """); //Mit den 6 " wird ein Menü angezeigt mit nur 1 Console.WriteLine
    var userMenuChoice = Console.ReadLine();
    switch(userMenuChoice)
    {
        case "1":
             //ToDo erstellen
             break;
        case "2":
             //ToDo abhaken
             break;
        default:
             //Nicht definierter Input (Anderes Antwort als was angegeben)
             break;
    }
}