using System;
using System.Collections.Generic;
using System.Text;



class SimpleQueue<T>
{
    private int Capacity;

    public int Count { get { return Queue.Count; } }
    public bool IsFull {  get { return Queue.Count == Capacity; } }
    public bool IsEmpty { get {  return Queue.Count == 0; }  }
    public List<T> Queue;

    public SimpleQueue(int capacity)
    {
        Capacity = capacity;
        Queue = new List<T>();
    }

    public T Enqueue(T item)
    {
        if(IsFull)
        {
            Console.WriteLine("큐가 가득 찼습니다.");
            return default(T);
        }

        Queue.Add(item);

        return item;
    }


    public T Dequeue()
    {

        if (IsEmpty)
        {
            Console.WriteLine("큐가 비어있습니다.");
            return default(T);
        }


        T item = Queue[0];
        
        for (int i = 1; i < Count; i++)
        {
            Queue[i-1] = Queue[i];
        }
        Queue.RemoveAt(Count-1);


        return item;
    }

    public T Peek()
    {
        if (IsEmpty)
        {
            Console.WriteLine("큐가 비어있습니다.");
            return default(T);
        }

        return Queue[0];

    }


}