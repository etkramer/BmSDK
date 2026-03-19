#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: AkDialogueTape<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AkDialogueTape : BmSDK.Engine.AkHash, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.AkDialogueTape", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkDialogueTape() { }

    /// <summary>
    /// Constructs a new AkDialogueTape
    /// </summary>
    public AkDialogueTape(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkDialogueTape Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkDialogueTape(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Conversation
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Conversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ObjectProperty: Event
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Event
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// IntProperty: ConversationId
    /// </summary>
    public unsafe int ConversationId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// StructProperty: EventHandle
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT EventHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// StructProperty: SpeechOpts
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SpeechOpts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// ByteProperty: TapeState
    /// </summary>
    public unsafe byte TapeState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// StructProperty: WwiseSourceId
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT WwiseSourceId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// FloatProperty: DuckLevel
    /// </summary>
    public unsafe float DuckLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// Enum: EAkDialogueTapeState
    /// </summary>
    public enum EAkDialogueTapeState
    {
        AK_TAPE_Initialised = 0,
        AK_TAPE_Loading = 1,
        AK_TAPE_Loaded = 2,
        AK_TAPE_DialogueLoading = 3,
        AK_TAPE_Speaking = 4,
        AK_TAPE_Finished = 5,
        AK_TAPE_MAX = 6,
    }
}
