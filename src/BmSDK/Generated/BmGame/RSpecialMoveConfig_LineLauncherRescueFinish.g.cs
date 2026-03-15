#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveConfig_LineLauncherRescueFinish<br/>
/// (size = 360)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_LineLauncherRescueFinish : BmSDK.BmGame.RSpecialMoveConfig_RelativeAnimMove, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveConfig_LineLauncherRescueFinish", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_LineLauncherRescueFinish() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_LineLauncherRescueFinish
    /// </summary>
    public RSpecialMoveConfig_LineLauncherRescueFinish(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_LineLauncherRescueFinish Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_LineLauncherRescueFinish(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: HostageAnimName
    /// </summary>
    public unsafe BmSDK.FName HostageAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// ObjectProperty: HostageAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet HostageAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }
}
