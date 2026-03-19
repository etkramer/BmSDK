#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqVar_IdleConfigAim<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqVar_IdleConfigAim : BmSDK.Engine.SequenceVariable, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqVar_IdleConfigAim", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqVar_IdleConfigAim() { }

    /// <summary>
    /// Constructs a new RSeqVar_IdleConfigAim
    /// </summary>
    public RSeqVar_IdleConfigAim(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqVar_IdleConfigAim Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqVar_IdleConfigAim(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: AimDistance
    /// </summary>
    public unsafe float AimDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }

    /// <summary>
    /// BoolProperty: bPlayer
    /// </summary>
    public unsafe bool bPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 236) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 236); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 236); }
    }

    /// <summary>
    /// BoolProperty: bUseMaxTime
    /// </summary>
    public unsafe bool bUseMaxTime
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 236) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 236); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 236); }
    }

    /// <summary>
    /// BoolProperty: bStatusIsOk
    /// </summary>
    public unsafe bool bStatusIsOk
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 236) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 236); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 236); }
    }

    /// <summary>
    /// IntProperty: Priority
    /// </summary>
    public unsafe int Priority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// FloatProperty: DotProdMin
    /// </summary>
    public unsafe float DotProdMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// FloatProperty: SavedDistance
    /// </summary>
    public unsafe float SavedDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// NameProperty: OptionalBoneName
    /// </summary>
    public unsafe BmSDK.FName OptionalBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// FloatProperty: MaxTimeToAim
    /// </summary>
    public unsafe float MaxTimeToAim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// FloatProperty: TimeBetweenAims
    /// </summary>
    public unsafe float TimeBetweenAims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// ObjectProperty: LinkedObj
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LinkedObj
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// ClassProperty: ExpectedType
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ExpectedType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// NameProperty: FindVarName
    /// </summary>
    public unsafe BmSDK.FName FindVarName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }
}
