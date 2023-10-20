using System.Text;

namespace Iterator;

public class MyLinkedList<T>
{
    private Node? root;
    private sealed class Node
    {
        public T Value;
        public Node? Next;
        public Node Previous;

        public Node(T value, Node previous)
        {
            Value = value;
            Previous = previous;
        }

        public override string? ToString()
        {
            return Value?.ToString() ?? string.Empty;
        }
    }

    public bool Contains(T value)
    {
        return GetIndexOf(value) != -1;
    }

    public T Get(int index)
    {
        var counter = 0;
        var current = root;

        while (counter != index)
        {
            current = current?.Next ?? throw new ArgumentException("Current node is null.");
            counter++;
        }

        return current!.Value;
    }

    public int GetIndexOf(T value)
    {
        if (root is null)
        {
            return -1;
        }

        int counter = 0;
        var current = root;
        while (!current.Value?.Equals(value) ?? false)
        {
            current = current.Next;
            if (current is null)
            {
                return -1;
            }
            counter++;
        }
        return counter;
    }

    public void Add(T value)
    {
        if (root is not null)
        {
            var lastElementOfList = LastNode();
            var newNode = new Node(value, lastElementOfList);
            lastElementOfList.Next = newNode;
        }
        else
        {
            root = new Node(value, null!);
        }
    }

    public T Last()
    {
        return LastNode().Value;
    }

    public T First()
    {
        return root!.Value ?? throw new ArgumentException("Root is not initialized.");
    }

    private Node LastNode()
    {
        var current = root;

        var previous = current;
        while (current is not null)
        {
            previous = current;
            current = current.Next;
        }
        return previous!;
    }

    public int Length()
    {
        var length = 0;

        var current = root;

        while (current is not null)
        {
            length++;
            current = current.Next;
        }
        return length;
    }

    public override string? ToString()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.Append('[');

        var current = root;
        while (current is not null)
        {
            stringBuilder.Append(current.Value).Append(", ");
            current = current.Next;
        }

        if (stringBuilder.Length > 1)
        {
            stringBuilder.Remove(stringBuilder.Length - 2, 2);
        }

        stringBuilder.Append(']');
        return stringBuilder.ToString();
    }
}
