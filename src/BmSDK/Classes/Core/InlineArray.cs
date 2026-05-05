using System.Collections;
using BmSDK.Framework;

namespace BmSDK;

public class InlineArray<T> : IReadOnlyList<T>
{
    public int Count { get; }
    private readonly IntPtr _ptr;
    private readonly int _stride;

    internal InlineArray(int count, IntPtr ptr)
    {
        Count = count;
        _ptr = ptr;
        _stride = MarshalUtil.GetSizeUnmanaged<T>();
    }

    public T this[int index]
    {
        get => MarshalUtil.ToManaged<T>(_ptr + index * _stride);
        set => MarshalUtil.ToUnmanaged(value, _ptr + index * _stride);
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (var i = 0; i < Count; i++)
        {
            yield return this[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
