#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RNavMeshPath_AvoidPathObjects<br/>
/// (flags = 0)
/// </summary>
public partial class RNavMeshPath_AvoidPathObjects : BmSDK.Engine.NavMeshPathConstraint, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RNavMeshPath_AvoidPathObjects", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RNavMeshPath_AvoidPathObjects() { }

    /// <summary>
    /// Constructs a new RNavMeshPath_AvoidPathObjects
    /// </summary>
    public RNavMeshPath_AvoidPathObjects(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RNavMeshPath_AvoidPathObjects Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RNavMeshPath_AvoidPathObjects(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: AvoidPathObjects
    /// </summary>
    public unsafe static bool AvoidPathObjects(BmSDK.BmGame.RNavigationHandle NewNavHandle, BmSDK.Engine.Actor AvoidObject1, BmSDK.Engine.Actor AvoidObject2 = default, BmSDK.Engine.Actor AvoidObject3 = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RNavMeshPath_AvoidPathObjects.AvoidPathObjects", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewNavHandle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AvoidObject1, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AvoidObject2, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AvoidObject3, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: AvoidPathObjectArray
    /// </summary>
    public unsafe static bool AvoidPathObjectArray(BmSDK.BmGame.RNavigationHandle NewNavHandle, BmSDK.TArray<BmSDK.Engine.Actor> AvoidObjectList)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RNavMeshPath_AvoidPathObjects.AvoidPathObjectArray", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewNavHandle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AvoidObjectList, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: AvoidPathObject
    /// </summary>
    public unsafe static bool AvoidPathObject(BmSDK.BmGame.RNavigationHandle NewNavHandle, BmSDK.Engine.Actor AvoidObject1)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RNavMeshPath_AvoidPathObjects.AvoidPathObject", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewNavHandle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AvoidObject1, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// ArrayProperty: AvoidObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> AvoidObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }
}
