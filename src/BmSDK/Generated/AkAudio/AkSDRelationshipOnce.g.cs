#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: AkSDRelationshipOnce<br/>
/// (flags = 0)
/// </summary>
public partial class AkSDRelationshipOnce : BmSDK.AkAudio.AkSDRelationship, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.AkSDRelationshipOnce", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkSDRelationshipOnce() { }

    /// <summary>
    /// Constructs a new AkSDRelationshipOnce
    /// </summary>
    public AkSDRelationshipOnce(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkSDRelationshipOnce Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkSDRelationshipOnce(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bFired
    /// </summary>
    public unsafe bool bFired
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 244); }
    }
}
