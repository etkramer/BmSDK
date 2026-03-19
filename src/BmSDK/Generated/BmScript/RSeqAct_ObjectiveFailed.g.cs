#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_ObjectiveFailed<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_ObjectiveFailed : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_ObjectiveFailed", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_ObjectiveFailed() { }

    /// <summary>
    /// Constructs a new RSeqAct_ObjectiveFailed
    /// </summary>
    public RSeqAct_ObjectiveFailed(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_ObjectiveFailed Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_ObjectiveFailed(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: GameOverSequence
    /// </summary>
    public unsafe BmSDK.FString GameOverSequence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// ArrayProperty: OptionalAdditionalRandomisedGameOverSequences
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> OptionalAdditionalRandomisedGameOverSequences
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// StrProperty: HintForNextTime
    /// </summary>
    public unsafe BmSDK.FString HintForNextTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// BoolProperty: FadeAudio
    /// </summary>
    public unsafe bool FadeAudio
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 424); }
    }

    /// <summary>
    /// FloatProperty: Time
    /// </summary>
    public unsafe float Time
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }
}
