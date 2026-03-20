#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveConfig_CwCatwalkToCeiling<br/>
/// (size = 436)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_CwCatwalkToCeiling : BmSDK.BmGame.RSpecialMoveConfig, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveConfig_CwCatwalkToCeiling", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_CwCatwalkToCeiling() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_CwCatwalkToCeiling
    /// </summary>
    public RSpecialMoveConfig_CwCatwalkToCeiling(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_CwCatwalkToCeiling Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_CwCatwalkToCeiling(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: StartAnimName
    /// </summary>
    public unsafe BmSDK.FName StartAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// NameProperty: EndAnimName
    /// </summary>
    public unsafe BmSDK.FName EndAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// BoolProperty: bBranchIntoFarMoves
    /// </summary>
    public unsafe bool bBranchIntoFarMoves
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 416); }
    }

    /// <summary>
    /// ObjectProperty: FarRailingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig FarRailingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// ObjectProperty: FarEdgeMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig FarEdgeMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }
}
