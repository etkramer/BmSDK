#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RAnimNotifyToken_SoundInterruptable<br/>
/// (size = 100)
/// (flags = 0)
/// </summary>
public partial class RAnimNotifyToken_SoundInterruptable : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RAnimNotifyToken_SoundInterruptable", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNotifyToken_SoundInterruptable() { }

    /// <summary>
    /// Constructs a new RAnimNotifyToken_SoundInterruptable
    /// </summary>
    public RAnimNotifyToken_SoundInterruptable(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNotifyToken_SoundInterruptable Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNotifyToken_SoundInterruptable(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: Handle
    /// </summary>
    public unsafe BmSDK.Engine.AkWwise.FAkSoundHandle Handle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkWwise.FAkSoundHandle>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
