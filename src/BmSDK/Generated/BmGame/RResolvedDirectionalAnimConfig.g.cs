#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RResolvedDirectionalAnimConfig<br/>
/// (size = 92)
/// (flags = 134217874)
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
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }
    /// <summary>
    /// ObjectProperty: Directions
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence Directions_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }
    /// <summary>
    /// ObjectProperty: Directions
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence Directions_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }
    /// <summary>
    /// ObjectProperty: Directions
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence Directions_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }
    /// <summary>
    /// ObjectProperty: Directions
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence Directions_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }
    /// <summary>
    /// ObjectProperty: Directions
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence Directions_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }
    /// <summary>
    /// ObjectProperty: Directions
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence Directions_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }
    /// <summary>
    /// ObjectProperty: Directions
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence Directions_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 72); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }
    }
    /// <summary>
    /// ObjectProperty: Directions
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence Directions_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 76); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }
    }
    /// <summary>
    /// ObjectProperty: Directions
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence Directions_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }
    /// <summary>
    /// ObjectProperty: Directions
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence Directions_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
    /// <summary>
    /// ObjectProperty: Directions
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence Directions_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }
}
