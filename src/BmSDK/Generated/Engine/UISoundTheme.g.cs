#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: UISoundTheme<br/>
/// (size = 100)
/// (flags = 0)
/// </summary>
public partial class UISoundTheme : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.UISoundTheme", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal UISoundTheme() { }

    /// <summary>
    /// Constructs a new UISoundTheme
    /// </summary>
    public UISoundTheme(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, UISoundTheme Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected UISoundTheme(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: ProcessSoundEvent
    /// </summary>
    public unsafe void ProcessSoundEvent(BmSDK.FName SoundEventName, BmSDK.Engine.PlayerController SoundOwner = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.UISoundTheme.ProcessSoundEvent", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundEventName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundOwner, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ArrayProperty: SoundEventBindings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.UISoundTheme.FSoundEventMapping> SoundEventBindings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.UISoundTheme.FSoundEventMapping>>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// Struct: FSoundEventMapping
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FSoundEventMapping
    {
        /// <summary>
        /// NameProperty: SoundEventName
        /// </summary>
        public unsafe BmSDK.FName SoundEventName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: SoundToPlay
        /// </summary>
        public unsafe BmSDK.Engine.SoundCue SoundToPlay
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SoundCue>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }
}
