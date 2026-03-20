#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RMultiNavHandleWrapper_DisarmedSearch<br/>
/// (size = 148)
/// (flags = 18)
/// </summary>
public partial class RMultiNavHandleWrapper_DisarmedSearch : BmSDK.BmGame.RMultiNavHandleWrapper, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RMultiNavHandleWrapper_DisarmedSearch", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RMultiNavHandleWrapper_DisarmedSearch() { }

    /// <summary>
    /// Constructs a new RMultiNavHandleWrapper_DisarmedSearch
    /// </summary>
    public RMultiNavHandleWrapper_DisarmedSearch(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RMultiNavHandleWrapper_DisarmedSearch Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RMultiNavHandleWrapper_DisarmedSearch(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: FreeAllHandles
    /// </summary>
    public unsafe override void FreeAllHandles()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RMultiNavHandleWrapper_DisarmedSearch.FreeAllHandles", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetShortestPath
    /// </summary>
    public unsafe override bool GetShortestPath(out float bestDist, out int BestPath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RMultiNavHandleWrapper_DisarmedSearch.GetShortestPath", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        bestDist = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
        BestPath = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: AddDestActor
    /// </summary>
    public unsafe virtual void AddDestActor(System.Numerics.Vector3 NewLoc, BmSDK.Engine.Actor NewActor, int NewIndex)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RMultiNavHandleWrapper_DisarmedSearch.AddDestActor", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewActor, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewIndex, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ArrayProperty: GunSourceActorList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> GunSourceActorList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }
}
