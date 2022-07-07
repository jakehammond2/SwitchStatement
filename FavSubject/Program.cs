

Console.WriteLine("What is your favorite subject?");
string favsub = Console.ReadLine();


switch (favsub.ToLower()) 
{
    case "math":
        Console.WriteLine("Cool. Math is my favorite subject too!");
        break;
    case "english":
        Console.WriteLine("Ewwww. English is my least favorite subject");
        break;
    case "science":
        Console.WriteLine("I think that Science is such an interesting subject.");
        break;
    case "history":
        Console.WriteLine("History is very valuable to learn and remember");
        break;
    case "reading":
        Console.WriteLine("Reading is very valuable.");
        break;

    default:
        Console.WriteLine("I'm not familiar with this subject");
        break;
}




