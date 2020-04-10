using System;
using System.Collections.Generic;

public class CircularBuffer<T>
{
    private readonly Queue<T> _buffer;
    private readonly int _capacity;
    public CircularBuffer(int capacity)
    {
        _buffer = new Queue<T>(capacity);
        _capacity = capacity;
    }

    public T Read()
    {
        return _buffer.Dequeue();
    }

    public void Write(T value)
    {
        _buffer.Enqueue(value);
        if (_buffer.Count > _capacity)
        {
            throw new InvalidOperationException();
        }
    }

    public void Overwrite(T value)
    {
        _buffer.Enqueue(value);
        if (_buffer.Count > _capacity)
        {
            _buffer.Dequeue();
        }
    }

    public void Clear()
    {
        _buffer.Clear();
    }
}