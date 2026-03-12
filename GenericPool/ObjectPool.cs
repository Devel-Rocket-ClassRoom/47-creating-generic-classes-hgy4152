using System;
using System.Collections.Generic;
using System.Text;
class ObjectPool<T> where T : class, IPoolable, new()
{
    public T[] pools;
    public List<T> _available = new List<T>();
    public List<T> _active = new List<T>();

    public ObjectPool(int capacity)
    {
        pools = new T[capacity];
    }


    public T Get()
    {
        if(_available.Count == 0)
            return new T();


        if (_active.Count + _available.Count > pools.Length)
            return null;

        T item = _available[_available.Count - 1];
        _available.Remove(item);

        _active.Add(item);

        return item;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   
    }


    public void Return(T item)
    {
        item.Reset();
    }
}