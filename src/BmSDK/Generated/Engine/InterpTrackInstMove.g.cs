#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: InterpTrackInstMove<br/>
/// (size = 160)
/// (flags = 134217874)
/// </summary>
public partial class InterpTrackInstMove : BmSDK.Engine.InterpTrackInst, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.InterpTrackInstMove", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal InterpTrackInstMove() { }

    /// <summary>
    /// Constructs a new InterpTrackInstMove
    /// </summary>
    public InterpTrackInstMove(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InterpTrackInstMove Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InterpTrackInstMove(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: ResetLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 ResetLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// StructProperty: ResetRotation
    /// </summary>
    public unsafe BmSDK.Rotator ResetRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// StructProperty: InitialTM
    /// </summary>
    public unsafe BmSDK.GameObject.FMatrix InitialTM
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FMatrix>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }

    /// <summary>
    /// StructProperty: InitialQuat
    /// </summary>
    public unsafe BmSDK.GameObject.FQuat InitialQuat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FQuat>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }
}
