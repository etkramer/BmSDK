#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: UISceneClient<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class UISceneClient : BmSDK.Engine.UIRoot, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.UISceneClient", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal UISceneClient() { }

    /// <summary>
    /// Constructs a new UISceneClient
    /// </summary>
    public UISceneClient(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, UISceneClient Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected UISceneClient(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: VfTable_FExec
    /// </summary>
    public unsafe System.IntPtr VfTable_FExec
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// StructProperty: RenderViewport
    /// </summary>
    public unsafe System.IntPtr RenderViewport
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// StructProperty: MousePosition
    /// </summary>
    public unsafe BmSDK.GameObject.FIntPoint MousePosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FIntPoint>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ObjectProperty: DataStoreManager
    /// </summary>
    public unsafe BmSDK.Engine.DataStoreClient DataStoreManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DataStoreClient>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ObjectProperty: UIScenePostProcess
    /// </summary>
    public unsafe BmSDK.Engine.PostProcessChain UIScenePostProcess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PostProcessChain>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// StructProperty: CanvasToScreen
    /// </summary>
    public unsafe BmSDK.GameObject.FMatrix CanvasToScreen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FMatrix>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// StructProperty: InvCanvasToScreen
    /// </summary>
    public unsafe BmSDK.GameObject.FMatrix InvCanvasToScreen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FMatrix>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// BoolProperty: bEnablePostProcess
    /// </summary>
    public unsafe bool bEnablePostProcess
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 288) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 288); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 288); }
    }
}
