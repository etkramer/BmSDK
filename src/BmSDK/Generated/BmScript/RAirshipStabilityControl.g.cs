#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RAirshipStabilityControl<br/>
/// (size = 692)
/// (flags = 10486290)
/// </summary>
public partial class RAirshipStabilityControl : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RAirshipStabilityControl", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAirshipStabilityControl() { }

    /// <summary>
    /// Constructs a new RAirshipStabilityControl
    /// </summary>
    public RAirshipStabilityControl(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAirshipStabilityControl Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAirshipStabilityControl(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAirshipStabilityControl>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAirshipStabilityControl>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAirshipStabilityControl>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAirshipStabilityControl>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAirshipStabilityControl>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAirshipStabilityControl>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAirshipStabilityControl>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RAirshipStabilityControl.Tick", true);
        byte* paramsPtr = stackalloc byte[128];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ComponentProperty: BaseMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent BaseMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ComponentProperty: BowlMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent BowlMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ComponentProperty: TopMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent TopMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }
}
