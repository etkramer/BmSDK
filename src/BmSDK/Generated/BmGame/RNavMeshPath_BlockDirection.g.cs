#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RNavMeshPath_BlockDirection<br/>
/// (size = 156)
/// (flags = 134217874)
/// </summary>
public partial class RNavMeshPath_BlockDirection : BmSDK.Engine.NavMeshPathConstraint, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RNavMeshPath_BlockDirection", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RNavMeshPath_BlockDirection.
    /// </summary>
    public static RNavMeshPath_BlockDirection DefaultObject => (RNavMeshPath_BlockDirection)StaticClass().DefaultObject;

    internal RNavMeshPath_BlockDirection() { }

    /// <summary>
    /// Constructs a new RNavMeshPath_BlockDirection
    /// </summary>
    public RNavMeshPath_BlockDirection(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RNavMeshPath_BlockDirection Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RNavMeshPath_BlockDirection(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RNavMeshPath_BlockDirection>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RNavMeshPath_BlockDirection>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RNavMeshPath_BlockDirection>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RNavMeshPath_BlockDirection>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RNavMeshPath_BlockDirection>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RNavMeshPath_BlockDirection>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RNavMeshPath_BlockDirection>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RNavMeshPath_BlockDirection>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: Recycle
    /// </summary>
    public unsafe override void Recycle()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RNavMeshPath_BlockDirection.Recycle", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BlockDir
    /// </summary>
    public unsafe static bool BlockDir(BmSDK.BmGame.RNavigationHandle NewNavHandle, System.Numerics.Vector3 nBlockPosition, System.Numerics.Vector3 nBlockDirection, int nBlockAngleHardYaw, int nBlockAngleSoftYaw, float nBlockDistance)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RNavMeshPath_BlockDirection.BlockDir", true);
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewNavHandle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nBlockPosition, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nBlockDirection, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nBlockAngleHardYaw, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nBlockAngleSoftYaw, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nBlockDistance, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 40);
    }

    /// <summary>
    /// Function: RecycleNative
    /// </summary>
    public unsafe virtual void RecycleNative()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RNavMeshPath_BlockDirection.RecycleNative", true);
        byte* paramsPtr = stackalloc byte[0];
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
    /// Function: Initialise
    /// </summary>
    public unsafe virtual void Initialise(BmSDK.BmGame.RNavigationHandle NewNavHandle)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RNavMeshPath_BlockDirection.Initialise", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewNavHandle, paramsPtr + 0);
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
    /// StructProperty: StartEdge
    /// </summary>
    public unsafe ref BmSDK.Engine.NavigationHandle.FEdgePointer StartEdge
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.NavigationHandle.FEdgePointer>(Ptr + 64);

    /// <summary>
    /// StructProperty: BlockPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BlockPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 68);

    /// <summary>
    /// StructProperty: BlockDirection
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BlockDirection
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 80);

    /// <summary>
    /// FloatProperty: BlockAngleHard
    /// </summary>
    public unsafe float BlockAngleHard
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// FloatProperty: BlockAngleSoft
    /// </summary>
    public unsafe float BlockAngleSoft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// FloatProperty: BlockDistance
    /// </summary>
    public unsafe float BlockDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// StructProperty: HardAngleLine1
    /// </summary>
    public unsafe ref System.Numerics.Vector3 HardAngleLine1
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 104);

    /// <summary>
    /// StructProperty: HardAngleLine2
    /// </summary>
    public unsafe ref System.Numerics.Vector3 HardAngleLine2
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 116);

    /// <summary>
    /// StructProperty: SoftAngleLine1
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SoftAngleLine1
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 128);

    /// <summary>
    /// StructProperty: SoftAngleLine2
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SoftAngleLine2
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 140);

    /// <summary>
    /// ObjectProperty: NavHandle
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationHandle NavHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }
}
