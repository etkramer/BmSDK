#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNode_ScalePlayRateToLength<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RAnimNode_ScalePlayRateToLength : BmSDK.Engine.AnimNodeBlendBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNode_ScalePlayRateToLength", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNode_ScalePlayRateToLength() { }

    /// <summary>
    /// Constructs a new RAnimNode_ScalePlayRateToLength
    /// </summary>
    public RAnimNode_ScalePlayRateToLength(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNode_ScalePlayRateToLength Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNode_ScalePlayRateToLength(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: ScaledAnimLength
    /// </summary>
    public unsafe float ScaledAnimLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }
}
