#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGrenadeGrateAssignmentPicker<br/>
/// (size = 164)
/// (flags = 8388626)
/// </summary>
public partial class RGrenadeGrateAssignmentPicker : BmSDK.BmGame.RGroupAssignmentPicker, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGrenadeGrateAssignmentPicker", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGrenadeGrateAssignmentPicker() { }

    /// <summary>
    /// Constructs a new RGrenadeGrateAssignmentPicker
    /// </summary>
    public RGrenadeGrateAssignmentPicker(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGrenadeGrateAssignmentPicker Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGrenadeGrateAssignmentPicker(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: InitGoalDataInstance
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RMultiDestGoalData InitGoalDataInstance()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrenadeGrateAssignmentPicker.InitGoalDataInstance", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMultiDestGoalData>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: BuildThugSearch
    /// </summary>
    public unsafe virtual void BuildThugSearch()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrenadeGrateAssignmentPicker.BuildThugSearch", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Update
    /// </summary>
    public unsafe override bool Update()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrenadeGrateAssignmentPicker.Update", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ClearAllSearch
    /// </summary>
    public unsafe virtual void ClearAllSearch()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrenadeGrateAssignmentPicker.ClearAllSearch", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Abort
    /// </summary>
    public unsafe virtual void Abort()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrenadeGrateAssignmentPicker.Abort", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe virtual void Init(BmSDK.BmGame.RBMRoomAIState NewRoomState, System.IntPtr NewGrenadeGrateAssignmentFound, System.IntPtr NewGrenadeGrateAssignmentFailed)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrenadeGrateAssignmentPicker.Init", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRoomState, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGrenadeGrateAssignmentFound, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGrenadeGrateAssignmentFailed, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GrenadeGrateAssignmentFailed
    /// </summary>
    public unsafe virtual void GrenadeGrateAssignmentFailed(BmSDK.BmGame.RGrenadeGrateAssignmentPicker GMAP)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrenadeGrateAssignmentPicker.GrenadeGrateAssignmentFailed", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GMAP, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GrenadeGrateAssignmentFound
    /// </summary>
    public unsafe virtual void GrenadeGrateAssignmentFound(BmSDK.BmGame.RGrenadeGrateAssignmentPicker GMAP, BmSDK.BmGame.RTunnelGrateBase Grate, BmSDK.BmGame.RBMPawnAI GrenadePawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrenadeGrateAssignmentPicker.GrenadeGrateAssignmentFound", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GMAP, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Grate, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrenadePawn, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FMultiDestPathFindInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FMultiDestPathFindInfo
    {
        /// <summary>
        /// ObjectProperty: Handle
        /// </summary>
        public unsafe BmSDK.BmGame.RNavigationHandle Handle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: GoalData
        /// </summary>
        public unsafe BmSDK.BmGame.RMultiDestGoalData GoalData
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMultiDestGoalData>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// ComponentProperty: RoomState
    /// </summary>
    public unsafe BmSDK.BmGame.RBMRoomAIState RoomState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMRoomAIState>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ArrayProperty: GrateList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RTunnelGrateBase> GrateList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RTunnelGrateBase>>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ArrayProperty: ThugSearch
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGrenadeGrateAssignmentPicker.FMultiDestPathFindInfo> ThugSearch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGrenadeGrateAssignmentPicker.FMultiDestPathFindInfo>>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// DelegateProperty: __GrenadeGrateAssignmentFound__Delegate
    /// </summary>
    public unsafe System.IntPtr __GrenadeGrateAssignmentFound__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// DelegateProperty: __GrenadeGrateAssignmentFailed__Delegate
    /// </summary>
    public unsafe System.IntPtr __GrenadeGrateAssignmentFailed__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }
}
