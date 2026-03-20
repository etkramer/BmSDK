#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: EdCoordSystem<br/>
/// (flags = 0)
/// </summary>
public partial class EdCoordSystem : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.EdCoordSystem", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal EdCoordSystem() { }

    /// <summary>
    /// Constructs a new EdCoordSystem
    /// </summary>
    public EdCoordSystem(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, EdCoordSystem Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected EdCoordSystem(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: M
    /// </summary>
    public unsafe BmSDK.GameObject.FMatrix M
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FMatrix>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// StrProperty: Desc
    /// </summary>
    public unsafe BmSDK.FString Desc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }
}
