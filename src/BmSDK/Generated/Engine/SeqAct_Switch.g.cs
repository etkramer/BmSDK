#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqAct_Switch<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SeqAct_Switch : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqAct_Switch", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_Switch() { }

    /// <summary>
    /// Constructs a new SeqAct_Switch
    /// </summary>
    public SeqAct_Switch(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_Switch Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_Switch(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: LinkCount
    /// </summary>
    public unsafe int LinkCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// IntProperty: IncrementAmount
    /// </summary>
    public unsafe int IncrementAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// BoolProperty: bLooping
    /// </summary>
    public unsafe bool bLooping
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 360); }
    }

    /// <summary>
    /// BoolProperty: bAutoDisableLinks
    /// </summary>
    public unsafe bool bAutoDisableLinks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 360); }
    }

    /// <summary>
    /// ArrayProperty: Indices
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>> Indices
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }
}
