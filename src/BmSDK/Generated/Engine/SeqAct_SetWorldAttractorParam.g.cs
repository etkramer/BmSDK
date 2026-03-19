#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqAct_SetWorldAttractorParam<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SeqAct_SetWorldAttractorParam : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqAct_SetWorldAttractorParam", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_SetWorldAttractorParam() { }

    /// <summary>
    /// Constructs a new SeqAct_SetWorldAttractorParam
    /// </summary>
    public SeqAct_SetWorldAttractorParam(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_SetWorldAttractorParam Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_SetWorldAttractorParam(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: Attractor
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SeqAct_SetWorldAttractorParam.Range> Attractor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SeqAct_SetWorldAttractorParam.Range>>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bEnabledField
    /// </summary>
    public unsafe bool bEnabledField
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 368); }
    }

    /// <summary>
    /// BoolProperty: bFalloffTypeField
    /// </summary>
    public unsafe bool bFalloffTypeField
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 368); }
    }

    /// <summary>
    /// BoolProperty: bFalloffExponentField
    /// </summary>
    public unsafe bool bFalloffExponentField
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 368); }
    }

    /// <summary>
    /// BoolProperty: bRangeField
    /// </summary>
    public unsafe bool bRangeField
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 368); }
    }

    /// <summary>
    /// BoolProperty: bStrengthField
    /// </summary>
    public unsafe bool bStrengthField
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 368); }
    }

    /// <summary>
    /// BoolProperty: bEnabled
    /// </summary>
    public unsafe bool bEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 368); }
    }

    /// <summary>
    /// ByteProperty: FalloffType
    /// </summary>
    public unsafe byte FalloffType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// StructProperty: FalloffExponent
    /// </summary>
    public unsafe BmSDK.Engine.SeqAct_SetWorldAttractorParam.Range FalloffExponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SeqAct_SetWorldAttractorParam.Range>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// StructProperty: Range
    /// </summary>
    public unsafe BmSDK.Engine.SeqAct_SetWorldAttractorParam.Strength Range
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SeqAct_SetWorldAttractorParam.Strength>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// StructProperty: Strength
    /// </summary>
    public unsafe BmSDK.Engine.SequenceAction.Targets Strength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SequenceAction.Targets>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }
}
