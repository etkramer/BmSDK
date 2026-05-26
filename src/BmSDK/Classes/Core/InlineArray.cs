using System.Collections;
using BmSDK.Framework;

namespace BmSDK;

/// <summary>
/// Wrapper for unmanaged inline arrays.
/// These are of fixed size and cannot be created.
/// </summary>
/// <typeparam name="T">Stored data type of the inline array</typeparam>
public class InlineArray<T> : IEnumerable<T>
{
    public int Count { get; }
    public IntPtr Ptr { get; }

    private readonly int _stride;
    private readonly GameObject _owner;

    internal InlineArray(int count, IntPtr ptr, int stride, GameObject owner)
    {
        Count = count;
        Ptr = ptr;
        _stride = stride;
        _owner = owner;
    }

    public bool IsValid => _owner.IsValid;

    public T this[int index]
    {
        get
        {
            Guard.Require(IsValid, "Tried accessing an invalid InlineArray");
            return MarshalUtil.ToManaged<T>(Ptr + Guard.Bounds(index, Count) * _stride);
        }
        set
        {
            Guard.Require(IsValid, "Tried accessing an invalid InlineArray");
            MarshalUtil.ToUnmanaged(value, Ptr + Guard.Bounds(index, Count) * _stride);
        }
    }

    /// <summary>
    /// Copies elements from a collection into the inline array.
    /// Copying stops when the array capacity is reached.
    /// </summary>
    /// <param name="source">Enumerable to copy elements from</param>
    /// <param name="index">Index of this array to start at</param>
    public void CopyFrom(IEnumerable<T> source, int index = 0)
    {
        Guard.Require(
            index >= 0 && index <= Count,
            $"Start index {index} is outside of inline array bounds (0-{Count})"
        );

        foreach (var element in source)
        {
            if (index >= Count)
            {
                break;
            }

            this[index++] = element;
        }
    }

    /// <summary>
    /// Zeroes out the entire array.
    /// </summary>
    public void Clear()
    {
        for (var i = 0; i < Count; ++i)
        {
            this[i] = default!;
        }
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
        if (left is null && right is null)
        {
            return true;
        }

        if (left is null || right is null)
        {
            return false;
        }

        return left.Equals(right);
    }

    public static bool operator !=(InlineArray<T>? left, InlineArray<T>? right) => !(left == right);
}
