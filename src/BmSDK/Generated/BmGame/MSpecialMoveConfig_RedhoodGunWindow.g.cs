#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MSpecialMoveConfig_RedhoodGunWindow<br/>
/// (size = 568)
/// (flags = 0)
/// </summary>
public partial class MSpecialMoveConfig_RedhoodGunWindow : BmSDK.BmGame.RSpecialMoveConfig_GlideKick, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MSpecialMoveConfig_RedhoodGunWindow", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MSpecialMoveConfig_RedhoodGunWindow() { }

    /// <summary>
    /// Constructs a new MSpecialMoveConfig_RedhoodGunWindow
    /// </summary>
    public MSpecialMoveConfig_RedhoodGunWindow(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MSpecialMoveConfig_RedhoodGunWindow Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MSpecialMoveConfig_RedhoodGunWindow(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: fractureRumble
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform fractureRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// ObjectProperty: TurnIdleRailingAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet TurnIdleRailingAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// ObjectProperty: TurnIdleAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet TurnIdleAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// NameProperty: TurnIdleRailingAnimName
    /// </summary>
    public unsafe BmSDK.FName TurnIdleRailingAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// NameProperty: TurnIdleAnimName
    /// </summary>
    public unsafe BmSDK.FName TurnIdleAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// NameProperty: AnimName_AR
    /// </summary>
    public unsafe BmSDK.FName AnimName_AR
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }
}
