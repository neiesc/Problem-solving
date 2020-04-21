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

    public T Read() => _buffer.Dequeue();

    public void Write(T value)
    {
        if (_buffer.Count + 1 > _capacity)
        {
            throw new InvalidOperationException();
        }
        _buffer.Enqueue(value);
    }

    public void Overwrite(T value)
    {
        if (_buffer.Count + 1 > _capacity)
        {
            _buffer.Dequeue();
        }
        _buffer.Enqueue(value);
    }

    public void Clear() => _buffer.Clear();
}