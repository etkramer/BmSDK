#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveConfig_PairedOpenDoor<br/>
/// (size = 576)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_PairedOpenDoor : BmSDK.BmGame.RSpecialMoveConfig_RelativeAnimMove, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveConfig_PairedOpenDoor", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_PairedOpenDoor() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_PairedOpenDoor
    /// </summary>
    public RSpecialMoveConfig_PairedOpenDoor(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_PairedOpenDoor Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_PairedOpenDoor(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: RobinBasicAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet RobinBasicAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// ObjectProperty: RobinElvisAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet RobinElvisAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// ObjectProperty: RobinCopAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet RobinCopAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// ObjectProperty: RobinHarleyAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet RobinHarleyAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// ObjectProperty: RobinTeacherAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet RobinTeacherAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// ObjectProperty: CatwomanBasicAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet CatwomanBasicAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// NameProperty: RobinBasicOpen
    /// </summary>
    public unsafe BmSDK.FName RobinBasicOpen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// NameProperty: RobinBasicOpenPersistant
    /// </summary>
    public unsafe BmSDK.FName RobinBasicOpenPersistant
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// NameProperty: RobinBasicOpenPersistantBack
    /// </summary>
    public unsafe BmSDK.FName RobinBasicOpenPersistantBack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// NameProperty: CatwomanBasicOpenPersistantLead
    /// </summary>
    public unsafe BmSDK.FName CatwomanBasicOpenPersistantLead
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// NameProperty: CatwomanBasicOpenPersistantFollow
    /// </summary>
    public unsafe BmSDK.FName CatwomanBasicOpenPersistantFollow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// NameProperty: CatwomanBasicOpenPersistantBackLead
    /// </summary>
    public unsafe BmSDK.FName CatwomanBasicOpenPersistantBackLead
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// NameProperty: CatwomanBasicOpenPersistantBackFollow
    /// </summary>
    public unsafe BmSDK.FName CatwomanBasicOpenPersistantBackFollow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// NameProperty: CameraAnimPersistantDoor
    /// </summary>
    public unsafe BmSDK.FName CameraAnimPersistantDoor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// NameProperty: CameraAnimPersistantDoorBack
    /// </summary>
    public unsafe BmSDK.FName CameraAnimPersistantDoorBack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }
}
