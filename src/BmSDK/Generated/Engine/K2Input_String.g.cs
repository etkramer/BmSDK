#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: K2Input_String<br/>
/// (size = 80)
/// (flags = 134217874)
/// </summary>
public partial class K2Input_String : BmSDK.Engine.K2Input, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.K2Input_String", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal K2Input_String() { }

    /// <summary>
    /// Constructs a new K2Input_String
    /// </summary>
    public K2Input_String(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, K2Input_String Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected K2Input_String(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: DefaultString
    /// </summary>
    public unsafe BmSDK.FString DefaultString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }
}
