using System.Collections;
using BmSDK.Framework;

namespace BmSDK;

public class InlineArray<T> : IReadOnlyList<T>
{
    public int Count { get; }
    public IntPtr Ptr { get; }

    private readonly int _stride;

    internal InlineArray(int count, IntPtr ptr, int stride)
    {
        Count = count;
        Ptr = ptr;
        _stride = stride;
    }

    public T this[int index]
    {
        get => MarshalUtil.ToManaged<T>(Ptr + index * _stride);
        set => MarshalUtil.ToUnmanaged(value, Ptr + index * _stride);
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

    public override bool Equals(object? obj)
    {
        if (obj is not InlineArray<T> array)
        {
            return false;
        }

        return Ptr == array.Ptr;
    }

    public override int GetHashCode() => HashCode.Combine(Ptr);

    public static bool operator ==(InlineArray<T>? left, InlineArray<T>? right)
    {
        if (left is null || right is null)
        {
            return Equals(left, right);
        }

        return left.Equals(right);
    }

    public static bool operator !=(InlineArray<T>? left, InlineArray<T>? right) =>
        !(left == right);
}
