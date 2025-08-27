using System.Collections;
using BmSDK.Framework;

#pragma warning disable CS0169
#pragma warning disable CS0649

namespace BmSDK;

internal interface IArray
{
    public IntPtr Ptr { set; }
}

public unsafe class TArray<TManaged> : IArray, IReadOnlyList<TManaged>
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct NativeData
    {
        public IntPtr AllocatorInstance;
        public int Num;
        public int Max;
    }

    internal ref NativeData Data => ref *(NativeData*)Ptr.ToPointer();

    public IntPtr Ptr { get; set; } = IntPtr.Zero;

    public int Count => Data.Num;
    public int Capacity => Data.Max;
    public int Stride => MarshalUtil.GetSizeUnmanaged<TManaged>();

    public bool IsReadOnly => false;

    public TManaged this[int idx]
    {
        get => MarshalUtil.ToManaged<TManaged>(Data.AllocatorInstance + (idx * Stride));
        set => MarshalUtil.ToUnmanaged(value, Data.AllocatorInstance + (idx * Stride));
    }

    /// <summary>
    /// Removes the specified number of items from the end of the array.
    /// </summary>
    public void Pop(int numItems = 1)
    {
        // Don't allow removing more items than actually exist.
        var newCount = Math.Min(Data.Num - numItems, 0);
        Resize(newCount);
    }

    /// <summary>
    /// Adds the given items to the end of the array.
    /// </summary>
    public void Push(params TManaged[] items)
    {
        // Resize array to fit new items.
        var oldCount = Count;
        var newCount = Count + items.Length;
        Resize(newCount);

        // Assign new items to array.
        for (var i = 0; i < items.Length; i++)
        {
            MarshalUtil.ToUnmanaged(items[oldCount + i], Data.AllocatorInstance + (i * Stride));
        }
    }

    /// <summary>
    /// Resizes the array to the specified count, reallocating if necessary and filling empty values with zeroes.
    /// </summary>
    private void Resize(int newNum)
    {
        // Nothing to resize
        if (newNum == Data.Num)
        {
            return;
        }

        // Shrink array: simple reduce count
        if (newNum < Data.Num)
        {
            Data.Num = newNum;
            return;
        }

        // Grow array (within capacity): simple increase count
        if (newNum > Data.Num && newNum <= Data.Max)
        {
            Data.Num = newNum;
            return;
        }

        // Grow array (beyond capacity): reallocate array
        if (newNum > Data.Num)
        {
            var dataPtr = (IntPtr*)Data.AllocatorInstance.ToPointer();
            var newMax = ((newNum / Data.Max) + 1) * Data.Max;
            *dataPtr = GameFunctions.AppRealloc(*dataPtr, newMax * Stride, 8);

            Debug.Log($"Reallocating: {Data.Max} to {newMax}");

            Data.Num = newNum;
            Data.Max = newMax;
            return;
        }
    }

    public unsafe IEnumerator<TManaged> GetEnumerator()
    {
        for (var i = 0; i < Count; i++)
        {
            yield return this[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public void Clear()
    {
        Resize(0);
    }

    public bool Contains(TManaged item)
    {
        for (var i = 0; i < Count; i++)
        {
            if (this[i]?.Equals(item) ?? false)
            {
                return true;
            }
        }

        return false;
    }
}
