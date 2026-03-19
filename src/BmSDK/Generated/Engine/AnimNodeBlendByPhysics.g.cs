#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AnimNodeBlendByPhysics<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AnimNodeBlendByPhysics : BmSDK.Engine.AnimNodeBlendList, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AnimNodeBlendByPhysics", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AnimNodeBlendByPhysics() { }

    /// <summary>
    /// Constructs a new AnimNodeBlendByPhysics
    /// </summary>
    public AnimNodeBlendByPhysics(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AnimNodeBlendByPhysics Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AnimNodeBlendByPhysics(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: TargetWeight
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>> TargetWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// FloatProperty: BlendTimeToGo
    /// </summary>
    public unsafe float BlendTimeToGo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// IntProperty: ActiveChildIndex
    /// </summary>
    public unsafe int ActiveChildIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// BoolProperty: bPlayActiveChild
    /// </summary>
    public unsafe bool bPlayActiveChild
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 328); }
    }

    /// <summary>
    /// BoolProperty: bForceChildFullWeightWhenBecomingRelevant
    /// </summary>
    public unsafe bool bForceChildFullWeightWhenBecomingRelevant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 328); }
    }

    /// <summary>
    /// BoolProperty: bSkipBlendWhenNotRendered
    /// </summary>
    public unsafe bool bSkipBlendWhenNotRendered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 328); }
    }

    /// <summary>
    /// FloatProperty: SliderPosition
    /// </summary>
    public unsafe float SliderPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// IntProperty: EditorActiveChildIndex
    /// </summary>
    public unsafe int EditorActiveChildIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }
}
