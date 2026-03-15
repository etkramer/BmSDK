#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: K2NodeBase<br/>
/// (size = 76)
/// (flags = 134217874)
/// </summary>
public partial class K2NodeBase : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.K2NodeBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal K2NodeBase() { }

    /// <summary>
    /// Constructs a new K2NodeBase
    /// </summary>
    public K2NodeBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, K2NodeBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected K2NodeBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: Inputs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.K2Input> Inputs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.K2Input>>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// ArrayProperty: Outputs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.K2Output> Outputs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.K2Output>>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// IntProperty: NodePosX
    /// </summary>
    public unsafe int NodePosX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }

    /// <summary>
    /// IntProperty: NodePosY
    /// </summary>
    public unsafe int NodePosY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }
    }
}
