#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkActionGlobal_GenericMusicControl<br/>
/// (flags = 0)
/// </summary>
public partial class AkActionGlobal_GenericMusicControl : BmSDK.Engine.AkActionGlobal_MusicControl, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkActionGlobal_GenericMusicControl", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkActionGlobal_GenericMusicControl() { }

    /// <summary>
    /// Constructs a new AkActionGlobal_GenericMusicControl
    /// </summary>
    public AkActionGlobal_GenericMusicControl(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkActionGlobal_GenericMusicControl Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkActionGlobal_GenericMusicControl(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: General_MusicState
    /// </summary>
    public unsafe BmSDK.Engine.AkStateName General_MusicState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkStateName>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// FloatProperty: General_MusicTimeout
    /// </summary>
    public unsafe float General_MusicTimeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: IgnoreCurrentCombatParam
    /// </summary>
    public unsafe bool IgnoreCurrentCombatParam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: ClearsReleaseState
    /// </summary>
    public unsafe bool ClearsReleaseState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }
}
