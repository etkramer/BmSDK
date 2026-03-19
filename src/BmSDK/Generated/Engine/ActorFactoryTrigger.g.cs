#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ActorFactoryTrigger<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ActorFactoryTrigger : BmSDK.Engine.ActorFactory, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ActorFactoryTrigger", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ActorFactoryTrigger() { }

    /// <summary>
    /// Constructs a new ActorFactoryTrigger
    /// </summary>
    public ActorFactoryTrigger(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ActorFactoryTrigger Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ActorFactoryTrigger(nint ptr) : base(ptr) { }

    /// <summary>
    /// ClassProperty: GameplayActorClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GameplayActorClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// NameProperty: GameplayActorClassName
    /// </summary>
    public unsafe BmSDK.FName GameplayActorClassName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// StrProperty: MenuName
    /// </summary>
    public unsafe BmSDK.FString MenuName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// IntProperty: MenuPriority
    /// </summary>
    public unsafe int MenuPriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// IntProperty: AlternateMenuPriority
    /// </summary>
    public unsafe int AlternateMenuPriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// ClassProperty: NewActorClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT NewActorClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// NameProperty: NewActorClassName
    /// </summary>
    public unsafe BmSDK.FName NewActorClassName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// BoolProperty: bPlaceable
    /// </summary>
    public unsafe bool bPlaceable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 140); }
    }

    /// <summary>
    /// BoolProperty: UseActorSelection
    /// </summary>
    public unsafe bool UseActorSelection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 140); }
    }

    /// <summary>
    /// BoolProperty: bShowInEditorQuickMenu
    /// </summary>
    public unsafe bool bShowInEditorQuickMenu
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 140); }
    }

    /// <summary>
    /// BoolProperty: RequiresPropertyWindow
    /// </summary>
    public unsafe bool RequiresPropertyWindow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 140); }
    }
}
