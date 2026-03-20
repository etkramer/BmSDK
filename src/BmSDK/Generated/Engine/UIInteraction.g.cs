#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: UIInteraction<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class UIInteraction : BmSDK.Engine.Interaction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.UIInteraction", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal UIInteraction() { }

    /// <summary>
    /// Constructs a new UIInteraction
    /// </summary>
    public UIInteraction(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, UIInteraction Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected UIInteraction(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: VfTable_FExec
    /// </summary>
    public unsafe System.IntPtr VfTable_FExec
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// StructProperty: VfTable_FGlobalDataStoreClientManager
    /// </summary>
    public unsafe System.IntPtr VfTable_FGlobalDataStoreClientManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// StructProperty: VfTable_FCallbackEventDevice
    /// </summary>
    public unsafe System.IntPtr VfTable_FCallbackEventDevice
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// ObjectProperty: UIManager
    /// </summary>
    public unsafe BmSDK.Engine.UIManager UIManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.UIManager>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// ObjectProperty: SceneClient
    /// </summary>
    public unsafe BmSDK.Engine.GameUISceneClient SceneClient
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameUISceneClient>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// ObjectProperty: DataStoreManager
    /// </summary>
    public unsafe BmSDK.Engine.DataStoreClient DataStoreManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DataStoreClient>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// ClassProperty: SceneClientClass
    /// </summary>
    public unsafe BmSDK.Class SceneClientClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// ClassProperty: UIManagerClass
    /// </summary>
    public unsafe BmSDK.Class UIManagerClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// ArrayProperty: SupportedDoubleClickKeys
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> SupportedDoubleClickKeys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// BoolProperty: bProcessInput
    /// </summary>
    public unsafe bool bProcessInput
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 252) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 252); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 252); }
    }

    /// <summary>
    /// FloatProperty: UIJoystickDeadZone
    /// </summary>
    public unsafe float UIJoystickDeadZone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// FloatProperty: UIAxisMultiplier
    /// </summary>
    public unsafe float UIAxisMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// FloatProperty: AxisRepeatDelay
    /// </summary>
    public unsafe float AxisRepeatDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// FloatProperty: MouseButtonRepeatDelay
    /// </summary>
    public unsafe float MouseButtonRepeatDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// FloatProperty: DoubleClickTriggerSeconds
    /// </summary>
    public unsafe float DoubleClickTriggerSeconds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// IntProperty: DoubleClickPixelTolerance
    /// </summary>
    public unsafe int DoubleClickPixelTolerance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// StructProperty: MouseButtonRepeatInfo
    /// </summary>
    public unsafe BmSDK.Engine.UIInteraction.FUIKeyRepeatData MouseButtonRepeatInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.UIInteraction.FUIKeyRepeatData>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// ArrayProperty: ConfiguredAxisEmulationDefinitions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.UIRoot.FUIAxisEmulationDefinition> ConfiguredAxisEmulationDefinitions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.UIRoot.FUIAxisEmulationDefinition>>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// MapProperty: AxisEmulationDefinitions
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ AxisEmulationDefinitions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// StructProperty: AxisInputEmulation
    /// </summary>
    public unsafe BmSDK.Engine.UIInteraction.FUIAxisEmulationData AxisInputEmulation_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.UIInteraction.FUIAxisEmulationData>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }
    /// <summary>
    /// StructProperty: AxisInputEmulation
    /// </summary>
    public unsafe BmSDK.Engine.UIInteraction.FUIAxisEmulationData AxisInputEmulation_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.UIInteraction.FUIAxisEmulationData>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }
    /// <summary>
    /// StructProperty: AxisInputEmulation
    /// </summary>
    public unsafe BmSDK.Engine.UIInteraction.FUIAxisEmulationData AxisInputEmulation_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.UIInteraction.FUIAxisEmulationData>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }
    /// <summary>
    /// StructProperty: AxisInputEmulation
    /// </summary>
    public unsafe BmSDK.Engine.UIInteraction.FUIAxisEmulationData AxisInputEmulation_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.UIInteraction.FUIAxisEmulationData>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }
}
