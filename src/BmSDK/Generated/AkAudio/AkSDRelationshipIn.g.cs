#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: AkSDRelationshipIn<br/>
/// (flags = 0)
/// </summary>
public partial class AkSDRelationshipIn : BmSDK.AkAudio.AkSDRelationship, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.AkSDRelationshipIn", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkSDRelationshipIn() { }

    /// <summary>
    /// Constructs a new AkSDRelationshipIn
    /// </summary>
    public AkSDRelationshipIn(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkSDRelationshipIn Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkSDRelationshipIn(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: InSeconds
    /// </summary>
    public unsafe float InSeconds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// FloatProperty: StartTime
    /// </summary>
    public unsafe float StartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// BoolProperty: bInitialized
    /// </summary>
    public unsafe bool bInitialized
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 252) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 252); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 252); }
    }
}
