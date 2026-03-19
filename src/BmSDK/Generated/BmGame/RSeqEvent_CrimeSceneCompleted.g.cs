#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvent_CrimeSceneCompleted<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqEvent_CrimeSceneCompleted : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvent_CrimeSceneCompleted", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_CrimeSceneCompleted() { }

    /// <summary>
    /// Constructs a new RSeqEvent_CrimeSceneCompleted
    /// </summary>
    public RSeqEvent_CrimeSceneCompleted(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_CrimeSceneCompleted Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_CrimeSceneCompleted(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: PartialCompletionPercentage
    /// </summary>
    public unsafe float PartialCompletionPercentage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// IntProperty: PartialCompletionNumber
    /// </summary>
    public unsafe int PartialCompletionNumber
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// IntProperty: LastTotal
    /// </summary>
    public unsafe int LastTotal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }
}
