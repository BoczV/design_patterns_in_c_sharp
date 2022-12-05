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
            return Value?.ToString() ?? "";
        }
    }

    public bool Contains(T value)
    {
        return GetIndexOf(value) != -1;
    }

    public T Get(int index)
    {
        int counter = 0;
        var current = root;
        while (counter != index)
        {
            current = current?.Next ?? throw new IndexOutOfRangeException();
            counter++;
        }
        return current!.Value;
    }

    public int GetIndexOf(T value)
    {
        if (root == null)
        {
            return -1;
        }

        int counter = 0;
        var current = root;
        while (!current!.Value.Equals(value))
        {
            current = current.Next;
            if (current == null)
            {
                return -1;
            }
            counter++;
        }
        return counter;
    }

    public void Add(T value)
    {
        if (root != null)
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
        return root.Value ?? throw new IndexOutOfRangeException();
    }

    private Node LastNode()
    {
        var current = root;

        Node previous = current;
        while (current != null)
        {
            previous = current;
            current = current.Next;
        }
        return previous;
    }

    public int Length()
    {
        var length = 0;

        var current = root;

        while (current != null)
        {
            length++;
            current = current.Next;
        }
        return length;
    }

    public override string? ToString()
    {
        StringBuilder stringBuilder = new StringBuilder("[");

        var current = root;
        while (current != null)
        {
            stringBuilder.Append(current.Value).Append(", ");
            current = current.Next;
        }

        if (stringBuilder.Length > 1)
        {
            stringBuilder.Remove(stringBuilder.Length - 2, 2);
        }

        stringBuilder.Append("]");
        return stringBuilder.ToString();
    }
}
