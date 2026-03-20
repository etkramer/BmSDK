#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSkelControl_CantileverBeam<br/>
/// (flags = 0)
/// </summary>
public partial class RSkelControl_CantileverBeam : BmSDK.Engine.SkelControlLookAt, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSkelControl_CantileverBeam", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSkelControl_CantileverBeam() { }

    /// <summary>
    /// Constructs a new RSkelControl_CantileverBeam
    /// </summary>
    public RSkelControl_CantileverBeam(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSkelControl_CantileverBeam Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSkelControl_CantileverBeam(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: WorldSpaceGoal
    /// </summary>
    public unsafe System.Numerics.Vector3 WorldSpaceGoal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// StructProperty: InitialWorldSpaceGoalOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 InitialWorldSpaceGoalOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// StructProperty: Velocity
    /// </summary>
    public unsafe System.Numerics.Vector3 Velocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// FloatProperty: SpringStiffness
    /// </summary>
    public unsafe float SpringStiffness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// FloatProperty: SpringDamping
    /// </summary>
    public unsafe float SpringDamping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// FloatProperty: PercentBeamVelocityTransfer
    /// </summary>
    public unsafe float PercentBeamVelocityTransfer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// DelegateProperty: __EntireBeamVelocity__Delegate
    /// </summary>
    public unsafe System.IntPtr __EntireBeamVelocity__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }
}
