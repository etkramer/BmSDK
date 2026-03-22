#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ClipPadEntry<br/>
/// (size = 68)
/// (flags = 134217874)
/// </summary>
public partial class ClipPadEntry : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ClipPadEntry", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ClipPadEntry() { }

    /// <summary>
    /// Constructs a new ClipPadEntry
    /// </summary>
    public ClipPadEntry(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ClipPadEntry Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ClipPadEntry(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: Title
    /// </summary>
    public unsafe BmSDK.FString Title
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// StrProperty: Text
    /// </summary>
    public unsafe BmSDK.FString Text
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }
}
