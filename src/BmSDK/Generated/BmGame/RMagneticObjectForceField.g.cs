#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RMagneticObjectForceField<br/>
/// (size = 516)
/// (flags = 142606994)
/// </summary>
public partial class RMagneticObjectForceField : BmSDK.Engine.NxRadialForceField, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RMagneticObjectForceField", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RMagneticObjectForceField() { }

    /// <summary>
    /// Constructs a new RMagneticObjectForceField
    /// </summary>
    public RMagneticObjectForceField(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RMagneticObjectForceField Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RMagneticObjectForceField(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMagneticObjectForceField>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticObjectForceField>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMagneticObjectForceField>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticObjectForceField>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticObjectForceField>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMagneticObjectForceField>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticObjectForceField>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: SetFieldProperties
    /// </summary>
    public unsafe virtual void SetFieldProperties(float Radius, float Strength)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RMagneticObjectForceField.SetFieldProperties", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Radius, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Strength, paramsPtr + 4);
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
    /// FloatProperty: FieldStrengthMultiplier
    /// </summary>
    public unsafe float FieldStrengthMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }
}
