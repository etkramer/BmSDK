#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: InterpTrackMoveAxis<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class InterpTrackMoveAxis : BmSDK.Engine.InterpTrackFloatBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.InterpTrackMoveAxis", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal InterpTrackMoveAxis() { }

    /// <summary>
    /// Constructs a new InterpTrackMoveAxis
    /// </summary>
    public InterpTrackMoveAxis(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InterpTrackMoveAxis Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InterpTrackMoveAxis(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: MoveAxis
    /// </summary>
    public unsafe BmSDK.Engine.InterpTrackMoveAxis.EInterpMoveAxis MoveAxis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.InterpTrackMoveAxis.EInterpMoveAxis>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// StructProperty: LookupTrack
    /// </summary>
    public unsafe BmSDK.Engine.InterpTrackMove.FInterpLookupTrack LookupTrack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.InterpTrackMove.FInterpLookupTrack>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// Enum: EInterpMoveAxis
    /// </summary>
    public enum EInterpMoveAxis
    {
        AXIS_TranslationX = 0,
        AXIS_TranslationY = 1,
        AXIS_TranslationZ = 2,
        AXIS_RotationX = 3,
        AXIS_RotationY = 4,
        AXIS_RotationZ = 5,
        AXIS_MAX = 6,
    }
}
