#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGangInteractPointBreakableBase<br/>
/// (flags = 0)
/// </summary>
public partial class RGangInteractPointBreakableBase : BmSDK.BmGame.RGangInteractPointBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGangInteractPointBreakableBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGangInteractPointBreakableBase() { }

    /// <summary>
    /// Constructs a new RGangInteractPointBreakableBase
    /// </summary>
    public RGangInteractPointBreakableBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGangInteractPointBreakableBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGangInteractPointBreakableBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGangInteractPointBreakableBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGangInteractPointBreakableBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGangInteractPointBreakableBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGangInteractPointBreakableBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGangInteractPointBreakableBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGangInteractPointBreakableBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGangInteractPointBreakableBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: GetPOILocation
    /// </summary>
    public unsafe System.Numerics.Vector3 GetPOILocation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGangInteractPointBreakableBase.GetPOILocation", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CrackObject
    /// </summary>
    public unsafe void CrackObject(System.Numerics.Vector3 SmashLocation, System.Numerics.Vector3 SmashNormal, System.Numerics.Vector3 SmashSpeed, bool bCanSmash, bool bForceSmash, BmSDK.Engine.Actor SmashActor = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGangInteractPointBreakableBase.CrackObject", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SmashLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SmashNormal, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SmashSpeed, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanSmash, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceSmash, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SmashActor, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CrackOrSmashObject
    /// </summary>
    public unsafe void CrackOrSmashObject(System.Numerics.Vector3 SmashLocation, System.Numerics.Vector3 SmashNormal, System.Numerics.Vector3 SmashSpeed, BmSDK.Engine.Actor SmashActor)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGangInteractPointBreakableBase.CrackOrSmashObject", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SmashLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SmashNormal, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SmashSpeed, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SmashActor, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SmashObject
    /// </summary>
    public unsafe void SmashObject(System.Numerics.Vector3 SmashLocation, System.Numerics.Vector3 SmashNormal, System.Numerics.Vector3 SmashSpeed, BmSDK.Engine.Actor SmashActor)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGangInteractPointBreakableBase.SmashObject", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SmashLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SmashNormal, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SmashSpeed, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SmashActor, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HitByMolotov
    /// </summary>
    public unsafe void HitByMolotov(System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal, System.Numerics.Vector3 SmashSpeed, BmSDK.Engine.Actor SmashActor)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGangInteractPointBreakableBase.HitByMolotov", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SmashSpeed, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SmashActor, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateSmashed
    /// </summary>
    public unsafe void UpdateSmashed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGangInteractPointBreakableBase.UpdateSmashed", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// BoolProperty: bSmashed
    /// </summary>
    public unsafe bool bSmashed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1304) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1304); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1304); }
    }

    /// <summary>
    /// ObjectProperty: RelatedApexActor
    /// </summary>
    public unsafe BmSDK.BmGame.RDestructibleProp RelatedApexActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDestructibleProp>(Ptr + 1308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1308); }
    }
}
