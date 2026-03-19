#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: AkSDRelationshipSymbolNotEqual<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AkSDRelationshipSymbolNotEqual : BmSDK.AkAudio.AkSDRelationship, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.AkSDRelationshipSymbolNotEqual", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkSDRelationshipSymbolNotEqual() { }

    /// <summary>
    /// Constructs a new AkSDRelationshipSymbolNotEqual
    /// </summary>
    public AkSDRelationshipSymbolNotEqual(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkSDRelationshipSymbolNotEqual Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkSDRelationshipSymbolNotEqual(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: VariableNodes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> VariableNodes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// IntProperty: NodeUpdateHint
    /// </summary>
    public unsafe int NodeUpdateHint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ArrayProperty: ChildNodes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ChildNodes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: HasOutputPin
    /// </summary>
    public unsafe bool HasOutputPin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: HasInputPin
    /// </summary>
    public unsafe bool HasInputPin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: HasVariablePin
    /// </summary>
    public unsafe bool HasVariablePin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: HasFixedVariables
    /// </summary>
    public unsafe bool HasFixedVariables
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: HideFromMenu
    /// </summary>
    public unsafe bool HideFromMenu
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: IgnoreThisComment
    /// </summary>
    public unsafe bool IgnoreThisComment
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// StrProperty: EditorDescription
    /// </summary>
    public unsafe BmSDK.FString EditorDescription
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// StrProperty: ShortDescription
    /// </summary>
    public unsafe BmSDK.FString ShortDescription
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// StrProperty: OutputPinName
    /// </summary>
    public unsafe BmSDK.FString OutputPinName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// StrProperty: InputPinName
    /// </summary>
    public unsafe BmSDK.FString InputPinName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// IntProperty: NodeFlag
    /// </summary>
    public unsafe int NodeFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// StructProperty: dbgTimer
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT dbgTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// IntProperty: dbgCycleTimer
    /// </summary>
    public unsafe int dbgCycleTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// StrProperty: dbgCalculated
    /// </summary>
    public unsafe BmSDK.FString dbgCalculated
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// StrProperty: Comment
    /// </summary>
    public unsafe BmSDK.FString Comment
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// Struct: FVariables
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FVariables
    {
        /// <summary>
        /// ObjectProperty: Entity
        /// </summary>
        public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Entity
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: Text
        /// </summary>
        public unsafe BmSDK.FString Text
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: Types
        /// </summary>
        public unsafe int Types
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ObjectProperty: Ed
        /// </summary>
        public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Ed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }
    }
}
