using System.Collections;
using BmSDK.Framework;

#pragma warning disable CS0169
#pragma warning disable CS0649

namespace BmSDK;

/// <summary>
/// BM4-specific TArray variant with inline items, used for GObjObjects
/// </summary>
[StructLayout(LayoutKind.Sequential)]
internal unsafe struct TObjArray : IEnumerable<GameObject>
{
    public fixed ulong Data[785000];
    public int Unk;
    public int Num;
    public int Max;

    public readonly GameObject? this[int idx]
    {
        get
        {
            var ptr = (IntPtr)Data[idx];
            return MarshalUtil.ToManaged<GameObject>(&ptr);
        }
    }

    public readonly IEnumerator<GameObject> GetEnumerator()
    {
        for (var i = 0; i < Num; i++)
        {
            var item = this[i];

            if (item is not null)
            {
                yield return item;
            }
        }
    }

    readonly IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
