#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnPlayerNightwingBase<br/>
/// (size = 6012)
/// (flags = 144703670)
/// </summary>
public partial class RPawnPlayerNightwingBase : BmSDK.BmGame.RPawnPlayer, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnPlayerNightwingBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnPlayerNightwingBase() { }

    /// <summary>
    /// Constructs a new RPawnPlayerNightwingBase
    /// </summary>
    public RPawnPlayerNightwingBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnPlayerNightwingBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnPlayerNightwingBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerNightwingBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerNightwingBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerNightwingBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerNightwingBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerNightwingBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerNightwingBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerNightwingBase>
        => ((GameObject)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: RicochetRayTest
    /// </summary>
    public unsafe virtual void RicochetRayTest(System.Numerics.Vector3 Start, System.Numerics.Vector3 Dir, float Length)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerNightwingBase.RicochetRayTest", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dir, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Length, paramsPtr + 24);
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
    /// Function: UpdateGetRicochetTarget
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor UpdateGetRicochetTarget(int maxIterations, BmSDK.BmGame.RInventoryGadget Gadget)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerNightwingBase.UpdateGetRicochetTarget", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(maxIterations, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Gadget, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: StartGetRicochetTarget
    /// </summary>
    public unsafe virtual void StartGetRicochetTarget(System.Numerics.Vector3 CameraLoc, BmSDK.Rotator CameraRot, System.Numerics.Vector3 launchPos)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerNightwingBase.StartGetRicochetTarget", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraRot, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(launchPos, paramsPtr + 24);
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
    /// NameProperty: TargetClass
    /// </summary>
    public unsafe BmSDK.FName TargetClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5956); }
    }

    /// <summary>
    /// BoolProperty: GettingTarget
    /// </summary>
    public unsafe bool GettingTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5964) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5964); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5964); }
    }

    /// <summary>
    /// IntProperty: RicochetRay
    /// </summary>
    public unsafe int RicochetRay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5968); }
    }

    /// <summary>
    /// IntProperty: RicochetNumRays
    /// </summary>
    public unsafe int RicochetNumRays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5972); }
    }

    /// <summary>
    /// FloatProperty: RicochetMaxRange
    /// </summary>
    public unsafe float RicochetMaxRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5976); }
    }

    /// <summary>
    /// IntProperty: RicochetMaxBounces
    /// </summary>
    public unsafe int RicochetMaxBounces
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5980); }
    }

    /// <summary>
    /// FloatProperty: RicochetMaxAngle
    /// </summary>
    public unsafe float RicochetMaxAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5984); }
    }

    /// <summary>
    /// IntProperty: RicochetMaxExtraTargets
    /// </summary>
    public unsafe int RicochetMaxExtraTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5988); }
    }

    /// <summary>
    /// FloatProperty: RicochetExtraTargetMaxDist
    /// </summary>
    public unsafe float RicochetExtraTargetMaxDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5992); }
    }

    /// <summary>
    /// ArrayProperty: RicochetBouncePoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnPlayerNightwingBase.FNwStickBouncePoint> RicochetBouncePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnPlayerNightwingBase.FNwStickBouncePoint>>(Ptr + 5996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5996); }
    }

    /// <summary>
    /// IntProperty: RicochetNumTargets
    /// </summary>
    public unsafe int RicochetNumTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6008); }
    }

    /// <summary>
    /// Struct: FNwStickBouncePoint
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FNwStickBouncePoint
    {
        /// <summary>
        /// StructProperty: Location
        /// </summary>
        public unsafe System.Numerics.Vector3 Location
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Normal
        /// </summary>
        public unsafe System.Numerics.Vector3 Normal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ObjectProperty: Pawn
        /// </summary>
        public unsafe BmSDK.Engine.Pawn Pawn
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }
}
