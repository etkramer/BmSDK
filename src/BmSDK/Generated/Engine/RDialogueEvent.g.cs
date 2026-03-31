#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RDialogueEvent<br/>
/// (size = 228)
/// (flags = 134217906)
/// </summary>
public partial class RDialogueEvent : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RDialogueEvent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RDialogueEvent.
    /// </summary>
    public static RDialogueEvent DefaultObject => (RDialogueEvent)StaticClass().DefaultObject;

    internal RDialogueEvent() { }

    /// <summary>
    /// Constructs a new RDialogueEvent
    /// </summary>
    public RDialogueEvent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDialogueEvent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDialogueEvent(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDialogueEvent>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDialogueEvent>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDialogueEvent>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDialogueEvent>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDialogueEvent>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDialogueEvent>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDialogueEvent>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDialogueEvent>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: GetCueDuration
    /// </summary>
    public unsafe virtual float GetCueDuration()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.RDialogueEvent.GetCueDuration", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// ObjectProperty: WwiseDialogueEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent WwiseDialogueEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// ObjectProperty: WwiseDuckingParameter
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName WwiseDuckingParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// StrProperty: CharacterName
    /// </summary>
    public unsafe BmSDK.FString CharacterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: bUsesTTS
    /// </summary>
    public unsafe bool bUsesTTS
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }
    }

    /// <summary>
    /// BoolProperty: bSyncFaceFX
    /// </summary>
    public unsafe bool bSyncFaceFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }
    }

    /// <summary>
    /// BoolProperty: NotInDemo
    /// </summary>
    public unsafe bool NotInDemo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }
    }

    /// <summary>
    /// BoolProperty: Is2D
    /// </summary>
    public unsafe bool Is2D
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }
    }

    /// <summary>
    /// BoolProperty: bEffect_IsRadio
    /// </summary>
    public unsafe bool bEffect_IsRadio
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreForSurviellance
    /// </summary>
    public unsafe bool bIgnoreForSurviellance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }
    }

    /// <summary>
    /// ByteProperty: DialogueEvent_Type
    /// </summary>
    public unsafe BmSDK.Engine.AkWwise.EDialogueHelperType DialogueEvent_Type
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkWwise.EDialogueHelperType>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }

    /// <summary>
    /// ByteProperty: Priority
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueEvent.EPriority Priority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueEvent.EPriority>(Ptr + 69); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 69); }
    }

    /// <summary>
    /// ByteProperty: PlaceHolder
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueEvent.EPlaceHolder PlaceHolder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueEvent.EPlaceHolder>(Ptr + 70); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 70); }
    }

    /// <summary>
    /// FloatProperty: MaxRange
    /// </summary>
    public unsafe float MaxRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 72); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }
    }

    /// <summary>
    /// FloatProperty: Duration
    /// </summary>
    public unsafe float Duration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 76); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }
    }

    /// <summary>
    /// ArrayProperty: OtherLangDuration
    /// </summary>
    public unsafe BmSDK.TArray<float> OtherLangDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }

    /// <summary>
    /// ArrayProperty: Subtitles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.EngineTypes.FSubtitleCue> Subtitles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.EngineTypes.FSubtitleCue>>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// StrProperty: Effect
    /// </summary>
    public unsafe BmSDK.FString Effect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// ObjectProperty: FaceFXAnimSetRef
    /// </summary>
    public unsafe BmSDK.Engine.FaceFXAnimSet FaceFXAnimSetRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.FaceFXAnimSet>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// StrProperty: FaceFXGroupName
    /// </summary>
    public unsafe BmSDK.FString FaceFXGroupName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// StrProperty: FaceFXAnimName
    /// </summary>
    public unsafe BmSDK.FString FaceFXAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ArrayProperty: AnimTriggers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RDialogueEvent.FAnimTriggerFaceFXTag> AnimTriggers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RDialogueEvent.FAnimTriggerFaceFXTag>>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// ArrayProperty: LocalizedSubtitles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RDialogueEvent.FRLocalizedSubtitle> LocalizedSubtitles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RDialogueEvent.FRLocalizedSubtitle>>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// StrProperty: TaggedText
    /// </summary>
    public unsafe BmSDK.FString TaggedText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// StrProperty: SubtitleCharacterName
    /// </summary>
    public unsafe BmSDK.FString SubtitleCharacterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// StrProperty: debugSubtitleCharacterName
    /// </summary>
    public unsafe BmSDK.FString debugSubtitleCharacterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// IntProperty: ImportRef
    /// </summary>
    public unsafe int ImportRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// StrProperty: LocDirect_StringID
    /// </summary>
    public unsafe BmSDK.FString LocDirect_StringID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// IntProperty: LocDirect_Hash
    /// </summary>
    public unsafe int LocDirect_Hash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// IntProperty: ConversationID
    /// </summary>
    public unsafe int ConversationID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// Struct: FAnimTriggerFaceFXTag
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FAnimTriggerFaceFXTag
    {
        /// <summary>
        /// NameProperty: TagName
        /// </summary>
        public unsafe BmSDK.FName TagName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: TagParams
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FString> TagParams
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ObjectProperty: TagAnimSet
        /// </summary>
        public unsafe BmSDK.Engine.AnimSet TagAnimSet
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: AtTime
        /// </summary>
        public unsafe float AtTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Struct: FRLocalizedSubtitle
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FRLocalizedSubtitle
    {
        /// <summary>
        /// StrProperty: Language
        /// </summary>
        public unsafe BmSDK.FString Language
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: Subtitles
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.EngineTypes.FSubtitleCue> Subtitles
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.EngineTypes.FSubtitleCue>>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Enum: EPlaceHolder
    /// </summary>
    public enum EPlaceHolder
    {
        PH_UNKNOWN = 0,
        PH_PLACEHOLDER = 1,
        PH_TEMPDIALOGUE = 2,
        PH_FINAL = 3,
        PH_SOUND_NOT_FOUND = 4,
        PH_DIALOGUE_TRACK_NEEDED = 5,
        PH_NO_CHARACTER = 6,
        PH_DIALOGUEBANK_NOT_FOUND = 7,
        PH_DIALOGUESTREAMS_NOT_LOADED = 8,
        PH_MAX = 9,
    }

    /// <summary>
    /// Enum: EPriority
    /// </summary>
    public enum EPriority
    {
        PRI_UNKNOWN = 0,
        PRI_EMOTE = 1,
        PRI_LOW = 2,
        PRI_NORMAL = 3,
        PRI_HIGH = 4,
        PRI_MAX = 5,
    }
}
