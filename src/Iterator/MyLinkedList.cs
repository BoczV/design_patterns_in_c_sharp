using System.Text;

namespace Iterator;

public class MyLinkedList<T>
{
    private Node? root;
    private sealed class Node
    {
        public T Value;
        public Node? Next;

        public Node(T value)
        {
            Value = value;
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

        var counter = 0;
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
            var newNode = new Node(value);
            lastElementOfList.Next = newNode;
        }
        else
        {
            root = new(value);
        }
    }

    public T Last()
    {
        return LastNode().Value;
    }

    public T First()
    {
        return root!.Value;
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
            var currentValue = current.ToString();
            stringBuilder.Append(currentValue).Append(", ");
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
