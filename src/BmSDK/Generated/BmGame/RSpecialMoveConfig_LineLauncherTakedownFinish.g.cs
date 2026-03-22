#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveConfig_LineLauncherTakedownFinish<br/>
/// (size = 364)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_LineLauncherTakedownFinish : BmSDK.BmGame.RSpecialMoveConfig_RelativeAnimMove, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveConfig_LineLauncherTakedownFinish", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_LineLauncherTakedownFinish() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_LineLauncherTakedownFinish
    /// </summary>
    public RSpecialMoveConfig_LineLauncherTakedownFinish(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_LineLauncherTakedownFinish Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_LineLauncherTakedownFinish(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: VictimAnimName
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> VictimAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// ObjectProperty: VictimAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VictimAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }
}
