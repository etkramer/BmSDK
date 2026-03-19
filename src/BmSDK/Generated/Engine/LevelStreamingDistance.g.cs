#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: LevelStreamingDistance<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class LevelStreamingDistance : BmSDK.Engine.LevelStreaming, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.LevelStreamingDistance", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal LevelStreamingDistance() { }

    /// <summary>
    /// Constructs a new LevelStreamingDistance
    /// </summary>
    public LevelStreamingDistance(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, LevelStreamingDistance Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected LevelStreamingDistance(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: Origin
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Origin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// FloatProperty: MaxDistance
    /// </summary>
    public unsafe float MaxDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }
}
