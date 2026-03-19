#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDirectionalAnimConfig<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RDirectionalAnimConfig : BmSDK.BmGame.RConfig, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDirectionalAnimConfig", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDirectionalAnimConfig() { }

    /// <summary>
    /// Constructs a new RDirectionalAnimConfig
    /// </summary>
    public RDirectionalAnimConfig(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDirectionalAnimConfig Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDirectionalAnimConfig(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: Directions
    /// </summary>
    public unsafe BmSDK.FName Directions_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
    /// <summary>
    /// NameProperty: Directions
    /// </summary>
    public unsafe BmSDK.FName Directions_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }
    /// <summary>
    /// NameProperty: Directions
    /// </summary>
    public unsafe BmSDK.FName Directions_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }
    /// <summary>
    /// NameProperty: Directions
    /// </summary>
    public unsafe BmSDK.FName Directions_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }
    /// <summary>
    /// NameProperty: Directions
    /// </summary>
    public unsafe BmSDK.FName Directions_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }
    /// <summary>
    /// NameProperty: Directions
    /// </summary>
    public unsafe BmSDK.FName Directions_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }
    /// <summary>
    /// NameProperty: Directions
    /// </summary>
    public unsafe BmSDK.FName Directions_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }
    /// <summary>
    /// NameProperty: Directions
    /// </summary>
    public unsafe BmSDK.FName Directions_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }
    /// <summary>
    /// NameProperty: Directions
    /// </summary>
    public unsafe BmSDK.FName Directions_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }
    /// <summary>
    /// NameProperty: Directions
    /// </summary>
    public unsafe BmSDK.FName Directions_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }
    /// <summary>
    /// NameProperty: Directions
    /// </summary>
    public unsafe BmSDK.FName Directions_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }
    /// <summary>
    /// NameProperty: Directions
    /// </summary>
    public unsafe BmSDK.FName Directions_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

}
