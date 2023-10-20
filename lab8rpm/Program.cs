using System;

class Node
{
    public int Value;
    public Node Next;

    public Node(int value)
    {
        Value = value;
        Next = null;
    }
}

class LinkedList
{
    public Node Head;

    public void AddToEnd(int value)
    {
        Node newNode = new Node(value);
        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            Node current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public void InsertAfterFirstNegative(int valueToInsert)
    {
        Node current = Head;
        while (current != null)
        {
            if (current.Value < 0)
            {
                Node newNode = new Node(valueToInsert);
                newNode.Next = current.Next;
                current.Next = newNode;
                break;
            }
            current = current.Next;
        }
    }

    public void PrintList()
    {
        Node current = Head;
        while (current != null)
        {
            Console.Write(current.Value + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        LinkedList list = new LinkedList();
        list.AddToEnd(5);
        list.AddToEnd(-3);
        list.AddToEnd(7);
        list.AddToEnd(8);

        Console.WriteLine("Первоначальный вид списка:");
        list.PrintList();

        list.InsertAfterFirstNegative(10);

        Console.WriteLine("Список после добавления 10 после отрицательного числа:");
        list.PrintList();
    }
}
