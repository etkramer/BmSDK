#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkAudioNotifySet<br/>
/// (flags = 0)
/// </summary>
public partial class AkAudioNotifySet : BmSDK.Engine.AkHash, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkAudioNotifySet", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkAudioNotifySet() { }

    /// <summary>
    /// Constructs a new AkAudioNotifySet
    /// </summary>
    public AkAudioNotifySet(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkAudioNotifySet Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkAudioNotifySet(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: Entries
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkAudioNotifySet.FAkAudioNotifyDefine> Entries
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkAudioNotifySet.FAkAudioNotifyDefine>>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// Struct: FAkAudioNotifyDefine
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FAkAudioNotifyDefine
    {
        /// <summary>
        /// ObjectProperty: Type
        /// </summary>
        public unsafe BmSDK.Engine.AkAudioNotifyType Type
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkAudioNotifyType>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: Event
        /// </summary>
        public unsafe BmSDK.Engine.AkEvent Event
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }
}
