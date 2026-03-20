#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: AkMultipointEmitterLineComponent<br/>
/// (flags = 0)
/// </summary>
public partial class AkMultipointEmitterLineComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.AkMultipointEmitterLineComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkMultipointEmitterLineComponent() { }

    /// <summary>
    /// Constructs a new AkMultipointEmitterLineComponent
    /// </summary>
    public AkMultipointEmitterLineComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkMultipointEmitterLineComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkMultipointEmitterLineComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: LineColor
    /// </summary>
    public unsafe BmSDK.GameObject.FColor LineColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// StructProperty: CircleColor
    /// </summary>
    public unsafe BmSDK.GameObject.FColor CircleColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }
}
