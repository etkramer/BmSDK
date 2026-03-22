#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RDivePressurePadTen<br/>
/// (size = 560)
/// (flags = 8389138)
/// </summary>
public partial class RDivePressurePadTen : BmSDK.BmScript.RDivePressurePad, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RDivePressurePadTen", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDivePressurePadTen() { }

    /// <summary>
    /// Constructs a new RDivePressurePadTen
    /// </summary>
    public RDivePressurePadTen(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDivePressurePadTen Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDivePressurePadTen(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDivePressurePadTen>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDivePressurePadTen>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDivePressurePadTen>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDivePressurePadTen>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDivePressurePadTen>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDivePressurePadTen>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDivePressurePadTen>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RDivePressurePadTen.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetBatarangPos
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetBatarangPos()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RDivePressurePadTen.GetBatarangPos", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    /// <summary>
    /// ComponentProperty: Light9
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent Light9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// ComponentProperty: Light10
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent Light10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// ComponentProperty: Light11
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent Light11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// ComponentProperty: Light12
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent Light12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }
}
