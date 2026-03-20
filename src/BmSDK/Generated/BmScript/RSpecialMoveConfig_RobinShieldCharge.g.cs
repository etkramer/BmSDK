#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveConfig_RobinShieldCharge<br/>
/// (size = 484)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_RobinShieldCharge : BmSDK.BmGame.RSpecialMoveConfig_RelativeAnimMove, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveConfig_RobinShieldCharge", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_RobinShieldCharge() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_RobinShieldCharge
    /// </summary>
    public RSpecialMoveConfig_RobinShieldCharge(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_RobinShieldCharge Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_RobinShieldCharge(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: QuickChargeDist
    /// </summary>
    public unsafe float QuickChargeDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// ObjectProperty: VictimReactionAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VictimReactionAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }

    /// <summary>
    /// ObjectProperty: PlayerAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// ObjectProperty: ControllerRumble
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform ControllerRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }
}
