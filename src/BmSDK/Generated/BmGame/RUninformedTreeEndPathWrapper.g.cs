#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RUninformedTreeEndPathWrapper<br/>
/// (flags = 0)
/// </summary>
public partial class RUninformedTreeEndPathWrapper : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RUninformedTreeEndPathWrapper", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RUninformedTreeEndPathWrapper() { }

    /// <summary>
    /// Constructs a new RUninformedTreeEndPathWrapper
    /// </summary>
    public RUninformedTreeEndPathWrapper(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RUninformedTreeEndPathWrapper Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RUninformedTreeEndPathWrapper(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: DrawPaths
    /// </summary>
    public unsafe void DrawPaths()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RUninformedTreeEndPathWrapper.DrawPaths", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsEmpty
    /// </summary>
    public unsafe bool IsEmpty()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RUninformedTreeEndPathWrapper.IsEmpty", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsSearching
    /// </summary>
    public unsafe bool IsSearching()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RUninformedTreeEndPathWrapper.IsSearching", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: FreeAllHandles
    /// </summary>
    public unsafe void FreeAllHandles()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RUninformedTreeEndPathWrapper.FreeAllHandles", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetNumPaths
    /// </summary>
    public unsafe int GetNumPaths()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RUninformedTreeEndPathWrapper.GetNumPaths", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetAllOpenEnds
    /// </summary>
    public unsafe void GetAllOpenEnds(out BmSDK.TArray<BmSDK.BmGame.RChasePoint> UsableEnds)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RUninformedTreeEndPathWrapper.GetAllOpenEnds", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        UsableEnds = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RChasePoint>>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: GetAllUsableTreeEnds
    /// </summary>
    public unsafe void GetAllUsableTreeEnds(out BmSDK.TArray<BmSDK.BmGame.RChasePoint> UsableEnds)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RUninformedTreeEndPathWrapper.GetAllUsableTreeEnds", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        UsableEnds = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RChasePoint>>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: GetShortestPath
    /// </summary>
    public unsafe bool GetShortestPath(out float bestDist, out BmSDK.BmGame.RChasePoint BestTreeEnd)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RUninformedTreeEndPathWrapper.GetShortestPath", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        bestDist = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
        BestTreeEnd = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RChasePoint>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: AddRequest
    /// </summary>
    public unsafe void AddRequest(BmSDK.BmGame.RChasePoint NewTreeEnd)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RUninformedTreeEndPathWrapper.AddRequest", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTreeEnd, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetDestPoint
    /// </summary>
    public unsafe void SetDestPoint(System.Numerics.Vector3 NewDestPoint, BmSDK.BmGame.RNavigationManager NewNavMan, BmSDK.FName NewClaimName = default, BmSDK.Engine.Pawn NewParamProxy = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RUninformedTreeEndPathWrapper.SetDestPoint", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewDestPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewNavMan, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewClaimName, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewParamProxy, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FTreeEndHandleCombo
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FTreeEndHandleCombo
    {
        /// <summary>
        /// ObjectProperty: NavHandle
        /// </summary>
        public unsafe BmSDK.BmGame.RNavigationHandle NavHandle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: TreeEnd
        /// </summary>
        public unsafe BmSDK.BmGame.RChasePoint TreeEnd
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RChasePoint>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// ObjectProperty: NavMan
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationManager NavMan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationManager>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: BlockPolyPylon
    /// </summary>
    public unsafe BmSDK.Engine.Pylon BlockPolyPylon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pylon>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ObjectProperty: ParamProxy
    /// </summary>
    public unsafe BmSDK.Engine.Pawn ParamProxy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ArrayProperty: BlockedPolyList
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> BlockedPolyList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ArrayProperty: Path
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RUninformedTreeEndPathWrapper.FTreeEndHandleCombo> Path
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RUninformedTreeEndPathWrapper.FTreeEndHandleCombo>>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// StructProperty: DestPoint
    /// </summary>
    public unsafe System.Numerics.Vector3 DestPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// NameProperty: ClaimName
    /// </summary>
    public unsafe BmSDK.FName ClaimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }
}
