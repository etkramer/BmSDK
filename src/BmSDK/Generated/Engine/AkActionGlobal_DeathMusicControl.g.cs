#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkActionGlobal_DeathMusicControl<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AkActionGlobal_DeathMusicControl : BmSDK.Engine.AkActionGlobal_MusicControl, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkActionGlobal_DeathMusicControl", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkActionGlobal_DeathMusicControl() { }

    /// <summary>
    /// Constructs a new AkActionGlobal_DeathMusicControl
    /// </summary>
    public AkActionGlobal_DeathMusicControl(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkActionGlobal_DeathMusicControl Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkActionGlobal_DeathMusicControl(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: DeathState
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DeathState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// FloatProperty: Death_MusicTimeout
    /// </summary>
    public unsafe float Death_MusicTimeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }
}
