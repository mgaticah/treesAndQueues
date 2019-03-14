using System;

public class GenericDsQueueItem<T>
{
    public T value;
    public GenericDsQueueItem<T> next;
    public GenericDsQueueItem(T value)
    {
        this.value = value;
        next = null;
    }
}
public class GenericDsQueue<T>
{
    GenericDsQueueItem<T> front;
    GenericDsQueueItem<T> rear;
    public GenericDsQueueItem<T> getFront()
    {
        return front;
    }
    public GenericDsQueue()
    {
        front = null;
        rear = null;
    }
    public void Enqueue(T value)
    {
        var newItem = new GenericDsQueueItem<T>(value);
        if (front == null && rear == null)
        {
            front = rear = newItem;
            return;
        }
        rear.next = newItem;
        rear = newItem;

    }
    public T Dequeue()
    {
        T frontValue=default(T);
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