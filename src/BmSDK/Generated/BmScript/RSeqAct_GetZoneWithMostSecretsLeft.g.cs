#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_GetZoneWithMostSecretsLeft<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_GetZoneWithMostSecretsLeft : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_GetZoneWithMostSecretsLeft", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_GetZoneWithMostSecretsLeft() { }

    /// <summary>
    /// Constructs a new RSeqAct_GetZoneWithMostSecretsLeft
    /// </summary>
    public RSeqAct_GetZoneWithMostSecretsLeft(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_GetZoneWithMostSecretsLeft Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_GetZoneWithMostSecretsLeft(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: NumTimesCalled
    /// </summary>
    public unsafe int NumTimesCalled
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// IntProperty: NumSecretsLeftInSelectedZone
    /// </summary>
    public unsafe int NumSecretsLeftInSelectedZone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }
}
