namespace Iterator;

public static class Program
{
    static void Main()
    {
        var linkedList = new MyLinkedList<int>();

        linkedList.Add(2);
        linkedList.Add(23);
        linkedList.Add(1);
        Console.WriteLine(linkedList);
        Console.WriteLine($"{linkedList.Last()}");
    }
}