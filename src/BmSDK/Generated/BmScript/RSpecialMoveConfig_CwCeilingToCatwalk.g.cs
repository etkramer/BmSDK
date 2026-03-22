#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveConfig_CwCeilingToCatwalk<br/>
/// (size = 312)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_CwCeilingToCatwalk : BmSDK.BmGame.RSpecialMoveConfig, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveConfig_CwCeilingToCatwalk", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_CwCeilingToCatwalk() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_CwCeilingToCatwalk
    /// </summary>
    public RSpecialMoveConfig_CwCeilingToCatwalk(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_CwCeilingToCatwalk Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_CwCeilingToCatwalk(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: StartAnimName
    /// </summary>
    public unsafe BmSDK.FName StartAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// NameProperty: EndAnimName
    /// </summary>
    public unsafe BmSDK.FName EndAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }
}
