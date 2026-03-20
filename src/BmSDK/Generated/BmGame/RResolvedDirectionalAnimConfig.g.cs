#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RResolvedDirectionalAnimConfig<br/>
/// (size = 180)
/// (flags = 0)
/// </summary>
public partial class RResolvedDirectionalAnimConfig : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RResolvedDirectionalAnimConfig", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RResolvedDirectionalAnimConfig() { }

    /// <summary>
    /// Constructs a new RResolvedDirectionalAnimConfig
    /// </summary>
    public RResolvedDirectionalAnimConfig(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RResolvedDirectionalAnimConfig Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RResolvedDirectionalAnimConfig(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Directions
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence Directions_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
    /// <summary>
    /// ObjectProperty: Directions
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence Directions_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }
    /// <summary>
    /// ObjectProperty: Directions
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence Directions_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }
    /// <summary>
    /// ObjectProperty: Directions
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence Directions_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }
    /// <summary>
    /// ObjectProperty: Directions
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence Directions_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }
    /// <summary>
    /// ObjectProperty: Directions
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence Directions_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }
    /// <summary>
    /// ObjectProperty: Directions
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence Directions_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }
    /// <summary>
    /// ObjectProperty: Directions
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence Directions_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }
    /// <summary>
    /// ObjectProperty: Directions
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence Directions_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }
    /// <summary>
    /// ObjectProperty: Directions
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence Directions_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }
    /// <summary>
    /// ObjectProperty: Directions
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence Directions_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }
    /// <summary>
    /// ObjectProperty: Directions
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence Directions_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }
}
