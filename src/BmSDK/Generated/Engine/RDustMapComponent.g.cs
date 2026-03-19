#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RDustMapComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RDustMapComponent : BmSDK.Engine.ActorComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RDustMapComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDustMapComponent() { }

    /// <summary>
    /// Constructs a new RDustMapComponent
    /// </summary>
    public RDustMapComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDustMapComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDustMapComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: DustSceneInfo
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DustSceneInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// FloatProperty: DustGlobalScale
    /// </summary>
    public unsafe float DustGlobalScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// FloatProperty: MinimumMistAmount
    /// </summary>
    public unsafe float MinimumMistAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// FloatProperty: MistThreshold
    /// </summary>
    public unsafe float MistThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// FloatProperty: DustPileThreshold
    /// </summary>
    public unsafe float DustPileThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// FloatProperty: CausticsAmount
    /// </summary>
    public unsafe float CausticsAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// FloatProperty: DustScaleMod
    /// </summary>
    public unsafe float DustScaleMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }
}
