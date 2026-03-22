#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RB_RadialImpulseComponent<br/>
/// (size = 424)
/// (flags = 2290090130)
/// </summary>
public partial class RB_RadialImpulseComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RB_RadialImpulseComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RB_RadialImpulseComponent() { }

    /// <summary>
    /// Constructs a new RB_RadialImpulseComponent
    /// </summary>
    public RB_RadialImpulseComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RB_RadialImpulseComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RB_RadialImpulseComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: FireImpulse
    /// </summary>
    public unsafe virtual void FireImpulse(System.Numerics.Vector3 Origin)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.RB_RadialImpulseComponent.FireImpulse", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Origin, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// ByteProperty: ImpulseFalloff
    /// </summary>
    public unsafe BmSDK.Engine.PrimitiveComponent.ERadialImpulseFalloff ImpulseFalloff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent.ERadialImpulseFalloff>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// FloatProperty: ImpulseStrength
    /// </summary>
    public unsafe float ImpulseStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// FloatProperty: ImpulseRadius
    /// </summary>
    public unsafe float ImpulseRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// BoolProperty: bVelChange
    /// </summary>
    public unsafe bool bVelChange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 416); }
    }

    /// <summary>
    /// BoolProperty: bAffectsRagdolls
    /// </summary>
    public unsafe bool bAffectsRagdolls
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 416); }
    }

    /// <summary>
    /// BoolProperty: bCauseFracture
    /// </summary>
    public unsafe bool bCauseFracture
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 416); }
    }

    /// <summary>
    /// ComponentProperty: PreviewSphere
    /// </summary>
    public unsafe BmSDK.Engine.DrawSphereComponent PreviewSphere
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DrawSphereComponent>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }
}
