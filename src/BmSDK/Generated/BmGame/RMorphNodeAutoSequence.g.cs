#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RMorphNodeAutoSequence<br/>
/// (size = 172)
/// (flags = 142606482)
/// </summary>
public partial class RMorphNodeAutoSequence : BmSDK.Engine.MorphNodeBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RMorphNodeAutoSequence", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RMorphNodeAutoSequence() { }

    /// <summary>
    /// Constructs a new RMorphNodeAutoSequence
    /// </summary>
    public RMorphNodeAutoSequence(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RMorphNodeAutoSequence Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RMorphNodeAutoSequence(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Set
    /// </summary>
    public unsafe BmSDK.Engine.MorphTargetSet Set
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MorphTargetSet>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// BoolProperty: SynchronizeToAnim
    /// </summary>
    public unsafe bool SynchronizeToAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 148); }
    }

    /// <summary>
    /// ArrayProperty: FrameIndexToTargetIndex
    /// </summary>
    public unsafe BmSDK.TArray<int> FrameIndexToTargetIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// FloatProperty: NormalizedTime
    /// </summary>
    public unsafe float NormalizedTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }
}
