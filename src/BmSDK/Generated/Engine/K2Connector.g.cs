#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: K2Connector<br/>
/// (size = 61)
/// (flags = 134217874)
/// </summary>
public partial class K2Connector : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.K2Connector", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal K2Connector() { }

    /// <summary>
    /// Constructs a new K2Connector
    /// </summary>
    public K2Connector(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, K2Connector Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected K2Connector(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: OwningNode
    /// </summary>
    public unsafe BmSDK.Engine.K2NodeBase OwningNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.K2NodeBase>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// StrProperty: ConnName
    /// </summary>
    public unsafe BmSDK.FString ConnName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// ByteProperty: Type
    /// </summary>
    public unsafe BmSDK.Engine.K2Connector.EK2ConnectorType Type
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.K2Connector.EK2ConnectorType>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// Enum: EK2ConnectorDirection
    /// </summary>
    public enum EK2ConnectorDirection
    {
        K2CD_Input = 0,
        K2CD_Output = 1,
        K2CD_MAX = 2,
    }

    /// <summary>
    /// Enum: EK2ConnectorType
    /// </summary>
    public enum EK2ConnectorType
    {
        K2CT_Bool = 0,
        K2CT_Int = 1,
        K2CT_Float = 2,
        K2CT_Vector = 3,
        K2CT_Rotator = 4,
        K2CT_String = 5,
        K2CT_Object = 6,
        K2CT_Exec = 7,
        K2CT_Unsupported = 8,
        K2CT_MAX = 9,
    }
}
