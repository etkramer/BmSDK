#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNotify_AddForce<br/>
/// (size = 76)
/// (flags = 134230162)
/// </summary>
public partial class RAnimNotify_AddForce : BmSDK.Engine.AnimNotify, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNotify_AddForce", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNotify_AddForce() { }

    /// <summary>
    /// Constructs a new RAnimNotify_AddForce
    /// </summary>
    public RAnimNotify_AddForce(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNotify_AddForce Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNotify_AddForce(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: Parts
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil.FRagdollParts Parts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.FRagdollParts>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// StructProperty: Translation
    /// </summary>
    public unsafe System.Numerics.Vector3 Translation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// StructProperty: Rotation
    /// </summary>
    public unsafe System.Numerics.Vector3 Rotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// FloatProperty: Duration
    /// </summary>
    public unsafe float Duration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 72); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }
    }
}
