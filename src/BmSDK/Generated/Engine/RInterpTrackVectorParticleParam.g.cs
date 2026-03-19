#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RInterpTrackVectorParticleParam<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RInterpTrackVectorParticleParam : BmSDK.Engine.InterpTrackVectorBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RInterpTrackVectorParticleParam", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RInterpTrackVectorParticleParam() { }

    /// <summary>
    /// Constructs a new RInterpTrackVectorParticleParam
    /// </summary>
    public RInterpTrackVectorParticleParam(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RInterpTrackVectorParticleParam Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RInterpTrackVectorParticleParam(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: ParamName
    /// </summary>
    public unsafe BmSDK.FName ParamName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }
}
