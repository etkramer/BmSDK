#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkAudioActionEvent<br/>
/// (size = 72)
/// (flags = 134230162)
/// </summary>
public partial class AkAudioActionEvent : BmSDK.Engine.AkAudioAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkAudioActionEvent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkAudioActionEvent() { }

    /// <summary>
    /// Constructs a new AkAudioActionEvent
    /// </summary>
    public AkAudioActionEvent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkAudioActionEvent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkAudioActionEvent(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: ActionTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor ActionTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }

    /// <summary>
    /// ObjectProperty: ActionEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ActionEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// StructProperty: ActionSoundHandle
    /// </summary>
    public unsafe BmSDK.Engine.AkWwise.FAkSoundHandle ActionSoundHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkWwise.FAkSoundHandle>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }
}
