#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveConfig_CwPickPocket<br/>
/// (size = 484)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_CwPickPocket : BmSDK.BmGame.RSpecialMoveConfig_RelativeAnimMove, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveConfig_CwPickPocket", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_CwPickPocket() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_CwPickPocket
    /// </summary>
    public RSpecialMoveConfig_CwPickPocket(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_CwPickPocket Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_CwPickPocket(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: CrouchedPickPocketAnim
    /// </summary>
    public unsafe BmSDK.FName CrouchedPickPocketAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// NameProperty: StandingPickPocketAnim
    /// </summary>
    public unsafe BmSDK.FName StandingPickPocketAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// StructProperty: SecurityCardRotationOffset
    /// </summary>
    public unsafe BmSDK.Rotator SecurityCardRotationOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }
}
