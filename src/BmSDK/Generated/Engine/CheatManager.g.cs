#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: CheatManager<br/>
/// (flags = 0)
/// </summary>
public partial class CheatManager : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.CheatManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal CheatManager() { }

    /// <summary>
    /// Constructs a new CheatManager
    /// </summary>
    public CheatManager(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, CheatManager Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected CheatManager(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: DebugCameraControllerRef
    /// </summary>
    public unsafe BmSDK.Engine.DebugCameraController DebugCameraControllerRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DebugCameraController>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ClassProperty: DebugCameraControllerClass
    /// </summary>
    public unsafe BmSDK.Class DebugCameraControllerClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// StrProperty: ViewingFrom
    /// </summary>
    public unsafe BmSDK.FString ViewingFrom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// StrProperty: OwnCamera
    /// </summary>
    public unsafe BmSDK.FString OwnCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// IntProperty: CurrentBatmobileSetting
    /// </summary>
    public unsafe int CurrentBatmobileSetting
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }
}
