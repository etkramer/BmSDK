#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ActorFactorySkeletalMesh<br/>
/// (flags = 0)
/// </summary>
public partial class ActorFactorySkeletalMesh : BmSDK.Engine.ActorFactory, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ActorFactorySkeletalMesh", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ActorFactorySkeletalMesh() { }

    /// <summary>
    /// Constructs a new ActorFactorySkeletalMesh
    /// </summary>
    public ActorFactorySkeletalMesh(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ActorFactorySkeletalMesh Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ActorFactorySkeletalMesh(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: SkeletalMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMesh SkeletalMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// ObjectProperty: AnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet AnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// NameProperty: AnimSequenceName
    /// </summary>
    public unsafe BmSDK.FName AnimSequenceName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }
}
