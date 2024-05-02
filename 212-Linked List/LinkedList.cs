namespace _212_Linked_List;

public class LinkedList
{
    public Node? First { get; set; }

    public void InsertFirst(int data)
    {
        Node newNode = new Node();
        //Put the data in the node
        newNode.Data = data;
        //put the old node in the next
        newNode.Next = First;
        //MAKE THE FIRST THE NEW NODE
        First = newNode;
    }

    public Node DeleteFirst()
    {
        Node temp = First;
        First = First.Next;
        return temp;
    }

    public void DisplayList()
    {
        Console.WriteLine("Iterate thru list");
        Node current = First;
        while (current != null)
        {
              current.DisplayNode();
              current = current.Next; //This is how you iterate thru Nodes 
        }
        
    }

    public void InsertLast(int data)
    {
        Node current = First;
        while (current.Next != null)
        {
            current = current.Next;
        }

        Node newNode = new Node();
        newNode.Data = data;
        current.Next = newNode;
    }
}