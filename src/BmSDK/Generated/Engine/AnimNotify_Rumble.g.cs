#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AnimNotify_Rumble<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AnimNotify_Rumble : BmSDK.Engine.AnimNotify, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AnimNotify_Rumble", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AnimNotify_Rumble() { }

    /// <summary>
    /// Constructs a new AnimNotify_Rumble
    /// </summary>
    public AnimNotify_Rumble(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AnimNotify_Rumble Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AnimNotify_Rumble(nint ptr) : base(ptr) { }

    /// <summary>
    /// ClassProperty: PredefinedWaveForm
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PredefinedWaveForm
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: WaveForm
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WaveForm
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: bCheckForBasedPlayer
    /// </summary>
    public unsafe bool bCheckForBasedPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// FloatProperty: EffectRadius
    /// </summary>
    public unsafe float EffectRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }
}
