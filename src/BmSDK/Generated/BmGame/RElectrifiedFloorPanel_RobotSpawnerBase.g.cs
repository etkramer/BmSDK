#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RElectrifiedFloorPanel_RobotSpawnerBase<br/>
/// (size = 989)
/// (flags = 10486291)
/// </summary>
public partial class RElectrifiedFloorPanel_RobotSpawnerBase : BmSDK.BmGame.RElectrifiedFloorPanel, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RElectrifiedFloorPanel_RobotSpawnerBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RElectrifiedFloorPanel_RobotSpawnerBase.
    /// </summary>
    public static RElectrifiedFloorPanel_RobotSpawnerBase DefaultObject => (RElectrifiedFloorPanel_RobotSpawnerBase)StaticClass().DefaultObject;

    internal RElectrifiedFloorPanel_RobotSpawnerBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RElectrifiedFloorPanel_RobotSpawnerBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RElectrifiedFloorPanel_RobotSpawnerBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RElectrifiedFloorPanel_RobotSpawnerBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RElectrifiedFloorPanel_RobotSpawnerBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RElectrifiedFloorPanel_RobotSpawnerBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RElectrifiedFloorPanel_RobotSpawnerBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RElectrifiedFloorPanel_RobotSpawnerBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RElectrifiedFloorPanel_RobotSpawnerBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RElectrifiedFloorPanel_RobotSpawnerBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: GetMeshCentre
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetMeshCentre()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RElectrifiedFloorPanel_RobotSpawnerBase.GetMeshCentre", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    /// <summary>
    /// ByteProperty: robotSpawnerState
    /// </summary>
    public unsafe BmSDK.BmGame.RElectrifiedFloorPanel_RobotSpawnerBase.eRobotSpawnerState robotSpawnerState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RElectrifiedFloorPanel_RobotSpawnerBase.eRobotSpawnerState>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// Enum: eRobotSpawnerState
    /// </summary>
    public enum eRobotSpawnerState : byte
    {
        eRSS_Inactive = 0,
        eRSS_Active = 1,
        eRSS_Spent = 2,
        eRSS_MAX = 3,
    }
}
