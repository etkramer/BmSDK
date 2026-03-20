#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveConfig_LineLauncherFlipAndAim<br/>
/// (size = 408)
/// (flags = 0)
/// </summary>
public partial class RSpecialMoveConfig_LineLauncherFlipAndAim : BmSDK.BmGame.RSpecialMoveConfig, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveConfig_LineLauncherFlipAndAim", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_LineLauncherFlipAndAim() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_LineLauncherFlipAndAim
    /// </summary>
    public RSpecialMoveConfig_LineLauncherFlipAndAim(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_LineLauncherFlipAndAim Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_LineLauncherFlipAndAim(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: FlipAndAimAnimationName
    /// </summary>
    public unsafe BmSDK.FName FlipAndAimAnimationName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }
}
