#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMAIAction_NervousSearchMove_Raw<br/>
/// (size = 616)
/// (flags = 8388626)
/// </summary>
public partial class RBMAIAction_NervousSearchMove_Raw : BmSDK.BmGame.RBMAIAction_NervousSearchMove, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMAIAction_NervousSearchMove_Raw", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMAIAction_NervousSearchMove_Raw.
    /// </summary>
    public static RBMAIAction_NervousSearchMove_Raw DefaultObject => (RBMAIAction_NervousSearchMove_Raw)StaticClass().DefaultObject;

    internal RBMAIAction_NervousSearchMove_Raw() { }

    /// <summary>
    /// Constructs a new RBMAIAction_NervousSearchMove_Raw
    /// </summary>
    public RBMAIAction_NervousSearchMove_Raw(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMAIAction_NervousSearchMove_Raw Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMAIAction_NervousSearchMove_Raw(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_NervousSearchMove_Raw>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_NervousSearchMove_Raw>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_NervousSearchMove_Raw>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_NervousSearchMove_Raw>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_NervousSearchMove_Raw>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_NervousSearchMove_Raw>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_NervousSearchMove_Raw>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_NervousSearchMove_Raw>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: BuildHandle
    /// </summary>
    public unsafe override BmSDK.BmGame.RNavigationHandle BuildHandle()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMAIAction_NervousSearchMove_Raw.BuildHandle", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetupGoal
    /// </summary>
    public unsafe virtual void SetupGoal(System.Numerics.Vector3 NewGoalPosFirst, bool bNewUseAdditionalPoint, System.Numerics.Vector3 NewGoalPosSecond)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMAIAction_NervousSearchMove_Raw.SetupGoal", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGoalPosFirst, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewUseAdditionalPoint, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGoalPosSecond, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// StructProperty: GoalPosFirst
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GoalPosFirst
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 588);

    /// <summary>
    /// StructProperty: GoalPosSecond
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GoalPosSecond
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 600);

    /// <summary>
    /// BoolProperty: bUseAdditionalPoint
    /// </summary>
    public unsafe bool bUseAdditionalPoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 612); }
    }
}
