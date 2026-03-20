#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: InterpTrackVectorBase<br/>
/// (flags = 0)
/// </summary>
public partial class InterpTrackVectorBase : BmSDK.Engine.InterpTrack, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.InterpTrackVectorBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal InterpTrackVectorBase() { }

    /// <summary>
    /// Constructs a new InterpTrackVectorBase
    /// </summary>
    public InterpTrackVectorBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InterpTrackVectorBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InterpTrackVectorBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: VectorTrack
    /// </summary>
    public unsafe BmSDK.GameObject.FInterpCurveVector VectorTrack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FInterpCurveVector>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// FloatProperty: CurveTension
    /// </summary>
    public unsafe float CurveTension
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// StructProperty: Randomiser
    /// </summary>
    public unsafe BmSDK.Engine.InterpTrackVectorBase.FRandomGeneratorVector Randomiser
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.InterpTrackVectorBase.FRandomGeneratorVector>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }
}
