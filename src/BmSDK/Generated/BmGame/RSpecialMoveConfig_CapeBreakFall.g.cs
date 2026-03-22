#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveConfig_CapeBreakFall<br/>
/// (size = 528)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_CapeBreakFall : BmSDK.BmGame.RSpecialMoveConfig_Land, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveConfig_CapeBreakFall", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_CapeBreakFall() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_CapeBreakFall
    /// </summary>
    public RSpecialMoveConfig_CapeBreakFall(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_CapeBreakFall Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_CapeBreakFall(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: AnimName
    /// </summary>
    public unsafe BmSDK.FName AnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// NameProperty: LandOnRailingPerchAnimName
    /// </summary>
    public unsafe BmSDK.FName LandOnRailingPerchAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// NameProperty: LandOnRailingStandAnimName
    /// </summary>
    public unsafe BmSDK.FName LandOnRailingStandAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// FloatProperty: TerminalVelocity
    /// </summary>
    public unsafe float TerminalVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// ObjectProperty: FloorParticles
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem FloorParticles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// BoolProperty: bManual
    /// </summary>
    public unsafe bool bManual
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 520) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 520); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 520); }
    }

    /// <summary>
    /// ObjectProperty: CapeOpeningSoundEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent CapeOpeningSoundEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }
}
