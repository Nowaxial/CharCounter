namespace CharCounter;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to CharCounter! Let's count! ");
        Console.Write("Enter your word / words: ");

        string writtenInput = Console.ReadLine()!;

        Console.WriteLine("Numbers of characters: " + writtenInput.Length);
        Console.ReadLine();
    }
}
