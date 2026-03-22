#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RXrayWire<br/>
/// (size = 572)
/// (flags = 8389138)
/// </summary>
public partial class RXrayWire : BmSDK.BmGame.RXrayInterpActor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RXrayWire", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RXrayWire() { }

    /// <summary>
    /// Constructs a new RXrayWire
    /// </summary>
    public RXrayWire(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RXrayWire Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RXrayWire(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RXrayWire>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RXrayWire>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RXrayWire>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RXrayWire>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RXrayWire>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RXrayWire>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RXrayWire>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RXrayWire.Tick", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetInXrayMode
    /// </summary>
    public unsafe override void SetInXrayMode(bool On, bool bForceOff)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RXrayWire.SetInXrayMode", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceOff, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// BoolProperty: bDisablePutInForeground
    /// </summary>
    public unsafe bool bDisablePutInForeground
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 564) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 564); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 564); }
    }

    /// <summary>
    /// ObjectProperty: XRayMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface XRayMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }
}
