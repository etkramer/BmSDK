#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCwStealthTakeDownStage_InvertedFromCeilingEnd<br/>
/// (size = 1032)
/// (flags = 8388626)
/// </summary>
public partial class RCwStealthTakeDownStage_InvertedFromCeilingEnd : BmSDK.BmGame.RStealthTakeDownStage, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCwStealthTakeDownStage_InvertedFromCeilingEnd", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCwStealthTakeDownStage_InvertedFromCeilingEnd() { }

    /// <summary>
    /// Constructs a new RCwStealthTakeDownStage_InvertedFromCeilingEnd
    /// </summary>
    public RCwStealthTakeDownStage_InvertedFromCeilingEnd(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCwStealthTakeDownStage_InvertedFromCeilingEnd Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCwStealthTakeDownStage_InvertedFromCeilingEnd(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCwStealthTakeDownStage_InvertedFromCeilingEnd>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwStealthTakeDownStage_InvertedFromCeilingEnd>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCwStealthTakeDownStage_InvertedFromCeilingEnd>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwStealthTakeDownStage_InvertedFromCeilingEnd>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwStealthTakeDownStage_InvertedFromCeilingEnd>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCwStealthTakeDownStage_InvertedFromCeilingEnd>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwStealthTakeDownStage_InvertedFromCeilingEnd>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: ResetCamera
    /// </summary>
    public unsafe virtual void ResetCamera()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwStealthTakeDownStage_InvertedFromCeilingEnd.ResetCamera", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetReferencePosition
    /// </summary>
    public unsafe override void GetReferencePosition(out System.Numerics.Vector3 ReferencePosition, out BmSDK.Rotator ReferenceRotation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwStealthTakeDownStage_InvertedFromCeilingEnd.GetReferencePosition", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ReferencePosition = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        ReferenceRotation = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 12);
        return;
    }
}
