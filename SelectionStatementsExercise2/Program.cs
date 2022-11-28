namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");
            var userFavSub = (Console.ReadLine());

            switch (userFavSub.ToLower())
            {
                case "history":
                    Console.WriteLine("History Facts: There were female Gladiators in Ancient Rome!");
                    break;
                case "math":
                    Console.WriteLine("Math Facts: Every odd number, when written in English, contains an “e”. ");
                    break;
                case "english":
                    Console.WriteLine("English Literature Facts: John Milton when composed “Paradise lost” was blind.");
                    break;
                case "science":
                    Console.WriteLine("Science Fact: A cockroach can live for up to one week without its head.");    
                    break;
                case "arts":
                    Console.WriteLine("Facts about Arts: The Mona Lisa has her own mailbox in the Louvre because of all the love letters she receives");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}