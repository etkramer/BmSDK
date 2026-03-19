#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_SwitchPlayerCharacter<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_SwitchPlayerCharacter : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_SwitchPlayerCharacter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_SwitchPlayerCharacter() { }

    /// <summary>
    /// Constructs a new RSeqAct_SwitchPlayerCharacter
    /// </summary>
    public RSeqAct_SwitchPlayerCharacter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_SwitchPlayerCharacter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_SwitchPlayerCharacter(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: CharacterName
    /// </summary>
    public unsafe BmSDK.FString CharacterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// ObjectProperty: PlayerStartPoint
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerStartPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// ObjectProperty: SwitchToThisPawn
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SwitchToThisPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// StrProperty: OldCharacterClassName
    /// </summary>
    public unsafe BmSDK.FString OldCharacterClassName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// BoolProperty: HasBeenActivated
    /// </summary>
    public unsafe bool HasBeenActivated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 424); }
    }

    /// <summary>
    /// BoolProperty: HasStartedLoadingCharacters
    /// </summary>
    public unsafe bool HasStartedLoadingCharacters
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 424); }
    }

    /// <summary>
    /// BoolProperty: bCatwomanSwitchPoint
    /// </summary>
    public unsafe bool bCatwomanSwitchPoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 424); }
    }

    /// <summary>
    /// BoolProperty: PreLoading
    /// </summary>
    public unsafe bool PreLoading
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 424); }
    }

    /// <summary>
    /// BoolProperty: PreLoaded
    /// </summary>
    public unsafe bool PreLoaded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 424); }
    }

    /// <summary>
    /// IntProperty: PreLoadSlot
    /// </summary>
    public unsafe int PreLoadSlot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }
}
