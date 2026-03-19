#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_StartGauntletMovie<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_StartGauntletMovie : BmSDK.BmGame.RSeqAct_StartGauntletMovieBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_StartGauntletMovie", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_StartGauntletMovie() { }

    /// <summary>
    /// Constructs a new RSeqAct_StartGauntletMovie
    /// </summary>
    public RSeqAct_StartGauntletMovie(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_StartGauntletMovie Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_StartGauntletMovie(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: GauntletMovie
    /// </summary>
    public unsafe BmSDK.FString GauntletMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// BoolProperty: ForceOpaque
    /// </summary>
    public unsafe bool ForceOpaque
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 388); }
    }

    /// <summary>
    /// BoolProperty: bConnectionFailed
    /// </summary>
    public unsafe bool bConnectionFailed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 388); }
    }

    /// <summary>
    /// BoolProperty: bSkipIntro
    /// </summary>
    public unsafe bool bSkipIntro
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 388); }
    }

    /// <summary>
    /// ObjectProperty: actorToAttachTo
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT actorToAttachTo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// ByteProperty: PortraitName
    /// </summary>
    public unsafe byte PortraitName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }
}
