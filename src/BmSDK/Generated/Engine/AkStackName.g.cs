#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkStackName<br/>
/// (size = 52)
/// (flags = 134217874)
/// </summary>
public partial class AkStackName : BmSDK.Engine.AkHash, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkStackName", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkStackName() { }

    /// <summary>
    /// Constructs a new AkStackName
    /// </summary>
    public AkStackName(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkStackName Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkStackName(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: StackColor
    /// </summary>
    public unsafe BmSDK.GameObject.FColor StackColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }
}
