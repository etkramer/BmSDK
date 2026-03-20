#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveConfig_KickJokerIntoGurney<br/>
/// (size = 408)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_KickJokerIntoGurney : BmSDK.BmGame.RSpecialMoveConfig, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveConfig_KickJokerIntoGurney", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_KickJokerIntoGurney() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_KickJokerIntoGurney
    /// </summary>
    public RSpecialMoveConfig_KickJokerIntoGurney(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_KickJokerIntoGurney Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_KickJokerIntoGurney(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: PunchAnimName
    /// </summary>
    public unsafe BmSDK.FName PunchAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }
}
