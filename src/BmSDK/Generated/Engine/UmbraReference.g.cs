#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: UmbraReference<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class UmbraReference : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.UmbraReference", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal UmbraReference() { }

    /// <summary>
    /// Constructs a new UmbraReference
    /// </summary>
    public UmbraReference(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, UmbraReference Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected UmbraReference(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: VisibilityData
    /// </summary>
    public unsafe BmSDK.Engine.UmbraData VisibilityData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.UmbraData>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }
}
