#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: REnvironmentSpecialMoveWrapperFalling<br/>
/// (size = 100)
/// (flags = 134221970)
/// </summary>
public partial class REnvironmentSpecialMoveWrapperFalling : BmSDK.BmGame.REnvironmentSpecialMoveWrapper, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.REnvironmentSpecialMoveWrapperFalling", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal REnvironmentSpecialMoveWrapperFalling() { }

    /// <summary>
    /// Constructs a new REnvironmentSpecialMoveWrapperFalling
    /// </summary>
    public REnvironmentSpecialMoveWrapperFalling(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, REnvironmentSpecialMoveWrapperFalling Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected REnvironmentSpecialMoveWrapperFalling(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: MinFallSpeed
    /// </summary>
    public unsafe float MinFallSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// FloatProperty: MaxFallSpeed
    /// </summary>
    public unsafe float MaxFallSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }
}
