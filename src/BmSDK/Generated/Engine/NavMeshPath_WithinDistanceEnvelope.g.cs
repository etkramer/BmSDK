#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: NavMeshPath_WithinDistanceEnvelope<br/>
/// (size = 136)
/// (flags = 134217874)
/// </summary>
public partial class NavMeshPath_WithinDistanceEnvelope : BmSDK.Engine.NavMeshPathConstraint, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.NavMeshPath_WithinDistanceEnvelope", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal NavMeshPath_WithinDistanceEnvelope() { }

    /// <summary>
    /// Constructs a new NavMeshPath_WithinDistanceEnvelope
    /// </summary>
    public NavMeshPath_WithinDistanceEnvelope(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, NavMeshPath_WithinDistanceEnvelope Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected NavMeshPath_WithinDistanceEnvelope(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: Recycle
    /// </summary>
    public unsafe override void Recycle()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.NavMeshPath_WithinDistanceEnvelope.Recycle", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StayWithinEnvelopeToLoc
    /// </summary>
    public unsafe static bool StayWithinEnvelopeToLoc(BmSDK.Engine.NavigationHandle NavHandle, System.Numerics.Vector3 InEnvelopeTestPoint, float InMaxDistance, float InMinDistance, bool bInSoft = default, float InSoftStartPenalty = default, bool bOnlyTossOutSpecsThatLeave = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.NavMeshPath_WithinDistanceEnvelope.StayWithinEnvelopeToLoc", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NavHandle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InEnvelopeTestPoint, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InMaxDistance, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InMinDistance, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInSoft, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSoftStartPenalty, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnlyTossOutSpecsThatLeave, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 40);
    }

    /// <summary>
    /// FloatProperty: MaxDistance
    /// </summary>
    public unsafe float MaxDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// FloatProperty: MinDistance
    /// </summary>
    public unsafe float MinDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: bSoft
    /// </summary>
    public unsafe bool bSoft
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: bOnlyThrowOutNodesThatLeaveEnvelope
    /// </summary>
    public unsafe bool bOnlyThrowOutNodesThatLeaveEnvelope
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// FloatProperty: SoftStartPenalty
    /// </summary>
    public unsafe float SoftStartPenalty
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// StructProperty: EnvelopeTestPoint
    /// </summary>
    public unsafe System.Numerics.Vector3 EnvelopeTestPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }
}
