#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SkeletalMeshActorMAT<br/>
/// (size = 508)
/// (flags = 142606482)
/// </summary>
public partial class SkeletalMeshActorMAT : BmSDK.Engine.SkeletalMeshCinematicActor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SkeletalMeshActorMAT", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as SkeletalMeshActorMAT.
    /// </summary>
    public static SkeletalMeshActorMAT DefaultObject => (SkeletalMeshActorMAT)StaticClass().DefaultObject;

    internal SkeletalMeshActorMAT() { }

    /// <summary>
    /// Constructs a new SkeletalMeshActorMAT
    /// </summary>
    public SkeletalMeshActorMAT(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SkeletalMeshActorMAT Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SkeletalMeshActorMAT(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SkeletalMeshActorMAT>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SkeletalMeshActorMAT>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SkeletalMeshActorMAT>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SkeletalMeshActorMAT>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SkeletalMeshActorMAT>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SkeletalMeshActorMAT>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SkeletalMeshActorMAT>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SkeletalMeshActorMAT>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: SetSkelControlScale
    /// </summary>
    public unsafe override void SetSkelControlScale(BmSDK.FName SkelControlName, float Scale)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.SkeletalMeshActorMAT.SetSkelControlScale", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelControlName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scale, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetMorphWeight
    /// </summary>
    public unsafe override void SetMorphWeight(BmSDK.FName MorphNodeName, float MorphWeight)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.SkeletalMeshActorMAT.SetMorphWeight", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MorphNodeName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MorphWeight, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FinishAnimControl
    /// </summary>
    public unsafe override void FinishAnimControl(BmSDK.Engine.InterpGroup InInterpGroup)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.SkeletalMeshActorMAT.FinishAnimControl", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroup, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: MAT_SetAnimPosition
    /// </summary>
    public unsafe virtual void MAT_SetAnimPosition(BmSDK.FName SlotName, int ChannelIndex, BmSDK.FName InAnimSeqName, float InPosition, bool bFireNotifies, bool bLooping, bool bEnableRootMotion)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.SkeletalMeshActorMAT.MAT_SetAnimPosition", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChannelIndex, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InAnimSeqName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPosition, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFireNotifies, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLooping, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableRootMotion, paramsPtr + 32);
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
    /// Function: SetAnimPosition
    /// </summary>
    public unsafe override void SetAnimPosition(BmSDK.FName SlotName, int ChannelIndex, BmSDK.FName InAnimSeqName, float InPosition, bool bFireNotifies, bool bLooping, bool bEnableRootMotion)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.SkeletalMeshActorMAT.SetAnimPosition", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChannelIndex, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InAnimSeqName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPosition, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFireNotifies, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLooping, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableRootMotion, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearAnimNodes
    /// </summary>
    public unsafe virtual void ClearAnimNodes()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.SkeletalMeshActorMAT.ClearAnimNodes", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CacheAnimNodes
    /// </summary>
    public unsafe virtual void CacheAnimNodes()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.SkeletalMeshActorMAT.CacheAnimNodes", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PostInitAnimTree
    /// </summary>
    public unsafe override void PostInitAnimTree(BmSDK.Engine.SkeletalMeshComponent SkelComp)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.SkeletalMeshActorMAT.PostInitAnimTree", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelComp, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.SkeletalMeshActorMAT.Destroyed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: MAT_SetSkelControlScale
    /// </summary>
    public unsafe virtual void MAT_SetSkelControlScale(BmSDK.FName SkelControlName, float Scale)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.SkeletalMeshActorMAT.MAT_SetSkelControlScale", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelControlName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scale, paramsPtr + 8);
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
    /// Function: MAT_SetMorphWeight
    /// </summary>
    public unsafe virtual void MAT_SetMorphWeight(BmSDK.FName MorphNodeName, float MorphWeight)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.SkeletalMeshActorMAT.MAT_SetMorphWeight", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MorphNodeName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MorphWeight, paramsPtr + 8);
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
    /// Function: MAT_SetAnimWeights
    /// </summary>
    public unsafe virtual void MAT_SetAnimWeights(BmSDK.TArray<BmSDK.Engine.Actor.FAnimSlotInfo> SlotInfos)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.SkeletalMeshActorMAT.MAT_SetAnimWeights", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotInfos, paramsPtr + 0);
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
    /// ArrayProperty: SlotNodes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimNodeSlot> SlotNodes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimNodeSlot>>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }
}
