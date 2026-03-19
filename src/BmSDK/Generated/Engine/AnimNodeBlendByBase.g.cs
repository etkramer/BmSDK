#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AnimNodeBlendByBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AnimNodeBlendByBase : BmSDK.Engine.AnimNodeBlendList, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AnimNodeBlendByBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AnimNodeBlendByBase() { }

    /// <summary>
    /// Constructs a new AnimNodeBlendByBase
    /// </summary>
    public AnimNodeBlendByBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AnimNodeBlendByBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AnimNodeBlendByBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: Type
    /// </summary>
    public unsafe byte Type
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// NameProperty: ActorTag
    /// </summary>
    public unsafe BmSDK.FName ActorTag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }
    }

    /// <summary>
    /// ClassProperty: ActorClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ActorClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// FloatProperty: BlendTime
    /// </summary>
    public unsafe float BlendTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// ObjectProperty: CachedBase
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CachedBase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// Enum: EBaseBlendType
    /// </summary>
    public enum EBaseBlendType
    {
        BBT_ByActorTag = 0,
        BBT_ByActorClass = 1,
        BBT_MAX = 2,
    }
}
