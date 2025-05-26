#pragma warning disable CS0169
#pragma warning disable CS0649

namespace BmSDK;

public unsafe struct FString
{
    private IntPtr AllocatorInstance;
    private int Num;
    private int Max;

    /// <summary>
    /// Creates a new FString from the given managed string.
    /// </summary>
    public FString(string str)
    {
        fixed (FString* thisPtr = &this)
        fixed (char* stringDataPtr = str)
        {
            // Call native ctor
            GameFunctions.StringCtor((IntPtr)thisPtr, (IntPtr)stringDataPtr);
        }
    }

    public static implicit operator FString(string str) => new(str);

    public override readonly string? ToString()
    {
        if (AllocatorInstance == IntPtr.Zero)
        {
            return null;
        }

        return Marshal.PtrToStringUni(AllocatorInstance, Num - 1)!;
    }
}
