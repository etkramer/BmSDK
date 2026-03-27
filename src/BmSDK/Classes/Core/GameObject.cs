using BmSDK.Framework;

namespace BmSDK;

public interface IGameObject
{
    static abstract Class StaticClass();
}

public partial class GameObject
{
    [Flags]
    public enum EObjectFlags : ulong
    {
        RF_ClassDefaultObject = 0x80,
        RF_RootSet = 0x400,
        RF_NeedPostLoad = 0x100000000000000,
    }

    public IntPtr Ptr { get; internal set; } = IntPtr.Zero;

    /// <summary>
    /// Returns true if this object is "alive", false if it has been destroyed or garbage collected on the UE3 side.
    /// If false, this object is unsafe to access or call any methods on.
    /// </summary>
    public bool IsValid => Ptr != IntPtr.Zero;

    /// <summary>
    /// Returns true if this object is the "Class Default Object", false if it is a usual instance.
    /// A CDO is the template instance of a class that holds the default attributes of new objects.
    /// Can be retrieved through GameObject.Class.DefaultObject.
    /// </summary>
    public bool IsCdo => ObjectFlags.HasFlag(EObjectFlags.RF_ClassDefaultObject);

    /// <summary>
    /// Enumerates all objects in this object's outer chain.
    /// </summary>
    public IEnumerable<GameObject> EnumerateOuter()
    {
        var outer = Outer;
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
        return $"{Guard.NotNull(Class).Name} {GetPathName(StopOuter)}";
    }

    /// <summary>
    /// Returns the fully qualified pathname for this object.
    /// </summary>
    public string GetPathName(GameObject? StopOuter = null)
    {
        var res = "";
        GetPathNameRecursive(StopOuter, ref res);
        return res;
    }

    private void GetPathNameRecursive(GameObject? StopOuter, ref string ResultString)
    {
        if (this != StopOuter)
        {
            try
            {
                _ = Outer;
            }
            catch (ArgumentException)
            {
                // Outer has been destroyed, probably because we're mid-destroy too.
                return;
            }

            if (Outer is not null && Outer != StopOuter)
            {
                Outer.GetPathNameRecursive(StopOuter, ref ResultString);
                ResultString += Outer is Package ? "." : ":";
            }

            ResultString += Name.ToString();
        }
        else
        {
            ResultString += "None";
        }
    }

    /// <summary>
    /// Causes this object (and anything it references) to be excluded from UE3's GC.
    /// </summary>
    public void AddToRoot()
    {
        ObjectFlags |= EObjectFlags.RF_RootSet;
    }

    /// <summary>
    /// Causes this object to be included in UE3's GC again after being excluded with <see cref="AddToRoot"/>.
    /// </summary>
    public void RemoveFromRoot()
    {
        ObjectFlags &= ~EObjectFlags.RF_RootSet;
    }

    /// <inheritdoc/>
    public override string ToString() => GetFullName();
}
