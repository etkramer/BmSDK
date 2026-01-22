using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using BmSDK.Framework;

#pragma warning disable CS0169
#pragma warning disable CS0649

namespace BmSDK;

interface IArray
{
    IntPtr Ptr { set; }
}

public unsafe class TArray<TManaged> : IArray, IList<TManaged>
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
        var newCount = oldCount + items.Length;
        Resize(newCount);

        // Assign new items to array.
        for (var i = 0; i < items.Length; i++)
        {
            var idx = oldCount + i;
            MarshalUtil.ToUnmanaged(items[i], Data.AllocatorInstance + (idx * Stride));
        }
    }

    /// <summary>
    /// Resizes the array to the specified count, reallocating if necessary and filling empty values with zeroes.
    /// </summary>
    void Resize(int newNum)
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
            // TODO: This doesn't seem right. Isn't AllocatorInstance[0] the first element?
            // Disable it all for now.
            throw new NotImplementedException("Array reallocation is not yet implemented!");

            /*var dataPtr = (IntPtr*)Data.AllocatorInstance.ToPointer();
            var newMax = ((newNum / Data.Max) + 1) * Data.Max;
            *dataPtr = GameFunctions.AppRealloc(*dataPtr, newMax * Stride, 8);

            Debug.Log($"Reallocating: {Data.Max} to {newMax}");

            Data.Num = newNum;
            Data.Max = newMax;
            return;*/
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

    public void Add(TManaged item)
    {
        Push(item);
    }

    public int IndexOf(TManaged item)
    {
        for (var i = 0; i < Count; i++)
        {
            if (this[i]?.Equals(item) ?? false)
            {
                return i;
            }
        }

        return -1;
    }

    public void Insert(int index, TManaged item)
    {
        if (index < 0 || index > Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (index == Count)
        {
            Add(item);
            return;
        }

        var oldCount = Count;
        Resize(oldCount + 1);

        for (var i = oldCount; i > index; i--)
        {
            this[i] = this[i - 1];
        }

        this[index] = item;
    }

    public bool Remove(TManaged item)
    {
        var index = IndexOf(item);
        if (index >= 0)
        {
            RemoveAt(index);
            return true;
        }

        return false;
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        for (var i = index; i < Count - 1; i++)
        {
            this[i] = this[i + 1];
        }

        Resize(Count - 1);
    }

    public void CopyTo(TManaged[] array, int arrayIndex)
    {
        if (array == null)
        {
            throw new ArgumentNullException(nameof(array));
        }

        if (arrayIndex < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(arrayIndex));
        }

        if (array.Length - arrayIndex < Count)
        {
            throw new ArgumentException(
                "Destination array is not long enough to copy all the items in the collection. Check array index and length."
            );
        }

        for (var i = 0; i < Count; i++)
        {
            array[arrayIndex + i] = this[i];
        }
    }
}
