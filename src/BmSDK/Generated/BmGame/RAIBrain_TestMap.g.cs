#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAIBrain_TestMap<br/>
/// (flags = 0)
/// </summary>
public partial class RAIBrain_TestMap : BmSDK.BmGame.RAIBrain, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAIBrain_TestMap", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAIBrain_TestMap() { }

    /// <summary>
    /// Constructs a new RAIBrain_TestMap
    /// </summary>
    public RAIBrain_TestMap(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAIBrain_TestMap Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAIBrain_TestMap(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: HostController
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIController HostController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIController>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: CurrentTopLevelAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAlertEventCoordinatorBase CurrentTopLevelAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAlertEventCoordinatorBase>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// NameProperty: BrainState
    /// </summary>
    public unsafe BmSDK.FName BrainState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ArrayProperty: KismetOutput
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> KismetOutput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ByteProperty: ScriptImportance
    /// </summary>
    public unsafe BmSDK.BmGame.RAIBrain.BrainScriptImportance ScriptImportance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAIBrain.BrainScriptImportance>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// BoolProperty: bAutoRevertOnBSIInterrupt
    /// </summary>
    public unsafe bool bAutoRevertOnBSIInterrupt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: bCleaningUp
    /// </summary>
    public unsafe bool bCleaningUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }
}
