using System;
public class DsQueueItem
{
    public int value;
    public DsQueueItem next;
    public DsQueueItem(int value)
    {
        this.value = value;
        next = null;
    }
}
public class DsQueue
{
    DsQueueItem front;
    DsQueueItem rear;
    public DsQueue()
    {
        front = null;
        rear = null;
    }
    public void Enqueue(int value)
    {
        var newItem = new DsQueueItem(value);
        if (front == null && rear == null)
        {
            front = rear = newItem;
            return;
        }
        rear.next = newItem;
        rear = newItem;

    }
    public int Dequeue()
    {
        int frontValue=0;
        if (front == null)
            throw new Exception("empty queue");
        if (front == rear)
            front = rear = null;
        else
        {
            frontValue = front.value;
            front = front.next;
        }
        return frontValue;
    }
    public bool isEmpty()
    {
        return front==null && rear==null;
    }
    public void print()
    {
        if(isEmpty())
        Console.WriteLine("Empty queue");
        else
        {
            var temp=front;
            while(temp!=null)
            {
                Console.Write(temp.value.ToString()+" ");
                temp=temp.next;
            }
        }
        Console.WriteLine();
    }

}