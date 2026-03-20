#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkDialogueVoiceSet<br/>
/// (flags = 0)
/// </summary>
public partial class AkDialogueVoiceSet : BmSDK.Engine.AkDialogueVoice, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkDialogueVoiceSet", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkDialogueVoiceSet() { }

    /// <summary>
    /// Constructs a new AkDialogueVoiceSet
    /// </summary>
    public AkDialogueVoiceSet(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkDialogueVoiceSet Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkDialogueVoiceSet(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: Voices
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkDialogueVoice> Voices
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkDialogueVoice>>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bVisited
    /// </summary>
    public unsafe bool bVisited
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 184) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 184); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 184); }
    }
}
