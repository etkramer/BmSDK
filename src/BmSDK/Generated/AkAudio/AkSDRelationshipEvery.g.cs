#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: AkSDRelationshipEvery<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AkSDRelationshipEvery : BmSDK.AkAudio.AkSDRelationship, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.AkSDRelationshipEvery", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkSDRelationshipEvery() { }

    /// <summary>
    /// Constructs a new AkSDRelationshipEvery
    /// </summary>
    public AkSDRelationshipEvery(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkSDRelationshipEvery Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkSDRelationshipEvery(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bInitialized
    /// </summary>
    public unsafe bool bInitialized
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 244); }
    }

    /// <summary>
    /// FloatProperty: TriggerTime
    /// </summary>
    public unsafe float TriggerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }
}
