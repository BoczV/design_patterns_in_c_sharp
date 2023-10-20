namespace Flyweight;

public static class Program
{
    static void Main()
    {
        var sentence = new Sentence("My new design pattern is done.");
        sentence[1].Capitalize = true;
        sentence[2].Capitalize = true;
        Console.WriteLine(sentence);
    }
}