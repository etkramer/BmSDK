#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RResolvedDirectionalAnimConfig<br/>
/// (size = 92)
/// (flags = 134217874)
/// </summary>
public partial class RResolvedDirectionalAnimConfig : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RResolvedDirectionalAnimConfig", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RResolvedDirectionalAnimConfig() { }

    /// <summary>
    /// Constructs a new RResolvedDirectionalAnimConfig
    /// </summary>
    public RResolvedDirectionalAnimConfig(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RResolvedDirectionalAnimConfig Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RResolvedDirectionalAnimConfig(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Directions
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence Directions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }
}
