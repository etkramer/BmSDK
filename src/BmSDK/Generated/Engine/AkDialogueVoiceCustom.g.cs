#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkDialogueVoiceCustom<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AkDialogueVoiceCustom : BmSDK.Engine.AkDialogueVoice, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkDialogueVoiceCustom", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkDialogueVoiceCustom() { }

    /// <summary>
    /// Constructs a new AkDialogueVoiceCustom
    /// </summary>
    public AkDialogueVoiceCustom(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkDialogueVoiceCustom Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkDialogueVoiceCustom(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: BaseVoice
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueVoice BaseVoice
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueVoice>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// StrProperty: CustomVoiceSubtitleLookup
    /// </summary>
    public unsafe BmSDK.FString CustomVoiceSubtitleLookup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// StrProperty: CustomVoicePortrait
    /// </summary>
    public unsafe BmSDK.FString CustomVoicePortrait
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }
}
