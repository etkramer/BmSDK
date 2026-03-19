#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: Client<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class Client : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.Client", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Client() { }

    /// <summary>
    /// Constructs a new Client
    /// </summary>
    public Client(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, Client Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Client(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: ButtonRepeatDelay
    /// </summary>
    public unsafe float ButtonRepeatDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// FloatProperty: InitialButtonRepeatDelay
    /// </summary>
    public unsafe float InitialButtonRepeatDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// FloatProperty: MinDesiredFrameRate
    /// </summary>
    public unsafe float MinDesiredFrameRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// FloatProperty: DisplayGammaReferenceBrightness
    /// </summary>
    public unsafe float DisplayGammaReferenceBrightness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// FloatProperty: DisplayGammaMax
    /// </summary>
    public unsafe float DisplayGammaMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// FloatProperty: DisplayGammaMin
    /// </summary>
    public unsafe float DisplayGammaMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// FloatProperty: DisplayGamma
    /// </summary>
    public unsafe float DisplayGamma
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }
}
