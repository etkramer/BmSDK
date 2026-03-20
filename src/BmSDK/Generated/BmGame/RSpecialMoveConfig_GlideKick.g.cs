#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveConfig_GlideKick<br/>
/// (flags = 0)
/// </summary>
public partial class RSpecialMoveConfig_GlideKick : BmSDK.BmGame.RSpecialMoveConfig_RunningRelativeAnimMove, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveConfig_GlideKick", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_GlideKick() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_GlideKick
    /// </summary>
    public RSpecialMoveConfig_GlideKick(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_GlideKick Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_GlideKick(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: WindowAttackOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 WindowAttackOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// ObjectProperty: SmashWindowRumble
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform SmashWindowRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }
}
