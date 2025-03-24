using BmSDK.Framework;

namespace BmSDK;

public partial class BaseObject
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    delegate IntPtr StaticFindObjectDelegate(
        IntPtr Class,
        IntPtr InOuter,
        IntPtr OrigInName,
        int ExactClass
    );

    static StaticFindObjectDelegate? _StaticFindObject = null;

    /// <summary>
    /// Find or load an object by string name with optional outer and filename specifications.<br/>
    /// These are optional because the InName can contain all of the necessary information.
    /// </summary>
    /// <param name="Class">The to be found object's class</param>
    /// <param name="InOuter">The to be found object's outer</param>
    /// <param name="Name">The to be found object's class</param>
    /// <param name="ExactClass">Whether to require an exact match with the passed in class</param>
    /// <returns>Returns the found object or null if none could be found</returns>
    public static unsafe T? StaticFindObject<T>(
        Class? Class,
        BaseObject? InOuter,
        string Name,
        bool ExactClass
    )
        where T : BaseObject
    {
        // Create delegate on first use
        _StaticFindObject ??= Marshal.GetDelegateForFunctionPointer<StaticFindObjectDelegate>(
            MemUtil.GetIntPointer(GameInfo.FuncOffsets.StaticFindObject)
        );

        // Get TCHAR* from string
        fixed (char* namePtr = Name)
        {
            // Call native func
            var result = _StaticFindObject(
                Class?.Ptr ?? 0,
                InOuter?.Ptr ?? -1,
                (IntPtr)namePtr,
                ExactClass ? 1 : 0
            );

            // Return null if needed
            if (result == IntPtr.Zero)
            {
                return null;
            }

            return (T?)(object?)MarshalUtil.MarshalToManaged<BaseObject>(&result);
        }
    }

    /// <returns>Returns the found object or throws if none could be found</returns>
    /// <inheritdoc cref="StaticFindObject"/>
    public static unsafe T StaticFindObjectChecked<T>(
        Class? Class,
        BaseObject? InOuter,
        string Name,
        bool ExactClass
    )
        where T : BaseObject =>
        Guard.NotNull(
            StaticFindObject<T>(Class, InOuter, Name, ExactClass),
            $"Failed to find object: {Name}"
        );

    /// <summary>
    /// Returns the fully qualified pathname for this object as well as the name of the class.
    /// </summary>
    public string GetFullName(BaseObject? StopOuter = null)
    {
        var result = Class.Name.ToString();
        result += " ";
        GetPathName(StopOuter, ref result);

        return result;
    }

    /// <summary>
    /// Returns the fully qualified pathname for this object.
    /// </summary>
    public string GetPathName(BaseObject? StopOuter = null)
    {
        var res = "";
        GetPathName(StopOuter, ref res);
        return res;
    }

    /// <summary>
    /// Internal version of GetPathName() that eliminates unnecessary copies.
    /// </summary>
    void GetPathName(BaseObject? StopOuter, ref string ResultString)
    {
        if (this != StopOuter)
        {
            if (Outer is not null && Outer != StopOuter)
            {
                Outer.GetPathName(StopOuter, ref ResultString);

                if (Outer.Class != Package.StaticClass())
                {
                    ResultString += ":";
                }
                else
                {
                    ResultString += ".";
                }
            }

            ResultString += Name.ToString();
        }
        else
        {
            ResultString += "None";
        }
    }

    /// <inheritdoc/>
    public override string ToString() => $"{GetFullName()} ({GetType().Name})";
}
