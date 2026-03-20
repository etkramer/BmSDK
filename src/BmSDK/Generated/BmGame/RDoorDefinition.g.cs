#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDoorDefinition<br/>
/// (flags = 0)
/// </summary>
public partial class RDoorDefinition : BmSDK.BmGame.RConfig, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDoorDefinition", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDoorDefinition() { }

    /// <summary>
    /// Constructs a new RDoorDefinition
    /// </summary>
    public RDoorDefinition(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDoorDefinition Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDoorDefinition(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: SkeletalMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMesh SkeletalMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: PhysicsAsset
    /// </summary>
    public unsafe BmSDK.Engine.PhysicsAsset PhysicsAsset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicsAsset>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ObjectProperty: AnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet AnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ObjectProperty: ConfigOpenDoorFront
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ConfigOpenDoorFront
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ObjectProperty: ConfigOpenDoorBack
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ConfigOpenDoorBack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ObjectProperty: ConfigLockedDoorFront
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ConfigLockedDoorFront
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ObjectProperty: ConfigLockedDoorBack
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ConfigLockedDoorBack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ObjectProperty: ConfigOpenDoorFrontDual
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ConfigOpenDoorFrontDual
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ObjectProperty: ConfigOpenDoorBackDual
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ConfigOpenDoorBackDual
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ObjectProperty: ConfigBlockedOpenDoor
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ConfigBlockedOpenDoor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// ObjectProperty: LockedSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent LockedSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ObjectProperty: AudioDoorSwitch
    /// </summary>
    public unsafe BmSDK.Engine.AkSwitchName AudioDoorSwitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkSwitchName>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// ObjectProperty: DoorPhysicalMaterial
    /// </summary>
    public unsafe BmSDK.Engine.PhysicalMaterial DoorPhysicalMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicalMaterial>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// IntProperty: MatIndexForLockedStatus
    /// </summary>
    public unsafe int MatIndexForLockedStatus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// NameProperty: AnimDoorUsedFront
    /// </summary>
    public unsafe BmSDK.FName AnimDoorUsedFront
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// NameProperty: AnimDoorUsedBack
    /// </summary>
    public unsafe BmSDK.FName AnimDoorUsedBack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// NameProperty: AnimDoorUsedFrontDual
    /// </summary>
    public unsafe BmSDK.FName AnimDoorUsedFrontDual
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// NameProperty: AnimDoorUsedBackDual
    /// </summary>
    public unsafe BmSDK.FName AnimDoorUsedBackDual
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }

    /// <summary>
    /// NameProperty: AnimDoorLockedFront
    /// </summary>
    public unsafe BmSDK.FName AnimDoorLockedFront
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// NameProperty: AnimDoorLockedBack
    /// </summary>
    public unsafe BmSDK.FName AnimDoorLockedBack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }

    /// <summary>
    /// NameProperty: AnimDoorOpenByKismet
    /// </summary>
    public unsafe BmSDK.FName AnimDoorOpenByKismet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// NameProperty: AnimDoorCloseByKismet
    /// </summary>
    public unsafe BmSDK.FName AnimDoorCloseByKismet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// NameProperty: AnimDoorLocked
    /// </summary>
    public unsafe BmSDK.FName AnimDoorLocked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }
}
