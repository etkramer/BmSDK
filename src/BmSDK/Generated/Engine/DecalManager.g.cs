#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DecalManager<br/>
/// (size = 728)
/// (flags = 0)
/// </summary>
public partial class DecalManager : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DecalManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DecalManager() { }

    /// <summary>
    /// Constructs a new DecalManager
    /// </summary>
    public DecalManager(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DecalManager Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DecalManager(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<DecalManager>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<DecalManager>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<DecalManager>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<DecalManager>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<DecalManager>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<DecalManager>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<DecalManager>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: SpawnDecal
    /// </summary>
    public unsafe BmSDK.Engine.DecalComponent SpawnDecal(BmSDK.Engine.MaterialInterface DecalMaterial, System.Numerics.Vector3 DecalLocation, BmSDK.Rotator DecalOrientation, float Width, float Height, float Thickness, bool bNoClip, float DecalRotation = default, BmSDK.Engine.PrimitiveComponent HitComponent = default, bool bProjectOnTerrain = default, bool bProjectOnSkeletalMeshes = default, BmSDK.FName HitBone = default, int HitNodeIndex = default, int HitLevelIndex = default, float InDecalLifeSpan = default, int InFracturedStaticMeshComponentIndex = default, float InDepthBias = default, System.Numerics.Vector2 InBlendRange = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.DecalManager.SpawnDecal", true);
        byte* paramsPtr = stackalloc byte[132];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DecalMaterial, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DecalLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DecalOrientation, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Width, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Height, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Thickness, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNoClip, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DecalRotation, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitComponent, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bProjectOnTerrain, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bProjectOnSkeletalMeshes, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitBone, paramsPtr + 68);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNodeIndex, paramsPtr + 76);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLevelIndex, paramsPtr + 80);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InDecalLifeSpan, paramsPtr + 84);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InFracturedStaticMeshComponentIndex, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InDepthBias, paramsPtr + 92);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InBlendRange, paramsPtr + 96);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DecalComponent>(paramsPtr + 104);
    }

    /// <summary>
    /// Function: GetPooledComponent
    /// </summary>
    public unsafe BmSDK.Engine.DecalComponent GetPooledComponent()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.DecalManager.GetPooledComponent", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DecalComponent>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetDecalParameters
    /// </summary>
    public unsafe static void SetDecalParameters(BmSDK.Engine.DecalComponent TheDecal, BmSDK.Engine.MaterialInterface DecalMaterial, System.Numerics.Vector3 DecalLocation, BmSDK.Rotator DecalOrientation, float Width, float Height, float Thickness, bool bNoClip, float DecalRotation, BmSDK.Engine.PrimitiveComponent HitComponent, bool bProjectOnTerrain, bool bProjectOnSkeletalMeshes, BmSDK.FName HitBone, int HitNodeIndex, int HitLevelIndex, int InFracturedStaticMeshComponentIndex, float DepthBias, System.Numerics.Vector2 BlendRange)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.DecalManager.SetDecalParameters", true);
        byte* paramsPtr = stackalloc byte[108];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheDecal, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DecalMaterial, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DecalLocation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DecalOrientation, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Width, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Height, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Thickness, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNoClip, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DecalRotation, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitComponent, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bProjectOnTerrain, paramsPtr + 68);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bProjectOnSkeletalMeshes, paramsPtr + 72);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitBone, paramsPtr + 76);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNodeIndex, paramsPtr + 84);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLevelIndex, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InFracturedStaticMeshComponentIndex, paramsPtr + 92);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DepthBias, paramsPtr + 96);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendRange, paramsPtr + 100);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanSpawnDecals
    /// </summary>
    public unsafe bool CanSpawnDecals()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.DecalManager.CanSpawnDecals", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: DecalFinished
    /// </summary>
    public unsafe void DecalFinished(BmSDK.Engine.DecalComponent Decal)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.DecalManager.DecalFinished", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Decal, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AreDynamicDecalsEnabled
    /// </summary>
    public unsafe static bool AreDynamicDecalsEnabled()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.DecalManager.AreDynamicDecalsEnabled", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Struct: FActiveDecalInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FActiveDecalInfo
    {
        /// <summary>
        /// ComponentProperty: Decal
        /// </summary>
        public unsafe BmSDK.Engine.DecalComponent Decal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DecalComponent>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: LifetimeRemaining
        /// </summary>
        public unsafe float LifetimeRemaining
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// ComponentProperty: DecalTemplate
    /// </summary>
    public unsafe BmSDK.Engine.DecalComponent DecalTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DecalComponent>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ArrayProperty: PoolDecals
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.DecalComponent> PoolDecals
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.DecalComponent>>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// IntProperty: MaxActiveDecals
    /// </summary>
    public unsafe int MaxActiveDecals
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// FloatProperty: DecalLifeSpan
    /// </summary>
    public unsafe float DecalLifeSpan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// FloatProperty: DecalDepthBias
    /// </summary>
    public unsafe float DecalDepthBias
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// StructProperty: DecalBlendRange
    /// </summary>
    public unsafe System.Numerics.Vector2 DecalBlendRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// ArrayProperty: ActiveDecals
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.DecalManager.FActiveDecalInfo> ActiveDecals
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.DecalManager.FActiveDecalInfo>>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }
}
