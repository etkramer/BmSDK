#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.GFxUI;

/// <summary>
/// Class: GFxObject<br/>
/// (flags = 0)
/// </summary>
public partial class GFxObject : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "GFxUI.GFxObject", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal GFxObject() { }

    /// <summary>
    /// Constructs a new GFxObject
    /// </summary>
    public GFxObject(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GFxObject Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GFxObject(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: Value
    /// </summary>
    public unsafe int Value_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
    /// <summary>
    /// IntProperty: Value
    /// </summary>
    public unsafe int Value_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }
    /// <summary>
    /// IntProperty: Value
    /// </summary>
    public unsafe int Value_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }
    /// <summary>
    /// IntProperty: Value
    /// </summary>
    public unsafe int Value_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }
    /// <summary>
    /// IntProperty: Value
    /// </summary>
    public unsafe int Value_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }
    /// <summary>
    /// IntProperty: Value
    /// </summary>
    public unsafe int Value_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }
    /// <summary>
    /// IntProperty: Value
    /// </summary>
    public unsafe int Value_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }
    /// <summary>
    /// IntProperty: Value
    /// </summary>
    public unsafe int Value_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }
    /// <summary>
    /// IntProperty: Value
    /// </summary>
    public unsafe int Value_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }
    /// <summary>
    /// IntProperty: Value
    /// </summary>
    public unsafe int Value_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }
    /// <summary>
    /// IntProperty: Value
    /// </summary>
    public unsafe int Value_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }
    /// <summary>
    /// IntProperty: Value
    /// </summary>
    public unsafe int Value_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// ArrayProperty: SubWidgetBindings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GFxUI.GFxMoviePlayer.FGFxWidgetBinding> SubWidgetBindings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GFxUI.GFxMoviePlayer.FGFxWidgetBinding>>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }
}
