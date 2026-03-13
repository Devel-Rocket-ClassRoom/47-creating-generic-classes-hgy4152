using System;
using System.Collections.Generic;
using System.Text;
class ObjectPool<T> where T : class, IPoolable, new()
{
    public T[] pools;
    private List<T> _available = new List<T>();
    private List<T> _active = new List<T>();

    public int ActiveCount {  get { return _active.Count; } }
    public int AvailableCount {  get { return _available.Count; } }

    public ObjectPool(int capacity)
    {
        pools = new T[capacity];
    }


    public T Get()
    {


        if (_available.Count == 0)
            _available.Add(new T());



        if (_active.Count + _available.Count > pools.Length)
        {
            Console.WriteLine("풀이 가득 찼습니다!");
            _available.RemoveAt(_available.Count - 1);

            return null;
        }

        T item = _available[_available.Count-1];
        _available.Remove(item);

        _active.Add(item);

        return item;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   
    }


    public void Return(T item)
    {
        Console.WriteLine("총알 반납됨");

        item.Reset();
        _active.Remove(item);
        _available.Add(item);
    }
}