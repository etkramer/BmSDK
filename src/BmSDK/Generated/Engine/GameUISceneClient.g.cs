#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: GameUISceneClient<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class GameUISceneClient : BmSDK.Engine.UISceneClient, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.GameUISceneClient", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal GameUISceneClient() { }

    /// <summary>
    /// Constructs a new GameUISceneClient
    /// </summary>
    public GameUISceneClient(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GameUISceneClient Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GameUISceneClient(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: LatestDeltaTime
    /// </summary>
    public unsafe float LatestDeltaTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// StructProperty: DoubleClickStartTime
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DoubleClickStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// StructProperty: DoubleClickStartPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DoubleClickStartPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// StructProperty: InitialPressedKeys
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT InitialPressedKeys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// BoolProperty: bUpdateInputProcessingStatus
    /// </summary>
    public unsafe bool bUpdateInputProcessingStatus
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 384); }
    }

    /// <summary>
    /// BoolProperty: bUpdateSceneViewportSizes
    /// </summary>
    public unsafe bool bUpdateSceneViewportSizes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 384); }
    }

    /// <summary>
    /// BoolProperty: bEnableDebugInput
    /// </summary>
    public unsafe bool bEnableDebugInput
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 384); }
    }

    /// <summary>
    /// BoolProperty: bRenderDebugInfo
    /// </summary>
    public unsafe bool bRenderDebugInfo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 384); }
    }

    /// <summary>
    /// BoolProperty: bCaptureUnprocessedInput
    /// </summary>
    public unsafe bool bCaptureUnprocessedInput
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 384); }
    }

    /// <summary>
    /// ArrayProperty: NavAliases
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>> NavAliases
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// ArrayProperty: AxisInputKeys
    /// </summary>
    public unsafe BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT> AxisInputKeys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }
}
