#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: InterpTrackFloatBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class InterpTrackFloatBase : BmSDK.Engine.InterpTrack, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.InterpTrackFloatBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal InterpTrackFloatBase() { }

    /// <summary>
    /// Constructs a new InterpTrackFloatBase
    /// </summary>
    public InterpTrackFloatBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InterpTrackFloatBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InterpTrackFloatBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: FloatTrack
    /// </summary>
    public unsafe BmSDK.Engine.InterpTrack.SubTracks FloatTrack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.InterpTrack.SubTracks>(Ptr + 180); }
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
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Randomiser
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }
}
