#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SoundCue<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SoundCue : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SoundCue", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SoundCue() { }

    /// <summary>
    /// Constructs a new SoundCue
    /// </summary>
    public SoundCue(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SoundCue Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SoundCue(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: FMODCategory
    /// </summary>
    public unsafe BmSDK.FString FMODCategory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: FirstNode
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FirstNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ObjectProperty: FaceFXAnimSetRef
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FaceFXAnimSetRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// MapProperty: EditorData
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ EditorData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// FloatProperty: VolumeMultiplier
    /// </summary>
    public unsafe float VolumeMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// FloatProperty: PitchMultiplier
    /// </summary>
    public unsafe float PitchMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// FloatProperty: Duration
    /// </summary>
    public unsafe float Duration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// BoolProperty: IgnorePitch
    /// </summary>
    public unsafe bool IgnorePitch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 200) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 200); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 200); }
    }

    /// <summary>
    /// StrProperty: FaceFXGroupName
    /// </summary>
    public unsafe BmSDK.FString FaceFXGroupName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// StrProperty: FaceFXAnimName
    /// </summary>
    public unsafe BmSDK.FString FaceFXAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// Struct: FSoundNodeEditorData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FSoundNodeEditorData
    {
        /// <summary>
        /// IntProperty: NodePosX
        /// </summary>
        public unsafe int NodePosX
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: NodePosY
        /// </summary>
        public unsafe int NodePosY
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }
}
