#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqAct_GetLocationAndRotation<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SeqAct_GetLocationAndRotation : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqAct_GetLocationAndRotation", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_GetLocationAndRotation() { }

    /// <summary>
    /// Constructs a new SeqAct_GetLocationAndRotation
    /// </summary>
    public SeqAct_GetLocationAndRotation(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_GetLocationAndRotation Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_GetLocationAndRotation(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: Location
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Location
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// StructProperty: RotationVector
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RotationVector
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// StructProperty: Rotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Rotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// NameProperty: SocketOrBoneName
    /// </summary>
    public unsafe BmSDK.FName SocketOrBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }
}
