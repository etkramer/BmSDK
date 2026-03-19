#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RInventoryManager<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RInventoryManager : BmSDK.Engine.InventoryManager, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RInventoryManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RInventoryManager() { }

    /// <summary>
    /// Constructs a new RInventoryManager
    /// </summary>
    public RInventoryManager(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RInventoryManager Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RInventoryManager(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RInventoryManager>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RInventoryManager>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RInventoryManager>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RInventoryManager>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RInventoryManager>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RInventoryManager>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RInventoryManager>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: CurrentGadget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrentGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// ObjectProperty: PrevGadget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PrevGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// ObjectProperty: DisplayedGadget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DisplayedGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// IntProperty: DeviceRequestedIndex
    /// </summary>
    public unsafe int DeviceRequestedIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// IntProperty: SelectableGadgetCount
    /// </summary>
    public unsafe int SelectableGadgetCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// StructProperty: AvailableGadgets
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryManager.BatarangGadgets AvailableGadgets_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryManager.BatarangGadgets>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }
    /// <summary>
    /// StructProperty: AvailableGadgets
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryManager.BatarangGadgets AvailableGadgets_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryManager.BatarangGadgets>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }
    /// <summary>
    /// StructProperty: AvailableGadgets
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryManager.BatarangGadgets AvailableGadgets_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryManager.BatarangGadgets>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }
    /// <summary>
    /// StructProperty: AvailableGadgets
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryManager.BatarangGadgets AvailableGadgets_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryManager.BatarangGadgets>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// StructProperty: BatarangGadgets
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryManager.BM2SelectableGadgets BatarangGadgets_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryManager.BM2SelectableGadgets>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }
    /// <summary>
    /// StructProperty: BatarangGadgets
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryManager.BM2SelectableGadgets BatarangGadgets_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryManager.BM2SelectableGadgets>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }
    /// <summary>
    /// StructProperty: BatarangGadgets
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryManager.BM2SelectableGadgets BatarangGadgets_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryManager.BM2SelectableGadgets>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }
    /// <summary>
    /// StructProperty: BatarangGadgets
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryManager.BM2SelectableGadgets BatarangGadgets_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryManager.BM2SelectableGadgets>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// ByteProperty: CurrentGadgetDir
    /// </summary>
    public unsafe byte CurrentGadgetDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// ByteProperty: GadgetSelectSkin
    /// </summary>
    public unsafe byte GadgetSelectSkin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 873); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 873); }
    }

    /// <summary>
    /// IntProperty: CurrentGadgetIndex
    /// </summary>
    public unsafe int CurrentGadgetIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// ArrayProperty: BM2SelectableGadgets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>> BM2SelectableGadgets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// ArrayProperty: PCSelectableGadgets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>> PCSelectableGadgets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }
}
