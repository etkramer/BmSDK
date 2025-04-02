using System.Collections.Generic;
using System.Linq;
using BmSDK.Framework;

namespace BmSDK;

public partial class GameObject
{
    /// <summary>
    /// Returns a reference to the global objects array. Should not be used directly.
    /// </summary>
    public static unsafe ref TArray<GameObject> GObjects =>
        ref *(TArray<GameObject>*)MemUtil.GetIntPointer(GameInfo.GlobalOffsets.GObjObjects);

    public static unsafe Package? LoadPackage(string Filename) => LoadPackage(null, Filename);

    public static unsafe Package? LoadPackage(Package? InOuter, string Filename, int LoadFlags = 0)
    {
        // Get TCHAR* from string
        fixed (char* filenamePtr = Filename)
        {
            // Call native func
            var result = GameFunctions.LoadPackage(
                InOuter?.Ptr ?? 0,
                (IntPtr)filenamePtr,
                LoadFlags
            );

            return MarshalUtil.MarshalToManaged<Package>(&result);
        }
    }

    /// <summary>
    /// Returns an enumerable containing all objects of the given type.
    /// </summary>
    public static unsafe IEnumerable<T> FindObjects<T>()
        where T : GameObject => GObjects.OfType<T>();

    /// <summary>
    /// Find or load an object by string name with optional outer and filename specifications.<br/>
    /// These are optional because the InName can contain all of the necessary information.
    /// </summary>
    /// <param name="Class">The to be found object's class</param>
    /// <param name="InOuter">The to be found object's outer</param>
    /// <param name="Name">The to be found object's class</param>
    /// <param name="ExactClass">Whether to require an exact match with the passed in class</param>
    /// <returns>Returns the found object or null if none could be found</returns>
    public static unsafe T StaticFindObjectChecked<T>(
        Class? Class,
        GameObject? InOuter,
        string Name,
        bool ExactClass
    )
        where T : GameObject
    {
        // Get TCHAR* from string
        fixed (char* namePtr = Name)
        {
            // Call native func
            var result = GameFunctions.StaticFindObject(
                Class?.Ptr ?? 0,
                InOuter?.Ptr ?? -1,
                (IntPtr)namePtr,
                ExactClass ? 1 : 0
            );

            return Guard.NotNull(
                (T?)(object?)MarshalUtil.MarshalToManaged<GameObject>(&result),
                $"Failed to find object: {Name}"
            );
        }
    }

    /// <summary>
    /// Construct an object of a particular class.
    /// </summary>
    /// <param name="Class">The class of object to construct</param>
    /// <param name="Outer">The outer for the new object.  If not specified, object will be created in the transient package.</param>
    /// <param name="Name">The name for the new object.  If not specified, the object will be given a transient name via MakeUniqueObjectName</param>
    /// <param name="SetFlags">The object flags to apply to the new object</param>
    /// <param name="Template">The object to use for initializing the new object.  If not specified, the class's default object will be used</param>
    /// <returns>A reference to a new object of the specified class</returns>
    public static unsafe GameObject ConstructObject(
        Class Class,
        GameObject? Outer = null,
        string? Name = null,
        EObjectFlags SetFlags = 0,
        GameObject? Template = null
    )
    {
        var result = ConstructObjectInternal(Class, Outer, Name, SetFlags, Template);
        return MarshalUtil.MarshalToManaged<GameObject>(&result);
    }

    /// <inheritdoc cref="ConstructObject"/>
    public static unsafe T ConstructObject<T>(
        GameObject? Outer = null,
        string? Name = null,
        EObjectFlags SetFlags = 0,
        GameObject? Template = null
    )
        where T : GameObject, IStaticObject =>
        (T)ConstructObject(T.StaticClass(), Outer, Name, SetFlags, Template);

    internal static unsafe IntPtr ConstructObjectInternal(
        Class Class,
        GameObject? Outer,
        string? Name,
        EObjectFlags SetFlags,
        GameObject? Template
    )
    {
        // Default to transient package
        Outer ??= Package.GetTransientPackage();

        // Call native func
        var result = GameFunctions.StaticConstructObject(
            Class.Ptr,
            Outer.Ptr,
            Name is null ? FName.None : new FName(Name),
            SetFlags,
            Template?.Ptr ?? 0,
            MemUtil.GetIntPointer(GameInfo.GlobalOffsets.GError),
            0,
            0
        );

        Guard.Require(result != 0, "StaticConstructObject() returned null");
        return result;
    }

    /// <summary>
    /// Enumerates all objects in this object's outer chain.
    /// </summary>
    public IEnumerable<GameObject> EnumerateOuter()
    {
        var outer = this.Outer;
        while (outer is not null)
        {
            yield return outer;
            outer = outer.Outer;
        }
    }

    /// <summary>
    /// Returns the fully qualified pathname for this object as well as the name of the class.
    /// </summary>
    public string GetFullName(GameObject? StopOuter = null)
    {
        var result = Guard.NotNull(Class).Name.ToString();
        result += " ";
        GetPathName(StopOuter, ref result);

        return result;
    }

    /// <summary>
    /// Returns the fully qualified pathname for this object.
    /// </summary>
    public string GetPathName(GameObject? StopOuter = null)
    {
        var res = "";
        GetPathName(StopOuter, ref res);
        return res;
    }

    /// <summary>
    /// Internal version of GetPathName() that eliminates unnecessary copies.
    /// </summary>
    void GetPathName(GameObject? StopOuter, ref string ResultString)
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
