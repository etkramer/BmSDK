#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMWeapon_SmashedSegment<br/>
/// (size = 996)
/// (flags = 10485778)
/// </summary>
public partial class RBMWeapon_SmashedSegment : BmSDK.Engine.KActorSpawnable, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMWeapon_SmashedSegment", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMWeapon_SmashedSegment.
    /// </summary>
    public static RBMWeapon_SmashedSegment DefaultObject => (RBMWeapon_SmashedSegment)StaticClass().DefaultObject;

    internal RBMWeapon_SmashedSegment() { }

    /// <summary>
    /// Constructs a new RBMWeapon_SmashedSegment
    /// </summary>
    public RBMWeapon_SmashedSegment(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMWeapon_SmashedSegment(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMWeapon_SmashedSegment>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeapon_SmashedSegment>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMWeapon_SmashedSegment>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeapon_SmashedSegment>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeapon_SmashedSegment>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeapon_SmashedSegment>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMWeapon_SmashedSegment>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeapon_SmashedSegment>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: SetSegmentMesh
    /// </summary>
    public unsafe virtual void SetSegmentMesh(BmSDK.Engine.StaticMesh NewMesh, System.Numerics.Vector3 Vel, System.Numerics.Vector3 AngVel, System.Numerics.Vector3 NewLocation, BmSDK.Rotator NewRotation, System.Numerics.Vector3 AdditionalTranslation = default, BmSDK.Rotator AdditionRotation = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMWeapon_SmashedSegment.SetSegmentMesh", true);
        byte* paramsPtr = stackalloc byte[80];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMesh, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Vel, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AngVel, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLocation, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRotation, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AdditionalTranslation, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AdditionRotation, paramsPtr + 68);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DestroyCheck
    /// </summary>
    public unsafe virtual void DestroyCheck()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMWeapon_SmashedSegment.DestroyCheck", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
